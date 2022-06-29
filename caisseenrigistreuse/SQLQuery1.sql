CREATE TABLE [dbo].[operation] (
    [id]                  INT          IDENTITY (1, 1) NOT NULL,
    [amount]              DECIMAL (18) NOT NULL,
    [operation_date_time] DATETIME     NOT NULL,
    [account_id]          INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);