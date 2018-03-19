using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ShareT.Data.Entity;

namespace ShareT.Data
{
    public partial class ShareTContext : DbContext
    {
        public ShareTContext(DbContextOptions<ShareTContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            { 
                optionsBuilder.UseSqlServer(@"Server=DESKTOP-RFPQC66\\SQL2016;Database=ShareT;User ID=sa;Password=123456;");
            }
        }

        
        //public virtual DbSet<Account> Account { get; set; }
        //public virtual DbSet<Activity> Activity { get; set; }
        //public virtual DbSet<ActivityLog> ActivityLog { get; set; }
        //public virtual DbSet<ActivityRecordNum> ActivityRecordNum { get; set; }
        //public virtual DbSet<Advertising> Advertising { get; set; }
        //public virtual DbSet<ApplyInvoice> ApplyInvoice { get; set; }
        //public virtual DbSet<ApproveHistory> ApproveHistory { get; set; }
        //public virtual DbSet<BackstageUser> BackstageUser { get; set; }
        //public virtual DbSet<BaiduCity> BaiduCity { get; set; }
        //public virtual DbSet<BespeakRecord> BespeakRecord { get; set; }
        //public virtual DbSet<CarAegis> CarAegis { get; set; }
        //public virtual DbSet<CarBrand> CarBrand { get; set; }
        //public virtual DbSet<CarBreakContract> CarBreakContract { get; set; }
        //public virtual DbSet<CarFaultReport> CarFaultReport { get; set; }
        //public virtual DbSet<CarIllegal> CarIllegal { get; set; }
        //public virtual DbSet<CarPriceRules> CarPriceRules { get; set; }
        //public virtual DbSet<Cars> Cars { get; set; }
        //public virtual DbSet<CarScheduling> CarScheduling { get; set; }
        //public virtual DbSet<CarTravelTrack> CarTravelTrack { get; set; }
        //public virtual DbSet<CarTravelTrackLogs> CarTravelTrackLogs { get; set; }
        //public virtual DbSet<CarType> CarType { get; set; }
        //public virtual DbSet<CarUsage> CarUsage { get; set; }
        //public virtual DbSet<CheckUser> CheckUser { get; set; }
        //public virtual DbSet<City> City { get; set; }
        //public virtual DbSet<CouponCode> CouponCode { get; set; }
        //public virtual DbSet<DepositHistory> DepositHistory { get; set; }
        //public virtual DbSet<Feedbacks> Feedbacks { get; set; }
        //public virtual DbSet<HolidayInfo> HolidayInfo { get; set; }
        //public virtual DbSet<Informations> Informations { get; set; }
        //public virtual DbSet<LotteryRecord> LotteryRecord { get; set; }
        //public virtual DbSet<MaintLog> MaintLog { get; set; }
        //public virtual DbSet<MaintLogFresh> MaintLogFresh { get; set; }
        //public virtual DbSet<MyCard> MyCard { get; set; }
        //public virtual DbSet<MyCoupon> MyCoupon { get; set; }
        //public virtual DbSet<MyInfo> MyInfo { get; set; }
        //public virtual DbSet<NewsManagement> NewsManagement { get; set; }
        //public virtual DbSet<Orders> Orders { get; set; }
        //public virtual DbSet<ParkingArea> ParkingArea { get; set; }
        //public virtual DbSet<ParkingSpaces> ParkingSpaces { get; set; }
        //public virtual DbSet<PreWarn> PreWarn { get; set; }
        //public virtual DbSet<Prize> Prize { get; set; }
        //public virtual DbSet<Region> Region { get; set; }
        //public virtual DbSet<SettingInfo> SettingInfo { get; set; }
        //public virtual DbSet<SystemActions> SystemActions { get; set; }
        //public virtual DbSet<SystemLogsApi> SystemLogsApi { get; set; }
        //public virtual DbSet<SystemLogsSms> SystemLogsSms { get; set; }
        //public virtual DbSet<SystemRolePermission> SystemRolePermission { get; set; }
        //public virtual DbSet<SystemRoles> SystemRoles { get; set; }
        //public virtual DbSet<SystemSettings> SystemSettings { get; set; }
        //public virtual DbSet<ZhimaHistory> ZhimaHistory { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        //    modelBuilder.Entity<Account>(entity =>
        //    {
        //        entity.HasIndex(e => e.LoginName)
        //            .HasName("IX_Account")
        //            .IsUnique();

        //        entity.Property(e => e.ApproveModel).HasDefaultValueSql("((1))");

        //        entity.Property(e => e.ApproveTime).HasColumnType("datetime");

        //        entity.Property(e => e.AvailableInvoice)
        //            .HasColumnType("decimal(10, 2)")
        //            .HasDefaultValueSql("((0))");

        //        entity.Property(e => e.CreateTime).HasColumnType("datetime");

        //        entity.Property(e => e.Deposit).HasColumnType("decimal(8, 2)");

        //        entity.Property(e => e.DepositSetting)
        //            .HasColumnType("decimal(8, 2)")
        //            .HasDefaultValueSql("((999))");

        //        entity.Property(e => e.DriversLicenseCopyPicture)
        //            .HasMaxLength(255)
        //            .IsUnicode(false);

        //        entity.Property(e => e.DriversLicenseEndTime).HasColumnType("datetime");

        //        entity.Property(e => e.DriversLicenseNumber).HasMaxLength(50);

        //        entity.Property(e => e.DriversLicenseOriginalPicture)
        //            .HasMaxLength(255)
        //            .IsUnicode(false);

        //        entity.Property(e => e.DriversLicenseStartTime).HasColumnType("datetime");

        //        entity.Property(e => e.DriversLicenseType).HasMaxLength(10);

        //        entity.Property(e => e.Email)
        //            .HasMaxLength(50)
        //            .IsUnicode(false);

        //        entity.Property(e => e.FullName).HasMaxLength(10);

        //        entity.Property(e => e.HandheldIdCardPicture)
        //            .HasMaxLength(255)
        //            .IsUnicode(false);

        //        entity.Property(e => e.HeadPicture)
        //            .HasMaxLength(255)
        //            .IsUnicode(false);

        //        entity.Property(e => e.Headimgurl).HasMaxLength(200);

        //        entity.Property(e => e.IdCard)
        //            .HasMaxLength(20)
        //            .IsUnicode(false);

        //        entity.Property(e => e.IdCardPicture)
        //            .HasMaxLength(255)
        //            .IsUnicode(false);

        //        entity.Property(e => e.IllegalAmount).HasDefaultValueSql("((0))");

        //        entity.Property(e => e.LastLoginIp)
        //            .HasColumnName("LastLoginIP")
        //            .HasMaxLength(40)
        //            .IsUnicode(false);

        //        entity.Property(e => e.LastLoginTime).HasColumnType("datetime");

        //        entity.Property(e => e.LastUseCarTime).HasColumnType("datetime");

        //        entity.Property(e => e.LoginName)
        //            .IsRequired()
        //            .HasMaxLength(20)
        //            .IsUnicode(false);

        //        entity.Property(e => e.NickName).HasMaxLength(50);

        //        entity.Property(e => e.OpenId).HasMaxLength(50);

        //        entity.Property(e => e.Password)
        //            .IsRequired()
        //            .HasMaxLength(40)
        //            .IsUnicode(false);

        //        entity.Property(e => e.RechargeAmount).HasColumnType("decimal(10, 2)");

        //        entity.Property(e => e.RechargeRate)
        //            .HasColumnType("decimal(8, 6)")
        //            .HasDefaultValueSql("((1))");

        //        entity.Property(e => e.RechargeTotal).HasColumnType("decimal(10, 2)");

        //        entity.Property(e => e.RecommendAccountId).HasDefaultValueSql("((0))");

        //        entity.Property(e => e.RedPacketRemainder)
        //            .HasColumnType("decimal(10, 2)")
        //            .HasDefaultValueSql("((0))");

        //        entity.Property(e => e.Remarks).HasMaxLength(500);

        //        entity.Property(e => e.Unionid).HasMaxLength(50);

        //        entity.Property(e => e.UpdateTime).HasColumnType("datetime");

        //        entity.Property(e => e.UseCarCost)
        //            .HasColumnType("decimal(10, 2)")
        //            .HasDefaultValueSql("((0))");

        //        entity.Property(e => e.UsedCarAmount).HasDefaultValueSql("((0))");

        //        entity.Property(e => e.WxNickname).HasMaxLength(50);
        //    });

        //    modelBuilder.Entity<Activity>(entity =>
        //    {
        //        entity.Property(e => e.Amount).HasDefaultValueSql("((0))");

        //        entity.Property(e => e.CreateTime)
        //            .HasColumnType("datetime")
        //            .HasDefaultValueSql("(getdate())");

        //        entity.Property(e => e.Description)
        //            .IsRequired()
        //            .HasMaxLength(1000);

        //        entity.Property(e => e.EndTime).HasColumnType("datetime");

        //        entity.Property(e => e.Image).HasMaxLength(200);

        //        entity.Property(e => e.Name).HasMaxLength(50);

        //        entity.Property(e => e.PrizeDetail).HasMaxLength(1000);

        //        entity.Property(e => e.ReuseCode)
        //            .HasMaxLength(20)
        //            .IsUnicode(false);

        //        entity.Property(e => e.StartTime).HasColumnType("datetime");

        //        entity.Property(e => e.Title)
        //            .IsRequired()
        //            .HasMaxLength(100);

        //        entity.Property(e => e.UsedAmount).HasDefaultValueSql("((0))");
        //    });

        //    modelBuilder.Entity<ActivityLog>(entity =>
        //    {
        //        entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");

        //        entity.Property(e => e.AccountId).HasColumnName("AccountID");

        //        entity.Property(e => e.ActivityId).HasColumnName("ActivityID");

        //        entity.Property(e => e.Createtime)
        //            .HasColumnType("datetime")
        //            .HasDefaultValueSql("(getdate())");

        //        entity.Property(e => e.UserName).HasMaxLength(100);
        //    });

        //    modelBuilder.Entity<Advertising>(entity =>
        //    {
        //        entity.Property(e => e.Id).ValueGeneratedNever();

        //        entity.Property(e => e.AdName)
        //            .IsRequired()
        //            .HasMaxLength(100);

        //        entity.Property(e => e.AdPic)
        //            .IsRequired()
        //            .HasMaxLength(200);

        //        entity.Property(e => e.BeginTime).HasColumnType("datetime");

        //        entity.Property(e => e.EndTime).HasColumnType("datetime");
        //    });

        //    modelBuilder.Entity<ApplyInvoice>(entity =>
        //    {
        //        entity.Property(e => e.ApplyTime)
        //            .HasColumnType("datetime")
        //            .HasDefaultValueSql("(getdate())");

        //        entity.Property(e => e.Area).HasMaxLength(100);

        //        entity.Property(e => e.CreateTime).HasColumnType("datetime");

        //        entity.Property(e => e.DetailsAddress).HasMaxLength(300);

        //        entity.Property(e => e.InvoiceAmount).HasColumnType("decimal(8, 2)");

        //        entity.Property(e => e.InvoiceHead).HasMaxLength(200);

        //        entity.Property(e => e.InvoiceStatus).HasDefaultValueSql("((0))");

        //        entity.Property(e => e.InvoiceType).HasDefaultValueSql("((1))");

        //        entity.Property(e => e.IsElectronic).HasDefaultValueSql("((1))");

        //        entity.Property(e => e.OrderDetail).HasMaxLength(3000);

        //        entity.Property(e => e.Phone).HasMaxLength(20);

        //        entity.Property(e => e.ReceivePeople).HasMaxLength(20);

        //        entity.Property(e => e.Remarks).HasMaxLength(500);

        //        entity.Property(e => e.TaxNumber).HasMaxLength(30);

        //        entity.HasOne(d => d.Account)
        //            .WithMany(p => p.ApplyInvoice)
        //            .HasForeignKey(d => d.AccountId)
        //            .OnDelete(DeleteBehavior.ClientSetNull)
        //            .HasConstraintName("FK_ApplyInvoice_Account");
        //    });

        //    modelBuilder.Entity<ApproveHistory>(entity =>
        //    {
        //        entity.Property(e => e.Id).ValueGeneratedNever();

        //        entity.Property(e => e.ApproveDetail)
        //            .IsRequired()
        //            .HasMaxLength(2000);

        //        entity.Property(e => e.ApproveStatus).HasDefaultValueSql("((0))");

        //        entity.Property(e => e.ApproveTime).HasColumnType("datetime");
        //    });

        //    modelBuilder.Entity<BackstageUser>(entity =>
        //    {
        //        entity.Property(e => e.CreateTime).HasColumnType("datetime");

        //        entity.Property(e => e.Email)
        //            .HasMaxLength(50)
        //            .IsUnicode(false);

        //        entity.Property(e => e.EndTime)
        //            .HasMaxLength(10)
        //            .IsUnicode(false);

        //        entity.Property(e => e.FullName).HasMaxLength(10);

        //        entity.Property(e => e.IdCard)
        //            .HasMaxLength(20)
        //            .IsUnicode(false);

        //        entity.Property(e => e.LastLoginIp)
        //            .HasColumnName("LastLoginIP")
        //            .HasMaxLength(40)
        //            .IsUnicode(false);

        //        entity.Property(e => e.LastLoginTime).HasColumnType("datetime");

        //        entity.Property(e => e.LoginName)
        //            .IsRequired()
        //            .HasMaxLength(20)
        //            .IsUnicode(false);

        //        entity.Property(e => e.Mobile)
        //            .HasMaxLength(20)
        //            .IsUnicode(false);

        //        entity.Property(e => e.OpenId).HasMaxLength(50);

        //        entity.Property(e => e.Password)
        //            .IsRequired()
        //            .HasMaxLength(40)
        //            .IsUnicode(false);

        //        entity.Property(e => e.RoleId).HasComputedColumnSql("([AccountType])");

        //        entity.Property(e => e.StartTime)
        //            .HasMaxLength(10)
        //            .IsUnicode(false);

        //        entity.Property(e => e.UpdateTime).HasColumnType("datetime");

        //        entity.HasOne(d => d.Role)
        //            .WithMany(p => p.BackstageUser)
        //            .HasForeignKey(d => d.RoleId)
        //            .OnDelete(DeleteBehavior.ClientSetNull)
        //            .HasConstraintName("FK_BackstageUser_SystemRoles");
        //    });

        //    modelBuilder.Entity<BaiduCity>(entity =>
        //    {
        //        entity.Property(e => e.CityCode)
        //            .HasMaxLength(50)
        //            .IsUnicode(false);

        //        entity.Property(e => e.Name)
        //            .IsRequired()
        //            .HasMaxLength(20)
        //            .HasDefaultValueSql("((0))");

        //        entity.Property(e => e.VinLength).HasDefaultValueSql("((0))");
        //    });

        //    modelBuilder.Entity<BespeakRecord>(entity =>
        //    {
        //        entity.Property(e => e.AccountId).HasDefaultValueSql("((0))");

        //        entity.Property(e => e.ActivityAddDay).HasDefaultValueSql("((0))");

        //        entity.Property(e => e.BespeakAddr).HasMaxLength(100);

        //        entity.Property(e => e.CarType).HasDefaultValueSql("((1))");

        //        entity.Property(e => e.CreateTime).HasColumnType("datetime");

        //        entity.Property(e => e.DailyRentalImg)
        //            .HasMaxLength(255)
        //            .IsUnicode(false);

        //        entity.Property(e => e.FailReason).HasMaxLength(100);

        //        entity.Property(e => e.InsuranceCost)
        //            .HasColumnType("decimal(10, 2)")
        //            .HasDefaultValueSql("((0))");

        //        entity.Property(e => e.Lat).HasColumnType("decimal(18, 15)");

        //        entity.Property(e => e.Lng).HasColumnType("decimal(18, 15)");

        //        entity.Property(e => e.OrderId).HasDefaultValueSql("('00000000-0000-0000-0000-000000000000')");

        //        entity.Property(e => e.ParkAddr)
        //            .HasColumnName("parkAddr")
        //            .HasMaxLength(100);

        //        entity.Property(e => e.ReletDay).HasDefaultValueSql("((0))");

        //        entity.Property(e => e.RizuActivityAddDay).HasDefaultValueSql("((0))");

        //        entity.Property(e => e.UseEndTime)
        //            .HasColumnType("datetime")
        //            .HasDefaultValueSql("('9999-12-31')");

        //        entity.Property(e => e.UsedTime).HasColumnType("datetime");

        //        entity.Property(e => e.WayType).HasDefaultValueSql("((1))");

        //        entity.Property(e => e.XuzuActivityAddDay).HasDefaultValueSql("((0))");
        //    });

        //    modelBuilder.Entity<CarAegis>(entity =>
        //    {
        //        entity.Property(e => e.Id)
        //            .HasColumnName("ID")
        //            .ValueGeneratedNever();

        //        entity.Property(e => e.BackstageUserId).HasColumnName("BackstageUserID");

        //        entity.Property(e => e.CarId).HasColumnName("CarID");

        //        entity.Property(e => e.CreateTime)
        //            .HasColumnType("datetime")
        //            .HasDefaultValueSql("(getdate())");

        //        entity.Property(e => e.Description).IsRequired();

        //        entity.Property(e => e.HandleTime).HasColumnType("datetime");

        //        entity.Property(e => e.HandleUserId).HasColumnName("HandleUserID");

        //        entity.Property(e => e.NowAddress).HasMaxLength(200);

        //        entity.Property(e => e.PicPath)
        //            .IsRequired()
        //            .HasMaxLength(200);

        //        entity.HasOne(d => d.BackstageUser)
        //            .WithMany(p => p.CarAegisBackstageUser)
        //            .HasForeignKey(d => d.BackstageUserId)
        //            .OnDelete(DeleteBehavior.ClientSetNull)
        //            .HasConstraintName("FK_CarAegis_BackstageUser");

        //        entity.HasOne(d => d.Car)
        //            .WithMany(p => p.CarAegis)
        //            .HasForeignKey(d => d.CarId)
        //            .OnDelete(DeleteBehavior.ClientSetNull)
        //            .HasConstraintName("FK_CarAegis_Cars");

        //        entity.HasOne(d => d.HandleUser)
        //            .WithMany(p => p.CarAegisHandleUser)
        //            .HasForeignKey(d => d.HandleUserId)
        //            .HasConstraintName("FK_CarAegis_BackstageUser1");
        //    });

        //    modelBuilder.Entity<CarBrand>(entity =>
        //    {
        //        entity.Property(e => e.BrandCode)
        //            .HasMaxLength(20)
        //            .IsUnicode(false);

        //        entity.Property(e => e.BrandName).HasMaxLength(50);

        //        entity.Property(e => e.CreateTime)
        //            .HasColumnType("datetime")
        //            .HasDefaultValueSql("(getdate())");
        //    });

        //    modelBuilder.Entity<CarBreakContract>(entity =>
        //    {
        //        entity.Property(e => e.Id).ValueGeneratedNever();

        //        entity.Property(e => e.BreakContractTime).HasColumnType("datetime");

        //        entity.Property(e => e.ComplainTime).HasColumnType("datetime");

        //        entity.Property(e => e.CreateTime).HasColumnType("datetime");

        //        entity.Property(e => e.CreateUserName).HasMaxLength(50);

        //        entity.Property(e => e.Location).HasMaxLength(255);

        //        entity.Property(e => e.Money).HasColumnType("decimal(10, 2)");

        //        entity.Property(e => e.Title).HasMaxLength(100);

        //        entity.Property(e => e.UpdateTime).HasColumnType("datetime");

        //        entity.Property(e => e.UpdateUserName).HasMaxLength(50);

        //        entity.HasOne(d => d.Account)
        //            .WithMany(p => p.CarBreakContract)
        //            .HasForeignKey(d => d.AccountId)
        //            .OnDelete(DeleteBehavior.ClientSetNull)
        //            .HasConstraintName("FK_CarBreakContract_Account");

        //        entity.HasOne(d => d.CarUsage)
        //            .WithMany(p => p.CarBreakContract)
        //            .HasForeignKey(d => d.CarUsageId)
        //            .OnDelete(DeleteBehavior.ClientSetNull)
        //            .HasConstraintName("FK_CarBreakContract_CarUsage");

        //        entity.HasOne(d => d.Cars)
        //            .WithMany(p => p.CarBreakContract)
        //            .HasForeignKey(d => d.CarsId)
        //            .OnDelete(DeleteBehavior.ClientSetNull)
        //            .HasConstraintName("FK_CarBreakContract_Cars");
        //    });

        //    modelBuilder.Entity<CarFaultReport>(entity =>
        //    {
        //        entity.Property(e => e.Id).ValueGeneratedNever();

        //        entity.Property(e => e.CreateTime)
        //            .HasColumnType("datetime")
        //            .HasDefaultValueSql("(getdate())");

        //        entity.Property(e => e.DealTime).HasColumnType("datetime");

        //        entity.Property(e => e.FaultReportType).HasDefaultValueSql("((0))");

        //        entity.Property(e => e.Location).HasMaxLength(150);

        //        entity.Property(e => e.ProcessResult).HasMaxLength(500);

        //        entity.Property(e => e.ReportDetail).HasMaxLength(500);

        //        entity.Property(e => e.WarningAddress).HasMaxLength(200);

        //        entity.HasOne(d => d.Account)
        //            .WithMany(p => p.CarFaultReport)
        //            .HasForeignKey(d => d.AccountId)
        //            .HasConstraintName("FK_CarFaultReport_Account");

        //        entity.HasOne(d => d.CarUsage)
        //            .WithMany(p => p.CarFaultReport)
        //            .HasForeignKey(d => d.CarUsageId)
        //            .HasConstraintName("FK_CarFaultReport_CarUsage");

        //        entity.HasOne(d => d.Cars)
        //            .WithMany(p => p.CarFaultReport)
        //            .HasForeignKey(d => d.CarsId)
        //            .OnDelete(DeleteBehavior.ClientSetNull)
        //            .HasConstraintName("FK_CarFaultReport_Cars");
        //    });

        //    modelBuilder.Entity<CarIllegal>(entity =>
        //    {
        //        entity.Property(e => e.Id).ValueGeneratedNever();

        //        entity.Property(e => e.Address).HasMaxLength(255);

        //        entity.Property(e => e.BreakRule).HasMaxLength(255);

        //        entity.Property(e => e.CreateTime).HasColumnType("datetime");

        //        entity.Property(e => e.PlateNumber)
        //            .IsRequired()
        //            .HasMaxLength(20);

        //        entity.Property(e => e.SystemTime)
        //            .HasColumnType("datetime")
        //            .HasDefaultValueSql("(getdate())");

        //        entity.Property(e => e.UpdateTime).HasColumnType("datetime");

        //        entity.HasOne(d => d.Account)
        //            .WithMany(p => p.CarIllegal)
        //            .HasForeignKey(d => d.AccountId)
        //            .HasConstraintName("FK_CarIllegal_Account");

        //        entity.HasOne(d => d.CarUsage)
        //            .WithMany(p => p.CarIllegal)
        //            .HasForeignKey(d => d.CarUsageId)
        //            .HasConstraintName("FK_CarIllegal_CarUsage");

        //        entity.HasOne(d => d.Cars)
        //            .WithMany(p => p.CarIllegal)
        //            .HasForeignKey(d => d.CarsId)
        //            .OnDelete(DeleteBehavior.ClientSetNull)
        //            .HasConstraintName("FK_CarIllegal_Cars");
        //    });

        //    modelBuilder.Entity<CarPriceRules>(entity =>
        //    {
        //        entity.HasKey(e => new { e.CityId, e.CarTypeId });

        //        entity.Property(e => e.CreateTime)
        //            .HasColumnType("datetime")
        //            .HasDefaultValueSql("(getdate())");

        //        entity.Property(e => e.PerDayCost).HasColumnType("decimal(8, 2)");

        //        entity.Property(e => e.PerKilometerCost).HasColumnType("decimal(6, 2)");

        //        entity.Property(e => e.PerKilometerNightCost).HasColumnType("decimal(6, 2)");

        //        entity.Property(e => e.PerMinutesCost).HasColumnType("decimal(6, 2)");

        //        entity.Property(e => e.PerMinutesNightCost).HasColumnType("decimal(6, 2)");

        //        entity.Property(e => e.PerMonthCost).HasColumnType("decimal(10, 2)");

        //        entity.HasOne(d => d.CarBrand)
        //            .WithMany(p => p.CarPriceRules)
        //            .HasForeignKey(d => d.CarBrandId)
        //            .HasConstraintName("FK_CarPriceRules_CarBrand");

        //        entity.HasOne(d => d.CarType)
        //            .WithMany(p => p.CarPriceRules)
        //            .HasForeignKey(d => d.CarTypeId)
        //            .OnDelete(DeleteBehavior.ClientSetNull)
        //            .HasConstraintName("FK_CarPriceRules_CarType");

        //        entity.HasOne(d => d.City)
        //            .WithMany(p => p.CarPriceRulesCity)
        //            .HasForeignKey(d => d.CityId)
        //            .OnDelete(DeleteBehavior.ClientSetNull)
        //            .HasConstraintName("FK_CarPriceRules_BaiduCity1");

        //        entity.HasOne(d => d.Province)
        //            .WithMany(p => p.CarPriceRulesProvince)
        //            .HasForeignKey(d => d.ProvinceId)
        //            .OnDelete(DeleteBehavior.ClientSetNull)
        //            .HasConstraintName("FK_CarPriceRules_BaiduCity");
        //    });

        //    modelBuilder.Entity<Cars>(entity =>
        //    {
        //        entity.HasIndex(e => e.Vin)
        //            .HasName("IX_Cars")
        //            .IsUnique();

        //        entity.Property(e => e.Id).ValueGeneratedNever();

        //        entity.Property(e => e.AnnualInspectionEndTime).HasColumnType("datetime");

        //        entity.Property(e => e.AnnualInspectionTime).HasColumnType("datetime");

        //        entity.Property(e => e.Battery).HasDefaultValueSql("((100))");

        //        entity.Property(e => e.CarCode).HasMaxLength(20);

        //        entity.Property(e => e.CarColor).HasMaxLength(20);

        //        entity.Property(e => e.CarName).HasMaxLength(200);

        //        entity.Property(e => e.CityId).HasColumnName("CityID");

        //        entity.Property(e => e.CreateTime)
        //            .HasColumnType("datetime")
        //            .HasDefaultValueSql("(getdate())");

        //        entity.Property(e => e.EngineModel).HasMaxLength(50);

        //        entity.Property(e => e.IncomeAmount)
        //            .HasColumnType("decimal(10, 2)")
        //            .HasDefaultValueSql("((0))");

        //        entity.Property(e => e.InsuranceEndTime).HasColumnType("datetime");

        //        entity.Property(e => e.InsuranceTime).HasColumnType("datetime");

        //        entity.Property(e => e.IsEnabled).HasDefaultValueSql("((1))");

        //        entity.Property(e => e.LastUsageImage)
        //            .HasMaxLength(2550)
        //            .IsUnicode(false);

        //        entity.Property(e => e.LastUsedTime)
        //            .HasColumnType("datetime")
        //            .HasDefaultValueSql("(getdate())");

        //        entity.Property(e => e.Latitude)
        //            .HasColumnType("decimal(18, 15)")
        //            .HasDefaultValueSql("((0))");

        //        entity.Property(e => e.LifeMileage)
        //            .HasColumnType("decimal(10, 2)")
        //            .HasDefaultValueSql("((0))");

        //        entity.Property(e => e.Location).HasMaxLength(150);

        //        entity.Property(e => e.Longitude)
        //            .HasColumnType("decimal(18, 15)")
        //            .HasDefaultValueSql("((0))");

        //        entity.Property(e => e.MachineType).HasDefaultValueSql("((1))");

        //        entity.Property(e => e.Mileage)
        //            .HasColumnType("decimal(7, 1)")
        //            .HasDefaultValueSql("((0))");

        //        entity.Property(e => e.PlateNumber)
        //            .IsRequired()
        //            .HasMaxLength(20);

        //        entity.Property(e => e.ProvinceId).HasColumnName("ProvinceID");

        //        entity.Property(e => e.Sn)
        //            .HasColumnName("SN")
        //            .HasMaxLength(50)
        //            .IsUnicode(false);

        //        entity.Property(e => e.UpdateTime).HasColumnType("datetime");

        //        entity.Property(e => e.UsedTimes).HasDefaultValueSql("((0))");

        //        entity.Property(e => e.Vin)
        //            .IsRequired()
        //            .HasColumnName("VIN")
        //            .HasMaxLength(30)
        //            .IsUnicode(false);

        //        entity.HasOne(d => d.CarBrand)
        //            .WithMany(p => p.Cars)
        //            .HasForeignKey(d => d.CarBrandId)
        //            .OnDelete(DeleteBehavior.ClientSetNull)
        //            .HasConstraintName("FK_Cars_CarBrand");

        //        entity.HasOne(d => d.CarType)
        //            .WithMany(p => p.Cars)
        //            .HasForeignKey(d => d.CarTypeId)
        //            .OnDelete(DeleteBehavior.ClientSetNull)
        //            .HasConstraintName("FK_Cars_CarType");

        //        entity.HasOne(d => d.City)
        //            .WithMany(p => p.CarsCity)
        //            .HasForeignKey(d => d.CityId)
        //            .OnDelete(DeleteBehavior.ClientSetNull)
        //            .HasConstraintName("FK_Cars_BaiduCity");

        //        entity.HasOne(d => d.ParkingArea)
        //            .WithMany(p => p.Cars)
        //            .HasForeignKey(d => d.ParkingAreaId)
        //            .OnDelete(DeleteBehavior.ClientSetNull)
        //            .HasConstraintName("FK_Cars_ParkingArea");

        //        entity.HasOne(d => d.Province)
        //            .WithMany(p => p.CarsProvince)
        //            .HasForeignKey(d => d.ProvinceId)
        //            .OnDelete(DeleteBehavior.ClientSetNull)
        //            .HasConstraintName("FK_Province_Cars");

        //        entity.HasOne(d => d.C)
        //            .WithMany(p => p.Cars)
        //            .HasForeignKey(d => new { d.CityId, d.CarTypeId })
        //            .OnDelete(DeleteBehavior.ClientSetNull)
        //            .HasConstraintName("FK_Cars_CarPriceRules");
        //    });

        //    modelBuilder.Entity<CarScheduling>(entity =>
        //    {
        //        entity.Property(e => e.Id)
        //            .HasColumnName("ID")
        //            .ValueGeneratedNever();

        //        entity.Property(e => e.BackstageUserId).HasColumnName("BackstageUserID");

        //        entity.Property(e => e.CarId).HasColumnName("CarID");

        //        entity.Property(e => e.CreateTime)
        //            .HasColumnType("datetime")
        //            .HasDefaultValueSql("(getdate())");

        //        entity.Property(e => e.NowAddress)
        //            .IsRequired()
        //            .HasMaxLength(200);

        //        entity.Property(e => e.SchedulingAddress)
        //            .IsRequired()
        //            .HasMaxLength(200);

        //        entity.Property(e => e.SchedulingTime).HasColumnType("datetime");

        //        entity.Property(e => e.SchedulingUserId).HasColumnName("SchedulingUserID");

        //        entity.HasOne(d => d.BackstageUser)
        //            .WithMany(p => p.CarSchedulingBackstageUser)
        //            .HasForeignKey(d => d.BackstageUserId)
        //            .OnDelete(DeleteBehavior.ClientSetNull)
        //            .HasConstraintName("FK_CarScheduling_BackstageUser");

        //        entity.HasOne(d => d.Car)
        //            .WithMany(p => p.CarScheduling)
        //            .HasForeignKey(d => d.CarId)
        //            .OnDelete(DeleteBehavior.ClientSetNull)
        //            .HasConstraintName("FK_CarScheduling_Cars");

        //        entity.HasOne(d => d.SchedulingUser)
        //            .WithMany(p => p.CarSchedulingSchedulingUser)
        //            .HasForeignKey(d => d.SchedulingUserId)
        //            .HasConstraintName("FK_CarScheduling_BackstageSchedulingUser");
        //    });

        //    modelBuilder.Entity<CarTravelTrack>(entity =>
        //    {
        //        entity.Property(e => e.Id).ValueGeneratedNever();

        //        entity.Property(e => e.BackDoor).HasMaxLength(50);

        //        entity.Property(e => e.BackDoorLocked).HasMaxLength(50);

        //        entity.Property(e => e.Charging).HasMaxLength(50);

        //        entity.Property(e => e.Compres).HasMaxLength(50);

        //        entity.Property(e => e.CreateTime).HasColumnType("datetime");

        //        entity.Property(e => e.Door).HasMaxLength(50);

        //        entity.Property(e => e.GearPos).HasMaxLength(50);

        //        entity.Property(e => e.Latitude).HasColumnType("decimal(18, 15)");

        //        entity.Property(e => e.Longitude).HasColumnType("decimal(18, 15)");

        //        entity.Property(e => e.Mileage).HasColumnType("decimal(8, 2)");

        //        entity.Property(e => e.PlateNumber).HasMaxLength(20);

        //        entity.Property(e => e.Startup).HasMaxLength(50);

        //        entity.HasOne(d => d.CarUsage)
        //            .WithMany(p => p.CarTravelTrack)
        //            .HasForeignKey(d => d.CarUsageId)
        //            .OnDelete(DeleteBehavior.ClientSetNull)
        //            .HasConstraintName("FK_CarTravelTrack_CarUsage");
        //    });

        //    modelBuilder.Entity<CarTravelTrackLogs>(entity =>
        //    {
        //        entity.Property(e => e.Id).ValueGeneratedNever();

        //        entity.Property(e => e.BackDoor).HasMaxLength(50);

        //        entity.Property(e => e.BackDoorLocked).HasMaxLength(50);

        //        entity.Property(e => e.Charging).HasMaxLength(50);

        //        entity.Property(e => e.Code).HasMaxLength(100);

        //        entity.Property(e => e.Compres).HasMaxLength(50);

        //        entity.Property(e => e.CreateTime).HasColumnType("datetime");

        //        entity.Property(e => e.Door).HasMaxLength(50);

        //        entity.Property(e => e.GearPos).HasMaxLength(50);

        //        entity.Property(e => e.Latitude).HasColumnType("decimal(18, 15)");

        //        entity.Property(e => e.LifeMileage)
        //            .HasColumnType("decimal(8, 2)")
        //            .HasDefaultValueSql("((0))");

        //        entity.Property(e => e.Longitude).HasColumnType("decimal(18, 15)");

        //        entity.Property(e => e.Message).HasMaxLength(250);

        //        entity.Property(e => e.Mileage).HasColumnType("decimal(8, 2)");

        //        entity.Property(e => e.PlateNumber).HasMaxLength(20);

        //        entity.Property(e => e.Startup).HasMaxLength(50);

        //        entity.Property(e => e.Vin)
        //            .HasMaxLength(100)
        //            .IsUnicode(false);

        //        entity.Property(e => e.Voltage)
        //            .HasColumnType("decimal(5, 2)")
        //            .HasDefaultValueSql("((0))");

        //        entity.HasOne(d => d.Cars)
        //            .WithMany(p => p.CarTravelTrackLogs)
        //            .HasForeignKey(d => d.CarsId)
        //            .OnDelete(DeleteBehavior.ClientSetNull)
        //            .HasConstraintName("FK_CarTravelTrackLogs_Cars");
        //    });

        //    modelBuilder.Entity<CarType>(entity =>
        //    {
        //        entity.Property(e => e.CarIcon).HasMaxLength(255);

        //        entity.Property(e => e.CarModel).HasMaxLength(20);

        //        entity.Property(e => e.CarName).HasMaxLength(50);

        //        entity.Property(e => e.CarPicture)
        //            .HasMaxLength(255)
        //            .IsUnicode(false);

        //        entity.Property(e => e.CreateTime)
        //            .HasColumnType("datetime")
        //            .HasDefaultValueSql("(getdate())");

        //        entity.Property(e => e.RedCarIcon).HasMaxLength(255);

        //        entity.Property(e => e.SeatStructure).HasMaxLength(20);

        //        entity.Property(e => e.ShiftType).HasMaxLength(20);

        //        entity.HasOne(d => d.Brand)
        //            .WithMany(p => p.CarType)
        //            .HasForeignKey(d => d.BrandId)
        //            .OnDelete(DeleteBehavior.ClientSetNull)
        //            .HasConstraintName("FK_CarType_CarBrand");
        //    });

        //    modelBuilder.Entity<CarUsage>(entity =>
        //    {
        //        entity.Property(e => e.Id).ValueGeneratedNever();

        //        entity.Property(e => e.BreakRulesDetail).HasMaxLength(500);

        //        entity.Property(e => e.CostDetails)
        //            .HasMaxLength(500)
        //            .IsUnicode(false);

        //        entity.Property(e => e.CreateTime).HasColumnType("datetime");

        //        entity.Property(e => e.DayCost)
        //            .HasColumnType("decimal(10, 2)")
        //            .HasDefaultValueSql("((0))");

        //        entity.Property(e => e.EndLocation).HasMaxLength(200);

        //        entity.Property(e => e.EndMileage)
        //            .HasColumnType("decimal(10, 2)")
        //            .HasDefaultValueSql("((0))");

        //        entity.Property(e => e.EndMileageFlag)
        //            .HasColumnType("decimal(10, 2)")
        //            .HasDefaultValueSql("((0))");

        //        entity.Property(e => e.EndTime).HasColumnType("datetime");

        //        entity.Property(e => e.EndTimeFlag).HasColumnType("datetime");

        //        entity.Property(e => e.ExternalPicture)
        //            .HasMaxLength(2000)
        //            .IsUnicode(false);

        //        entity.Property(e => e.InsidePicture)
        //            .HasMaxLength(2000)
        //            .IsUnicode(false);

        //        entity.Property(e => e.IsRedCarTravel).HasDefaultValueSql("((0))");

        //        entity.Property(e => e.Latitude)
        //            .HasColumnType("decimal(18, 15)")
        //            .HasDefaultValueSql("((0))");

        //        entity.Property(e => e.Longitude)
        //            .HasColumnType("decimal(18, 15)")
        //            .HasDefaultValueSql("((0))");

        //        entity.Property(e => e.Mileage)
        //            .HasColumnType("decimal(11, 2)")
        //            .HasComputedColumnSql("([EndMileage]-[StartMileage])");

        //        entity.Property(e => e.MileageCost)
        //            .HasColumnType("decimal(10, 2)")
        //            .HasDefaultValueSql("((0))");

        //        entity.Property(e => e.MinutesCost)
        //            .HasColumnType("decimal(10, 2)")
        //            .HasDefaultValueSql("((0))");

        //        entity.Property(e => e.OtherImage)
        //            .HasMaxLength(2550)
        //            .IsUnicode(false);

        //        entity.Property(e => e.ParkingStatus).HasDefaultValueSql("((0))");

        //        entity.Property(e => e.PriceRules)
        //            .HasMaxLength(500)
        //            .IsUnicode(false);

        //        entity.Property(e => e.Remark).HasMaxLength(500);

        //        entity.Property(e => e.StartLocation).HasMaxLength(200);

        //        entity.Property(e => e.StartMileage)
        //            .HasColumnType("decimal(10, 2)")
        //            .HasDefaultValueSql("((0))");

        //        entity.Property(e => e.StartTime).HasColumnType("datetime");

        //        entity.Property(e => e.TotalMinutes).HasDefaultValueSql("((0))");

        //        entity.Property(e => e.UpdateTime).HasColumnType("datetime");

        //        entity.HasOne(d => d.Account)
        //            .WithMany(p => p.CarUsage)
        //            .HasForeignKey(d => d.AccountId)
        //            .OnDelete(DeleteBehavior.ClientSetNull)
        //            .HasConstraintName("FK_CarUsage_Account");

        //        entity.HasOne(d => d.Admin)
        //            .WithMany(p => p.CarUsage)
        //            .HasForeignKey(d => d.AdminId)
        //            .HasConstraintName("FK_CarUsage_BackstageUser");

        //        entity.HasOne(d => d.Car)
        //            .WithMany(p => p.CarUsage)
        //            .HasForeignKey(d => d.CarId)
        //            .OnDelete(DeleteBehavior.ClientSetNull)
        //            .HasConstraintName("FK_CarUsage_Cars");

        //        entity.HasOne(d => d.FromParkingArea)
        //            .WithMany(p => p.CarUsageFromParkingArea)
        //            .HasForeignKey(d => d.FromParkingAreaId)
        //            .HasConstraintName("FK_CarUsage_ParkingArea");

        //        entity.HasOne(d => d.ToParkingArea)
        //            .WithMany(p => p.CarUsageToParkingArea)
        //            .HasForeignKey(d => d.ToParkingAreaId)
        //            .HasConstraintName("FK_CarUsage_ParkingArea1");
        //    });

        //    modelBuilder.Entity<CheckUser>(entity =>
        //    {
        //        entity.Property(e => e.CarType).HasMaxLength(50);

        //        entity.Property(e => e.CertTime).HasColumnType("datetime");

        //        entity.Property(e => e.CreateTime).HasColumnType("datetime");

        //        entity.Property(e => e.FileNo)
        //            .HasMaxLength(255)
        //            .IsUnicode(false);

        //        entity.Property(e => e.UpdateTime).HasColumnType("datetime");

        //        entity.Property(e => e.ValidTime).HasColumnType("datetime");
        //    });

        //    modelBuilder.Entity<City>(entity =>
        //    {
        //        entity.Property(e => e.CityName).HasMaxLength(30);
        //    });

        //    modelBuilder.Entity<CouponCode>(entity =>
        //    {
        //        entity.Property(e => e.Code)
        //            .IsRequired()
        //            .HasMaxLength(15)
        //            .IsUnicode(false);

        //        entity.Property(e => e.CreateTime)
        //            .HasColumnType("datetime")
        //            .HasDefaultValueSql("(getdate())");

        //        entity.Property(e => e.UsedTime).HasColumnType("datetime");
        //    });

        //    modelBuilder.Entity<DepositHistory>(entity =>
        //    {
        //        entity.Property(e => e.Id).ValueGeneratedNever();

        //        entity.Property(e => e.ApplyRefundTime).HasColumnType("datetime");

        //        entity.Property(e => e.CarDamageMoney)
        //            .HasColumnType("decimal(8, 2)")
        //            .HasDefaultValueSql("((0))");

        //        entity.Property(e => e.CreateTime).HasColumnType("datetime");

        //        entity.Property(e => e.DepositStatus).HasDefaultValueSql("((0))");

        //        entity.Property(e => e.IllegalMoney)
        //            .HasColumnType("decimal(8, 2)")
        //            .HasDefaultValueSql("((0))");

        //        entity.Property(e => e.PayAmount).HasColumnType("decimal(8, 2)");

        //        entity.Property(e => e.PayTime).HasColumnType("datetime");

        //        entity.Property(e => e.RefundAmount).HasColumnType("decimal(8, 2)");

        //        entity.Property(e => e.RefundRemark).HasMaxLength(1000);

        //        entity.Property(e => e.RefundTime).HasColumnType("datetime");

        //        entity.HasOne(d => d.Account)
        //            .WithMany(p => p.DepositHistory)
        //            .HasForeignKey(d => d.AccountId)
        //            .OnDelete(DeleteBehavior.ClientSetNull)
        //            .HasConstraintName("FK_DepositHistory_Account");

        //        entity.HasOne(d => d.Order)
        //            .WithMany(p => p.DepositHistory)
        //            .HasForeignKey(d => d.OrderId)
        //            .OnDelete(DeleteBehavior.ClientSetNull)
        //            .HasConstraintName("FK_DepositHistory_Orders");
        //    });

        //    modelBuilder.Entity<Feedbacks>(entity =>
        //    {
        //        entity.Property(e => e.Id).ValueGeneratedNever();

        //        entity.Property(e => e.Contents).HasMaxLength(1000);

        //        entity.Property(e => e.CreateTime).HasColumnType("datetime");

        //        entity.Property(e => e.HandlerMessage).HasMaxLength(500);

        //        entity.Property(e => e.Images).HasMaxLength(2000);

        //        entity.Property(e => e.TypeName).HasMaxLength(200);

        //        entity.Property(e => e.UpdateTime).HasColumnType("datetime");

        //        entity.HasOne(d => d.Account)
        //            .WithMany(p => p.Feedbacks)
        //            .HasForeignKey(d => d.AccountId)
        //            .HasConstraintName("FK_Feedbacks_Account");

        //        entity.HasOne(d => d.HandledUser)
        //            .WithMany(p => p.Feedbacks)
        //            .HasForeignKey(d => d.HandledUserId)
        //            .HasConstraintName("FK_Feedbacks_BackstageUser");
        //    });

        //    modelBuilder.Entity<HolidayInfo>(entity =>
        //    {
        //        entity.Property(e => e.Id).ValueGeneratedNever();

        //        entity.Property(e => e.CreateTime).HasColumnType("datetime");

        //        entity.Property(e => e.HolidayName)
        //            .IsRequired()
        //            .HasMaxLength(50);

        //        entity.Property(e => e.HolidayTime).HasColumnType("datetime");

        //        entity.Property(e => e.UpdateTime).HasColumnType("datetime");
        //    });

        //    modelBuilder.Entity<Informations>(entity =>
        //    {
        //        entity.Property(e => e.Id).ValueGeneratedNever();

        //        entity.Property(e => e.CreateTime).HasColumnType("datetime");

        //        entity.Property(e => e.Description).IsRequired();

        //        entity.Property(e => e.Picture)
        //            .HasMaxLength(255)
        //            .IsUnicode(false);

        //        entity.Property(e => e.Title)
        //            .IsRequired()
        //            .HasMaxLength(50);

        //        entity.Property(e => e.UpdateTime).HasColumnType("datetime");
        //    });

        //    modelBuilder.Entity<LotteryRecord>(entity =>
        //    {
        //        entity.Property(e => e.CreateTime).HasColumnType("datetime");
        //    });

        //    modelBuilder.Entity<MaintLog>(entity =>
        //    {
        //        entity.Property(e => e.ChargeCost).HasDefaultValueSql("((0))");

        //        entity.Property(e => e.CreateTime).HasColumnType("datetime");

        //        entity.Property(e => e.EndAddress).HasMaxLength(200);

        //        entity.Property(e => e.Handle).HasMaxLength(300);

        //        entity.Property(e => e.HandleTime).HasColumnType("datetime");

        //        entity.Property(e => e.MaintStatus).HasDefaultValueSql("((0))");

        //        entity.Property(e => e.ManAddr).HasMaxLength(200);

        //        entity.Property(e => e.MoveCost).HasDefaultValueSql("((0))");

        //        entity.Property(e => e.OpenId)
        //            .IsRequired()
        //            .HasMaxLength(50);

        //        entity.Property(e => e.PlateNumber)
        //            .IsRequired()
        //            .HasMaxLength(30);

        //        entity.Property(e => e.StartAddress)
        //            .IsRequired()
        //            .HasMaxLength(200);

        //        entity.Property(e => e.WarnId).HasDefaultValueSql("((0))");

        //        entity.Property(e => e.WashCost).HasDefaultValueSql("((0))");
        //    });

        //    modelBuilder.Entity<MaintLogFresh>(entity =>
        //    {
        //        entity.Property(e => e.Charge).IsUnicode(false);

        //        entity.Property(e => e.CheckCar).IsUnicode(false);

        //        entity.Property(e => e.CreateTime).HasColumnType("datetime");

        //        entity.Property(e => e.EndAddress).HasMaxLength(50);

        //        entity.Property(e => e.HandleAddr).HasMaxLength(200);

        //        entity.Property(e => e.HandleTime).HasColumnType("datetime");

        //        entity.Property(e => e.ManAddr).HasMaxLength(200);

        //        entity.Property(e => e.Move).IsUnicode(false);

        //        entity.Property(e => e.OpenId)
        //            .HasMaxLength(50)
        //            .IsUnicode(false);

        //        entity.Property(e => e.PlateNumber).HasMaxLength(20);

        //        entity.Property(e => e.StartAddress).HasMaxLength(50);

        //        entity.Property(e => e.Wash).IsUnicode(false);
        //    });

        //    modelBuilder.Entity<MyCard>(entity =>
        //    {
        //        entity.Property(e => e.EndTime).HasColumnType("datetime");

        //        entity.Property(e => e.PreCounts).HasDefaultValueSql("((0))");

        //        entity.Property(e => e.StartTime).HasColumnType("datetime");
        //    });

        //    modelBuilder.Entity<MyCoupon>(entity =>
        //    {
        //        entity.Property(e => e.Id).ValueGeneratedNever();

        //        entity.Property(e => e.Amount).HasColumnType("decimal(6, 2)");

        //        entity.Property(e => e.AvailableAmount).HasColumnType("decimal(6, 2)");

        //        entity.Property(e => e.CreateTime).HasColumnType("datetime");

        //        entity.Property(e => e.EndDate).HasColumnType("datetime");

        //        entity.Property(e => e.IsExpired).HasComputedColumnSql("(CONVERT([bit],case when getdate()<=[EndDate] AND getdate()>=[StartDate] then (0) else (1) end))");

        //        entity.Property(e => e.Name).HasMaxLength(20);

        //        entity.Property(e => e.StartDate).HasColumnType("datetime");

        //        entity.Property(e => e.UpdateTime).HasColumnType("datetime");
        //    });

        //    modelBuilder.Entity<MyInfo>(entity =>
        //    {
        //        entity.Property(e => e.Id).ValueGeneratedNever();

        //        entity.Property(e => e.CreateTime).HasColumnType("datetime");

        //        entity.Property(e => e.Description)
        //            .IsRequired()
        //            .HasMaxLength(500);

        //        entity.Property(e => e.InfoStatus).HasDefaultValueSql("((0))");

        //        entity.Property(e => e.InfoType).HasDefaultValueSql("((0))");

        //        entity.Property(e => e.TargetId)
        //            .HasMaxLength(50)
        //            .IsUnicode(false);

        //        entity.Property(e => e.UpdateTime).HasColumnType("datetime");
        //    });

        //    modelBuilder.Entity<NewsManagement>(entity =>
        //    {
        //        entity.Property(e => e.Id).ValueGeneratedNever();

        //        entity.Property(e => e.CreateTime).HasColumnType("datetime");

        //        entity.Property(e => e.NewsContent).IsRequired();
        //    });

        //    modelBuilder.Entity<Orders>(entity =>
        //    {
        //        entity.Property(e => e.Id).ValueGeneratedNever();

        //        entity.Property(e => e.ActualAmount).HasColumnType("decimal(8, 2)");

        //        entity.Property(e => e.AlipayId)
        //            .HasMaxLength(100)
        //            .IsUnicode(false);

        //        entity.Property(e => e.CreateTime).HasColumnType("datetime");

        //        entity.Property(e => e.InvoiceAmount)
        //            .HasColumnType("decimal(8, 2)")
        //            .HasComputedColumnSql("(case when [OrderStatus]=(1) then case [OrderType] when (1) then [PayAmount] when (21) then [ActualAmount] else (0) end else (0) end)");

        //        entity.Property(e => e.OrderCode)
        //            .HasMaxLength(40)
        //            .IsUnicode(false);

        //        entity.Property(e => e.PackageAmount).HasColumnType("decimal(8, 2)");

        //        entity.Property(e => e.PayAmount).HasColumnType("decimal(8, 2)");

        //        entity.Property(e => e.RealWalletAmount).HasColumnType("decimal(9, 3)");

        //        entity.Property(e => e.TargetId)
        //            .HasMaxLength(50)
        //            .IsUnicode(false);

        //        entity.Property(e => e.UpdateTime).HasColumnType("datetime");

        //        entity.Property(e => e.WalletAmount).HasColumnType("decimal(8, 2)");

        //        entity.HasOne(d => d.Account)
        //            .WithMany(p => p.OrdersAccount)
        //            .HasForeignKey(d => d.AccountId)
        //            .OnDelete(DeleteBehavior.ClientSetNull)
        //            .HasConstraintName("FK_Orders_Account");

        //        entity.HasOne(d => d.CarUsage)
        //            .WithMany(p => p.Orders)
        //            .HasForeignKey(d => d.CarUsageId)
        //            .HasConstraintName("FK_Orders_CarUsage");

        //        entity.HasOne(d => d.TargetAccount)
        //            .WithMany(p => p.OrdersTargetAccount)
        //            .HasForeignKey(d => d.TargetAccountId)
        //            .HasConstraintName("FK_Orders_TagetAccount");
        //    });

        //    modelBuilder.Entity<ParkingArea>(entity =>
        //    {
        //        entity.Property(e => e.BaiduMap).IsUnicode(false);

        //        entity.Property(e => e.BusinessTime).HasMaxLength(50);

        //        entity.Property(e => e.CreateTime)
        //            .HasColumnType("datetime")
        //            .HasDefaultValueSql("(getdate())");

        //        entity.Property(e => e.IsEnabled).HasDefaultValueSql("((1))");

        //        entity.Property(e => e.Latitude).HasColumnType("decimal(18, 15)");

        //        entity.Property(e => e.Location).HasMaxLength(150);

        //        entity.Property(e => e.Longitude).HasColumnType("decimal(18, 15)");

        //        entity.Property(e => e.MapRangeString).IsUnicode(false);

        //        entity.Property(e => e.Name).HasMaxLength(50);

        //        entity.Property(e => e.ParkingCost).HasMaxLength(50);

        //        entity.Property(e => e.Phone).HasMaxLength(20);

        //        entity.Property(e => e.ProvinceId).HasColumnName("ProvinceID");

        //        entity.HasOne(d => d.City)
        //            .WithMany(p => p.ParkingAreaCity)
        //            .HasForeignKey(d => d.CityId)
        //            .OnDelete(DeleteBehavior.ClientSetNull)
        //            .HasConstraintName("FK_ParkingArea_BaiduCity");

        //        entity.HasOne(d => d.Province)
        //            .WithMany(p => p.ParkingAreaProvince)
        //            .HasForeignKey(d => d.ProvinceId)
        //            .HasConstraintName("FK_ParkingArea_BaiduCity1");
        //    });

        //    modelBuilder.Entity<ParkingSpaces>(entity =>
        //    {
        //        entity.Property(e => e.Id).ValueGeneratedNever();

        //        entity.Property(e => e.Latitude).HasMaxLength(100);

        //        entity.Property(e => e.Location).HasMaxLength(1000);

        //        entity.Property(e => e.Longitude).HasMaxLength(100);

        //        entity.Property(e => e.PlateNumber).HasMaxLength(20);

        //        entity.Property(e => e.ProvinceId).HasColumnName("ProvinceID");

        //        entity.Property(e => e.SpaceNumber).HasMaxLength(50);

        //        entity.Property(e => e.SpacesName).HasMaxLength(100);

        //        entity.HasOne(d => d.City)
        //            .WithMany(p => p.ParkingSpacesCity)
        //            .HasForeignKey(d => d.CityId)
        //            .HasConstraintName("FK_ParkingSpaces_BaiduCity");

        //        entity.HasOne(d => d.ParkingArea)
        //            .WithMany(p => p.ParkingSpaces)
        //            .HasForeignKey(d => d.ParkingAreaId)
        //            .HasConstraintName("FK_ParkingSpaces_ParkingArea");

        //        entity.HasOne(d => d.Province)
        //            .WithMany(p => p.ParkingSpacesProvince)
        //            .HasForeignKey(d => d.ProvinceId)
        //            .HasConstraintName("FK_ParkingSpaces_BaiduCity1");
        //    });

        //    modelBuilder.Entity<PreWarn>(entity =>
        //    {
        //        entity.Property(e => e.CreateTime).HasColumnType("datetime");

        //        entity.Property(e => e.EndTime).HasColumnType("datetime");

        //        entity.Property(e => e.HandleStatus).HasDefaultValueSql("((0))");

        //        entity.Property(e => e.Latitude).HasColumnType("decimal(18, 15)");

        //        entity.Property(e => e.Longitude).HasColumnType("decimal(18, 15)");

        //        entity.Property(e => e.OpenId).HasMaxLength(50);

        //        entity.Property(e => e.PlateNumber).HasMaxLength(20);

        //        entity.Property(e => e.Sn)
        //            .HasColumnName("SN")
        //            .HasMaxLength(50)
        //            .IsUnicode(false);
        //    });

        //    modelBuilder.Entity<Prize>(entity =>
        //    {
        //        entity.Property(e => e.CreateTime).HasColumnType("datetime");

        //        entity.Property(e => e.PrizeMoney).HasColumnType("decimal(8, 2)");

        //        entity.Property(e => e.PrizeName).HasMaxLength(50);
        //    });

        //    modelBuilder.Entity<Region>(entity =>
        //    {
        //        entity.Property(e => e.RegionName).HasMaxLength(30);
        //    });

        //    modelBuilder.Entity<SettingInfo>(entity =>
        //    {
        //        entity.Property(e => e.KeyName)
        //            .IsRequired()
        //            .HasMaxLength(50);

        //        entity.Property(e => e.ValueName)
        //            .IsRequired()
        //            .HasMaxLength(50);
        //    });

        //    modelBuilder.Entity<SystemActions>(entity =>
        //    {
        //        entity.HasKey(e => e.ActionId);

        //        entity.Property(e => e.ActionId).ValueGeneratedNever();

        //        entity.Property(e => e.ActionDescription)
        //            .IsRequired()
        //            .HasMaxLength(100);

        //        entity.Property(e => e.ActionName)
        //            .IsRequired()
        //            .HasMaxLength(300)
        //            .IsUnicode(false);

        //        entity.Property(e => e.CreateTime).HasColumnType("datetime");

        //        entity.Property(e => e.Url)
        //            .IsRequired()
        //            .HasMaxLength(200)
        //            .IsUnicode(false);
        //    });

        //    modelBuilder.Entity<SystemLogsApi>(entity =>
        //    {
        //        entity.ToTable("SystemLogs_Api");

        //        entity.Property(e => e.ApiName).HasMaxLength(80);

        //        entity.Property(e => e.CreateTime).HasColumnType("datetime");

        //        entity.Property(e => e.Ip)
        //            .HasColumnName("IP")
        //            .HasMaxLength(40)
        //            .IsUnicode(false);

        //        entity.Property(e => e.Method)
        //            .HasMaxLength(10)
        //            .IsUnicode(false);

        //        entity.Property(e => e.Source).HasMaxLength(50);

        //        entity.Property(e => e.Url).HasMaxLength(100);

        //        entity.Property(e => e.UserAgent)
        //            .HasMaxLength(500)
        //            .IsUnicode(false);
        //    });

        //    modelBuilder.Entity<SystemLogsSms>(entity =>
        //    {
        //        entity.ToTable("SystemLogs_Sms");

        //        entity.Property(e => e.Code)
        //            .HasMaxLength(6)
        //            .IsUnicode(false);

        //        entity.Property(e => e.Contents).HasMaxLength(100);

        //        entity.Property(e => e.CreateTime).HasColumnType("datetime");

        //        entity.Property(e => e.Ip)
        //            .HasColumnName("IP")
        //            .HasMaxLength(20)
        //            .IsUnicode(false);

        //        entity.Property(e => e.Mobile)
        //            .HasMaxLength(12)
        //            .IsUnicode(false);
        //    });

        //    modelBuilder.Entity<SystemRolePermission>(entity =>
        //    {
        //        entity.HasKey(e => new { e.RoleId, e.ActionId });

        //        entity.Property(e => e.CreateTime).HasColumnType("datetime");
        //    });

        //    modelBuilder.Entity<SystemRoles>(entity =>
        //    {
        //        entity.Property(e => e.Id).ValueGeneratedNever();

        //        entity.Property(e => e.Name)
        //            .IsRequired()
        //            .HasMaxLength(50);
        //    });

        //    modelBuilder.Entity<SystemSettings>(entity =>
        //    {
        //        entity.HasIndex(e => e.Name)
        //            .IsUnique();

        //        entity.Property(e => e.Id).ValueGeneratedNever();

        //        entity.Property(e => e.CreateTime).HasColumnType("datetime");

        //        entity.Property(e => e.Name)
        //            .IsRequired()
        //            .HasMaxLength(30);

        //        entity.Property(e => e.UpdateTime).HasColumnType("datetime");

        //        entity.Property(e => e.Value).IsRequired();
        //    });

        //    modelBuilder.Entity<ZhimaHistory>(entity =>
        //    {
        //        entity.Property(e => e.Id).ValueGeneratedNever();

        //        entity.Property(e => e.BizNo)
        //            .IsRequired()
        //            .HasMaxLength(50);

        //        entity.Property(e => e.CreateTime).HasColumnType("datetime");

        //        entity.Property(e => e.UpdateTime).HasColumnType("datetime");
        //    });
        }
    }
}
