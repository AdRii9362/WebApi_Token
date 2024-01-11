﻿CREATE FUNCTION [dbo].[FHasher]
(
	@Password VARCHAR(50),
	@SecurityStamp UNIQUEIDENTIFIER


)
RETURNS BINARY(64)
AS
BEGIN
	-- On declare hashedValue
	DECLARE @HashedValue BINARY(64) = CONVERT(BINARY(64), CONCAT(HASHBYTES('SHA_512',(@Password + CAST(@SecurityStamp AS VARCHAR(36)))),@SecurityStamp))
	RETURN @HashedValue
END
