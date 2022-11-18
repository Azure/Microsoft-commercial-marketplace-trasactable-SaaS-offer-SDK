﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.Marketplace.SaasKit.Client.DataAccess.Context;

#nullable disable

namespace Marketplace.SaaS.Accelerator.DataAccess.Migrations
{
    [DbContext(typeof(SaasKitContext))]
    [Migration("20221118045814_Baseline_v2")]
    partial class Baseline_v2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.Marketplace.SaasKit.Client.DataAccess.Entities.ApplicationConfiguration", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ApplicationConfiguration");
                });

            modelBuilder.Entity("Microsoft.Marketplace.SaasKit.Client.DataAccess.Entities.ApplicationLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("ActionTime")
                        .HasColumnType("datetime");

                    b.Property<string>("LogDetail")
                        .HasMaxLength(4000)
                        .IsUnicode(false)
                        .HasColumnType("varchar(4000)");

                    b.HasKey("Id");

                    b.ToTable("ApplicationLog");
                });

            modelBuilder.Entity("Microsoft.Marketplace.SaasKit.Client.DataAccess.Entities.DatabaseVersionHistory", b =>
                {
                    b.Property<string>("ChangeLog")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreateBy")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime");

                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal>("VersionNumber")
                        .HasColumnType("decimal(6,2)");

                    b.ToTable("DatabaseVersionHistory");
                });

            modelBuilder.Entity("Microsoft.Marketplace.SaasKit.Client.DataAccess.Entities.EmailTemplate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Bcc")
                        .HasMaxLength(1000)
                        .IsUnicode(false)
                        .HasColumnType("varchar(1000)")
                        .HasColumnName("BCC");

                    b.Property<string>("Cc")
                        .HasMaxLength(1000)
                        .IsUnicode(false)
                        .HasColumnType("varchar(1000)")
                        .HasColumnName("CC");

                    b.Property<string>("Description")
                        .HasMaxLength(1000)
                        .IsUnicode(false)
                        .HasColumnType("varchar(1000)");

                    b.Property<DateTime?>("InsertDate")
                        .HasColumnType("datetime");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Status")
                        .HasMaxLength(1000)
                        .IsUnicode(false)
                        .HasColumnType("varchar(1000)");

                    b.Property<string>("Subject")
                        .HasMaxLength(1000)
                        .IsUnicode(false)
                        .HasColumnType("varchar(1000)");

                    b.Property<string>("TemplateBody")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<string>("ToRecipients")
                        .HasMaxLength(1000)
                        .IsUnicode(false)
                        .HasColumnType("varchar(1000)");

                    b.HasKey("Id");

                    b.ToTable("EmailTemplate");
                });

            modelBuilder.Entity("Microsoft.Marketplace.SaasKit.Client.DataAccess.Entities.Events", b =>
                {
                    b.Property<int>("EventsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EventsId"), 1L, 1);

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime");

                    b.Property<string>("EventsName")
                        .HasMaxLength(225)
                        .IsUnicode(false)
                        .HasColumnType("varchar(225)");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.HasKey("EventsId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("Microsoft.Marketplace.SaasKit.Client.DataAccess.Entities.KnownUsers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("UserEmail")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("KnownUsers");
                });

            modelBuilder.Entity("Microsoft.Marketplace.SaasKit.Client.DataAccess.Entities.MeteredAuditLogs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime");

                    b.Property<string>("RequestJson")
                        .HasMaxLength(500)
                        .IsUnicode(false)
                        .HasColumnType("varchar(500)");

                    b.Property<string>("ResponseJson")
                        .HasMaxLength(500)
                        .IsUnicode(false)
                        .HasColumnType("varchar(500)");

                    b.Property<string>("StatusCode")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<int?>("SubscriptionId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("SubscriptionUsageDate")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.HasIndex("SubscriptionId");

                    b.ToTable("MeteredAuditLogs");
                });

            modelBuilder.Entity("Microsoft.Marketplace.SaasKit.Client.DataAccess.Entities.MeteredDimensions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Description")
                        .HasMaxLength(250)
                        .IsUnicode(false)
                        .HasColumnType("varchar(250)");

                    b.Property<string>("Dimension")
                        .HasMaxLength(150)
                        .IsUnicode(false)
                        .HasColumnType("varchar(150)");

                    b.Property<int?>("PlanId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PlanId");

                    b.ToTable("MeteredDimensions");
                });

            modelBuilder.Entity("Microsoft.Marketplace.SaasKit.Client.DataAccess.Entities.OfferAttributes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Description")
                        .HasMaxLength(225)
                        .IsUnicode(false)
                        .HasColumnType("varchar(225)");

                    b.Property<string>("DisplayName")
                        .HasMaxLength(225)
                        .IsUnicode(false)
                        .HasColumnType("varchar(225)");

                    b.Property<int?>("DisplaySequence")
                        .HasColumnType("int");

                    b.Property<bool>("FromList")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsRequired")
                        .HasColumnType("bit");

                    b.Property<bool>("Isactive")
                        .HasColumnType("bit");

                    b.Property<int?>("Max")
                        .HasColumnType("int");

                    b.Property<int?>("Min")
                        .HasColumnType("int");

                    b.Property<Guid>("OfferId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ParameterId")
                        .HasMaxLength(225)
                        .IsUnicode(false)
                        .HasColumnType("varchar(225)");

                    b.Property<string>("Type")
                        .HasMaxLength(225)
                        .IsUnicode(false)
                        .HasColumnType("varchar(225)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.Property<int?>("ValueTypeId")
                        .HasColumnType("int");

                    b.Property<string>("ValuesList")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.HasKey("Id");

                    b.ToTable("OfferAttributes");
                });

            modelBuilder.Entity("Microsoft.Marketplace.SaasKit.Client.DataAccess.Entities.Offers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime");

                    b.Property<Guid>("OfferGuid")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("OfferGUId");

                    b.Property<string>("OfferId")
                        .HasMaxLength(225)
                        .IsUnicode(false)
                        .HasColumnType("varchar(225)");

                    b.Property<string>("OfferName")
                        .HasMaxLength(225)
                        .IsUnicode(false)
                        .HasColumnType("varchar(225)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Offers");
                });

            modelBuilder.Entity("Microsoft.Marketplace.SaasKit.Client.DataAccess.Entities.PlanAttributeMapping", b =>
                {
                    b.Property<int>("PlanAttributeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PlanAttributeId"), 1L, 1);

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime");

                    b.Property<bool>("IsEnabled")
                        .HasColumnType("bit");

                    b.Property<int>("OfferAttributeId")
                        .HasColumnType("int")
                        .HasColumnName("OfferAttributeID");

                    b.Property<Guid>("PlanId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("PlanAttributeId")
                        .HasName("PK__PlanAttr__8B476A98C058FAF2");

                    b.ToTable("PlanAttributeMapping");
                });

            modelBuilder.Entity("Microsoft.Marketplace.SaasKit.Client.DataAccess.Entities.PlanAttributeOutput", b =>
                {
                    b.Property<int>("RowNumber")
                        .HasColumnType("int");

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasMaxLength(225)
                        .IsUnicode(false)
                        .HasColumnType("varchar(225)");

                    b.Property<bool>("IsEnabled")
                        .HasColumnType("bit");

                    b.Property<int>("OfferAttributeId")
                        .HasColumnType("int");

                    b.Property<int>("PlanAttributeId")
                        .HasColumnType("int");

                    b.Property<Guid>("PlanId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Type")
                        .HasMaxLength(225)
                        .IsUnicode(false)
                        .HasColumnType("varchar(225)");

                    b.HasKey("RowNumber")
                        .HasName("PK__PlanAttr__AAAC09D888FE3E40");

                    b.ToTable("PlanAttributeOutput");
                });

            modelBuilder.Entity("Microsoft.Marketplace.SaasKit.Client.DataAccess.Entities.PlanEventsMapping", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool?>("CopyToCustomer")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime");

                    b.Property<int>("EventId")
                        .HasColumnType("int");

                    b.Property<string>("FailureStateEmails")
                        .HasMaxLength(225)
                        .IsUnicode(false)
                        .HasColumnType("varchar(225)");

                    b.Property<bool>("Isactive")
                        .HasColumnType("bit");

                    b.Property<Guid>("PlanId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("SuccessStateEmails")
                        .HasMaxLength(225)
                        .IsUnicode(false)
                        .HasColumnType("varchar(225)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("PlanEventsMapping");
                });

            modelBuilder.Entity("Microsoft.Marketplace.SaasKit.Client.DataAccess.Entities.PlanEventsOutPut", b =>
                {
                    b.Property<int>("RowNumber")
                        .HasColumnType("int");

                    b.Property<bool?>("CopyToCustomer")
                        .HasColumnType("bit");

                    b.Property<int>("EventId")
                        .HasColumnType("int");

                    b.Property<string>("EventsName")
                        .IsRequired()
                        .HasMaxLength(225)
                        .IsUnicode(false)
                        .HasColumnType("varchar(225)");

                    b.Property<string>("FailureStateEmails")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<bool>("Isactive")
                        .HasColumnType("bit");

                    b.Property<Guid>("PlanId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("SuccessStateEmails")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.HasKey("RowNumber")
                        .HasName("PK__PlanEven__AAAC09D8C9229532");

                    b.ToTable("PlanEventsOutPut");
                });

            modelBuilder.Entity("Microsoft.Marketplace.SaasKit.Client.DataAccess.Entities.Plans", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .IsUnicode(false)
                        .HasColumnType("varchar(500)");

                    b.Property<string>("DisplayName")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<bool?>("IsPerUser")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsmeteringSupported")
                        .HasColumnType("bit");

                    b.Property<Guid>("OfferId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("OfferID");

                    b.Property<Guid>("PlanGuid")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("PlanGUID");

                    b.Property<string>("PlanId")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Plans");
                });

            modelBuilder.Entity("Microsoft.Marketplace.SaasKit.Client.DataAccess.Entities.Roles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Microsoft.Marketplace.SaasKit.Client.DataAccess.Entities.SubscriptionAttributeValues", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime");

                    b.Property<Guid>("OfferId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("OfferID");

                    b.Property<int>("PlanAttributeId")
                        .HasColumnType("int");

                    b.Property<Guid>("PlanId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("PlanID");

                    b.Property<Guid>("SubscriptionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("Value")
                        .HasMaxLength(225)
                        .IsUnicode(false)
                        .HasColumnType("varchar(225)");

                    b.HasKey("Id");

                    b.ToTable("SubscriptionAttributeValues");
                });

            modelBuilder.Entity("Microsoft.Marketplace.SaasKit.Client.DataAccess.Entities.SubscriptionAuditLogs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Attribute")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<int?>("CreateBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime");

                    b.Property<string>("NewValue")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<string>("OldValue")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int?>("SubscriptionId")
                        .HasColumnType("int")
                        .HasColumnName("SubscriptionID");

                    b.HasKey("Id");

                    b.HasIndex("SubscriptionId");

                    b.ToTable("SubscriptionAuditLogs");
                });

            modelBuilder.Entity("Microsoft.Marketplace.SaasKit.Client.DataAccess.Entities.SubscriptionEmailOutput", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasMaxLength(225)
                        .IsUnicode(false)
                        .HasColumnType("varchar(225)");

                    b.Property<string>("Value")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.ToTable("SubscriptionEmailOutput");
                });

            modelBuilder.Entity("Microsoft.Marketplace.SaasKit.Client.DataAccess.Entities.SubscriptionParametersOutput", b =>
                {
                    b.Property<int>("RowNumber")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime");

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasMaxLength(225)
                        .IsUnicode(false)
                        .HasColumnType("varchar(225)");

                    b.Property<int>("DisplaySequence")
                        .HasColumnType("int");

                    b.Property<bool>("FromList")
                        .HasColumnType("bit");

                    b.Property<string>("Htmltype")
                        .IsRequired()
                        .HasMaxLength(225)
                        .IsUnicode(false)
                        .HasColumnType("varchar(225)")
                        .HasColumnName("HTMLType");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<bool>("IsEnabled")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsRequired")
                        .HasColumnType("bit");

                    b.Property<int>("Max")
                        .HasColumnType("int");

                    b.Property<int>("Min")
                        .HasColumnType("int");

                    b.Property<int>("OfferAttributeId")
                        .HasColumnType("int")
                        .HasColumnName("OfferAttributeID");

                    b.Property<Guid>("OfferId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("PlanAttributeId")
                        .HasColumnType("int");

                    b.Property<Guid>("PlanId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SubscriptionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(225)
                        .IsUnicode(false)
                        .HasColumnType("varchar(225)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("Value")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<string>("ValueType")
                        .IsRequired()
                        .HasMaxLength(225)
                        .IsUnicode(false)
                        .HasColumnType("varchar(225)");

                    b.Property<string>("ValuesList")
                        .IsRequired()
                        .HasMaxLength(225)
                        .IsUnicode(false)
                        .HasColumnType("varchar(225)");

                    b.HasKey("RowNumber")
                        .HasName("PK__Subscrip__AAAC09D8BA727059");

                    b.ToTable("SubscriptionParametersOutput");
                });

            modelBuilder.Entity("Microsoft.Marketplace.SaasKit.Client.DataAccess.Entities.Subscriptions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AmpplanId")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("AMPPlanId");

                    b.Property<int>("Ampquantity")
                        .HasColumnType("int")
                        .HasColumnName("AMPQuantity");

                    b.Property<Guid>("AmpsubscriptionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("AMPSubscriptionId")
                        .HasDefaultValueSql("(newid())");

                    b.Property<int?>("CreateBy")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifyDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("PurchaserEmail")
                        .HasMaxLength(225)
                        .IsUnicode(false)
                        .HasColumnType("varchar(225)");

                    b.Property<Guid?>("PurchaserTenantId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("SubscriptionStatus")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Subscriptions");
                });

            modelBuilder.Entity("Microsoft.Marketplace.SaasKit.Client.DataAccess.Entities.Users", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime");

                    b.Property<string>("EmailAddress")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("FullName")
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Microsoft.Marketplace.SaasKit.Client.DataAccess.Entities.ValueTypes", b =>
                {
                    b.Property<int>("ValueTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ValueTypeId"), 1L, 1);

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Htmltype")
                        .HasMaxLength(225)
                        .IsUnicode(false)
                        .HasColumnType("varchar(225)")
                        .HasColumnName("HTMLType");

                    b.Property<string>("ValueType")
                        .HasMaxLength(225)
                        .IsUnicode(false)
                        .HasColumnType("varchar(225)");

                    b.HasKey("ValueTypeId")
                        .HasName("PK__ValueTyp__A51E9C5AEA096123");

                    b.ToTable("ValueTypes");
                });

            modelBuilder.Entity("Microsoft.Marketplace.SaasKit.Client.DataAccess.Entities.WebJobSubscriptionStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<DateTime?>("InsertDate")
                        .HasColumnType("datetime");

                    b.Property<Guid?>("SubscriptionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("SubscriptionStatus")
                        .HasMaxLength(225)
                        .IsUnicode(false)
                        .HasColumnType("varchar(225)");

                    b.HasKey("Id");

                    b.ToTable("WebJobSubscriptionStatus");
                });

            modelBuilder.Entity("Microsoft.Marketplace.SaasKit.Client.DataAccess.Entities.KnownUsers", b =>
                {
                    b.HasOne("Microsoft.Marketplace.SaasKit.Client.DataAccess.Entities.Roles", "Role")
                        .WithMany("KnownUsers")
                        .HasForeignKey("RoleId")
                        .IsRequired()
                        .HasConstraintName("FK__KnownUser__RoleI__619B8048");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Microsoft.Marketplace.SaasKit.Client.DataAccess.Entities.MeteredAuditLogs", b =>
                {
                    b.HasOne("Microsoft.Marketplace.SaasKit.Client.DataAccess.Entities.Subscriptions", "Subscription")
                        .WithMany("MeteredAuditLogs")
                        .HasForeignKey("SubscriptionId")
                        .HasConstraintName("FK__MeteredAu__Subsc__628FA481");

                    b.Navigation("Subscription");
                });

            modelBuilder.Entity("Microsoft.Marketplace.SaasKit.Client.DataAccess.Entities.MeteredDimensions", b =>
                {
                    b.HasOne("Microsoft.Marketplace.SaasKit.Client.DataAccess.Entities.Plans", "Plan")
                        .WithMany("MeteredDimensions")
                        .HasForeignKey("PlanId")
                        .HasConstraintName("FK__MeteredDi__PlanI__6383C8BA");

                    b.Navigation("Plan");
                });

            modelBuilder.Entity("Microsoft.Marketplace.SaasKit.Client.DataAccess.Entities.SubscriptionAuditLogs", b =>
                {
                    b.HasOne("Microsoft.Marketplace.SaasKit.Client.DataAccess.Entities.Subscriptions", "Subscription")
                        .WithMany("SubscriptionAuditLogs")
                        .HasForeignKey("SubscriptionId")
                        .HasConstraintName("FK__Subscript__Subsc__6477ECF3");

                    b.Navigation("Subscription");
                });

            modelBuilder.Entity("Microsoft.Marketplace.SaasKit.Client.DataAccess.Entities.Subscriptions", b =>
                {
                    b.HasOne("Microsoft.Marketplace.SaasKit.Client.DataAccess.Entities.Users", "User")
                        .WithMany("Subscriptions")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK__Subscript__UserI__656C112C");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Microsoft.Marketplace.SaasKit.Client.DataAccess.Entities.Plans", b =>
                {
                    b.Navigation("MeteredDimensions");
                });

            modelBuilder.Entity("Microsoft.Marketplace.SaasKit.Client.DataAccess.Entities.Roles", b =>
                {
                    b.Navigation("KnownUsers");
                });

            modelBuilder.Entity("Microsoft.Marketplace.SaasKit.Client.DataAccess.Entities.Subscriptions", b =>
                {
                    b.Navigation("MeteredAuditLogs");

                    b.Navigation("SubscriptionAuditLogs");
                });

            modelBuilder.Entity("Microsoft.Marketplace.SaasKit.Client.DataAccess.Entities.Users", b =>
                {
                    b.Navigation("Subscriptions");
                });
#pragma warning restore 612, 618
        }
    }
}
