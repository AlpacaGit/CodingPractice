--レポジトリテーブルの作成SQL集。
CREATE TABLE [dbo].[NoteUser] (
    [UserID]         NVARCHAR (50) NOT NULL,
    [UserName]       NVARCHAR (50) NOT NULL,
    [UserRole]       NVARCHAR (50) NULL,
    [RecDateTime]    DATETIME      NOT NULL,
    [UpdateDateTime] DATETIME      NOT NULL,
    CONSTRAINT [PK_NoteUser] PRIMARY KEY CLUSTERED ([UserID] ASC)
);


CREATE TABLE [dbo].[UserCertificationInfo] (
    [UserID]         NVARCHAR (50) NOT NULL,
    [SoltValue]      NVARCHAR (100) NOT NULL,
    [HashValue]      NVARCHAR (300) NOT NULL,
    CONSTRAINT [PK_UserCertificationInfo] PRIMARY KEY CLUSTERED ([UserID] ASC)
);
