--create table with int id primary key and image img both not null
select * from Test;

insert into Test(id,img)
select 1, BulkColumn 
From Openrowset ( Bulk 'C:\Users\zecar\Desktop\teste.png', Single_Blob) as img 

insert into Test(id,img)
select 1, BulkColumn 
From Openrowset ( Bulk 'C:\Users\zecar\Desktop\LI4-Backups\teste2.png', Single_Blob) as img 

insert into Test(id,img)
select 2, BulkColumn 
From Openrowset ( Bulk 'C:\Users\zecar\Desktop\LI4-Backups\A71223.png', Single_Blob) as img 

insert into Test(id,img)
select 3, BulkColumn 
From Openrowset ( Bulk 'C:\Users\zecar\Desktop\LI4-Backups\A72223.png', Single_Blob) as img 

insert into Test(id,img)
select 4, BulkColumn 
From Openrowset ( Bulk 'C:\Users\zecar\Desktop\LI4-Backups\A70443.png', Single_Blob) as img 

insert into Test(id,img)
select 5, BulkColumn 
From Openrowset ( Bulk 'C:\Users\zecar\Desktop\LI4-Backups\A71751.jpg', Single_Blob) as img

select * from Test