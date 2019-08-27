using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace UnitOfWorkLibary.NewTMSDBModels
{
    public partial class NewTMSDBContext : DbContext
    {
        public NewTMSDBContext()
        {
        }

        public NewTMSDBContext(DbContextOptions<NewTMSDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TabnormalDataMonitor> TabnormalDataMonitor { get; set; }
        public virtual DbSet<TaddressStore> TaddressStore { get; set; }
        public virtual DbSet<Tagency> Tagency { get; set; }
        public virtual DbSet<TagencyAgent> TagencyAgent { get; set; }
        public virtual DbSet<TagencyNode> TagencyNode { get; set; }
        public virtual DbSet<TapplicationUpgrade> TapplicationUpgrade { get; set; }
        public virtual DbSet<TapplicationVersion> TapplicationVersion { get; set; }
        public virtual DbSet<TautoExecuteSql> TautoExecuteSql { get; set; }
        public virtual DbSet<TautoExecuteSqlResult> TautoExecuteSqlResult { get; set; }
        public virtual DbSet<TautoReportExport> TautoReportExport { get; set; }
        public virtual DbSet<TautoReportExportFile> TautoReportExportFile { get; set; }
        public virtual DbSet<TautoReportExportSubscription> TautoReportExportSubscription { get; set; }
        public virtual DbSet<TautoReportExportTime> TautoReportExportTime { get; set; }
        public virtual DbSet<TautoTask> TautoTask { get; set; }
        public virtual DbSet<TautoTaskClass> TautoTaskClass { get; set; }
        public virtual DbSet<TautoTaskLog> TautoTaskLog { get; set; }
        public virtual DbSet<TautoTaskServer> TautoTaskServer { get; set; }
        public virtual DbSet<TbatchToDoList> TbatchToDoList { get; set; }
        public virtual DbSet<Tcity> Tcity { get; set; }
        public virtual DbSet<TcontactPerson> TcontactPerson { get; set; }
        public virtual DbSet<Tcustomer> Tcustomer { get; set; }
        public virtual DbSet<TdataPublisher> TdataPublisher { get; set; }
        public virtual DbSet<TdataPublisherParameter> TdataPublisherParameter { get; set; }
        public virtual DbSet<TdataSubscription> TdataSubscription { get; set; }
        public virtual DbSet<TdataTrack> TdataTrack { get; set; }
        public virtual DbSet<TdelayBatch> TdelayBatch { get; set; }
        public virtual DbSet<TdelayParcel> TdelayParcel { get; set; }
        public virtual DbSet<TdelayReason> TdelayReason { get; set; }
        public virtual DbSet<TdeliveryTimeConsume> TdeliveryTimeConsume { get; set; }
        public virtual DbSet<Tdepartment> Tdepartment { get; set; }
        public virtual DbSet<Tdescription> Tdescription { get; set; }
        public virtual DbSet<TdescriptionType> TdescriptionType { get; set; }
        public virtual DbSet<TdistributeCenter> TdistributeCenter { get; set; }
        public virtual DbSet<TdistributeCenterDomain> TdistributeCenterDomain { get; set; }
        public virtual DbSet<Tdistrict> Tdistrict { get; set; }
        public virtual DbSet<Tdriver> Tdriver { get; set; }
        public virtual DbSet<TdynamicSql> TdynamicSql { get; set; }
        public virtual DbSet<Texpress> Texpress { get; set; }
        public virtual DbSet<TgisArea> TgisArea { get; set; }
        public virtual DbSet<TgisDomain> TgisDomain { get; set; }
        public virtual DbSet<Thandle> Thandle { get; set; }
        public virtual DbSet<ThandleType> ThandleType { get; set; }
        public virtual DbSet<TinterfaceExpress> TinterfaceExpress { get; set; }
        public virtual DbSet<Tlanguage> Tlanguage { get; set; }
        public virtual DbSet<TlogisticInterface> TlogisticInterface { get; set; }
        public virtual DbSet<TlogisticLogParcelDetail> TlogisticLogParcelDetail { get; set; }
        public virtual DbSet<TlogisticParcel> TlogisticParcel { get; set; }
        public virtual DbSet<TlogisticParcelLog> TlogisticParcelLog { get; set; }
        public virtual DbSet<TlogisticParcelType> TlogisticParcelType { get; set; }
        public virtual DbSet<TlongText> TlongText { get; set; }
        public virtual DbSet<TmailAttachment> TmailAttachment { get; set; }
        public virtual DbSet<TmailFailed> TmailFailed { get; set; }
        public virtual DbSet<TmailFormat> TmailFormat { get; set; }
        public virtual DbSet<TmailFormatAttachment> TmailFormatAttachment { get; set; }
        public virtual DbSet<TmailSent> TmailSent { get; set; }
        public virtual DbSet<TmailToSend> TmailToSend { get; set; }
        public virtual DbSet<Tnode> Tnode { get; set; }
        public virtual DbSet<TnodeActor> TnodeActor { get; set; }
        public virtual DbSet<TnodeApplication> TnodeApplication { get; set; }
        public virtual DbSet<TnodeCondition> TnodeCondition { get; set; }
        public virtual DbSet<TnodeInstance> TnodeInstance { get; set; }
        public virtual DbSet<TnodeInstanceActor> TnodeInstanceActor { get; set; }
        public virtual DbSet<TnodeInstanceHandle> TnodeInstanceHandle { get; set; }
        public virtual DbSet<TnodeLink> TnodeLink { get; set; }
        public virtual DbSet<TnodeLinkInstance> TnodeLinkInstance { get; set; }
        public virtual DbSet<TnodeProcess> TnodeProcess { get; set; }
        public virtual DbSet<TnodeSchedule> TnodeSchedule { get; set; }
        public virtual DbSet<TnoticeEvent> TnoticeEvent { get; set; }
        public virtual DbSet<TnoticeEventArgument> TnoticeEventArgument { get; set; }
        public virtual DbSet<TnoticeEventDataItem> TnoticeEventDataItem { get; set; }
        public virtual DbSet<TnoticeEventMessage> TnoticeEventMessage { get; set; }
        public virtual DbSet<TnoticeEventSubscription> TnoticeEventSubscription { get; set; }
        public virtual DbSet<TobjectPower> TobjectPower { get; set; }
        public virtual DbSet<Toccupation> Toccupation { get; set; }
        public virtual DbSet<TouterParcel> TouterParcel { get; set; }
        public virtual DbSet<TouterParcelHistory> TouterParcelHistory { get; set; }
        public virtual DbSet<TparameterSet> TparameterSet { get; set; }
        public virtual DbSet<TparameterSetDetail> TparameterSetDetail { get; set; }
        public virtual DbSet<Tparcel> Tparcel { get; set; }
        public virtual DbSet<TparcelHandle> TparcelHandle { get; set; }
        public virtual DbSet<TparcelInterception> TparcelInterception { get; set; }
        public virtual DbSet<Tposition> Tposition { get; set; }
        public virtual DbSet<TpositionLevel> TpositionLevel { get; set; }
        public virtual DbSet<Tpower> Tpower { get; set; }
        public virtual DbSet<Tprocess> Tprocess { get; set; }
        public virtual DbSet<TprocessInstance> TprocessInstance { get; set; }
        public virtual DbSet<TprocessParameter> TprocessParameter { get; set; }
        public virtual DbSet<TprocessSchedule> TprocessSchedule { get; set; }
        public virtual DbSet<TprocessVersion> TprocessVersion { get; set; }
        public virtual DbSet<Tprovince> Tprovince { get; set; }
        public virtual DbSet<TrecordChange> TrecordChange { get; set; }
        public virtual DbSet<TrecordChangeField> TrecordChangeField { get; set; }
        public virtual DbSet<TreplicationApplication> TreplicationApplication { get; set; }
        public virtual DbSet<TreplicationType> TreplicationType { get; set; }
        public virtual DbSet<Tschedule> Tschedule { get; set; }
        public virtual DbSet<TshortText> TshortText { get; set; }
        public virtual DbSet<TsiteReplication> TsiteReplication { get; set; }
        public virtual DbSet<TsmsFailed> TsmsFailed { get; set; }
        public virtual DbSet<TsmsFormat> TsmsFormat { get; set; }
        public virtual DbSet<TsmsReceivedPending> TsmsReceivedPending { get; set; }
        public virtual DbSet<TsmsSent> TsmsSent { get; set; }
        public virtual DbSet<TsmsToSend> TsmsToSend { get; set; }
        public virtual DbSet<TsmsToSendTimer> TsmsToSendTimer { get; set; }
        public virtual DbSet<TsysColsList> TsysColsList { get; set; }
        public virtual DbSet<TsysConfig> TsysConfig { get; set; }
        public virtual DbSet<TsysConfigClass> TsysConfigClass { get; set; }
        public virtual DbSet<TsysMaxNumber> TsysMaxNumber { get; set; }
        public virtual DbSet<TsysStatus> TsysStatus { get; set; }
        public virtual DbSet<TsysStatusLanguage> TsysStatusLanguage { get; set; }
        public virtual DbSet<TsysTablesList> TsysTablesList { get; set; }
        public virtual DbSet<TtaskType> TtaskType { get; set; }
        public virtual DbSet<TtimeLimit> TtimeLimit { get; set; }
        public virtual DbSet<TtoDoList> TtoDoList { get; set; }
        public virtual DbSet<TtoDoListErrorLog> TtoDoListErrorLog { get; set; }
        public virtual DbSet<TtoDoListHistory> TtoDoListHistory { get; set; }
        public virtual DbSet<TtoDoType> TtoDoType { get; set; }
        public virtual DbSet<TtransportBatch> TtransportBatch { get; set; }
        public virtual DbSet<TtransportBatchHandle> TtransportBatchHandle { get; set; }
        public virtual DbSet<TtransportParcel> TtransportParcel { get; set; }
        public virtual DbSet<Ttruck> Ttruck { get; set; }
        public virtual DbSet<TtruckBrand> TtruckBrand { get; set; }
        public virtual DbSet<Tuser> Tuser { get; set; }
        public virtual DbSet<TuserDistributeCenter> TuserDistributeCenter { get; set; }
        public virtual DbSet<TuserIp> TuserIp { get; set; }
        public virtual DbSet<TuserLogin> TuserLogin { get; set; }
        public virtual DbSet<TuserPasswordHistory> TuserPasswordHistory { get; set; }
        public virtual DbSet<TuserPosition> TuserPosition { get; set; }
        public virtual DbSet<TuserProfile> TuserProfile { get; set; }
        public virtual DbSet<TuserRelation> TuserRelation { get; set; }

        // Unable to generate entity type for table 'dbo.tmp_tmstamp'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("server=10.10.4.201;User ID=sa;Password=colipu;database=NewTMSDB;Min Pool Size=10;Max Pool Size=500;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<TabnormalDataMonitor>(entity =>
            {
                entity.HasKey(e => e.MonitorId)
                    .HasName("PK_TABNORMALDATAMONITOR");

                entity.ToTable("TAbnormalDataMonitor");

                entity.Property(e => e.MonitorId)
                    .HasMaxLength(60)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.LastExecuteTime).HasColumnType("datetime");

                entity.Property(e => e.MonitorName)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.SqlStatement)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.StartTime)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TaddressStore>(entity =>
            {
                entity.HasKey(e => e.AddressStoreId)
                    .HasName("PK_TADDRESSSTORE");

                entity.ToTable("TAddressStore");

                entity.HasIndex(e => e.OriginalAddress)
                    .HasName("Index_AddressStore_OriginalAddress");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ConfirmTime).HasColumnType("datetime");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Latitude).HasColumnType("numeric(9, 6)");

                entity.Property(e => e.Longitude).HasColumnType("numeric(9, 6)");

                entity.Property(e => e.OriginalAddress)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.Source)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Tagency>(entity =>
            {
                entity.HasKey(e => e.AgencyId)
                    .HasName("PK_TAGENCY");

                entity.ToTable("TAgency");

                entity.HasIndex(e => e.Authorizer)
                    .HasName("XIF339TAgency");

                entity.Property(e => e.ActualEndTime).HasColumnType("datetime");

                entity.Property(e => e.AgencyName)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.IsAllowSubAuthorize)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.IsMultiLevel)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TagencyAgent>(entity =>
            {
                entity.HasKey(e => new { e.AgencyId, e.AgentUserId })
                    .HasName("PK_TAGENCYAGENT");

                entity.ToTable("TAgencyAgent");

                entity.HasIndex(e => e.AgencyId)
                    .HasName("XIF353TAgencyAgent");

                entity.HasIndex(e => e.AgentUserId)
                    .HasName("XIF343TAgencyAgent");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TagencyNode>(entity =>
            {
                entity.HasKey(e => new { e.AgencyId, e.NodeId })
                    .HasName("PK_TAGENCYNODE");

                entity.ToTable("TAgencyNode");

                entity.HasIndex(e => e.AgencyId)
                    .HasName("XIF352TAgencyNode");

                entity.HasIndex(e => e.NodeId)
                    .HasName("XIF341TAgencyNode");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TapplicationUpgrade>(entity =>
            {
                entity.HasKey(e => e.UpgradeId)
                    .HasName("PK_TAPPLICATIONUPGRADE");

                entity.ToTable("TApplicationUpgrade");

                entity.HasIndex(e => e.ApplicationId)
                    .HasName("XIF440TApplicationUpgrade");

                entity.Property(e => e.ApplicationId)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.ApplicationVersion)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TapplicationVersion>(entity =>
            {
                entity.HasKey(e => e.ApplicationId)
                    .HasName("PK_TAPPLICATIONVERSION");

                entity.ToTable("TApplicationVersion");

                entity.Property(e => e.ApplicationId)
                    .HasMaxLength(60)
                    .ValueGeneratedNever();

                entity.Property(e => e.ApplicationName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CurrentVersion)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CustomerCode)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TautoExecuteSql>(entity =>
            {
                entity.HasKey(e => e.SqlId)
                    .HasName("PK_TAUTOEXECUTESQL");

                entity.ToTable("TAutoExecuteSql");

                entity.Property(e => e.SqlId)
                    .HasMaxLength(255)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.ExecuteDay)
                    .IsRequired()
                    .HasMaxLength(7);

                entity.Property(e => e.HasReturnData)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.LastExecuteTime).HasColumnType("datetime");

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.SqlName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.SqlStatement).HasColumnType("text");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.StartTime)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TautoExecuteSqlResult>(entity =>
            {
                entity.HasKey(e => e.ExecuteId)
                    .HasName("PK_TAUTOEXECUTESQLRESULT");

                entity.ToTable("TAutoExecuteSqlResult");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.IsSuccess)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Result)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.SqlId)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<TautoReportExport>(entity =>
            {
                entity.HasKey(e => e.ReportId)
                    .HasName("PK_TAUTOREPORTEXPORT");

                entity.ToTable("TAutoReportExport");

                entity.Property(e => e.ReportId).ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.ExecuteDay)
                    .IsRequired()
                    .HasMaxLength(7);

                entity.Property(e => e.FileFormat)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.FilePath)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.IsSendMail)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.ReportCode)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ReportName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.SqlStatement)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TautoReportExportFile>(entity =>
            {
                entity.HasKey(e => e.FileId)
                    .HasName("PK_TAUTOREPORTEXPORTFILE");

                entity.ToTable("TAutoReportExportFile");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.FileFormat)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<TautoReportExportSubscription>(entity =>
            {
                entity.HasKey(e => new { e.ReportId, e.Email })
                    .HasName("PK_TAUTOREPORTEXPORTSUBSCRIPTI");

                entity.ToTable("TAutoReportExportSubscription");

                entity.Property(e => e.Email)
                    .HasColumnName("EMail")
                    .HasMaxLength(255);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TautoReportExportTime>(entity =>
            {
                entity.HasKey(e => new { e.ReportId, e.ExecuteTime })
                    .HasName("PK_TAUTOREPORTEXPORTTIME");

                entity.ToTable("TAutoReportExportTime");

                entity.Property(e => e.ExecuteTime).HasMaxLength(8);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.LastExecuteTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TautoTask>(entity =>
            {
                entity.HasKey(e => e.TaskId)
                    .HasName("PK_TAUTOTASK");

                entity.ToTable("TAutoTask");

                entity.Property(e => e.TaskId)
                    .HasMaxLength(60)
                    .ValueGeneratedNever();

                entity.Property(e => e.ClassId)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.ClassName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.InitialValue)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.IsAutoExecute)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.IsEnableAlert)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasMaxLength(512);

                entity.Property(e => e.ServerId)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.TaskName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TautoTaskClass>(entity =>
            {
                entity.HasKey(e => e.ClassId)
                    .HasName("PK_TAUTOTASKCLASS");

                entity.ToTable("TAutoTaskClass");

                entity.Property(e => e.ClassId)
                    .HasMaxLength(60)
                    .ValueGeneratedNever();

                entity.Property(e => e.ClassName)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TautoTaskLog>(entity =>
            {
                entity.HasKey(e => e.LogId)
                    .HasName("PK_TAUTOTASKLOG");

                entity.ToTable("TAutoTaskLog");

                entity.HasIndex(e => e.TaskId)
                    .HasName("Index_TaskId");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.LogContent)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.ServerId)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.TaskId)
                    .IsRequired()
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<TautoTaskServer>(entity =>
            {
                entity.HasKey(e => e.ServerId)
                    .HasName("PK_TAUTOTASKSERVER");

                entity.ToTable("TAutoTaskServer");

                entity.Property(e => e.ServerId)
                    .HasMaxLength(60)
                    .ValueGeneratedNever();

                entity.Property(e => e.ComputerName)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.IpAddress)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ServerName)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TbatchToDoList>(entity =>
            {
                entity.HasKey(e => e.ToDoListId)
                    .HasName("PK_TBATCHTODOLIST");

                entity.ToTable("TBatchToDoList");

                entity.Property(e => e.AdditiveId)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.RelativeId)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.ToDoType)
                    .IsRequired()
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<Tcity>(entity =>
            {
                entity.HasKey(e => e.CityId)
                    .HasName("PK_TCITY");

                entity.ToTable("TCity");

                entity.HasIndex(e => e.ProvinceId)
                    .HasName("XIF279TCity");

                entity.Property(e => e.CityId).ValueGeneratedNever();

                entity.Property(e => e.AliasName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CityCode)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.CityName)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TcontactPerson>(entity =>
            {
                entity.HasKey(e => e.ContactPersonId)
                    .HasName("PK_TCONTACTPERSON");

                entity.ToTable("TContactPerson");

                entity.HasIndex(e => e.LastName)
                    .HasName("Index_ContactPerson_LastName");

                entity.Property(e => e.ContactPersonType)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DistributeCenterId)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("EMail")
                    .HasMaxLength(255);

                entity.Property(e => e.FaxNo)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.IsMaster)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.MobileNo)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.PhoneNo)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Tcustomer>(entity =>
            {
                entity.HasKey(e => e.CustomerId)
                    .HasName("PK_TCUSTOMER");

                entity.ToTable("TCustomer");

                entity.Property(e => e.CustomerId).ValueGeneratedNever();

                entity.Property(e => e.ApiPassword).HasMaxLength(255);

                entity.Property(e => e.ApiUserId)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.DistributeCenterId)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TdataPublisher>(entity =>
            {
                entity.HasKey(e => e.DataPublisherId)
                    .HasName("PK_TDATAPUBLISHER");

                entity.ToTable("TDataPublisher");

                entity.Property(e => e.DataPublisherId)
                    .HasMaxLength(60)
                    .ValueGeneratedNever();

                entity.Property(e => e.ClassName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DataPublisherName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.DataSourceType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.LastExecuteTime).HasColumnType("datetime");

                entity.Property(e => e.SqlStatement).HasColumnType("text");

                entity.Property(e => e.StartTime)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TdataPublisherParameter>(entity =>
            {
                entity.HasKey(e => e.DataPublisherId)
                    .HasName("PK_TDATAPUBLISHERPARAMETER");

                entity.ToTable("TDataPublisherParameter");

                entity.Property(e => e.DataPublisherId)
                    .HasMaxLength(60)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DataType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.DefaultValue)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.MaxValue)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.MinValue)
                    .IsRequired()
                    .HasColumnName("MInValue")
                    .HasMaxLength(255);

                entity.Property(e => e.ParameterCode)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ParameterName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TdataSubscription>(entity =>
            {
                entity.HasKey(e => e.SubscriptionId)
                    .HasName("PK_TDATASUBSCRIPTION");

                entity.ToTable("TDataSubscription");

                entity.Property(e => e.ClassName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DataPublisherId)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.SubscriptionType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<TdataTrack>(entity =>
            {
                entity.HasKey(e => e.TrackId)
                    .HasName("PK_TDATATRACK");

                entity.ToTable("TDataTrack");

                entity.Property(e => e.AdditiveId)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.RelativeId)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.TrackType)
                    .IsRequired()
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<TdelayBatch>(entity =>
            {
                entity.HasKey(e => e.BatchId)
                    .HasName("PK_DelayMaster");

                entity.ToTable("TDelayBatch");

                entity.HasIndex(e => e.CreateTime)
                    .HasName("Index_TdelayBatch_CreateTime");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DelayType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.DistributeCenterId)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TdelayParcel>(entity =>
            {
                entity.HasKey(e => e.BatchParcelId)
                    .HasName("PK_DelayItem");

                entity.ToTable("TDelayParcel");

                entity.HasIndex(e => e.ParcelId)
                    .HasName("Index_DelayParcel_ParcelId");

                entity.Property(e => e.BatchParcelId).ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DelayTime).HasColumnType("datetime");

                entity.Property(e => e.ReasonId)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TdelayReason>(entity =>
            {
                entity.HasKey(e => e.ReasonId)
                    .HasName("PK_TDELAYREASON");

                entity.ToTable("TDelayReason");

                entity.Property(e => e.ReasonId)
                    .HasMaxLength(20)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.ReasonName)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TdeliveryTimeConsume>(entity =>
            {
                entity.HasKey(e => new { e.DistributeCenterId, e.ProvinceId, e.InterfaceId })
                    .HasName("PK_TDELIVERYTIMECONSUME");

                entity.ToTable("TDeliveryTimeConsume");

                entity.Property(e => e.DistributeCenterId).HasMaxLength(50);

                entity.Property(e => e.InterfaceId).HasDefaultValueSql("((2))");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Tdepartment>(entity =>
            {
                entity.HasKey(e => e.DepartmentId)
                    .HasName("PK_TDEPARTMENT");

                entity.ToTable("TDepartment");

                entity.Property(e => e.DepartmentId).ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DepartmentName)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.DepartmentType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.IsFunction)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Tdescription>(entity =>
            {
                entity.HasKey(e => e.DescriptionId)
                    .HasName("PK_TDESCRIPTION");

                entity.ToTable("TDescription");

                entity.HasIndex(e => e.DescriptionTypeId)
                    .HasName("XIF392TDescription");

                entity.Property(e => e.DescriptionId).ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DescriptionName)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.DescriptionTypeId)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TdescriptionType>(entity =>
            {
                entity.HasKey(e => e.DescriptionTypeId)
                    .HasName("PK_TDESCRIPTIONTYPE");

                entity.ToTable("TDescriptionType");

                entity.Property(e => e.DescriptionTypeId)
                    .HasMaxLength(60)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DescriptionTypeName)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TdistributeCenter>(entity =>
            {
                entity.HasKey(e => e.DistributeCenterId)
                    .HasName("PK_TDISTRIBUTECENTER");

                entity.ToTable("TDistributeCenter");

                entity.Property(e => e.DistributeCenterId)
                    .HasMaxLength(60)
                    .ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DistributeCenterName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TdistributeCenterDomain>(entity =>
            {
                entity.HasKey(e => new { e.DistributeCenterId, e.StartTime })
                    .HasName("PK_TDISTRIBUTECENTERDOMAIN");

                entity.ToTable("TDistributeCenterDomain");

                entity.Property(e => e.DistributeCenterId).HasMaxLength(60);

                entity.Property(e => e.StartTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.EndTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(((2099)-(12))-(31))");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Tdistrict>(entity =>
            {
                entity.HasKey(e => e.DistrictId)
                    .HasName("PK_TDISTRICT");

                entity.ToTable("TDistrict");

                entity.HasIndex(e => e.CityId)
                    .HasName("XIF347TDistrict");

                entity.Property(e => e.DistrictId).ValueGeneratedNever();

                entity.Property(e => e.AliasName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DistrictCode)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.DistrictName)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Tdriver>(entity =>
            {
                entity.HasKey(e => e.DriverId)
                    .HasName("PK_DRIVER");

                entity.ToTable("TDriver");

                entity.HasIndex(e => e.DriverName)
                    .HasName("Index_TDriver_DriverName");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DistributeCenterId)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.DriverCode)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.DriverName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.EntryTime).HasColumnType("smalldatetime");

                entity.Property(e => e.IdCard)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.MobileNo)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.UrgentContact)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.UrgentPhone)
                    .IsRequired()
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<TdynamicSql>(entity =>
            {
                entity.HasKey(e => e.SqlUsageCode)
                    .HasName("PK_TDYNAMICSQL");

                entity.ToTable("TDynamicSql");

                entity.Property(e => e.SqlUsageCode)
                    .HasMaxLength(60)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasMaxLength(512);

                entity.Property(e => e.SqlUsageName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.SqlUsageType)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Sqlstatement)
                    .IsRequired()
                    .HasColumnName("SQLStatement")
                    .HasColumnType("text");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Texpress>(entity =>
            {
                entity.HasKey(e => e.ExpressId)
                    .HasName("PK_TEXPRESS");

                entity.ToTable("TExpress");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.ExpressCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ExpressName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.IsDisplayOnWeb)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IsMultiPackage)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TgisArea>(entity =>
            {
                entity.HasKey(e => e.AreaId)
                    .HasName("PK_TGISAREA");

                entity.ToTable("TGisArea");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.AreaName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasMaxLength(60)
                    .HasDefaultValueSql("(N'white')");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DistributeCenterId)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.IsByRegion)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Path).HasColumnType("text");

                entity.Property(e => e.PointLatitude).HasColumnType("numeric(9, 6)");

                entity.Property(e => e.PointLongitude).HasColumnType("numeric(9, 6)");

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ShippingType).HasMaxLength(1);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TgisDomain>(entity =>
            {
                entity.HasKey(e => e.DomainId)
                    .HasName("PK_TGISDOMAIN");

                entity.ToTable("TGisDomain");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.DistributeCenterId)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.DomainName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Thandle>(entity =>
            {
                entity.HasKey(e => e.HandleId)
                    .HasName("PK_THANDLE");

                entity.ToTable("THandle");

                entity.HasIndex(e => e.HandleTypeId)
                    .HasName("XIF379THandle");

                entity.HasIndex(e => e.RelativeId)
                    .HasName("XIE1TOperationInfo_RelativeId");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.RelativeId)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasMaxLength(512);
            });

            modelBuilder.Entity<ThandleType>(entity =>
            {
                entity.HasKey(e => e.HandleTypeId)
                    .HasName("PK_THANDLETYPE");

                entity.ToTable("THandleType");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.HandleTypeName)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TinterfaceExpress>(entity =>
            {
                entity.HasKey(e => new { e.InterfaceId, e.ExpressId })
                    .HasName("PK_TINTERFACEEXPRESS");

                entity.ToTable("TInterfaceExpress");

                entity.Property(e => e.CourierRegex)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.InterfaceExpressCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ReceiverRegex)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Tlanguage>(entity =>
            {
                entity.HasKey(e => e.LanguageId)
                    .HasName("PK_TLANGUAGE");

                entity.ToTable("TLanguage");

                entity.Property(e => e.LanguageId)
                    .HasMaxLength(20)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.LanguageName)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TlogisticInterface>(entity =>
            {
                entity.HasKey(e => e.InterfaceId)
                    .HasName("PK_TLOGISTICINTERFACE");

                entity.ToTable("TLogisticInterface");

                entity.Property(e => e.InterfaceId).ValueGeneratedNever();

                entity.Property(e => e.ApplicationId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CourierRegex)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.InterfaceIntervalHour).HasDefaultValueSql("('')");

                entity.Property(e => e.InterfaceName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.InterfaceType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.PrepareClassName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ReceiverRegex)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TlogisticLogParcelDetail>(entity =>
            {
                entity.HasKey(e => e.DetailId)
                    .HasName("PK_TLOGISTICLOGPARCELDETAIL");

                entity.ToTable("TLogisticLogParcelDetail");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CustomerCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.VoucherNo).HasMaxLength(3000);
            });

            modelBuilder.Entity<TlogisticParcel>(entity =>
            {
                entity.HasKey(e => e.ParcelId)
                    .HasName("PK_TLOGISTICPARCEL");

                entity.ToTable("TLogisticParcel");

                entity.HasIndex(e => e.CustomerCode)
                    .HasName("Index_CustomerCode");

                entity.HasIndex(e => e.ExpressParcelCode)
                    .HasName("Index_ExpressParcelCode");

                entity.HasIndex(e => new { e.ParcelId, e.ConfirmTime, e.IsConfirmed, e.Status })
                    .HasName("idx_TLogisticParcel_IsConfirmed_Status");

                entity.Property(e => e.ConfirmTime).HasColumnType("datetime");

                entity.Property(e => e.Courier)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CourierMobile)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CustomerCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DataType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.DeliveryTime).HasColumnType("datetime");

                entity.Property(e => e.DistributeCenterId)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ExportTime).HasColumnType("datetime");

                entity.Property(e => e.ExpressParcelCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.InterfaceErrorMessage)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.InterfaceStatus)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.InterfaceUpdateTime).HasColumnType("datetime");

                entity.Property(e => e.IsConfirmed)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NextInterfaceTime).HasColumnType("datetime");

                entity.Property(e => e.ParcelAmount).HasColumnType("decimal(19, 8)");

                entity.Property(e => e.Receiver).HasMaxLength(100);

                entity.Property(e => e.ReceiverAddress)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ReceiverMobile)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ReceiverPhone)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.SignTime).HasColumnType("datetime");

                entity.Property(e => e.Signer)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Tmstamp)
                    .IsRequired()
                    .HasColumnName("tmstamp")
                    .IsRowVersion();

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.VoucherNo).HasMaxLength(3000);
            });

            modelBuilder.Entity<TlogisticParcelLog>(entity =>
            {
                entity.HasKey(e => e.LogId)
                    .HasName("PK_TLOGISTICPARCELLOG");

                entity.ToTable("TLogisticParcelLog");

                entity.HasIndex(e => e.ParcelId)
                    .HasName("Index_ParcelId");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.LogContent)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.LogTime).HasColumnType("datetime");

                entity.Property(e => e.LogType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Tmstamp)
                    .IsRequired()
                    .HasColumnName("tmstamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<TlogisticParcelType>(entity =>
            {
                entity.HasKey(e => e.ParcelTypeId)
                    .HasName("PK_TLOGISTICPARCELTYPE");

                entity.ToTable("TLogisticParcelType");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DataType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.IsNeedConfirmn)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.ParcelTypeCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ParcelTypeName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TlongText>(entity =>
            {
                entity.HasKey(e => e.LongTextId)
                    .HasName("PK_TLONGTEXT");

                entity.ToTable("TLongText");

                entity.Property(e => e.LongTextId).ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.TextContent)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TmailAttachment>(entity =>
            {
                entity.HasKey(e => e.AttachmentId)
                    .HasName("PK_TMAILATTACHMENT");

                entity.ToTable("TMailAttachment");

                entity.HasIndex(e => e.MailId)
                    .HasName("XIF376TMailAttachment");

                entity.Property(e => e.AttachmentId).ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<TmailFailed>(entity =>
            {
                entity.HasKey(e => e.MailId)
                    .HasName("PK_TMAILFAILED");

                entity.ToTable("TMailFailed");

                entity.HasIndex(e => e.MailFormatId)
                    .HasName("XIF364TMailFailed");

                entity.HasIndex(e => e.MailId)
                    .HasName("XIF363TMailFailed");

                entity.HasIndex(e => e.MailTo)
                    .HasName("XIE1TMailFailed_MailTo");

                entity.Property(e => e.MailId).ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.FailDescription)
                    .IsRequired()
                    .HasMaxLength(4000);

                entity.Property(e => e.LastRetryTime).HasColumnType("datetime");

                entity.Property(e => e.MailCc)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.MailTo)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.RelativeId)
                    .IsRequired()
                    .HasMaxLength(2000);
            });

            modelBuilder.Entity<TmailFormat>(entity =>
            {
                entity.HasKey(e => e.MailFormatId)
                    .HasName("PK_TMAILFORMAT");

                entity.ToTable("TMailFormat");

                entity.Property(e => e.MailFormatId).ValueGeneratedNever();

                entity.Property(e => e.ContentUrl)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.IsAllowEdit)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.IsEnablEdit)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.MailBcc)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.MailCc)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.MailContent).HasColumnType("text");

                entity.Property(e => e.MailFormatCode)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.MailFormatName)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.MailFrom)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.VerifyWord)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<TmailFormatAttachment>(entity =>
            {
                entity.HasKey(e => e.AttatchmentId)
                    .HasName("PK_TMAILFORMATATTACHMENT");

                entity.ToTable("TMailFormatAttachment");

                entity.HasIndex(e => e.MailFormatId)
                    .HasName("XIF377TMailFormatAttachment");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<TmailSent>(entity =>
            {
                entity.HasKey(e => e.MailId)
                    .HasName("PK_TMAILSENT");

                entity.ToTable("TMailSent");

                entity.HasIndex(e => e.MailFormatId)
                    .HasName("XIF366TMailSent");

                entity.HasIndex(e => e.MailId)
                    .HasName("XIF365TMailSent");

                entity.HasIndex(e => e.MailTo)
                    .HasName("XIE1TMailSent_MailTo");

                entity.Property(e => e.MailId).ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.MailCc)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.MailFrom)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.MailTo)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.RelativeId)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.SendTime).HasColumnType("datetime");

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<TmailToSend>(entity =>
            {
                entity.HasKey(e => e.MailId)
                    .HasName("PK_TMAILTOSEND");

                entity.ToTable("TMailToSend");

                entity.HasIndex(e => e.MailFormatId)
                    .HasName("XIF362TMailToSend");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.MailCc)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.MailTo)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.RelativeId)
                    .IsRequired()
                    .HasMaxLength(2000);
            });

            modelBuilder.Entity<Tnode>(entity =>
            {
                entity.HasKey(e => e.NodeId)
                    .HasName("PK_TNODE");

                entity.ToTable("TNode");

                entity.HasIndex(e => e.EarliestTimeLimitId)
                    .HasName("XIF451TNode");

                entity.HasIndex(e => e.LastTimeLimitId)
                    .HasName("XIF450TNode");

                entity.HasIndex(e => e.ProcessVersionId)
                    .HasName("XIF312TNode");

                entity.HasIndex(e => e.StandardTimeLimitId)
                    .HasName("XIF449TNode");

                entity.Property(e => e.NodeId).ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.IsAutoAllocateActor)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.IsAutoExecute)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.IsCancelWhenExpired)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.IsMultiActor)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.NodeInstanceName)
                    .IsRequired()
                    .HasMaxLength(512);

                entity.Property(e => e.NodeName)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.NodeType)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TnodeActor>(entity =>
            {
                entity.HasKey(e => e.NodeActorId)
                    .HasName("PK_TNODEACTOR");

                entity.ToTable("TNodeActor");

                entity.HasIndex(e => e.NodeId)
                    .HasName("XIF334TNodeActor");

                entity.Property(e => e.NodeActorId).ValueGeneratedNever();

                entity.Property(e => e.ActType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.ActorRelationType)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.ActorRelationValue)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.ActorSource)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.ActorType)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.IsIncludeChild)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.IsIncludePlurality)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.IsMultiActor)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TnodeApplication>(entity =>
            {
                entity.HasKey(e => e.NodeId)
                    .HasName("PK_TNODEAPPLICATION");

                entity.ToTable("TNodeApplication");

                entity.HasIndex(e => e.ParameterSetId)
                    .HasName("XIF356TNodeApplication");

                entity.Property(e => e.NodeId).ValueGeneratedNever();

                entity.Property(e => e.ApplicationType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.ConfigValue1)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.ConfigValue2)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TnodeCondition>(entity =>
            {
                entity.HasKey(e => e.NodeId)
                    .HasName("PK_TNODECONDITION");

                entity.ToTable("TNodeCondition");

                entity.HasIndex(e => e.NodeId)
                    .HasName("XIF319TNodeCondition");

                entity.Property(e => e.NodeId).ValueGeneratedNever();

                entity.Property(e => e.CompleteCondition)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.EndConditionDisplayNote)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.StartCondition)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.StartConditionDisplayNote)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TnodeInstance>(entity =>
            {
                entity.HasKey(e => e.NodeInstanceId)
                    .HasName("PK_TNODEINSTANCE");

                entity.ToTable("TNodeInstance");

                entity.HasIndex(e => e.NodeId)
                    .HasName("XIF323TNodeInstance");

                entity.HasIndex(e => e.ProcessInstanceId)
                    .HasName("XIF324TNodeInstance");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.EarliestDateExpired).HasColumnType("smalldatetime");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.LastDateExpired).HasColumnType("smalldatetime");

                entity.Property(e => e.NodeInstanceName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.StardandDateExpired).HasColumnType("smalldatetime");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);
            });

            modelBuilder.Entity<TnodeInstanceActor>(entity =>
            {
                entity.HasKey(e => e.InstanceActorId)
                    .HasName("PK_TNODEINSTANCEACTOR");

                entity.ToTable("TNodeInstanceActor");

                entity.HasIndex(e => e.NodeInstanceId)
                    .HasName("XIF335TNodeInstanceActor");

                entity.Property(e => e.ActType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.ActorType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TnodeInstanceHandle>(entity =>
            {
                entity.HasKey(e => e.HandelId)
                    .HasName("PK_TNODEINSTANCEHANDLE");

                entity.ToTable("TNodeInstanceHandle");

                entity.HasIndex(e => e.NodeInstanceId)
                    .HasName("XIF351TNodeInstanceHandle");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.StartTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TnodeLink>(entity =>
            {
                entity.HasKey(e => e.LinkId)
                    .HasName("PK_TNODELINK");

                entity.ToTable("TNodeLink");

                entity.HasIndex(e => e.NextNodeId)
                    .HasName("XIF318TNodeLink");

                entity.HasIndex(e => e.PriorNodeId)
                    .HasName("XIF317TNodeLink");

                entity.Property(e => e.LinkId).ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.IsJumpByCondition)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.JumpCondition)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.JumpConditionDisplayNote)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TnodeLinkInstance>(entity =>
            {
                entity.HasKey(e => e.LinkInstanceId)
                    .HasName("PK_TNODELINKINSTANCE");

                entity.ToTable("TNodeLinkInstance");

                entity.HasIndex(e => e.LinkId)
                    .HasName("XIF357TNodeLinkInstance");

                entity.HasIndex(e => e.NextNodeInstanceId)
                    .HasName("XIF359TNodeLinkInstance");

                entity.HasIndex(e => e.PriorNodeInstanceId)
                    .HasName("XIF358TNodeLinkInstance");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TnodeProcess>(entity =>
            {
                entity.HasKey(e => e.NodeId)
                    .HasName("PK_TNODEPROCESS");

                entity.ToTable("TNodeProcess");

                entity.HasIndex(e => e.NodeId)
                    .HasName("XIF320TNodeProcess");

                entity.HasIndex(e => e.ProcessVersionId)
                    .HasName("XIF321TNodeProcess");

                entity.Property(e => e.NodeId).ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TnodeSchedule>(entity =>
            {
                entity.HasKey(e => new { e.NodeId, e.ScheduleId })
                    .HasName("PK_TNODESCHEDULE");

                entity.ToTable("TNodeSchedule");

                entity.HasIndex(e => e.NodeId)
                    .HasName("XIF332TNodeSchedule");

                entity.HasIndex(e => e.ScheduleId)
                    .HasName("XIF333TNodeSchedule");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);
            });

            modelBuilder.Entity<TnoticeEvent>(entity =>
            {
                entity.HasKey(e => e.EventId)
                    .HasName("PK_TNOTICEEVENT");

                entity.ToTable("TNoticeEvent");

                entity.Property(e => e.EventId)
                    .HasMaxLength(60)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.EventDescription)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.EventName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.IsUse)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.SendType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.SubscriptionType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TnoticeEventArgument>(entity =>
            {
                entity.HasKey(e => new { e.EventId, e.ArgumentName })
                    .HasName("PK_TNOTICEEVENTARGUMENT");

                entity.ToTable("TNoticeEventArgument");

                entity.HasIndex(e => e.EventId)
                    .HasName("XIF385TNoticeEventArgument");

                entity.Property(e => e.EventId).HasMaxLength(60);

                entity.Property(e => e.ArgumentName).HasMaxLength(60);

                entity.Property(e => e.ArgumentDescription)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TnoticeEventDataItem>(entity =>
            {
                entity.HasKey(e => new { e.EventId, e.DataItemName })
                    .HasName("PK_TNOTICEEVENTDATAITEM");

                entity.ToTable("TNoticeEventDataItem");

                entity.Property(e => e.EventId).HasMaxLength(60);

                entity.Property(e => e.DataItemName).HasMaxLength(60);

                entity.Property(e => e.DataItemDescription)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);
            });

            modelBuilder.Entity<TnoticeEventMessage>(entity =>
            {
                entity.HasKey(e => e.MessageId)
                    .HasName("PK_TNOTICEEVENTMESSAGE");

                entity.ToTable("TNoticeEventMessage");

                entity.HasIndex(e => e.EventId)
                    .HasName("XIF382TNoticeEventMessage");

                entity.Property(e => e.MessageId).ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.EventId)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.IsUse)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.MessageFormatId)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.MessageType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TnoticeEventSubscription>(entity =>
            {
                entity.HasKey(e => e.SubscriptionId)
                    .HasName("PK_TNOTICEEVENTSUBSCRIPTION");

                entity.ToTable("TNoticeEventSubscription");

                entity.HasIndex(e => e.EventId)
                    .HasName("XIF389TNoticeEventSubscription");

                entity.HasIndex(e => e.MessageId)
                    .HasName("XIF388TNoticeEventSubscription");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.EventId)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Subscriber)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<TobjectPower>(entity =>
            {
                entity.HasKey(e => new { e.ObjectType, e.ObjectId })
                    .HasName("PK_TOBJECTPOWER");

                entity.ToTable("TObjectPower");

                entity.Property(e => e.ObjectType).HasMaxLength(20);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.PowerValue)
                    .IsRequired()
                    .HasMaxLength(4000);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Toccupation>(entity =>
            {
                entity.HasKey(e => e.OccupationId)
                    .HasName("PK_TOCCUPATION");

                entity.ToTable("TOccupation");

                entity.Property(e => e.OccupationId).ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.OccupationCode)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.OccupationName).HasMaxLength(60);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TouterParcel>(entity =>
            {
                entity.HasKey(e => e.OuterParcelId)
                    .HasName("PK_TOUTERPARCEL");

                entity.ToTable("TOuterParcel");

                entity.HasIndex(e => e.CreateTime)
                    .HasName("Index_TOuterParcel_CreateTime");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.CodAmount).HasColumnType("numeric(19, 2)");

                entity.Property(e => e.Company).HasMaxLength(100);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CustomerNote)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.DeliveryNote)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.DeliveryTime).HasColumnType("datetime");

                entity.Property(e => e.DistributeCenterId)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.District)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.FailedReason)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.GoodsAmount).HasColumnType("numeric(19, 2)");

                entity.Property(e => e.IsFailed)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.Latitude).HasColumnType("numeric(9, 6)");

                entity.Property(e => e.Longitude).HasColumnType("numeric(9, 6)");

                entity.Property(e => e.Mobile)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.OperateType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.OrderCustomerId)
                    .IsRequired()
                    .HasColumnName("OrderCustomerID")
                    .HasMaxLength(60);

                entity.Property(e => e.ParcelType)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.PayType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.PayTypeDescription)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Province)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.SalesOrderNo)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Source)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.StockOrderNo)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.TelePhone)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TouterParcelHistory>(entity =>
            {
                entity.HasKey(e => e.OuterParcelId)
                    .HasName("PK_TOUTERPARCELHISTORY");

                entity.ToTable("TOuterParcelHistory");

                entity.HasIndex(e => e.CreateTime)
                    .HasName("Index_TOuterParcel_CreateTime");

                entity.Property(e => e.OuterParcelId).ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.CodAmount).HasColumnType("numeric(19, 2)");

                entity.Property(e => e.Company).HasMaxLength(100);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CustomerNote)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.DeliveryNote)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.DeliveryTime).HasColumnType("datetime");

                entity.Property(e => e.DistributeCenterId)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.District)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.FailedReason)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.GoodsAmount).HasColumnType("numeric(19, 2)");

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.Latitude).HasColumnType("numeric(9, 6)");

                entity.Property(e => e.Longitude).HasColumnType("numeric(9, 6)");

                entity.Property(e => e.Mobile)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.OperateType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.OrderCustomerId)
                    .IsRequired()
                    .HasColumnName("OrderCustomerID")
                    .HasMaxLength(60);

                entity.Property(e => e.ParcelType)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.PayType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.PayTypeDescription)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.ProcessTime).HasColumnType("datetime");

                entity.Property(e => e.Province)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.SalesOrderNo)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Source)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.StockOrderNo)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.TelePhone)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TparameterSet>(entity =>
            {
                entity.HasKey(e => e.SetId)
                    .HasName("PK_TPARAMETERSET");

                entity.ToTable("TParameterSet");

                entity.Property(e => e.SetId).ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TparameterSetDetail>(entity =>
            {
                entity.HasKey(e => new { e.SetId, e.ParameterName })
                    .HasName("PK_TPARAMETERSETDETAIL");

                entity.ToTable("TParameterSetDetail");

                entity.HasIndex(e => e.SetId)
                    .HasName("XIF354TParameterSetDetail");

                entity.Property(e => e.ParameterName).HasMaxLength(60);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DataType)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.ParameterValue)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.ValueType)
                    .IsRequired()
                    .HasMaxLength(1);
            });

            modelBuilder.Entity<Tparcel>(entity =>
            {
                entity.HasKey(e => e.ParcelId)
                    .HasName("PK_GIS_TASKORDER");

                entity.ToTable("TParcel");

                entity.HasIndex(e => e.AreaId)
                    .HasName("Index_Parcel_ParcelCode");

                entity.HasIndex(e => e.CreateTime)
                    .HasName("Index_TParcel_CreateTime");

                entity.HasIndex(e => new { e.CustomerId, e.StockOrderNo, e.Status })
                    .HasName("idx_TParcel_CustomerId_StockOrderNo_Status");

                entity.HasIndex(e => new { e.StockOrderNo, e.DeliveryTime, e.DistributeCenterId, e.Source, e.Status })
                    .HasName("IX_TParcel_DSSD_S");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.AppointPayType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.CodAmount).HasColumnType("numeric(19, 2)");

                entity.Property(e => e.Company).HasMaxLength(100);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.CustomerNote)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.DeliveryNote)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.DeliveryTime).HasColumnType("datetime");

                entity.Property(e => e.DistributeCenterId)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.GoodsAmount).HasColumnType("numeric(19, 2)");

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.Latitude).HasColumnType("numeric(9, 6)");

                entity.Property(e => e.Longitude).HasColumnType("numeric(9, 6)");

                entity.Property(e => e.Mobile)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.OrderCustomerId)
                    .IsRequired()
                    .HasColumnName("OrderCustomerID")
                    .HasMaxLength(60);

                entity.Property(e => e.OriginalAddress)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.OriginalDeliveryTime).HasColumnType("datetime");

                entity.Property(e => e.ParcelType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.RealPayType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.SalesOrderNo)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Source)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.StockOrderNo)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.TelePhone)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TparcelHandle>(entity =>
            {
                entity.HasKey(e => e.HandleId)
                    .HasName("PK_TPARCELHANDLE");

                entity.ToTable("TParcelHandle");

                entity.HasIndex(e => e.ParcelId)
                    .HasName("Index_ParcelHandle_ParcelId");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.HandleType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.ReasonId)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<TparcelInterception>(entity =>
            {
                entity.HasKey(e => e.InterceptionId)
                    .HasName("PK_TPARCELINTERCEPTION");

                entity.ToTable("TParcelInterception");

                entity.HasIndex(e => e.CreateTime)
                    .HasName("Index_ParcelException_CreateTime");

                entity.HasIndex(e => e.ParcelId)
                    .HasName("Index_ParcelException_ParcelId");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DateIntercepted).HasColumnType("datetime");

                entity.Property(e => e.FailedReason)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.InterceptedUser)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.InterceptionReason)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.SalesOrderNo)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.StockOrderNo)
                    .IsRequired()
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<Tposition>(entity =>
            {
                entity.HasKey(e => e.PositionId)
                    .HasName("PK_TPOSITION");

                entity.ToTable("TPosition");

                entity.HasIndex(e => e.DepartmentId)
                    .HasName("XIF304TPosition");

                entity.HasIndex(e => e.PositionLevelId)
                    .HasName("XIF308TPosition");

                entity.Property(e => e.PositionId).ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.PositionName)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TpositionLevel>(entity =>
            {
                entity.HasKey(e => e.PositionLevelId)
                    .HasName("PK_TPOSITIONLEVEL");

                entity.ToTable("TPositionLevel");

                entity.Property(e => e.PositionLevelId).ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.PositionLevelName)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Tpower>(entity =>
            {
                entity.HasKey(e => e.PowerId)
                    .HasName("PK_TPOWER");

                entity.ToTable("TPower");

                entity.Property(e => e.PowerId).ValueGeneratedNever();

                entity.Property(e => e.ApplicationId)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.HasSplitLine)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.IsLastLevel)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.IsUseSsl)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.MenuIcon).HasMaxLength(255);

                entity.Property(e => e.ObjectName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.PowerCode)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.PowerName)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.PowerType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Tprocess>(entity =>
            {
                entity.HasKey(e => e.ProcessId)
                    .HasName("PK_TPROCESS");

                entity.ToTable("TProcess");

                entity.HasIndex(e => e.CurrentVersionId)
                    .HasName("XIF345TProcess");

                entity.Property(e => e.ProcessId).ValueGeneratedNever();

                entity.Property(e => e.Class1)
                    .IsRequired()
                    .HasMaxLength(60)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Class2)
                    .IsRequired()
                    .HasMaxLength(60)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.ProcessDescription)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProcessName)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TprocessInstance>(entity =>
            {
                entity.HasKey(e => e.ProcessInstanceId)
                    .HasName("PK_TPROCESSINSTANCE");

                entity.ToTable("TProcessInstance");

                entity.HasIndex(e => e.ProcessVersionId)
                    .HasName("XIF322TProcessInstance");

                entity.HasIndex(e => new { e.ProcessVersionId, e.KeyValue })
                    .HasName("XIE1TProcessInstance_Version_k");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.EarliestDateExpired).HasColumnType("smalldatetime");

                entity.Property(e => e.KeyValue)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.LastDateExpired).HasColumnType("smalldatetime");

                entity.Property(e => e.ProcessInstanceName)
                    .IsRequired()
                    .HasMaxLength(512);

                entity.Property(e => e.RelavantData)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.StardandDateExpired).HasColumnType("smalldatetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TprocessParameter>(entity =>
            {
                entity.HasKey(e => e.ParameterId)
                    .HasName("PK_TPROCESSPARAMETER");

                entity.ToTable("TProcessParameter");

                entity.HasIndex(e => e.ProcessId)
                    .HasName("XIF447TProcessParameter");

                entity.Property(e => e.ParameterId).ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DataType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.ParameterCode)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.ParameterDescription)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.ParameterName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ParameterType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.ParameterUsage)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TprocessSchedule>(entity =>
            {
                entity.HasKey(e => new { e.ProcessVersionId, e.ScheduleId })
                    .HasName("PK_TPROCESSSCHEDULE");

                entity.ToTable("TProcessSchedule");

                entity.HasIndex(e => e.ProcessVersionId)
                    .HasName("XIF336TProcessSchedule");

                entity.HasIndex(e => e.ScheduleId)
                    .HasName("XIF337TProcessSchedule");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TprocessVersion>(entity =>
            {
                entity.HasKey(e => e.ProcessVersionId)
                    .HasName("PK_TPROCESSVERSION");

                entity.ToTable("TProcessVersion");

                entity.HasIndex(e => e.ConstructParameterSetId)
                    .HasName("XIF355TProcessVersion");

                entity.HasIndex(e => e.ProcessId)
                    .HasName("XIF344TProcessVersion");

                entity.Property(e => e.ProcessVersionId).ValueGeneratedNever();

                entity.Property(e => e.ClassName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.IsAutoExecute)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.IsCancelWhenExpired)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.ProcessDescription)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProcessInstanceName)
                    .IsRequired()
                    .HasMaxLength(512);

                entity.Property(e => e.ProcessName)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.VersionId)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.XmlData).HasColumnType("text");
            });

            modelBuilder.Entity<Tprovince>(entity =>
            {
                entity.HasKey(e => e.ProvinceId)
                    .HasName("PK_TPROVINCE");

                entity.ToTable("TProvince");

                entity.Property(e => e.ProvinceId).ValueGeneratedNever();

                entity.Property(e => e.AliasName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.ProvinceCode)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.ProvinceName)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TrecordChange>(entity =>
            {
                entity.HasKey(e => e.ChangeId)
                    .HasName("PK_TRECORDCHANGE");

                entity.ToTable("TRecordChange");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.KeyValue)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<TrecordChangeField>(entity =>
            {
                entity.HasKey(e => new { e.ChangeId, e.FieldName })
                    .HasName("PK_TRECORDCHANGEFIELD");

                entity.ToTable("TRecordChangeField");

                entity.HasIndex(e => e.ChangeId)
                    .HasName("XIF381TRecordChangeField");

                entity.Property(e => e.FieldName).HasMaxLength(255);

                entity.Property(e => e.NewValue)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.OldValue)
                    .IsRequired()
                    .HasMaxLength(1000);
            });

            modelBuilder.Entity<TreplicationApplication>(entity =>
            {
                entity.HasKey(e => e.ApplicationId)
                    .HasName("PK_TREPLICATIONAPPLICATION");

                entity.ToTable("TReplicationApplication");

                entity.Property(e => e.ApplicationId)
                    .HasMaxLength(60)
                    .ValueGeneratedNever();

                entity.Property(e => e.ApplicationName)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.ApplicationType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.CommunicationKey).HasMaxLength(255);

                entity.Property(e => e.CommunicationUserId)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.InterfaceBaseUrl)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.IsVerifyKey)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TreplicationType>(entity =>
            {
                entity.HasKey(e => e.ReplicationTypeId)
                    .HasName("PK_TREPLICATIONTYPE");

                entity.ToTable("TReplicationType");

                entity.HasIndex(e => e.ApplicationId)
                    .HasName("XIF432TReplicationType");

                entity.Property(e => e.ReplicationTypeId)
                    .HasMaxLength(60)
                    .ValueGeneratedNever();

                entity.Property(e => e.ApplicationId)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DataQtyType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.IsForceReplicationAll)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.PrepareClassName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ReplicationAllDayTime)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.ReplicationAllWeekDay)
                    .IsRequired()
                    .HasMaxLength(7);

                entity.Property(e => e.ReplicationTypeName)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.WriteClassName)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Tschedule>(entity =>
            {
                entity.HasKey(e => e.ScheduleId)
                    .HasName("PK_TSCHEDULE");

                entity.ToTable("TSchedule");

                entity.Property(e => e.ScheduleId).ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DailyEndTime)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.DailyFrequency)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.DailyIntervalType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.DailyOnceTime)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.DailyStartTime)
                    .IsRequired()
                    .HasMaxLength(8);

                entity.Property(e => e.EndDate).HasColumnType("smalldatetime");

                entity.Property(e => e.InnerMonthValue)
                    .IsRequired()
                    .HasMaxLength(31);

                entity.Property(e => e.InnerWeekValue)
                    .IsRequired()
                    .HasMaxLength(7);

                entity.Property(e => e.IntervalType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.LastRunTime).HasColumnType("datetime");

                entity.Property(e => e.ScheduleName)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.StartDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.UsageKeyValue)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UsageType)
                    .IsRequired()
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<TshortText>(entity =>
            {
                entity.HasKey(e => e.ShortTextId)
                    .HasName("PK_TSHORTTEXT");

                entity.ToTable("TShortText");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.TextContent)
                    .IsRequired()
                    .HasMaxLength(4000);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TsiteReplication>(entity =>
            {
                entity.HasKey(e => e.ReplicationTypeId)
                    .HasName("PK_TSITEREPLICATION");

                entity.ToTable("TSiteReplication");

                entity.Property(e => e.ReplicationTypeId)
                    .HasMaxLength(60)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.PrepareLastTime).HasColumnType("datetime");

                entity.Property(e => e.ReplicationAllLastTime).HasColumnType("datetime");

                entity.Property(e => e.ReplicationLastTime).HasColumnType("datetime");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TsmsFailed>(entity =>
            {
                entity.HasKey(e => e.SmsId)
                    .HasName("PK_TSMSFAILED");

                entity.ToTable("TSmsFailed");

                entity.HasIndex(e => e.SmsId)
                    .HasName("XIF368TSmsFailed");

                entity.Property(e => e.SmsId).ValueGeneratedNever();

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.FailDescription)
                    .IsRequired()
                    .HasMaxLength(4000);

                entity.Property(e => e.LastRetryTime).HasColumnType("datetime");

                entity.Property(e => e.MobileNo)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Receiver)
                    .IsRequired()
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<TsmsFormat>(entity =>
            {
                entity.HasKey(e => e.SmsFormatId)
                    .HasName("PK_TSMSFORMAT");

                entity.ToTable("TSmsFormat");

                entity.Property(e => e.SmsFormatId).ValueGeneratedNever();

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.SmsFormatCode)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.SmsFormatName)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TsmsReceivedPending>(entity =>
            {
                entity.HasKey(e => e.SmsId)
                    .HasName("PK_TSMSRECEIVEDPENDING");

                entity.ToTable("TSmsReceivedPending");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.MobileNo)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<TsmsSent>(entity =>
            {
                entity.HasKey(e => e.SmsId)
                    .HasName("PK_TSMSSENT");

                entity.ToTable("TSmsSent");

                entity.HasIndex(e => e.Receiver)
                    .HasName("XIE1TSmsSent_Receiver");

                entity.HasIndex(e => e.SmsId)
                    .HasName("XIF367TSmsSent");

                entity.Property(e => e.SmsId).ValueGeneratedNever();

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DateSent).HasColumnType("datetime");

                entity.Property(e => e.MobileNo)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Receiver)
                    .IsRequired()
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<TsmsToSend>(entity =>
            {
                entity.HasKey(e => e.SmsId)
                    .HasName("PK_TSMSTOSEND");

                entity.ToTable("TSmsToSend");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.MobileNo)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Receiver)
                    .IsRequired()
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<TsmsToSendTimer>(entity =>
            {
                entity.HasKey(e => e.SmsId)
                    .HasName("PK_TSMSTOSENDTIMER");

                entity.ToTable("TSmsToSendTimer");

                entity.HasIndex(e => e.ExpectedSendTime)
                    .HasName("XIE1TSmsToSendTimer_ExprectedD");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.ExpectedSendTime).HasColumnType("datetime");

                entity.Property(e => e.MobileNo)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Receiver)
                    .IsRequired()
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<TsysColsList>(entity =>
            {
                entity.HasKey(e => new { e.ColName, e.TableName })
                    .HasName("PK_TSYSCOLSLIST");

                entity.ToTable("TSysColsList");

                entity.Property(e => e.ColName).HasMaxLength(128);

                entity.Property(e => e.TableName).HasMaxLength(128);

                entity.Property(e => e.ClassName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ClassPropertyName)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ColDescription)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ColNote)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DataType)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultValue)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IsBool)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.IsDefaultSetByUser)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IsGetByParent)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.IsNeedLanguage)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IsRequired)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.MaxValue)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MinValue)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ParentGetMethodName)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RegExpression)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserDefaultValue)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ValueType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TsysConfig>(entity =>
            {
                entity.HasKey(e => new { e.ConfigClass, e.ConfigName })
                    .HasName("PK_TSYSCONFIG");

                entity.ToTable("TSysConfig");

                entity.Property(e => e.ConfigClass).HasMaxLength(60);

                entity.Property(e => e.ConfigName).HasMaxLength(60);

                entity.Property(e => e.ConfigDescription)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ConfigNote)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.ConfigStatus)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.ConfigValue)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.IsReserved)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.ValidateRegExpress)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<TsysConfigClass>(entity =>
            {
                entity.HasKey(e => e.ConfigClass)
                    .HasName("PK_TSYSCONFIGCLASS");

                entity.ToTable("TSysConfigClass");

                entity.Property(e => e.ConfigClass)
                    .HasMaxLength(60)
                    .ValueGeneratedNever();

                entity.Property(e => e.ConfigClassName)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TsysMaxNumber>(entity =>
            {
                entity.HasKey(e => new { e.ColName, e.TableName })
                    .HasName("PK_TSYSMAXNUMBER");

                entity.ToTable("TSysMaxNumber");

                entity.Property(e => e.ColName).HasMaxLength(128);

                entity.Property(e => e.TableName).HasMaxLength(128);

                entity.Property(e => e.ColNote)
                    .IsRequired()
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<TsysStatus>(entity =>
            {
                entity.HasKey(e => new { e.TableName, e.ColName, e.CodeValue })
                    .HasName("PK_TSYSSTATUS");

                entity.ToTable("TSysStatus");

                entity.Property(e => e.TableName)
                    .HasMaxLength(128)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.ColName).HasMaxLength(128);

                entity.Property(e => e.CodeValue)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayValue)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayValueEnglish)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StatusNote)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TsysStatusLanguage>(entity =>
            {
                entity.HasKey(e => new { e.TableName, e.ColName, e.CodeValue, e.LanguageId })
                    .HasName("PK_TSYSSTATUSLANGUAGE");

                entity.ToTable("TSysStatusLanguage");

                entity.HasIndex(e => e.LanguageId)
                    .HasName("XIF434TSysStatusLanguage");

                entity.Property(e => e.TableName)
                    .HasMaxLength(128)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.ColName).HasMaxLength(128);

                entity.Property(e => e.CodeValue).HasMaxLength(60);

                entity.Property(e => e.LanguageId).HasMaxLength(20);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DisplayValue)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.DisplayValueEnglish)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.StatusNote)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TsysTablesList>(entity =>
            {
                entity.HasKey(e => e.TableName)
                    .HasName("PK_TSYSTABLESLIST");

                entity.ToTable("TSysTablesList");

                entity.Property(e => e.TableName)
                    .HasMaxLength(128)
                    .ValueGeneratedNever();

                entity.Property(e => e.IsAllowCache)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IsEnableCache)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TableDescription)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TtaskType>(entity =>
            {
                entity.HasKey(e => e.TaskTypeId)
                    .HasName("PK_TTASKTYPE");

                entity.ToTable("TTaskType");

                entity.Property(e => e.TaskTypeId)
                    .HasMaxLength(60)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DateHandled).HasColumnType("datetime");

                entity.Property(e => e.MaxId)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.TaskTypeName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TtimeLimit>(entity =>
            {
                entity.HasKey(e => e.TimeLimitId)
                    .HasName("PK_TTIMELIMIT");

                entity.ToTable("TTimeLimit");

                entity.Property(e => e.TimeLimitId).ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.IntervalType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.TimeLimtName)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TtoDoList>(entity =>
            {
                entity.HasKey(e => e.ToDoListId)
                    .HasName("PK_TTODOLIST");

                entity.ToTable("TToDoList");

                entity.HasIndex(e => new { e.RelativeId, e.ToDoType })
                    .HasName("XIE1TToDoList_relativeid");

                entity.Property(e => e.AdditiveId)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.ErrorInfo).HasColumnType("text");

                entity.Property(e => e.IsStoped)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.LastRetryTime).HasColumnType("datetime");

                entity.Property(e => e.NextRetryTime).HasColumnType("datetime");

                entity.Property(e => e.RelativeId)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.ToDoType)
                    .IsRequired()
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<TtoDoListErrorLog>(entity =>
            {
                entity.HasKey(e => e.ErrorId)
                    .HasName("PK_TTODOLISTERRORLOG");

                entity.ToTable("TToDoListErrorLog");

                entity.HasIndex(e => e.ToDoListId)
                    .HasName("ToDoListErrorLog_ToDoId");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.ErrorInfo)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.IsBatchToDoList)
                    .IsRequired()
                    .HasMaxLength(1);
            });

            modelBuilder.Entity<TtoDoListHistory>(entity =>
            {
                entity.HasKey(e => e.ToDoListId)
                    .HasName("PK_TTODOLISTHISTORY");

                entity.ToTable("TToDoListHistory");

                entity.HasIndex(e => e.ToDoListId)
                    .HasName("XIF427TToDoListHistory");

                entity.HasIndex(e => new { e.RelativeId, e.ToDoType })
                    .HasName("XIE1TIDToDoHistory_");

                entity.Property(e => e.ToDoListId).ValueGeneratedNever();

                entity.Property(e => e.AdditiveId)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DateProcessed).HasColumnType("datetime");

                entity.Property(e => e.RelativeId)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.ToDoType)
                    .IsRequired()
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<TtoDoType>(entity =>
            {
                entity.HasKey(e => e.ToDoTypeId)
                    .HasName("PK_TTODOTYPE");

                entity.ToTable("TToDoType");

                entity.Property(e => e.ToDoTypeId)
                    .HasMaxLength(60)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DateNoticed).HasColumnType("smalldatetime");

                entity.Property(e => e.EventNoticeId)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.IsAlertWhenDelay)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.ToDoTypeName)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TtransportBatch>(entity =>
            {
                entity.HasKey(e => e.BatchId)
                    .HasName("PK_GIS_DELIVERYMASTER");

                entity.ToTable("TTransportBatch");

                entity.HasIndex(e => e.CreateTime)
                    .HasName("Index_TransportBatch_CreateTime");

                entity.Property(e => e.BatchId)
                    .HasMaxLength(20)
                    .ValueGeneratedNever();

                entity.Property(e => e.CodAmount).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DeliveryTime).HasColumnType("datetime");

                entity.Property(e => e.DistributeCenterId)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.GoodsAmount).HasColumnType("decimal(19, 2)");

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TtransportBatchHandle>(entity =>
            {
                entity.HasKey(e => e.HandleId)
                    .HasName("PK_TTRANSPORTBATCHHANDLE");

                entity.ToTable("TTransportBatchHandle");

                entity.Property(e => e.BatchId)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.HandleType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<TtransportParcel>(entity =>
            {
                entity.HasKey(e => e.BatchParcelId)
                    .HasName("PK_GIS_DELIVERYITEM");

                entity.ToTable("TTransportParcel");

                entity.HasIndex(e => e.ParcelId)
                    .HasName("Index_TTransportParcel_ParcelId");

                entity.Property(e => e.BatchId)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Ttruck>(entity =>
            {
                entity.HasKey(e => e.TruckId)
                    .HasName("PK_TTRUCK");

                entity.ToTable("TTruck");

                entity.Property(e => e.BrandId)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DateRegistered).HasColumnType("smalldatetime");

                entity.Property(e => e.DistributeCenterId)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.LoadCapacityKg).HasColumnType("numeric(9, 1)");

                entity.Property(e => e.PlateNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.TrackLength).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TtruckBrand>(entity =>
            {
                entity.HasKey(e => e.BrandId)
                    .HasName("PK_TTRUCKBRAND");

                entity.ToTable("TTruckBrand");

                entity.Property(e => e.BrandId)
                    .HasMaxLength(60)
                    .ValueGeneratedNever();

                entity.Property(e => e.BrandName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Remark).HasMaxLength(500);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Tuser>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK_TUSER");

                entity.ToTable("TUser");

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.CompanyPhoneNo)
                    .IsRequired()
                    .HasMaxLength(60)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Field1)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Field2)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Field3)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.HomePhoneNo)
                    .IsRequired()
                    .HasMaxLength(60)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IsFromAd)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.IsRestrictIp)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.LoginId)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Memo)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MobileNo)
                    .IsRequired()
                    .HasMaxLength(60)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Pwd)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.PwdExpireTime).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<TuserDistributeCenter>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.DistributeCenterId })
                    .HasName("PK_TUSERDISTRIBUTECENTER");

                entity.ToTable("TUserDistributeCenter");

                entity.Property(e => e.DistributeCenterId).HasMaxLength(60);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TuserIp>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.IpAddress })
                    .HasName("PK_TUSERIP");

                entity.ToTable("TUserIp");

                entity.HasIndex(e => e.UserId)
                    .HasName("XIF452TUserIp");

                entity.Property(e => e.IpAddress).HasMaxLength(255);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TuserLogin>(entity =>
            {
                entity.HasKey(e => e.UserLoginId)
                    .HasName("PK_TUSERLOGIN");

                entity.ToTable("TUserLogin");

                entity.HasIndex(e => e.UserId)
                    .HasName("XIF393TUserLogin");

                entity.Property(e => e.LoginTime).HasColumnType("datetime");

                entity.Property(e => e.LogoutTime).HasColumnType("datetime");

                entity.Property(e => e.ServerIpAddress)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.UserIpAddress)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<TuserPasswordHistory>(entity =>
            {
                entity.HasKey(e => e.UserPasswordHistoryId)
                    .HasName("PK_TUSERPASSWORDHISTORY");

                entity.ToTable("TUserPasswordHistory");

                entity.HasIndex(e => e.UserId)
                    .HasName("XIF439TUserPasswordHistory");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.NewPwd)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.OldPwd)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<TuserPosition>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.PositionId })
                    .HasName("PK_TUSERPOSITION");

                entity.ToTable("TUserPosition");

                entity.HasIndex(e => e.PositionId)
                    .HasName("XIF310TUserPosition");

                entity.HasIndex(e => e.UserId)
                    .HasName("XIF273TUserPosition");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Field1)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Field2)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.Field3)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.IsPlurality)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TuserProfile>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.ProfileType })
                    .HasName("PK_TUSERPROFILE");

                entity.ToTable("TUserProfile");

                entity.Property(e => e.ProfileType).HasMaxLength(60);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.ProfileValue)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TuserRelation>(entity =>
            {
                entity.HasKey(e => new { e.ParentUserId, e.ChildUserId, e.OccupationId })
                    .HasName("PK_TUSERRELATION");

                entity.ToTable("TUserRelation");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });
        }
    }
}
