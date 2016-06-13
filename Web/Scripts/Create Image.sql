USE Interrail;

CREATE TABLE MyTable 
(
    ID INT PRIMARY KEY IDENTITY (1,1), 
    ImageColumnName IMAGE NULL
)

DECLARE @RowId INT
INSERT MyTable (ImageColumnName) VALUES (0xFFFFFFFF)
SELECT @RowId = SCOPE_IDENTITY()

-- get a pointer value to the row+column you want to 
-- write the image to
DECLARE @Pointer_Value varbinary(16)
SELECT @Pointer_Value = TEXTPTR(ImageColumnName)
FROM MyTable
WHERE Id = @RowId

-- write the image to the row+column pointer
WRITETEXT MyTable.ImageColumnName @Pointer_Value 'C:\Users\Tiago\Desktop\tiger.jpg'

Select * From MyTable;

Drop Table MyTable;