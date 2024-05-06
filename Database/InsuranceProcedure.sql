--- Các stored procedure

--Procedure đăng nhập
CREATE PROCEDURE SP_LOGIN (
    @Email VARCHAR(255),
    @Password VARBINARY(MAX),
    @Role VARCHAR(20) OUT,
    @Result INT OUT
)
AS
BEGIN
    DECLARE @EmployeeCount INT;
    DECLARE @CustomerCount INT;
    SELECT @EmployeeCount = COUNT(*) FROM Employee WHERE Email = @Email AND Password = @Password;

    SELECT @CustomerCount = COUNT(*) FROM Customer WHERE Email = @Email AND Password = @Password;

    IF @EmployeeCount > 0
    BEGIN
        SELECT @Role = RoleId FROM Employee WHERE Email = @Email;
        SET @Result = 1;
    END
    ELSE IF @CustomerCount > 0
    BEGIN
        SELECT @Role = RoleId FROM Customer WHERE Email = @Email;
        SET @Result = 1;
    END
    ELSE
    BEGIN
        SET @Result = 0;
    END
END


select * from Customer
--Proc EMPLOYEE----------------------------------------------------------------------------------
--Procedure Thêm nhân viên
CREATE PROCEDURE SP_INS_EMPLOYEE
(
    @EmployId VARCHAR(20),
    @Email VARCHAR(255),
	@Name NVARCHAR(50),
    @PassWord VARBINARY(MAX),
    @RoleId VARCHAR(20),
    @InsuranceTypeId VARCHAR(20)
)
WITH ENCRYPTION
AS
BEGIN
    BEGIN TRY
        IF @EmployId IS NOT NULL AND @Email IS NOT NULL AND @PassWord IS NOT NULL AND @RoleId IS NOT NULL
        BEGIN
            INSERT INTO Employee (UserId, Email, EmployName, Password, RoleId, InsuranceTypeId)
            VALUES (@EmployId, @Email,@Name, @PassWord, @RoleId, @InsuranceTypeId)
        END
        ELSE
        BEGIN
            -- Xử lý khi một hoặc nhiều tham số đầu vào là null
            THROW 51000, 'Vui lòng nhập đầy đủ thông tin.', 1;
        END
    END TRY
    BEGIN CATCH
        -- Xử lý ngoại lệ
        DECLARE @ErrorMessage NVARCHAR(4000);
        DECLARE @ErrorSeverity INT;
        DECLARE @ErrorState INT;

        SELECT
            @ErrorMessage = ERROR_MESSAGE(),
            @ErrorSeverity = ERROR_SEVERITY(),
            @ErrorState = ERROR_STATE();

        RAISERROR (@ErrorMessage, @ErrorSeverity, @ErrorState);
    END CATCH
END


--Proc Xoa Nhan Vien
CREATE PROCEDURE SP_DEL_EMPLOYEE
(
	@UserId NVARCHAR(20)
)
AS
BEGIN
	DELETE Employee WHERE UserId = @UserId
END



--Proc Sua NhanVien
CREATE PROCEDURE SP_EDIT_EMPLOYEE
(
    @EmployId VARCHAR(20),
	@Name NVARCHAR(50),
    @PassWord VARBINARY(MAX),
    @RoleId VARCHAR(20),
    @InsuranceTypeId VARCHAR(20)
)
WITH ENCRYPTION
AS
BEGIN
    BEGIN TRY
        IF @EmployId IS NOT NULL AND @PassWord IS NOT NULL AND @RoleId IS NOT NULL
        BEGIN
            UPDATE Employee 
            SET EmployName = @Name,
                Password = @PassWord, 
                RoleId = @RoleId, 
                InsuranceTypeId = @InsuranceTypeId
            WHERE UserId = @EmployId;
        END
        ELSE
        BEGIN
            THROW 51000, 'Vui lòng nhập đầy đủ thông tin.', 1;
        END
    END TRY
    BEGIN CATCH
        -- Xử lý ngoại lệ
        DECLARE @ErrorMessage NVARCHAR(4000);
        DECLARE @ErrorSeverity INT;
        DECLARE @ErrorState INT;

        SELECT
            @ErrorMessage = ERROR_MESSAGE(),
            @ErrorSeverity = ERROR_SEVERITY(),
            @ErrorState = ERROR_STATE();

        RAISERROR (@ErrorMessage, @ErrorSeverity, @ErrorState);
    END CATCH
END

drop proc SP_EDIT_EMPLOYEE

--Proc CUSTOMER----------------------------------------------------------------

--Proc thêm CUSTOMER


CREATE PROCEDURE SP_ADD_CUSTOMER
(
    @CustomerId VARCHAR(20),
    @Email VARCHAR(255),
    @Password VARBINARY(MAX),
    @Name VARCHAR(255),
	@Role VARCHAR(20)
)
AS
BEGIN
    BEGIN TRY
        IF @CustomerId IS NOT NULL AND @Email IS NOT NULL AND @Password IS NOT NULL AND @Name IS NOT NULL
        BEGIN
            INSERT INTO Customer (CustomerId, Email, Password, Name, RoleId)
            VALUES (@CustomerId, @Email, @Password, @Name,@Role);
        END
        ELSE
        BEGIN
            -- Xử lý khi một hoặc nhiều tham số đầu vào là null
            THROW 51000, 'Vui lòng nhập đầy đủ thông tin.', 1;
        END
    END TRY
    BEGIN CATCH
        -- Xử lý ngoại lệ
        DECLARE @ErrorMessage NVARCHAR(4000);
        DECLARE @ErrorSeverity INT;
        DECLARE @ErrorState INT;

        SELECT
            @ErrorMessage = ERROR_MESSAGE(),
            @ErrorSeverity = ERROR_SEVERITY(),
            @ErrorState = ERROR_STATE();

        RAISERROR (@ErrorMessage, @ErrorSeverity, @ErrorState);
    END CATCH
END


--Proc xóa CUSTOMER
CREATE PROCEDURE SP_DEL_CUSTOMER
(
	@CustomerId VARCHAR(20)
)
WITH ENCRYPTION
AS
BEGIN
	DELETE Customer WHERE CustomerId = @CustomerId
END

--Proc sửa CUSTOMER
CREATE PROCEDURE SP_EDIT_CUSTOMER
(
	@CustomerId VARCHAR(20),
    @Password VARBINARY(MAX),
    @Name VARCHAR(255)
)
WITH ENCRYPTION
AS
BEGIN
	IF @CustomerId IS NOT NULL AND @Password IS NOT NULL AND @Name IS NOT NULL
	BEGIN
		UPDATE Customer 
		SET Name = @Name,
			Password = @Password
		WHERE CustomerId = @CustomerId
	END
END

--Proc Loai Bao hiem

CREATE PROCEDURE AddTypeInsurance
    @InsuranceTypeId VARCHAR(20),
    @NameType VARCHAR(255),
    @CoverageAmount DECIMAL(10, 2),
    @Deductible DECIMAL(10, 2),
    @PremiumRate DECIMAL(5, 2),
    @PolicyLimit DECIMAL(10, 2)
WITH ENCRYPTION
AS
BEGIN
    IF EXISTS (SELECT 1 FROM TypeInsurance WHERE InsuranceTypeId = @InsuranceTypeId)
    BEGIN
        RAISERROR('InsuranceTypeId already exists.', 16, 1);
        RETURN;
    END

    -- Thêm loại bảo hiểm mới vào bảng TypeInsurance
    INSERT INTO TypeInsurance (InsuranceTypeId, NameType, CoverageAmount, Deductible, PremiumRate, PolicyLimit)
    VALUES (@InsuranceTypeId, @NameType, @CoverageAmount, @Deductible, @PremiumRate, @PolicyLimit);

END

--Proc ConTract-----------------------------------------------------------------------------------------------------------

--Proc tạo Contract
CREATE PROCEDURE SP_INS_CONTRACT
(
    @ContractId VARCHAR(20),
    @CreatorId VARCHAR(20),
    @CustomerId VARCHAR(20),
    @InsuranceTypeId VARCHAR(20),
    @TermLength INT,
    @StartDay DATE,
    @EndDay DATE,
    @TotalPrice DECIMAL(10, 2),
    @PaymentType NVARCHAR(50),
    @LastPaymentDate DATE,
    @TotalPaid DECIMAL(10, 2),
    @NextPaymentDueDate DATE
)
WITH ENCRYPTION
AS
BEGIN
     INSERT INTO Contract (ContractId, CreatorId, CustomerId, InsuranceTypeId, TermLength, StartDay, EndDay, TotalPrice, PaymentType, LastPaymentDate, TotalPaid, NextPaymentDueDate, Status, Signature)
     VALUES (@ContractId, @CreatorId, @CustomerId, @InsuranceTypeId, @TermLength, @StartDay, @EndDay, @TotalPrice, @PaymentType, @LastPaymentDate, @TotalPaid, @NextPaymentDueDate, 'pending', NULL);
END



