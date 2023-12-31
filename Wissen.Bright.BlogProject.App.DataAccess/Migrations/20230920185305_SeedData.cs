﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Wissen.Bright.BlogProject.App.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "Description", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 9, 20, 21, 53, 5, 227, DateTimeKind.Local).AddTicks(9542), "C#.Net Introduction", false, "C#.Net Programming" },
                    { 2, new DateTime(2023, 9, 20, 21, 53, 5, 227, DateTimeKind.Local).AddTicks(9554), "Entity Framework Core ile ORM teknolojileri", false, "Entity Framework Core" },
                    { 3, new DateTime(2023, 9, 20, 21, 53, 5, 227, DateTimeKind.Local).AddTicks(9556), "Asp.Net Core Mvc ile Web Programlama", false, "Asp.Net Core Mvc" }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedDate", "IsDeleted", "PictureUrl", "Summary", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, 1, "Visual Studio .Net ortamında C#.Net ile temel seviyeden (veri türleri, değişkenler, karar verme (if-else), döngüler, diziler) ileri düzeye (nesneye dayalı proglama (oop), collections, generic collections, linq) eğitim programı.", new DateTime(2023, 9, 20, 21, 53, 5, 227, DateTimeKind.Local).AddTicks(9994), false, "CSharp01.jpg", "Visual Studio .Net ortamında C#.Net ile temel seviyeden (veri türleri, değişkenler, karar verme (if-else), döngüler, diziler) ileri düzeye (nesneye dayalı proglama (oop), collections, generic collections, linq) eğitim programı...", "C#.Net Introduction", 1 },
                    { 2, 2, "Visual Studio .Net ortamında Entity Framework Core ORM teknolojisini kullanarak veritabanı yönetiminin en popüler yollarını gösteren eğitim programı.", new DateTime(2023, 9, 20, 21, 53, 5, 228, DateTimeKind.Local).AddTicks(1), false, "EFCore01.jpg", "Visual Studio .Net ortamında Entity Framework Core ORM teknolojisini kullanarak veritabanı yönetiminin en popüler yollarını gösteren eğitim programı...", "Entity Framework Core ile ORM", 2 },
                    { 3, 3, "Visual Studio .Net ortamında Asp.Net Core MVC ile temel düzeyden ileri seviyeye web programlama eğitim programı.", new DateTime(2023, 9, 20, 21, 53, 5, 228, DateTimeKind.Local).AddTicks(4), false, "Mvc01.jpg", "Visual Studio .Net ortamında Asp.Net Core MVC ile temel düzeyden ileri seviyeye web programlama eğitim programı.", "ASp.Net Core MVC ile Web Programlama", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
