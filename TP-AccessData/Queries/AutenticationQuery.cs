﻿using SqlKata.Compilers;
using SqlKata.Execution;
using System.Data;
using System.Linq;
using TP_Domain.Entities;
using TP_Domain.Queries;

namespace TP_AccessData.Queries
{
    public class AutenticationQuery : IAutenticationQuery
    {
        private readonly IDbConnection connection;
        private readonly Compiler sqlKataCompiler;

        public AutenticationQuery (IDbConnection connection, Compiler sqlKataCompiler)
        {
            this.connection = connection;
            this.sqlKataCompiler = sqlKataCompiler;
        }

        public Usuario GetUserByEmail(string email)
        {
            var db = new QueryFactory(connection, sqlKataCompiler);

            var query = db.Query("Usuarios")
                .Where("Email", "=", email);

            return query.FirstOrDefault<Usuario>();
        }
    }
}
