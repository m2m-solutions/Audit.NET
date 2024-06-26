﻿using System;
using System.Data.SqlClient;

namespace Audit.EntityFramework.UnitTest
{
    internal static class TestHelper
    {
        public static string GetConnectionString(string database)
        {
            var env = Environment.GetEnvironmentVariable("SQL_SERVER_CONNECTION_STRING");
            if (env == null)
            {
                throw new Exception("Environment variable 'SQL_SERVER_CONNECTION_STRING' not set.");
            }
            return new SqlConnectionStringBuilder(env) { InitialCatalog = database }.ConnectionString;

        }
    }
}
