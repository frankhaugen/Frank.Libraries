namespace Frank.Libraries.IRC.Server.Persistance.Constants;

public static class SqlStatements
{
    public const string CreateUsersTable = @"
        CREATE TABLE Users (
            Id INT PRIMARY KEY,
            Nickname NVARCHAR(50) NOT NULL,
            RealName NVARCHAR(50) NOT NULL,
            Hostname NVARCHAR(50) NOT NULL,
            Servername NVARCHAR(50) NOT NULL,
            IsOperator BIT NOT NULL,
            IsAway BIT NOT NULL,
            AwayMessage NVARCHAR(255) NULL,
            LastActivity DATETIME NOT NULL
        )";

    public const string CreateChannelsTable = @"
        CREATE TABLE Channels (
            Id INT PRIMARY KEY,
            Name NVARCHAR(50) NOT NULL,
            Topic NVARCHAR(255) NULL
        )";

    public const string CreateChannelUsersTable = @"
        CREATE TABLE ChannelUsers (
            UserId INT NOT NULL,
            ChannelId INT NOT NULL,
            PRIMARY KEY (UserId, ChannelId),
            FOREIGN KEY (UserId) REFERENCES Users(Id),
            FOREIGN KEY (ChannelId) REFERENCES Channels(Id)
        )";

    public const string CreateMessagesTable = @"
        CREATE TABLE Messages (
            Id INT PRIMARY KEY,
            ChannelId INT NULL,
            UserId INT NULL,
            Text NVARCHAR(255) NOT NULL,
            Timestamp DATETIME NOT NULL,
            FOREIGN KEY (ChannelId) REFERENCES Channels(Id),
            FOREIGN KEY (UserId) REFERENCES Users(Id)
        )";
}