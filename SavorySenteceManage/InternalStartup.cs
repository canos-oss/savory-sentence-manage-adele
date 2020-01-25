using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using Savory.SentenceManage.Convertor;
using Savory.SentenceManage.Repository;
using MySql.Data.MySqlClient;
using Savory.SentenceManage.Repository.Mysql;

namespace Savory.SentenceManage
{
    partial class Startup
    {

        private void InternalConfigure(IApplicationBuilder app, IWebHostEnvironment env)
        {

        }
    }
}
