CREATE DATABASE FINAL_MIS;
--drop database FINAL_MIS
go
USE FINAL_MIS;
--USE FINAL_CNPM;
go

-- Create table for product information
CREATE TABLE product (
  product_id VARCHAR(5) PRIMARY KEY,
  product_name VARCHAR(255),
  price DECIMAL(10,2),
  quantity INT,
  description TEXT,
  category_id VARCHAR(5),
  supplier_id VARCHAR(5),	
);

-- Create table for customer information
CREATE TABLE customer (
  customer_id VARCHAR(5) PRIMARY KEY,
  customer_name VARCHAR(255),
  email VARCHAR(255),
  phone_number VARCHAR(20),
  address VARCHAR(255)
);

-- Create table for customer's special offer
CREATE TABLE special_offer (
  offer_id VARCHAR(5) PRIMARY KEY,
  offer_name VARCHAR(255),
  offer_description TEXT,
  start_date DATE,
  end_date DATE,
  status VARCHAR(255),
  discount DECIMAL(10,2)
);

-- Create table for product category
CREATE TABLE category (
  category_id VARCHAR(5) PRIMARY KEY,
  category_name VARCHAR(255)
);

-- Create table for customer orders
CREATE TABLE orders (
  order_id VARCHAR(5) PRIMARY KEY,
  customer_id VARCHAR(5),
  order_date DATE,
  delivery_address VARCHAR(255),
  delivery_status VARCHAR(50),
  price float,
);

-- Create table for order detail
CREATE TABLE order_detail (
  detail_id VARCHAR(5) PRIMARY KEY,
  order_id VARCHAR(5),
  product_id VARCHAR(5),
  quantity INT,
);
-- Create table for import to warehouse
CREATE TABLE warehouse_import (
  import_id VARCHAR(5) PRIMARY KEY,
  import_date DATE,
  product_id VARCHAR(5),
  quantity INT,
);

-- Create table for supplier information
CREATE TABLE supplier (
  supplier_id VARCHAR(5) PRIMARY KEY,
  supplier_name VARCHAR(255),
  email VARCHAR(255),
  phone_number VARCHAR(20),
  address VARCHAR(255)
);
--create table for offer to order
CREATE TABLE order_offer (
  order_id VARCHAR(5),
  offer_id VARCHAR(5),
  PRIMARY KEY (order_id, offer_id)
);


	alter table product
	add FOREIGN KEY (category_id) REFERENCES category(category_id),
	FOREIGN KEY (supplier_id) REFERENCES supplier(supplier_id)

	alter table orders
	add FOREIGN KEY (customer_id) REFERENCES customer(customer_id)

	alter table order_detail
	add FOREIGN KEY (order_id) REFERENCES orders(order_id),
	FOREIGN KEY (product_id) REFERENCES product(product_id)


	alter table warehouse_import
	add FOREIGN KEY (product_id) REFERENCES product(product_id)

	alter table order_offer
	add FOREIGN KEY (order_id) REFERENCES orders(order_id),
	FOREIGN KEY (offer_id) REFERENCES special_offer(offer_id)



CREATE TRIGGER trg_DeleteOrder
ON orders
AFTER DELETE
AS
BEGIN
  SET NOCOUNT ON;

  -- Delete order detail records
  DELETE FROM order_detail
  WHERE order_id IN (SELECT deleted.order_id FROM deleted)

  -- Delete order offer records
  DELETE FROM order_offer
  WHERE order_id IN (SELECT deleted.order_id FROM deleted)
END

CREATE TRIGGER update_order_product_quantity
ON order_detail
AFTER INSERT
AS
BEGIN
    DECLARE @product_id VARCHAR(5), @quantity INT, @available_quantity INT;
    
    SELECT @product_id = product_id, @quantity = quantity FROM inserted;
    
    -- Check if there is enough quantity in stock
    SELECT @available_quantity = quantity FROM product WHERE product_id = @product_id;
    
    IF (@quantity > @available_quantity)
    BEGIN
        RAISERROR ('Not enough quantity in stock', 16, 1);
        ROLLBACK TRANSACTION;
        RETURN;
    END
    
    -- Update product quantity
    UPDATE product SET quantity = quantity - @quantity WHERE product_id = @product_id;
END
--drop trigger update_product_quantity
CREATE TRIGGER update_product_quantity
ON warehouse_import
AFTER INSERT
AS
BEGIN
  UPDATE product
  SET quantity = product.quantity + i.quantity
  FROM inserted i
  WHERE product.product_id = i.product_id;
END;


CREATE TRIGGER calculate_order_price
ON order_detail
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
  SET NOCOUNT ON;

  DECLARE @order_id VARCHAR(5);
  DECLARE @total_price DECIMAL(10,2);

  -- Get the order ID and calculate the total price
  SELECT @order_id = order_id FROM inserted;
  SELECT @total_price = SUM(od.quantity * p.price) FROM order_detail od,product p WHERE order_id = @order_id;

  -- Apply any special offers to the total price
  DECLARE @discount DECIMAL(10,2);
  SELECT @discount = COALESCE(SUM(discount), 0) FROM order_offer o JOIN special_offer s ON o.offer_id = s.offer_id WHERE o.order_id = @order_id AND GETDATE() BETWEEN s.start_date AND s.end_date;
  SET @total_price = @total_price - (@total_price * @discount);

  -- Update the order with the new price
  UPDATE orders SET price = @total_price WHERE order_id = @order_id;
END;



CREATE TRIGGER check_date_and_set_status
ON special_offer
AFTER INSERT
AS
BEGIN
  UPDATE special_offer
  SET status = CASE
    WHEN start_date <= GETDATE() AND end_date >= GETDATE() THEN 'active'
    ELSE 'expired'
  END
  WHERE offer_id IN (
    SELECT offer_id FROM inserted
  );
END;


CREATE TRIGGER trg_delete_product__
ON product
instead of DELETE
AS
BEGIN
    SET NOCOUNT ON;

    DELETE FROM order_detail
    WHERE product_id IN (SELECT deleted.product_id FROM deleted);

	DELETE FROM warehouse_import
	WHERE product_id IN(SELECT deleted.product_id FROM deleted);

    DELETE FROM product
    WHERE product_id IN (SELECT deleted.product_id FROM deleted);

END


create trigger trg_deleOrder
on orders
instead of delete
as
begin
	set nocount on;

	delete from order_offer
	where order_id in(select deleted.order_id from deleted)

	delete from order_detail
	where order_id in (select deleted.order_id from deleted)

	delete from orders
	where order_id in(select deleted.order_id from deleted) 
end


CREATE TRIGGER trg_DeleteCustomer
ON customer
INSTEAD OF DELETE
AS
BEGIN
  SET NOCOUNT ON;

  -- Delete order records for the deleted customer
  DELETE FROM orders
  WHERE customer_id IN (SELECT deleted.customer_id FROM deleted)

  -- Delete the deleted customer
  DELETE FROM customer
  WHERE customer_id IN (SELECT deleted.customer_id FROM deleted)
END

create trigger trg_DelSupplier
on supplier
instead of delete
as 
begin
	set nocount on;
	delete from product
	where supplier_id in(select deleted.supplier_id from deleted)

	delete from supplier
	where supplier_id in(select deleted.supplier_id from deleted)
end

create trigger trg_DelOffer
on special_offer
instead of delete
as
begin
	set nocount on;
	delete from order_offer
	where offer_id in (select deleted.offer_id from deleted)

	delete from special_offer
	where offer_id in (select deleted.offer_id from deleted) 
end


-- Sample data for supplier table
INSERT INTO supplier (supplier_id, supplier_name, email, phone_number, address) VALUES
('S1', 'ABC Company', 'abc@company.com', '1234567890', '123 Main St'),
('S2', 'XYZ Inc.', 'xyz@inc.com', '9876543210', '456 Elm St'),
('S3', '123 Corp.', '123@corp.com', '5555555555', '789 Oak St'),
('S4', 'PQR Industries', 'pqr@ind.com', '4444444444', '345 Maple St'),
('S5', 'LMN Ltd.', 'lmn@ltd.com', '1111111111', '567 Pine St');

-- Sample data for category table
INSERT INTO category (	category_id, category_name)
VALUES ('C001', 'Electronics'),
       ('C002', 'Clothing'),
       ('C003', 'Home and Garden'),
       ('C004', 'Toys and Games');


-- Sample data for product table
INSERT INTO product (product_id, product_name, price,quantity, description, category_id, supplier_id)
VALUES 
  ('P0001', 'Apple iPhone 12', 999.00,100, 'A high-end smartphone from Apple', 'C001', 'S1'),
  ('P0002', 'Samsung Galaxy S21', 799.00,100, 'A high-end smartphone from Samsung', 'C001', 'S2'),
  ('P0003', 'Sony PlayStation 5', 499.00,100, 'A next-generation gaming console from Sony', 'C002', 'S3'),
  ('P0004', 'Microsoft Xbox Series X', 499.00,100, 'A next-generation gaming console from Microsoft', 'C002', 'S4'),
  ('P0005', 'Dell XPS 13', 1299.00,100, 'A high-end laptop from Dell', 'C003', 'S5');

-- Sample data for customer table
INSERT INTO customer (customer_id, customer_name, email, phone_number, address)
VALUES 
  ('C0001', 'John Doe', 'johndoe@gmail.com', '123-456-7890', '123 Main St, Anytown, USA'),
  ('C0002', 'Jane Smith', 'janesmith@yahoo.com', '555-123-4567', '456 Oak Ave, Anytown, USA'),
  ('C0003', 'Bob Johnson', 'bobjohnson@hotmail.com', '555-555-5555', '789 Maple Rd, Anytown, USA');

-- Sample data for special_offer table
INSERT INTO special_offer (offer_id, offer_name, offer_description, start_date, end_date, discount)
VALUES 
  ('O0001', 'Summer Sale', 'Get 20% off on all items during the summer season', '2023-02-01', '2023-09-01', 20),
  ('O0002', 'Back to School', 'Get 10% off on all laptops during the back-to-school season', '2023-04-01', '2023-09-30', 10),
  ('O0003', 'Black Friday', 'Get 30% off on all items during the Black Friday sale', '2023-4-24', '2023-4-27', 30);

-- Sample data for orders table
INSERT INTO orders (order_id, customer_id, order_date, delivery_address, delivery_status)
VALUES 
    ('OD001', 'C0001', '2022-05-01', '123 Main St, Anytown USA', 'Pending'),
    ('OD002', 'C0002', '2022-05-02', '456 Elm St, Anytown USA', 'Delivered'),
    ('OD003', 'C0003', '2022-05-03', '789 Oak St, Anytown USA', 'Processing'),
    ('OD004', 'C0001', '2022-05-04', '321 Pine St, Anytown USA', 'Cancelled');

-- Sample data for order_detail table
INSERT INTO order_detail (detail_id, order_id, product_id, quantity)VALUES ('D001', 'OD001', 'P0001', 2);
INSERT INTO order_detail (detail_id, order_id, product_id, quantity)VALUES('D002', 'OD001', 'P0002', 1);
INSERT INTO order_detail (detail_id, order_id, product_id, quantity)VALUES('D003', 'OD002', 'P0003', 4);
INSERT INTO order_detail (detail_id, order_id, product_id, quantity)VALUES('D004', 'OD003', 'P0002', 3);
INSERT INTO order_detail (detail_id, order_id, product_id, quantity)VALUES('D005', 'OD003', 'P0004', 2);
INSERT INTO order_detail (detail_id, order_id, product_id, quantity)VALUES('D006', 'OD004', 'P0001', 1);
INSERT INTO order_detail (detail_id, order_id, product_id, quantity)VALUES('D007', 'OD004', 'P0003', 1);
     
-- Sample data for warehouse_import table
INSERT INTO warehouse_import (import_id, import_date, product_id, quantity) VALUES
('WH1', '2023-04-01', 'P0001', 100),
('WH2', '2023-04-02', 'P0002', 50),
('WH3', '2023-04-03', 'P0003', 200),
('WH4', '2023-04-04', 'P0004', 75),
('WH5', '2023-04-05', 'P0005', 150);

-- Sample data for order_offer table
INSERT INTO order_offer (order_id, offer_id)
VALUES
  ('OD001', 'O0001'),
  ('OD002', 'O0002'),
  ('OD003', 'O0001'),
  ('OD004', 'O0003');

select *from product 
select *from customer
select *from category
select *from supplier
select *from warehouse_import
select *from order_detail
select *from orders	
select *from special_offer
select *from order_offer



DELETE FROM product;
DELETE FROM customer;
DELETE FROM special_offer;
DELETE FROM category;
DELETE FROM orders ;
DELETE FROM order_detail ;
DELETE FROM warehouse_import;
DELETE FROM supplier;
DELETE FROM order_offer;


select supplier_name from supplier

SELECT p.product_id, p.product_name, p.price, p.quantity, p.description, c.category_name, s.supplier_name
FROM product p
JOIN category c ON p.category_id = c.category_id
JOIN supplier s ON p.supplier_id = s.supplier_id;


SELECT wi.import_id, wi.import_date, p.product_name, wi.quantity
FROM warehouse_import wi
INNER JOIN product p ON wi.product_id = p.product_id;

SELECT o.order_id, c.customer_name, o.order_date, o.delivery_address, o.delivery_status, o.price
FROM orders o
INNER JOIN customer c ON o.customer_id = c.customer_id;