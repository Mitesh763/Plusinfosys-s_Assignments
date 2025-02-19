
--scalar function call
SELECT dbo.fn_GetDate(GETDATE())

-- inline table function
SELECT * FROM dbo.fn_PostByHR('HR')