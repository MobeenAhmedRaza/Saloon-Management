create database salon

use salon

create table customer(id varchar(5),name varchar(30),phone varchar(20),srvce varchar(100),bill varchar(10))
select * from customer


create table staff(id varchar(5),name varchar(30),passwrd varchar(36),contact varchar(20))
select * from staff


create table receipt(cid varchar(5),sid varchar(5),price varchar(10),date datetime)
select * from receipt








--insert customer
create proc ins_cust(@id varchar(5),@name varchar(30),@phone varchar(20),@ser varchar(100),@bill varchar(10))
as
begin
	insert into customer values(@id,@name,@phone,@ser,@bill)
end

execute ins_cust 1,'Ali','090010133','Gold Hair Cutting, Standard Facial, Gold Shave, Standard SPA','1100'


--delete customer
create proc del_cust
as
begin
	delete from customer where id=(select MAX(id) from customer)
end

execute del_cust

--TRIGGERS

--insert trigger

Create TRIGGER INS_CUSTOMER ON STUDENT INSTEAD OF INSERT
AS
BEGIN
	DECLARE @ID VARCHAR(30);
	SET @ID = (SELECT ID FROM inserted)
	IF(EXISTS (SELECT * FROM STUDENT WHERE ID=@ID))
		PRINT 'ALREADY EXISTS'
	ELSE
		INSERT INTO STUDENT SELECT * FROM inserted
END

--delete trigger
Create trigger del on student after delete
as 
begin
Select * from deleted
End