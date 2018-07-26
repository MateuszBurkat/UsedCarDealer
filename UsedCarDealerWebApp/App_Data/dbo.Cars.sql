CREATE TABLE [dbo].[Cars] (
    [CarID]          INT           NOT NULL,
    [CarBrand]       NVARCHAR (50) NOT NULL,
    [CarModel]       NVARCHAR (50) NOT NULL,
    [FuelType]       NVARCHAR (50) NOT NULL,
    [YearProduction] INT           NOT NULL,
    [TypeCar]        NVARCHAR (50) NOT NULL,
    [Milage]         INT           NOT NULL,
    [Price]          INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([CarID] ASC)
);

