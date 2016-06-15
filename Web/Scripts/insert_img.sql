select * from tbl_Image;

insert into tbl_Image(id,img)
select 1, BulkColumn 
From Openrowset ( Bulk 'C:\Users\zecar\Desktop\teste.png', Single_Blob) as img 


