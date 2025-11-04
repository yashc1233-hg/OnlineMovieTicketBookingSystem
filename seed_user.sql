-- seed_user.sql
-- Run this against your app database if you have a Users table with columns (Username, PasswordHash) OR adapt it.
-- NOTE: Passwords are typically hashed. This SQL is illustrative only.
-- Replace table/column names to match your schema.

-- Example for a simple custom Users table (not Identity):
INSERT INTO Users (Username, Password) VALUES ('yash75', '752004');
-- If your app uses ASP.NET Identity, prefer to run the C# seed script below which uses UserManager to hash the password.
