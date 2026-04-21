using System;
using System.Collections.Generic;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence;

public partial class GigbridgeDbContext : DbContext
{
    public GigbridgeDbContext(DbContextOptions<GigbridgeDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AdminAuditLog> AdminAuditLogs { get; set; }

    public virtual DbSet<AiconversationSession> AiconversationSessions { get; set; }

    public virtual DbSet<AiinterviewQuestion> AiinterviewQuestions { get; set; }

    public virtual DbSet<AiinterviewSession> AiinterviewSessions { get; set; }

    public virtual DbSet<Aimessage> Aimessages { get; set; }

    public virtual DbSet<AuditLogEntry> AuditLogEntries { get; set; }

    public virtual DbSet<Bucket> Buckets { get; set; }

    public virtual DbSet<BucketsAnalytic> BucketsAnalytics { get; set; }

    public virtual DbSet<BucketsVector> BucketsVectors { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Certification> Certifications { get; set; }

    public virtual DbSet<ClientProfile> ClientProfiles { get; set; }

    public virtual DbSet<Contract> Contracts { get; set; }

    public virtual DbSet<Conversation> Conversations { get; set; }

    public virtual DbSet<CustomOauthProvider> CustomOauthProviders { get; set; }

    public virtual DbSet<Dispute> Disputes { get; set; }

    public virtual DbSet<DisputeEvidence> DisputeEvidences { get; set; }

    public virtual DbSet<DisputeMessage> DisputeMessages { get; set; }

    public virtual DbSet<Education> Educations { get; set; }

    public virtual DbSet<EsignAuditTrail> EsignAuditTrails { get; set; }

    public virtual DbSet<EsignDocument> EsignDocuments { get; set; }

    public virtual DbSet<EsignSignature> EsignSignatures { get; set; }

    public virtual DbSet<EsignTemplate> EsignTemplates { get; set; }

    public virtual DbSet<Faq> Faqs { get; set; }

    public virtual DbSet<Faqcategory> Faqcategories { get; set; }

    public virtual DbSet<FlowState> FlowStates { get; set; }

    public virtual DbSet<FreelancerProfile> FreelancerProfiles { get; set; }

    public virtual DbSet<FreelancerSkill> FreelancerSkills { get; set; }

    public virtual DbSet<Identity> Identities { get; set; }

    public virtual DbSet<Instance> Instances { get; set; }

    public virtual DbSet<JobPost> JobPosts { get; set; }

    public virtual DbSet<JobPostAttachment> JobPostAttachments { get; set; }

    public virtual DbSet<JobPostSkill> JobPostSkills { get; set; }

    public virtual DbSet<Message> Messages { get; set; }

    public virtual DbSet<MessageAttachment> MessageAttachments { get; set; }

    public virtual DbSet<MfaAmrClaim> MfaAmrClaims { get; set; }

    public virtual DbSet<MfaChallenge> MfaChallenges { get; set; }

    public virtual DbSet<MfaFactor> MfaFactors { get; set; }

    public virtual DbSet<Migration> Migrations { get; set; }

    public virtual DbSet<Milestone> Milestones { get; set; }

    public virtual DbSet<MilestoneAttachment> MilestoneAttachments { get; set; }

    public virtual DbSet<Notification> Notifications { get; set; }

    public virtual DbSet<OauthAuthorization> OauthAuthorizations { get; set; }

    public virtual DbSet<OauthClient> OauthClients { get; set; }

    public virtual DbSet<OauthClientState> OauthClientStates { get; set; }

    public virtual DbSet<OauthConsent> OauthConsents { get; set; }

    public virtual DbSet<Object> Objects { get; set; }

    public virtual DbSet<OneTimeToken> OneTimeTokens { get; set; }

    public virtual DbSet<PaymentProof> PaymentProofs { get; set; }

    public virtual DbSet<PlatformSetting> PlatformSettings { get; set; }

    public virtual DbSet<PortfolioItem> PortfolioItems { get; set; }

    public virtual DbSet<Proposal> Proposals { get; set; }

    public virtual DbSet<ProposalAttachment> ProposalAttachments { get; set; }

    public virtual DbSet<RefreshToken> RefreshTokens { get; set; }

    public virtual DbSet<RefreshToken1> RefreshTokens1 { get; set; }

    public virtual DbSet<Report> Reports { get; set; }

    public virtual DbSet<Review> Reviews { get; set; }

    public virtual DbSet<S3MultipartUpload> S3MultipartUploads { get; set; }

    public virtual DbSet<S3MultipartUploadsPart> S3MultipartUploadsParts { get; set; }

    public virtual DbSet<SamlProvider> SamlProviders { get; set; }

    public virtual DbSet<SamlRelayState> SamlRelayStates { get; set; }

    public virtual DbSet<SavedFreelancer> SavedFreelancers { get; set; }

    public virtual DbSet<SavedJob> SavedJobs { get; set; }

    public virtual DbSet<SchemaMigration> SchemaMigrations { get; set; }

    public virtual DbSet<SchemaMigration1> SchemaMigrations1 { get; set; }

    public virtual DbSet<Session> Sessions { get; set; }

    public virtual DbSet<Skill> Skills { get; set; }

    public virtual DbSet<SsoDomain> SsoDomains { get; set; }

    public virtual DbSet<SsoProvider> SsoProviders { get; set; }

    public virtual DbSet<Subscription> Subscriptions { get; set; }

    public virtual DbSet<Subscription1> Subscriptions1 { get; set; }

    public virtual DbSet<SubscriptionPlan> SubscriptionPlans { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<User1> Users1 { get; set; }

    public virtual DbSet<VectorIndex> VectorIndexes { get; set; }

    public virtual DbSet<WebauthnChallenge> WebauthnChallenges { get; set; }

    public virtual DbSet<WebauthnCredential> WebauthnCredentials { get; set; }

    public virtual DbSet<WorkExperience> WorkExperiences { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .HasPostgresEnum("auth", "aal_level", new[] { "aal1", "aal2", "aal3" })
            .HasPostgresEnum("auth", "code_challenge_method", new[] { "s256", "plain" })
            .HasPostgresEnum("auth", "factor_status", new[] { "unverified", "verified" })
            .HasPostgresEnum("auth", "factor_type", new[] { "totp", "webauthn", "phone" })
            .HasPostgresEnum("auth", "oauth_authorization_status", new[] { "pending", "approved", "denied", "expired" })
            .HasPostgresEnum("auth", "oauth_client_type", new[] { "public", "confidential" })
            .HasPostgresEnum("auth", "oauth_registration_type", new[] { "dynamic", "manual" })
            .HasPostgresEnum("auth", "oauth_response_type", new[] { "code" })
            .HasPostgresEnum("auth", "one_time_token_type", new[] { "confirmation_token", "reauthentication_token", "recovery_token", "email_change_token_new", "email_change_token_current", "phone_change_token" })
            .HasPostgresEnum("realtime", "action", new[] { "INSERT", "UPDATE", "DELETE", "TRUNCATE", "ERROR" })
            .HasPostgresEnum("realtime", "equality_op", new[] { "eq", "neq", "lt", "lte", "gt", "gte", "in" })
            .HasPostgresEnum("storage", "buckettype", new[] { "STANDARD", "ANALYTICS", "VECTOR" })
            .HasPostgresExtension("extensions", "pg_stat_statements")
            .HasPostgresExtension("extensions", "pgcrypto")
            .HasPostgresExtension("extensions", "uuid-ossp")
            .HasPostgresExtension("graphql", "pg_graphql")
            .HasPostgresExtension("vault", "supabase_vault");

        modelBuilder.Entity<AdminAuditLog>(entity =>
        {
            entity.HasKey(e => e.AalAdminAuditLogsId).HasName("AdminAuditLogs_pkey");

            entity.HasIndex(e => e.Action, "IX_AdminAuditLogs_Action");

            entity.HasIndex(e => e.UsrAdminId, "IX_AdminAuditLogs_AdminId");

            entity.HasIndex(e => e.CreatedAt, "IX_AdminAuditLogs_CreatedAt");

            entity.HasIndex(e => new { e.EntityId, e.EntityType }, "IX_AdminAuditLogs_EntityId_EntityType");

            entity.Property(e => e.AalAdminAuditLogsId)
                .HasDefaultValueSql("gen_random_uuid()")
                .HasColumnName("aal_AdminAuditLogsId");
            entity.Property(e => e.Action).HasMaxLength(100);
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("now()");
            entity.Property(e => e.EntityType).HasMaxLength(50);
            entity.Property(e => e.IpAddress).HasMaxLength(45);
            entity.Property(e => e.NewValues).HasColumnType("jsonb");
            entity.Property(e => e.OldValues).HasColumnType("jsonb");
            entity.Property(e => e.UsrAdminId).HasColumnName("usr_AdminId");

            entity.HasOne(d => d.UsrAdmin).WithMany(p => p.AdminAuditLogs)
                .HasForeignKey(d => d.UsrAdminId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("AdminAuditLogs_usr_AdminId_fkey");
        });

        modelBuilder.Entity<AiconversationSession>(entity =>
        {
            entity.HasKey(e => e.AiSessAiconversationSessionsId).HasName("AIConversationSessions_pkey");

            entity.ToTable("AIConversationSessions");

            entity.HasIndex(e => e.ContContractsId, "IX_AIConversationSessions_ContractsId");

            entity.HasIndex(e => e.Type, "IX_AIConversationSessions_Type");

            entity.HasIndex(e => e.UsrUserId, "IX_AIConversationSessions_UserId");

            entity.HasIndex(e => new { e.UsrUserId, e.Type }, "IX_AIConversationSessions_UserId_Type");

            entity.Property(e => e.AiSessAiconversationSessionsId)
                .HasDefaultValueSql("gen_random_uuid()")
                .HasColumnName("aiSess_AIConversationSessionsId");
            entity.Property(e => e.ContContractsId).HasColumnName("cont_ContractsId");
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("now()");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.JpJobPostsId).HasColumnName("jp_JobPostsId");
            entity.Property(e => e.ModelUsed).HasMaxLength(100);
            entity.Property(e => e.Title).HasMaxLength(300);
            entity.Property(e => e.TotalTokensUsed).HasDefaultValue(0);
            entity.Property(e => e.Type).HasComment("Enum AISessionType: 0=WorkAssistant, 1=ProfileOptimizer, 2=JobPostGenerator, 3=ProposalGenerator");
            entity.Property(e => e.UsrUserId).HasColumnName("usr_UserId");

            entity.HasOne(d => d.ContContracts).WithMany(p => p.AiconversationSessions)
                .HasForeignKey(d => d.ContContractsId)
                .HasConstraintName("AIConversationSessions_cont_ContractsId_fkey");

            entity.HasOne(d => d.JpJobPosts).WithMany(p => p.AiconversationSessions)
                .HasForeignKey(d => d.JpJobPostsId)
                .HasConstraintName("AIConversationSessions_jp_JobPostsId_fkey");

            entity.HasOne(d => d.UsrUser).WithMany(p => p.AiconversationSessions)
                .HasForeignKey(d => d.UsrUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("AIConversationSessions_usr_UserId_fkey");
        });

        modelBuilder.Entity<AiinterviewQuestion>(entity =>
        {
            entity.HasKey(e => e.AiQAiinterviewQuestionsId).HasName("AIInterviewQuestions_pkey");

            entity.ToTable("AIInterviewQuestions");

            entity.HasIndex(e => new { e.AiIntvAiinterviewSessionsId, e.SortOrder }, "IX_AIInterviewQuestions_SessionId_SortOrder");

            entity.Property(e => e.AiQAiinterviewQuestionsId)
                .HasDefaultValueSql("gen_random_uuid()")
                .HasColumnName("aiQ_AIInterviewQuestionsId");
            entity.Property(e => e.AiIntvAiinterviewSessionsId).HasColumnName("aiIntv_AIInterviewSessionsId");
            entity.Property(e => e.Aianalysis).HasColumnName("AIAnalysis");
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("now()");
            entity.Property(e => e.Score).HasPrecision(5, 2);
            entity.Property(e => e.SortOrder).HasDefaultValue(0);

            entity.HasOne(d => d.AiIntvAiinterviewSessions).WithMany(p => p.AiinterviewQuestions)
                .HasForeignKey(d => d.AiIntvAiinterviewSessionsId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("AIInterviewQuestions_aiIntv_AIInterviewSessionsId_fkey");
        });

        modelBuilder.Entity<AiinterviewSession>(entity =>
        {
            entity.HasKey(e => e.AiIntvAiinterviewSessionsId).HasName("AIInterviewSessions_pkey");

            entity.ToTable("AIInterviewSessions");

            entity.HasIndex(e => new { e.JpJobPostsId, e.FlProFreelancerProfilesId }, "AIInterviewSessions_jp_JobPostsId_flPro_FreelancerProfilesI_key").IsUnique();

            entity.HasIndex(e => e.FlProFreelancerProfilesId, "IX_AIInterviewSessions_FreelancerProfilesId");

            entity.HasIndex(e => e.JpJobPostsId, "IX_AIInterviewSessions_JobPostsId");

            entity.HasIndex(e => e.Status, "IX_AIInterviewSessions_Status");

            entity.Property(e => e.AiIntvAiinterviewSessionsId)
                .HasDefaultValueSql("gen_random_uuid()")
                .HasColumnName("aiIntv_AIInterviewSessionsId");
            entity.Property(e => e.Aifeedback).HasColumnName("AIFeedback");
            entity.Property(e => e.ClProClientProfilesId).HasColumnName("clPro_ClientProfilesId");
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("now()");
            entity.Property(e => e.FlProFreelancerProfilesId).HasColumnName("flPro_FreelancerProfilesId");
            entity.Property(e => e.JpJobPostsId).HasColumnName("jp_JobPostsId");
            entity.Property(e => e.OverallScore).HasPrecision(5, 2);
            entity.Property(e => e.PropoProposalsId).HasColumnName("propo_ProposalsId");
            entity.Property(e => e.Status).HasComment("Enum InterviewStatus: 0=Pending, 1=InProgress, 2=Completed, 3=Cancelled");

            entity.HasOne(d => d.ClProClientProfiles).WithMany(p => p.AiinterviewSessions)
                .HasForeignKey(d => d.ClProClientProfilesId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("AIInterviewSessions_clPro_ClientProfilesId_fkey");

            entity.HasOne(d => d.FlProFreelancerProfiles).WithMany(p => p.AiinterviewSessions)
                .HasForeignKey(d => d.FlProFreelancerProfilesId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("AIInterviewSessions_flPro_FreelancerProfilesId_fkey");

            entity.HasOne(d => d.JpJobPosts).WithMany(p => p.AiinterviewSessions)
                .HasForeignKey(d => d.JpJobPostsId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("AIInterviewSessions_jp_JobPostsId_fkey");

            entity.HasOne(d => d.PropoProposals).WithMany(p => p.AiinterviewSessions)
                .HasForeignKey(d => d.PropoProposalsId)
                .HasConstraintName("AIInterviewSessions_propo_ProposalsId_fkey");
        });

        modelBuilder.Entity<Aimessage>(entity =>
        {
            entity.HasKey(e => e.AiMsgAimessagesId).HasName("AIMessages_pkey");

            entity.ToTable("AIMessages");

            entity.HasIndex(e => new { e.AiSessAiconversationSessionsId, e.SortOrder }, "IX_AIMessages_SessionId_SortOrder");

            entity.Property(e => e.AiMsgAimessagesId)
                .HasDefaultValueSql("gen_random_uuid()")
                .HasColumnName("aiMsg_AIMessagesId");
            entity.Property(e => e.AiSessAiconversationSessionsId).HasColumnName("aiSess_AIConversationSessionsId");
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("now()");
            entity.Property(e => e.Role).HasMaxLength(20);
            entity.Property(e => e.SortOrder).HasDefaultValue(0);
            entity.Property(e => e.TokensUsed).HasDefaultValue(0);

            entity.HasOne(d => d.AiSessAiconversationSessions).WithMany(p => p.Aimessages)
                .HasForeignKey(d => d.AiSessAiconversationSessionsId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("AIMessages_aiSess_AIConversationSessionsId_fkey");
        });

        modelBuilder.Entity<AuditLogEntry>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("audit_log_entries_pkey");

            entity.ToTable("audit_log_entries", "auth", tb => tb.HasComment("Auth: Audit trail for user actions."));

            entity.HasIndex(e => e.InstanceId, "audit_logs_instance_id_idx");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.InstanceId).HasColumnName("instance_id");
            entity.Property(e => e.IpAddress)
                .HasMaxLength(64)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("ip_address");
            entity.Property(e => e.Payload)
                .HasColumnType("json")
                .HasColumnName("payload");
        });

        modelBuilder.Entity<Bucket>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("buckets_pkey");

            entity.ToTable("buckets", "storage");

            entity.HasIndex(e => e.Name, "bname").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AllowedMimeTypes).HasColumnName("allowed_mime_types");
            entity.Property(e => e.AvifAutodetection)
                .HasDefaultValue(false)
                .HasColumnName("avif_autodetection");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.FileSizeLimit).HasColumnName("file_size_limit");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Owner)
                .HasComment("Field is deprecated, use owner_id instead")
                .HasColumnName("owner");
            entity.Property(e => e.OwnerId).HasColumnName("owner_id");
            entity.Property(e => e.Public)
                .HasDefaultValue(false)
                .HasColumnName("public");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<BucketsAnalytic>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("buckets_analytics_pkey");

            entity.ToTable("buckets_analytics", "storage");

            entity.HasIndex(e => e.Name, "buckets_analytics_unique_name_idx")
                .IsUnique()
                .HasFilter("(deleted_at IS NULL)");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("gen_random_uuid()")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");
            entity.Property(e => e.Format)
                .HasDefaultValueSql("'ICEBERG'::text")
                .HasColumnName("format");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<BucketsVector>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("buckets_vectors_pkey");

            entity.ToTable("buckets_vectors", "storage");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.CateCategoriesId).HasName("Categories_pkey");

            entity.HasIndex(e => e.IsActive, "IX_Categories_IsActive");

            entity.HasIndex(e => e.ParentCategoryId, "IX_Categories_ParentCategoryId");

            entity.HasIndex(e => e.Slug, "IX_Categories_Slug").IsUnique();

            entity.Property(e => e.CateCategoriesId)
                .HasDefaultValueSql("gen_random_uuid()")
                .HasColumnName("cate_CategoriesId");
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("now()");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.NameVi).HasMaxLength(200);
            entity.Property(e => e.Slug).HasMaxLength(200);
            entity.Property(e => e.SortOrder).HasDefaultValue(0);

            entity.HasOne(d => d.ParentCategory).WithMany(p => p.InverseParentCategory)
                .HasForeignKey(d => d.ParentCategoryId)
                .HasConstraintName("Categories_ParentCategoryId_fkey");
        });

        modelBuilder.Entity<Certification>(entity =>
        {
            entity.HasKey(e => e.CerCertificationsId).HasName("Certifications_pkey");

            entity.HasIndex(e => e.FlFreelancerId, "IX_Certifications_FreelancerId");

            entity.Property(e => e.CerCertificationsId)
                .HasDefaultValueSql("gen_random_uuid()")
                .HasColumnName("cer_CertificationsId");
            entity.Property(e => e.FlFreelancerId).HasColumnName("fl_FreelancerId");
            entity.Property(e => e.IssuingOrganization).HasMaxLength(300);
            entity.Property(e => e.Name).HasMaxLength(300);

            entity.HasOne(d => d.FlFreelancer).WithMany(p => p.Certifications)
                .HasForeignKey(d => d.FlFreelancerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Certifications_fl_FreelancerId_fkey");
        });

        modelBuilder.Entity<ClientProfile>(entity =>
        {
            entity.HasKey(e => e.ClProClientProfilesId).HasName("ClientProfiles_pkey");

            entity.HasIndex(e => e.UsrUserId, "ClientProfiles_usr_UserId_key").IsUnique();

            entity.HasIndex(e => e.UsrUserId, "IX_ClientProfiles_UserId").IsUnique();

            entity.Property(e => e.ClProClientProfilesId)
                .HasDefaultValueSql("gen_random_uuid()")
                .HasColumnName("clPro_ClientProfilesId");
            entity.Property(e => e.CompanyName).HasMaxLength(300);
            entity.Property(e => e.CompanySize).HasComment("Enum CompanySize: 0=Solo, 1=Small, 2=Medium, 3=Large");
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("now()");
            entity.Property(e => e.Industry).HasMaxLength(200);
            entity.Property(e => e.Location).HasMaxLength(300);
            entity.Property(e => e.UsrUserId).HasColumnName("usr_UserId");

            entity.HasOne(d => d.UsrUser).WithOne(p => p.ClientProfile)
                .HasForeignKey<ClientProfile>(d => d.UsrUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ClientProfiles_usr_UserId_fkey");
        });

        modelBuilder.Entity<Contract>(entity =>
        {
            entity.HasKey(e => e.ContContractsId).HasName("Contracts_pkey");

            entity.HasIndex(e => e.PropoProposalsId, "Contracts_propo_ProposalsId_key").IsUnique();

            entity.HasIndex(e => e.ClProClientProfilesId, "IX_Contracts_ClientProfilesId");

            entity.HasIndex(e => new { e.ClProClientProfilesId, e.Status }, "IX_Contracts_ClientProfilesId_Status");

            entity.HasIndex(e => e.FlProFreelancerProfilesId, "IX_Contracts_FreelancerProfilesId");

            entity.HasIndex(e => new { e.FlProFreelancerProfilesId, e.Status }, "IX_Contracts_FreelancerProfilesId_Status");

            entity.HasIndex(e => e.JpJobPostsId, "IX_Contracts_JobPostsId");

            entity.HasIndex(e => e.Status, "IX_Contracts_Status");

            entity.Property(e => e.ContContractsId)
                .HasDefaultValueSql("gen_random_uuid()")
                .HasColumnName("cont_ContractsId");
            entity.Property(e => e.ClProClientProfilesId).HasColumnName("clPro_ClientProfilesId");
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("now()");
            entity.Property(e => e.EsignContractPdfUrl)
                .HasComment("v1.2: URL bản hợp đồng lao động e-sign PDF khi có tranh chấp thanh toán")
                .HasColumnName("ESignContractPdfUrl");
            entity.Property(e => e.FlProFreelancerProfilesId).HasColumnName("flPro_FreelancerProfilesId");
            entity.Property(e => e.JpJobPostsId).HasColumnName("jp_JobPostsId");
            entity.Property(e => e.PaymentType).HasComment("Enum PaymentType: 0=Fixed, 1=Hourly");
            entity.Property(e => e.PropoProposalsId).HasColumnName("propo_ProposalsId");
            entity.Property(e => e.Status).HasComment("Enum ContractStatus: 0=Active, 1=Completed, 2=Cancelled, 3=Disputed");
            entity.Property(e => e.Title).HasMaxLength(500);
            entity.Property(e => e.TotalBudget).HasPrecision(18, 2);

            entity.HasOne(d => d.ClProClientProfiles).WithMany(p => p.Contracts)
                .HasForeignKey(d => d.ClProClientProfilesId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Contracts_clPro_ClientProfilesId_fkey");

            entity.HasOne(d => d.FlProFreelancerProfiles).WithMany(p => p.Contracts)
                .HasForeignKey(d => d.FlProFreelancerProfilesId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Contracts_flPro_FreelancerProfilesId_fkey");

            entity.HasOne(d => d.JpJobPosts).WithMany(p => p.Contracts)
                .HasForeignKey(d => d.JpJobPostsId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Contracts_jp_JobPostsId_fkey");

            entity.HasOne(d => d.PropoProposals).WithOne(p => p.Contract)
                .HasForeignKey<Contract>(d => d.PropoProposalsId)
                .HasConstraintName("Contracts_propo_ProposalsId_fkey");
        });

        modelBuilder.Entity<Conversation>(entity =>
        {
            entity.HasKey(e => e.ConvConversationsId).HasName("Conversations_pkey");

            entity.HasIndex(e => new { e.UsrUser1Id, e.UsrUser2Id, e.ContContractsId }, "Conversations_usr_User1Id_usr_User2Id_cont_ContractsId_key").IsUnique();

            entity.HasIndex(e => e.ContContractsId, "IX_Conversations_ContractsId");

            entity.HasIndex(e => e.LastMessageAt, "IX_Conversations_LastMessageAt").IsDescending();

            entity.HasIndex(e => e.UsrUser1Id, "IX_Conversations_User1Id");

            entity.HasIndex(e => e.UsrUser2Id, "IX_Conversations_User2Id");

            entity.Property(e => e.ConvConversationsId)
                .HasDefaultValueSql("gen_random_uuid()")
                .HasColumnName("conv_ConversationsId");
            entity.Property(e => e.ContContractsId).HasColumnName("cont_ContractsId");
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("now()");
            entity.Property(e => e.Type)
                .HasDefaultValue(0)
                .HasComment("Enum ConversationType: 0=DirectMessage, 1=ContractChat");
            entity.Property(e => e.UsrUser1Id).HasColumnName("usr_User1Id");
            entity.Property(e => e.UsrUser2Id).HasColumnName("usr_User2Id");

            entity.HasOne(d => d.ContContracts).WithMany(p => p.Conversations)
                .HasForeignKey(d => d.ContContractsId)
                .HasConstraintName("Conversations_cont_ContractsId_fkey");

            entity.HasOne(d => d.UsrUser1).WithMany(p => p.ConversationUsrUser1s)
                .HasForeignKey(d => d.UsrUser1Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Conversations_usr_User1Id_fkey");

            entity.HasOne(d => d.UsrUser2).WithMany(p => p.ConversationUsrUser2s)
                .HasForeignKey(d => d.UsrUser2Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Conversations_usr_User2Id_fkey");
        });

        modelBuilder.Entity<CustomOauthProvider>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("custom_oauth_providers_pkey");

            entity.ToTable("custom_oauth_providers", "auth");

            entity.HasIndex(e => e.CreatedAt, "custom_oauth_providers_created_at_idx");

            entity.HasIndex(e => e.Enabled, "custom_oauth_providers_enabled_idx");

            entity.HasIndex(e => e.Identifier, "custom_oauth_providers_identifier_idx");

            entity.HasIndex(e => e.Identifier, "custom_oauth_providers_identifier_key").IsUnique();

            entity.HasIndex(e => e.ProviderType, "custom_oauth_providers_provider_type_idx");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("gen_random_uuid()")
                .HasColumnName("id");
            entity.Property(e => e.AcceptableClientIds)
                .HasDefaultValueSql("'{}'::text[]")
                .HasColumnName("acceptable_client_ids");
            entity.Property(e => e.AttributeMapping)
                .HasDefaultValueSql("'{}'::jsonb")
                .HasColumnType("jsonb")
                .HasColumnName("attribute_mapping");
            entity.Property(e => e.AuthorizationParams)
                .HasDefaultValueSql("'{}'::jsonb")
                .HasColumnType("jsonb")
                .HasColumnName("authorization_params");
            entity.Property(e => e.AuthorizationUrl).HasColumnName("authorization_url");
            entity.Property(e => e.CachedDiscovery)
                .HasColumnType("jsonb")
                .HasColumnName("cached_discovery");
            entity.Property(e => e.ClientId).HasColumnName("client_id");
            entity.Property(e => e.ClientSecret).HasColumnName("client_secret");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.DiscoveryCachedAt).HasColumnName("discovery_cached_at");
            entity.Property(e => e.DiscoveryUrl).HasColumnName("discovery_url");
            entity.Property(e => e.EmailOptional)
                .HasDefaultValue(false)
                .HasColumnName("email_optional");
            entity.Property(e => e.Enabled)
                .HasDefaultValue(true)
                .HasColumnName("enabled");
            entity.Property(e => e.Identifier).HasColumnName("identifier");
            entity.Property(e => e.Issuer).HasColumnName("issuer");
            entity.Property(e => e.JwksUri).HasColumnName("jwks_uri");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.PkceEnabled)
                .HasDefaultValue(true)
                .HasColumnName("pkce_enabled");
            entity.Property(e => e.ProviderType).HasColumnName("provider_type");
            entity.Property(e => e.Scopes)
                .HasDefaultValueSql("'{}'::text[]")
                .HasColumnName("scopes");
            entity.Property(e => e.SkipNonceCheck)
                .HasDefaultValue(false)
                .HasColumnName("skip_nonce_check");
            entity.Property(e => e.TokenUrl).HasColumnName("token_url");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("updated_at");
            entity.Property(e => e.UserinfoUrl).HasColumnName("userinfo_url");
        });

        modelBuilder.Entity<Dispute>(entity =>
        {
            entity.HasKey(e => e.DispDisputesId).HasName("Disputes_pkey");

            entity.HasIndex(e => e.ContContractsId, "IX_Disputes_ContractsId");

            entity.HasIndex(e => e.UsrInitiatorId, "IX_Disputes_InitiatorId");

            entity.HasIndex(e => e.ResolvedByAdminId, "IX_Disputes_ResolvedByAdminId");

            entity.HasIndex(e => e.Status, "IX_Disputes_Status");

            entity.Property(e => e.DispDisputesId)
                .HasDefaultValueSql("gen_random_uuid()")
                .HasColumnName("disp_DisputesId");
            entity.Property(e => e.ContContractsId).HasColumnName("cont_ContractsId");
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("now()");
            entity.Property(e => e.MStoneMilestonesId).HasColumnName("mStone_MilestonesId");
            entity.Property(e => e.Resolution).HasComment("Enum DisputeResolution: 0=ClientFavored, 1=FreelancerFavored, 2=Split, 3=Dismissed");
            entity.Property(e => e.Status).HasComment("Enum DisputeStatus: 0=Open, 1=UnderReview, 2=Resolved, 3=Closed");
            entity.Property(e => e.UsrInitiatorId).HasColumnName("usr_InitiatorId");

            entity.HasOne(d => d.ContContracts).WithMany(p => p.Disputes)
                .HasForeignKey(d => d.ContContractsId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Disputes_cont_ContractsId_fkey");

            entity.HasOne(d => d.MStoneMilestones).WithMany(p => p.Disputes)
                .HasForeignKey(d => d.MStoneMilestonesId)
                .HasConstraintName("Disputes_mStone_MilestonesId_fkey");

            entity.HasOne(d => d.ResolvedByAdmin).WithMany(p => p.DisputeResolvedByAdmins)
                .HasForeignKey(d => d.ResolvedByAdminId)
                .HasConstraintName("Disputes_ResolvedByAdminId_fkey");

            entity.HasOne(d => d.UsrInitiator).WithMany(p => p.DisputeUsrInitiators)
                .HasForeignKey(d => d.UsrInitiatorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Disputes_usr_InitiatorId_fkey");
        });

        modelBuilder.Entity<DisputeEvidence>(entity =>
        {
            entity.HasKey(e => e.DispEvDisputeEvidenceId).HasName("DisputeEvidence_pkey");

            entity.ToTable("DisputeEvidence");

            entity.HasIndex(e => e.DispDisputesId, "IX_DisputeEvidence_DisputesId");

            entity.Property(e => e.DispEvDisputeEvidenceId)
                .HasDefaultValueSql("gen_random_uuid()")
                .HasColumnName("dispEv_DisputeEvidenceId");
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("now()");
            entity.Property(e => e.DispDisputesId).HasColumnName("disp_DisputesId");
            entity.Property(e => e.FileName).HasMaxLength(500);
            entity.Property(e => e.UsrUploadedById).HasColumnName("usr_UploadedById");

            entity.HasOne(d => d.DispDisputes).WithMany(p => p.DisputeEvidences)
                .HasForeignKey(d => d.DispDisputesId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("DisputeEvidence_disp_DisputesId_fkey");

            entity.HasOne(d => d.UsrUploadedBy).WithMany(p => p.DisputeEvidences)
                .HasForeignKey(d => d.UsrUploadedById)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("DisputeEvidence_usr_UploadedById_fkey");
        });

        modelBuilder.Entity<DisputeMessage>(entity =>
        {
            entity.HasKey(e => e.DispMsgDisputeMessagesId).HasName("DisputeMessages_pkey");

            entity.HasIndex(e => new { e.DispDisputesId, e.CreatedAt }, "IX_DisputeMessages_DisputesId_CreatedAt");

            entity.Property(e => e.DispMsgDisputeMessagesId)
                .HasDefaultValueSql("gen_random_uuid()")
                .HasColumnName("dispMsg_DisputeMessagesId");
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("now()");
            entity.Property(e => e.DispDisputesId).HasColumnName("disp_DisputesId");
            entity.Property(e => e.UsrSenderId).HasColumnName("usr_SenderId");

            entity.HasOne(d => d.DispDisputes).WithMany(p => p.DisputeMessages)
                .HasForeignKey(d => d.DispDisputesId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("DisputeMessages_disp_DisputesId_fkey");

            entity.HasOne(d => d.UsrSender).WithMany(p => p.DisputeMessages)
                .HasForeignKey(d => d.UsrSenderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("DisputeMessages_usr_SenderId_fkey");
        });

        modelBuilder.Entity<Education>(entity =>
        {
            entity.HasKey(e => e.EEducationsId).HasName("Educations_pkey");

            entity.HasIndex(e => e.FlFreelancerId, "IX_Educations_FreelancerId");

            entity.Property(e => e.EEducationsId)
                .HasDefaultValueSql("gen_random_uuid()")
                .HasColumnName("e_EducationsId");
            entity.Property(e => e.Degree).HasMaxLength(200);
            entity.Property(e => e.FieldOfStudy).HasMaxLength(200);
            entity.Property(e => e.FlFreelancerId).HasColumnName("fl_FreelancerId");
            entity.Property(e => e.Institution).HasMaxLength(300);

            entity.HasOne(d => d.FlFreelancer).WithMany(p => p.Educations)
                .HasForeignKey(d => d.FlFreelancerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Educations_fl_FreelancerId_fkey");
        });

        modelBuilder.Entity<EsignAuditTrail>(entity =>
        {
            entity.HasKey(e => e.EAuditEsignAuditTrailsId).HasName("ESignAuditTrails_pkey");

            entity.ToTable("ESignAuditTrails");

            entity.HasIndex(e => e.Action, "IX_ESignAuditTrails_Action");

            entity.HasIndex(e => new { e.EDocEsignDocumentsId, e.CreatedAt }, "IX_ESignAuditTrails_DocId_CreatedAt").IsDescending(false, true);

            entity.HasIndex(e => e.UsrUserId, "IX_ESignAuditTrails_UserId");

            entity.Property(e => e.EAuditEsignAuditTrailsId)
                .HasDefaultValueSql("gen_random_uuid()")
                .HasColumnName("eAudit_ESignAuditTrailsId");
            entity.Property(e => e.Action).HasComment("Enum ESignAuditAction: 0=DocumentCreated, 1=DocumentViewed, 2=SignatureAdded, 3=SignatureDeclined, 4=DocumentFinalized, 5=DocumentExported, 6=DocumentVoided");
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("now()");
            entity.Property(e => e.EDocEsignDocumentsId).HasColumnName("eDoc_ESignDocumentsId");
            entity.Property(e => e.IpAddress).HasMaxLength(45);
            entity.Property(e => e.Metadata).HasColumnType("jsonb");
            entity.Property(e => e.UsrUserId).HasColumnName("usr_UserId");

            entity.HasOne(d => d.EDocEsignDocuments).WithMany(p => p.EsignAuditTrails)
                .HasForeignKey(d => d.EDocEsignDocumentsId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ESignAuditTrails_eDoc_ESignDocumentsId_fkey");

            entity.HasOne(d => d.UsrUser).WithMany(p => p.EsignAuditTrails)
                .HasForeignKey(d => d.UsrUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ESignAuditTrails_usr_UserId_fkey");
        });

        modelBuilder.Entity<EsignDocument>(entity =>
        {
            entity.HasKey(e => e.EDocEsignDocumentsId).HasName("ESignDocuments_pkey");

            entity.ToTable("ESignDocuments");

            entity.HasIndex(e => e.ContContractsId, "ESignDocuments_cont_ContractsId_key").IsUnique();

            entity.HasIndex(e => e.DocumentCode, "IX_ESignDocuments_DocumentCode").IsUnique();

            entity.HasIndex(e => e.JpJobPostsId, "IX_ESignDocuments_JobPostsId");

            entity.HasIndex(e => e.Status, "IX_ESignDocuments_Status");

            entity.HasIndex(e => new { e.Status, e.CreatedAt }, "IX_ESignDocuments_Status_CreatedAt").IsDescending(false, true);

            entity.Property(e => e.EDocEsignDocumentsId)
                .HasDefaultValueSql("gen_random_uuid()")
                .HasColumnName("eDoc_ESignDocumentsId");
            entity.Property(e => e.ContContractsId).HasColumnName("cont_ContractsId");
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("now()");
            entity.Property(e => e.DocumentCode).HasMaxLength(50);
            entity.Property(e => e.DocumentHash).HasMaxLength(128);
            entity.Property(e => e.ETplEsignTemplatesId).HasColumnName("eTpl_ESignTemplatesId");
            entity.Property(e => e.JpJobPostsId).HasColumnName("jp_JobPostsId");
            entity.Property(e => e.Status)
                .HasDefaultValue(0)
                .HasComment("Enum ESignDocumentStatus: 0=Draft, 1=PendingSignatures, 2=PartiallySigned, 3=FullySigned, 4=Expired, 5=Voided");

            entity.HasOne(d => d.ContContracts).WithOne(p => p.EsignDocument)
                .HasForeignKey<EsignDocument>(d => d.ContContractsId)
                .HasConstraintName("ESignDocuments_cont_ContractsId_fkey");

            entity.HasOne(d => d.ETplEsignTemplates).WithMany(p => p.EsignDocuments)
                .HasForeignKey(d => d.ETplEsignTemplatesId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ESignDocuments_eTpl_ESignTemplatesId_fkey");

            entity.HasOne(d => d.JpJobPosts).WithMany(p => p.EsignDocuments)
                .HasForeignKey(d => d.JpJobPostsId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ESignDocuments_jp_JobPostsId_fkey");
        });

        modelBuilder.Entity<EsignSignature>(entity =>
        {
            entity.HasKey(e => e.ESigEsignSignaturesId).HasName("ESignSignatures_pkey");

            entity.ToTable("ESignSignatures");

            entity.HasIndex(e => new { e.EDocEsignDocumentsId, e.UsrUserId }, "ESignSignatures_eDoc_ESignDocumentsId_usr_UserId_key").IsUnique();

            entity.HasIndex(e => new { e.EDocEsignDocumentsId, e.Status }, "IX_ESignSignatures_DocId_Status");

            entity.HasIndex(e => e.EDocEsignDocumentsId, "IX_ESignSignatures_ESignDocumentsId");

            entity.HasIndex(e => e.Status, "IX_ESignSignatures_Status");

            entity.HasIndex(e => e.UsrUserId, "IX_ESignSignatures_UserId");

            entity.Property(e => e.ESigEsignSignaturesId)
                .HasDefaultValueSql("gen_random_uuid()")
                .HasColumnName("eSig_ESignSignaturesId");
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("now()");
            entity.Property(e => e.EDocEsignDocumentsId).HasColumnName("eDoc_ESignDocumentsId");
            entity.Property(e => e.IpAddress).HasMaxLength(45);
            entity.Property(e => e.SignerRole).HasComment("Enum ESignerRole: 0=Client, 1=Freelancer");
            entity.Property(e => e.Status)
                .HasDefaultValue(0)
                .HasComment("Enum ESignSignatureStatus: 0=Pending, 1=Signed, 2=Declined");
            entity.Property(e => e.UsrUserId).HasColumnName("usr_UserId");

            entity.HasOne(d => d.EDocEsignDocuments).WithMany(p => p.EsignSignatures)
                .HasForeignKey(d => d.EDocEsignDocumentsId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ESignSignatures_eDoc_ESignDocumentsId_fkey");

            entity.HasOne(d => d.UsrUser).WithMany(p => p.EsignSignatures)
                .HasForeignKey(d => d.UsrUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ESignSignatures_usr_UserId_fkey");
        });

        modelBuilder.Entity<EsignTemplate>(entity =>
        {
            entity.HasKey(e => e.ETplEsignTemplatesId).HasName("ESignTemplates_pkey");

            entity.ToTable("ESignTemplates");

            entity.HasIndex(e => e.CreatedBy, "IX_ESignTemplates_CreatedBy");

            entity.HasIndex(e => e.IsActive, "IX_ESignTemplates_IsActive");

            entity.HasIndex(e => e.Name, "IX_ESignTemplates_Name");

            entity.Property(e => e.ETplEsignTemplatesId)
                .HasDefaultValueSql("gen_random_uuid()")
                .HasColumnName("eTpl_ESignTemplatesId");
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("now()");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.Name).HasMaxLength(300);
            entity.Property(e => e.NameVi).HasMaxLength(300);
            entity.Property(e => e.PlaceholderSchema).HasColumnType("jsonb");
            entity.Property(e => e.Version).HasDefaultValue(1);

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.EsignTemplates)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ESignTemplates_CreatedBy_fkey");
        });

        modelBuilder.Entity<Faq>(entity =>
        {
            entity.HasKey(e => e.FaqFaqsId).HasName("FAQs_pkey");

            entity.ToTable("FAQs");

            entity.HasIndex(e => e.FaqCatFaqcategoriesId, "IX_FAQs_FAQCategoriesId");

            entity.HasIndex(e => e.IsActive, "IX_FAQs_IsActive");

            entity.Property(e => e.FaqFaqsId)
                .HasDefaultValueSql("gen_random_uuid()")
                .HasColumnName("faq_FAQsId");
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("now()");
            entity.Property(e => e.FaqCatFaqcategoriesId).HasColumnName("faqCat_FAQCategoriesId");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.SortOrder).HasDefaultValue(0);

            entity.HasOne(d => d.FaqCatFaqcategories).WithMany(p => p.Faqs)
                .HasForeignKey(d => d.FaqCatFaqcategoriesId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FAQs_faqCat_FAQCategoriesId_fkey");
        });

        modelBuilder.Entity<Faqcategory>(entity =>
        {
            entity.HasKey(e => e.FaqCatFaqcategoriesId).HasName("FAQCategories_pkey");

            entity.ToTable("FAQCategories");

            entity.HasIndex(e => e.Slug, "IX_FAQCategories_Slug").IsUnique();

            entity.Property(e => e.FaqCatFaqcategoriesId)
                .HasDefaultValueSql("gen_random_uuid()")
                .HasColumnName("faqCat_FAQCategoriesId");
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("now()");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.NameVi).HasMaxLength(200);
            entity.Property(e => e.Slug).HasMaxLength(200);
            entity.Property(e => e.SortOrder).HasDefaultValue(0);
        });

        modelBuilder.Entity<FlowState>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("flow_state_pkey");

            entity.ToTable("flow_state", "auth", tb => tb.HasComment("Stores metadata for all OAuth/SSO login flows"));

            entity.HasIndex(e => e.CreatedAt, "flow_state_created_at_idx").IsDescending();

            entity.HasIndex(e => e.AuthCode, "idx_auth_code");

            entity.HasIndex(e => new { e.UserId, e.AuthenticationMethod }, "idx_user_id_auth_method");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.AuthCode).HasColumnName("auth_code");
            entity.Property(e => e.AuthCodeIssuedAt).HasColumnName("auth_code_issued_at");
            entity.Property(e => e.AuthenticationMethod).HasColumnName("authentication_method");
            entity.Property(e => e.CodeChallenge).HasColumnName("code_challenge");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.EmailOptional)
                .HasDefaultValue(false)
                .HasColumnName("email_optional");
            entity.Property(e => e.InviteToken).HasColumnName("invite_token");
            entity.Property(e => e.LinkingTargetId).HasColumnName("linking_target_id");
            entity.Property(e => e.OauthClientStateId).HasColumnName("oauth_client_state_id");
            entity.Property(e => e.ProviderAccessToken).HasColumnName("provider_access_token");
            entity.Property(e => e.ProviderRefreshToken).HasColumnName("provider_refresh_token");
            entity.Property(e => e.ProviderType).HasColumnName("provider_type");
            entity.Property(e => e.Referrer).HasColumnName("referrer");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            entity.Property(e => e.UserId).HasColumnName("user_id");
        });

        modelBuilder.Entity<FreelancerProfile>(entity =>
        {
            entity.HasKey(e => e.FlProFreelancerProfilesId).HasName("FreelancerProfiles_pkey");

            entity.HasIndex(e => e.UsrUserId, "FreelancerProfiles_usr_UserId_key").IsUnique();

            entity.HasIndex(e => e.Availability, "IX_FreelancerProfiles_Availability");

            entity.HasIndex(e => e.ExperienceLevel, "IX_FreelancerProfiles_ExperienceLevel");

            entity.HasIndex(e => e.UsrUserId, "IX_FreelancerProfiles_UserId").IsUnique();

            entity.Property(e => e.FlProFreelancerProfilesId)
                .HasDefaultValueSql("gen_random_uuid()")
                .HasColumnName("flPro_FreelancerProfilesId");
            entity.Property(e => e.Availability)
                .HasDefaultValue(0)
                .HasComment("Enum Availability: 0=FullTime, 1=PartTime, 2=NotAvailable");
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("now()");
            entity.Property(e => e.ExperienceLevel).HasComment("Enum ExperienceLevel: 0=Entry, 1=Intermediate, 2=Expert");
            entity.Property(e => e.HourlyRate).HasPrecision(18, 2);
            entity.Property(e => e.Location).HasMaxLength(300);
            entity.Property(e => e.Title).HasMaxLength(300);
            entity.Property(e => e.UsrUserId).HasColumnName("usr_UserId");

            entity.HasOne(d => d.UsrUser).WithOne(p => p.FreelancerProfile)
                .HasForeignKey<FreelancerProfile>(d => d.UsrUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FreelancerProfiles_usr_UserId_fkey");
        });

        modelBuilder.Entity<FreelancerSkill>(entity =>
        {
            entity.HasKey(e => e.FSkillFreelancerSkillsId).HasName("FreelancerSkills_pkey");

            entity.HasIndex(e => new { e.FlFreelancerId, e.SkSkillsId }, "FreelancerSkills_fl_FreelancerId_sk_SkillsId_key").IsUnique();

            entity.HasIndex(e => e.FlFreelancerId, "IX_FreelancerSkills_FreelancerId");

            entity.HasIndex(e => e.SkSkillsId, "IX_FreelancerSkills_SkillsId");

            entity.Property(e => e.FSkillFreelancerSkillsId)
                .HasDefaultValueSql("gen_random_uuid()")
                .HasColumnName("fSkill_FreelancerSkillsId");
            entity.Property(e => e.FlFreelancerId).HasColumnName("fl_FreelancerId");
            entity.Property(e => e.ProficiencyLevel).HasComment("Enum ProficiencyLevel: 0=Beginner, 1=Intermediate, 2=Advanced, 3=Expert");
            entity.Property(e => e.SkSkillsId).HasColumnName("sk_SkillsId");

            entity.HasOne(d => d.FlFreelancer).WithMany(p => p.FreelancerSkills)
                .HasForeignKey(d => d.FlFreelancerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FreelancerSkills_fl_FreelancerId_fkey");

            entity.HasOne(d => d.SkSkills).WithMany(p => p.FreelancerSkills)
                .HasForeignKey(d => d.SkSkillsId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FreelancerSkills_sk_SkillsId_fkey");
        });

        modelBuilder.Entity<Identity>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("identities_pkey");

            entity.ToTable("identities", "auth", tb => tb.HasComment("Auth: Stores identities associated to a user."));

            entity.HasIndex(e => e.Email, "identities_email_idx").HasOperators(new[] { "text_pattern_ops" });

            entity.HasIndex(e => new { e.ProviderId, e.Provider }, "identities_provider_id_provider_unique").IsUnique();

            entity.HasIndex(e => e.UserId, "identities_user_id_idx");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("gen_random_uuid()")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.Email)
                .HasComputedColumnSql("lower((identity_data ->> 'email'::text))", true)
                .HasComment("Auth: Email is a generated column that references the optional email property in the identity_data")
                .HasColumnName("email");
            entity.Property(e => e.IdentityData)
                .HasColumnType("jsonb")
                .HasColumnName("identity_data");
            entity.Property(e => e.LastSignInAt).HasColumnName("last_sign_in_at");
            entity.Property(e => e.Provider).HasColumnName("provider");
            entity.Property(e => e.ProviderId).HasColumnName("provider_id");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.User).WithMany(p => p.Identities)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("identities_user_id_fkey");
        });

        modelBuilder.Entity<Instance>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("instances_pkey");

            entity.ToTable("instances", "auth", tb => tb.HasComment("Auth: Manages users across multiple sites."));

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.RawBaseConfig).HasColumnName("raw_base_config");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            entity.Property(e => e.Uuid).HasColumnName("uuid");
        });

        modelBuilder.Entity<JobPost>(entity =>
        {
            entity.HasKey(e => e.JpJobPostsId).HasName("JobPosts_pkey");

            entity.HasIndex(e => e.ApplicationDeadline, "IX_JobPosts_ApplicationDeadline");

            entity.HasIndex(e => e.CategoryId, "IX_JobPosts_CategoryId");

            entity.HasIndex(e => e.ClProClientProfilesId, "IX_JobPosts_ClientProfilesId");

            entity.HasIndex(e => e.CreatedAt, "IX_JobPosts_CreatedAt").IsDescending();

            entity.HasIndex(e => e.Status, "IX_JobPosts_Status");

            entity.HasIndex(e => new { e.Status, e.Visibility }, "IX_JobPosts_Status_Visibility");

            entity.HasIndex(e => new { e.Status, e.Visibility, e.CreatedAt }, "IX_JobPosts_Status_Visibility_CreatedAt").IsDescending(false, false, true);

            entity.Property(e => e.JpJobPostsId)
                .HasDefaultValueSql("gen_random_uuid()")
                .HasColumnName("jp_JobPostsId");
            entity.Property(e => e.BudgetMax).HasPrecision(18, 2);
            entity.Property(e => e.BudgetMin).HasPrecision(18, 2);
            entity.Property(e => e.BudgetType).HasComment("Enum BudgetType: 0=Fixed, 1=Hourly");
            entity.Property(e => e.ClProClientProfilesId).HasColumnName("clPro_ClientProfilesId");
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("now()");
            entity.Property(e => e.Currency)
                .HasMaxLength(5)
                .HasDefaultValueSql("'VND'::character varying");
            entity.Property(e => e.EstimatedDuration).HasMaxLength(100);
            entity.Property(e => e.ExperienceLevelRequired).HasComment("Enum ExperienceLevel: 0=Entry, 1=Intermediate, 2=Expert");
            entity.Property(e => e.IsAigenerated)
                .HasDefaultValue(false)
                .HasColumnName("IsAIGenerated");
            entity.Property(e => e.Location).HasMaxLength(300);
            entity.Property(e => e.LocationType)
                .HasDefaultValue(0)
                .HasComment("Enum LocationType: 0=Remote, 1=OnSite, 2=Hybrid");
            entity.Property(e => e.Status).HasComment("Enum JobPostStatus: 0=Draft, 1=Open, 2=InProgress, 3=Closed, 4=Cancelled");
            entity.Property(e => e.Title).HasMaxLength(500);
            entity.Property(e => e.Visibility)
                .HasDefaultValue(0)
                .HasComment("Enum JobPostVisibility: 0=Public, 1=Private, 2=InviteOnly");

            entity.HasOne(d => d.Category).WithMany(p => p.JobPosts)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("JobPosts_CategoryId_fkey");

            entity.HasOne(d => d.ClProClientProfiles).WithMany(p => p.JobPosts)
                .HasForeignKey(d => d.ClProClientProfilesId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("JobPosts_clPro_ClientProfilesId_fkey");
        });

        modelBuilder.Entity<JobPostAttachment>(entity =>
        {
            entity.HasKey(e => e.JpAttachJobPostAttachmentsId).HasName("JobPostAttachments_pkey");

            entity.HasIndex(e => e.JpJobPostsId, "IX_JobPostAttachments_JobPostsId");

            entity.Property(e => e.JpAttachJobPostAttachmentsId)
                .HasDefaultValueSql("gen_random_uuid()")
                .HasColumnName("jpAttach_JobPostAttachmentsId");
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("now()");
            entity.Property(e => e.FileName).HasMaxLength(500);
            entity.Property(e => e.JpJobPostsId).HasColumnName("jp_JobPostsId");

            entity.HasOne(d => d.JpJobPosts).WithMany(p => p.JobPostAttachments)
                .HasForeignKey(d => d.JpJobPostsId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("JobPostAttachments_jp_JobPostsId_fkey");
        });

        modelBuilder.Entity<JobPostSkill>(entity =>
        {
            entity.HasKey(e => e.JpSkillJobPostSkillsId).HasName("JobPostSkills_pkey");

            entity.HasIndex(e => e.JpJobPostsId, "IX_JobPostSkills_JobPostsId");

            entity.HasIndex(e => e.SkSkillsId, "IX_JobPostSkills_SkillsId");

            entity.HasIndex(e => new { e.JpJobPostsId, e.SkSkillsId }, "JobPostSkills_jp_JobPostsId_sk_SkillsId_key").IsUnique();

            entity.Property(e => e.JpSkillJobPostSkillsId)
                .HasDefaultValueSql("gen_random_uuid()")
                .HasColumnName("jpSkill_JobPostSkillsId");
            entity.Property(e => e.IsRequired).HasDefaultValue(true);
            entity.Property(e => e.JpJobPostsId).HasColumnName("jp_JobPostsId");
            entity.Property(e => e.SkSkillsId).HasColumnName("sk_SkillsId");

            entity.HasOne(d => d.JpJobPosts).WithMany(p => p.JobPostSkills)
                .HasForeignKey(d => d.JpJobPostsId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("JobPostSkills_jp_JobPostsId_fkey");

            entity.HasOne(d => d.SkSkills).WithMany(p => p.JobPostSkills)
                .HasForeignKey(d => d.SkSkillsId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("JobPostSkills_sk_SkillsId_fkey");
        });

        modelBuilder.Entity<Message>(entity =>
        {
            entity.HasKey(e => e.MsgMessagesId).HasName("Messages_pkey");

            entity.HasIndex(e => new { e.ConvConversationsId, e.CreatedAt }, "IX_Messages_ConversationsId_CreatedAt").IsDescending(false, true);

            entity.HasIndex(e => e.IsRead, "IX_Messages_IsRead");

            entity.HasIndex(e => e.UsrSenderId, "IX_Messages_SenderId");

            entity.Property(e => e.MsgMessagesId)
                .HasDefaultValueSql("gen_random_uuid()")
                .HasColumnName("msg_MessagesId");
            entity.Property(e => e.ConvConversationsId).HasColumnName("conv_ConversationsId");
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("now()");
            entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            entity.Property(e => e.IsEdited).HasDefaultValue(false);
            entity.Property(e => e.IsRead).HasDefaultValue(false);
            entity.Property(e => e.Type)
                .HasDefaultValue(0)
                .HasComment("Enum MessageType: 0=Text, 1=File, 2=System");
            entity.Property(e => e.UsrSenderId).HasColumnName("usr_SenderId");

            entity.HasOne(d => d.ConvConversations).WithMany(p => p.Messages)
                .HasForeignKey(d => d.ConvConversationsId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Messages_conv_ConversationsId_fkey");

            entity.HasOne(d => d.UsrSender).WithMany(p => p.Messages)
                .HasForeignKey(d => d.UsrSenderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Messages_usr_SenderId_fkey");
        });

        modelBuilder.Entity<MessageAttachment>(entity =>
        {
            entity.HasKey(e => e.MsgAttachMessageAttachmentsId).HasName("MessageAttachments_pkey");

            entity.HasIndex(e => e.MsgMessagesId, "IX_MessageAttachments_MessagesId");

            entity.Property(e => e.MsgAttachMessageAttachmentsId)
                .HasDefaultValueSql("gen_random_uuid()")
                .HasColumnName("msgAttach_MessageAttachmentsId");
            entity.Property(e => e.ContentType).HasMaxLength(100);
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("now()");
            entity.Property(e => e.FileName).HasMaxLength(500);
            entity.Property(e => e.MsgMessagesId).HasColumnName("msg_MessagesId");

            entity.HasOne(d => d.MsgMessages).WithMany(p => p.MessageAttachments)
                .HasForeignKey(d => d.MsgMessagesId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("MessageAttachments_msg_MessagesId_fkey");
        });

        modelBuilder.Entity<MfaAmrClaim>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("amr_id_pk");

            entity.ToTable("mfa_amr_claims", "auth", tb => tb.HasComment("auth: stores authenticator method reference claims for multi factor authentication"));

            entity.HasIndex(e => new { e.SessionId, e.AuthenticationMethod }, "mfa_amr_claims_session_id_authentication_method_pkey").IsUnique();

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.AuthenticationMethod).HasColumnName("authentication_method");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.SessionId).HasColumnName("session_id");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.Session).WithMany(p => p.MfaAmrClaims)
                .HasForeignKey(d => d.SessionId)
                .HasConstraintName("mfa_amr_claims_session_id_fkey");
        });

        modelBuilder.Entity<MfaChallenge>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("mfa_challenges_pkey");

            entity.ToTable("mfa_challenges", "auth", tb => tb.HasComment("auth: stores metadata about challenge requests made"));

            entity.HasIndex(e => e.CreatedAt, "mfa_challenge_created_at_idx").IsDescending();

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.FactorId).HasColumnName("factor_id");
            entity.Property(e => e.IpAddress).HasColumnName("ip_address");
            entity.Property(e => e.OtpCode).HasColumnName("otp_code");
            entity.Property(e => e.VerifiedAt).HasColumnName("verified_at");
            entity.Property(e => e.WebAuthnSessionData)
                .HasColumnType("jsonb")
                .HasColumnName("web_authn_session_data");

            entity.HasOne(d => d.Factor).WithMany(p => p.MfaChallenges)
                .HasForeignKey(d => d.FactorId)
                .HasConstraintName("mfa_challenges_auth_factor_id_fkey");
        });

        modelBuilder.Entity<MfaFactor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("mfa_factors_pkey");

            entity.ToTable("mfa_factors", "auth", tb => tb.HasComment("auth: stores metadata about factors"));

            entity.HasIndex(e => new { e.UserId, e.CreatedAt }, "factor_id_created_at_idx");

            entity.HasIndex(e => e.LastChallengedAt, "mfa_factors_last_challenged_at_key").IsUnique();

            entity.HasIndex(e => new { e.FriendlyName, e.UserId }, "mfa_factors_user_friendly_name_unique")
                .IsUnique()
                .HasFilter("(TRIM(BOTH FROM friendly_name) <> ''::text)");

            entity.HasIndex(e => e.UserId, "mfa_factors_user_id_idx");

            entity.HasIndex(e => new { e.UserId, e.Phone }, "unique_phone_factor_per_user").IsUnique();

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.FriendlyName).HasColumnName("friendly_name");
            entity.Property(e => e.LastChallengedAt).HasColumnName("last_challenged_at");
            entity.Property(e => e.LastWebauthnChallengeData)
                .HasComment("Stores the latest WebAuthn challenge data including attestation/assertion for customer verification")
                .HasColumnType("jsonb")
                .HasColumnName("last_webauthn_challenge_data");
            entity.Property(e => e.Phone).HasColumnName("phone");
            entity.Property(e => e.Secret).HasColumnName("secret");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.WebAuthnAaguid).HasColumnName("web_authn_aaguid");
            entity.Property(e => e.WebAuthnCredential)
                .HasColumnType("jsonb")
                .HasColumnName("web_authn_credential");

            entity.HasOne(d => d.User).WithMany(p => p.MfaFactors)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("mfa_factors_user_id_fkey");
        });

        modelBuilder.Entity<Migration>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("migrations_pkey");

            entity.ToTable("migrations", "storage");

            entity.HasIndex(e => e.Name, "migrations_name_key").IsUnique();

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.ExecutedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("executed_at");
            entity.Property(e => e.Hash)
                .HasMaxLength(40)
                .HasColumnName("hash");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Milestone>(entity =>
        {
            entity.HasKey(e => e.MStoneMilestonesId).HasName("Milestones_pkey");

            entity.HasIndex(e => e.ContContractsId, "IX_Milestones_ContractsId");

            entity.HasIndex(e => new { e.ContContractsId, e.SortOrder }, "IX_Milestones_ContractsId_SortOrder");

            entity.HasIndex(e => e.Status, "IX_Milestones_Status");

            entity.Property(e => e.MStoneMilestonesId)
                .HasDefaultValueSql("gen_random_uuid()")
                .HasColumnName("mStone_MilestonesId");
            entity.Property(e => e.Amount).HasPrecision(18, 2);
            entity.Property(e => e.ContContractsId).HasColumnName("cont_ContractsId");
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("now()");
            entity.Property(e => e.SortOrder).HasDefaultValue(0);
            entity.Property(e => e.Status).HasComment("Enum MilestoneStatus: 0=Pending, 1=InProgress, 2=Submitted, 3=Approved, 4=PaymentProofUploaded, 5=PaymentConfirmed, 6=Disputed");
            entity.Property(e => e.Title).HasMaxLength(500);

            entity.HasOne(d => d.ContContracts).WithMany(p => p.Milestones)
                .HasForeignKey(d => d.ContContractsId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Milestones_cont_ContractsId_fkey");
        });

        modelBuilder.Entity<MilestoneAttachment>(entity =>
        {
            entity.HasKey(e => e.MStoneAttachMilestoneAttachmentsId).HasName("MilestoneAttachments_pkey");

            entity.HasIndex(e => e.MStoneMilestonesId, "IX_MilestoneAttachments_MilestonesId");

            entity.Property(e => e.MStoneAttachMilestoneAttachmentsId)
                .HasDefaultValueSql("gen_random_uuid()")
                .HasColumnName("mStoneAttach_MilestoneAttachmentsId");
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("now()");
            entity.Property(e => e.FileName).HasMaxLength(500);
            entity.Property(e => e.MStoneMilestonesId).HasColumnName("mStone_MilestonesId");

            entity.HasOne(d => d.MStoneMilestones).WithMany(p => p.MilestoneAttachments)
                .HasForeignKey(d => d.MStoneMilestonesId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("MilestoneAttachments_mStone_MilestonesId_fkey");

            entity.HasOne(d => d.UploadedByUser).WithMany(p => p.MilestoneAttachments)
                .HasForeignKey(d => d.UploadedByUserId)
                .HasConstraintName("MilestoneAttachments_UploadedByUserId_fkey");
        });

        modelBuilder.Entity<Notification>(entity =>
        {
            entity.HasKey(e => e.NotiNotificationsId).HasName("Notifications_pkey");

            entity.HasIndex(e => new { e.ReferenceId, e.ReferenceType }, "IX_Notifications_ReferenceId_ReferenceType");

            entity.HasIndex(e => new { e.UsrUserId, e.CreatedAt }, "IX_Notifications_UserId_CreatedAt").IsDescending(false, true);

            entity.HasIndex(e => new { e.UsrUserId, e.IsRead }, "IX_Notifications_UserId_IsRead");

            entity.Property(e => e.NotiNotificationsId)
                .HasDefaultValueSql("gen_random_uuid()")
                .HasColumnName("noti_NotificationsId");
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("now()");
            entity.Property(e => e.IsRead).HasDefaultValue(false);
            entity.Property(e => e.ReferenceType).HasMaxLength(50);
            entity.Property(e => e.Title).HasMaxLength(300);
            entity.Property(e => e.Type).HasComment("Enum NotificationType: 0=NewJob, 1=ProposalReceived, 2=ProposalStatusChanged, 3=ContractStarted, 4=MilestoneUpdated, 5=PaymentProofUploaded, 6=PaymentConfirmed, 7=ChatMessage, 8=DisputeUpdate, 9=ReviewReceived, 10=SystemAlert, 11=AIInterviewInvite, 12=SubscriptionExpiring");
            entity.Property(e => e.UsrUserId).HasColumnName("usr_UserId");

            entity.HasOne(d => d.UsrUser).WithMany(p => p.Notifications)
                .HasForeignKey(d => d.UsrUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Notifications_usr_UserId_fkey");
        });

        modelBuilder.Entity<OauthAuthorization>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("oauth_authorizations_pkey");

            entity.ToTable("oauth_authorizations", "auth");

            entity.HasIndex(e => e.ExpiresAt, "oauth_auth_pending_exp_idx").HasFilter("(status = 'pending'::auth.oauth_authorization_status)");

            entity.HasIndex(e => e.AuthorizationCode, "oauth_authorizations_authorization_code_key").IsUnique();

            entity.HasIndex(e => e.AuthorizationId, "oauth_authorizations_authorization_id_key").IsUnique();

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.ApprovedAt).HasColumnName("approved_at");
            entity.Property(e => e.AuthorizationCode).HasColumnName("authorization_code");
            entity.Property(e => e.AuthorizationId).HasColumnName("authorization_id");
            entity.Property(e => e.ClientId).HasColumnName("client_id");
            entity.Property(e => e.CodeChallenge).HasColumnName("code_challenge");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.ExpiresAt)
                .HasDefaultValueSql("(now() + '00:03:00'::interval)")
                .HasColumnName("expires_at");
            entity.Property(e => e.Nonce).HasColumnName("nonce");
            entity.Property(e => e.RedirectUri).HasColumnName("redirect_uri");
            entity.Property(e => e.Resource).HasColumnName("resource");
            entity.Property(e => e.Scope).HasColumnName("scope");
            entity.Property(e => e.State).HasColumnName("state");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.Client).WithMany(p => p.OauthAuthorizations)
                .HasForeignKey(d => d.ClientId)
                .HasConstraintName("oauth_authorizations_client_id_fkey");

            entity.HasOne(d => d.User).WithMany(p => p.OauthAuthorizations)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("oauth_authorizations_user_id_fkey");
        });

        modelBuilder.Entity<OauthClient>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("oauth_clients_pkey");

            entity.ToTable("oauth_clients", "auth");

            entity.HasIndex(e => e.DeletedAt, "oauth_clients_deleted_at_idx");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.ClientName).HasColumnName("client_name");
            entity.Property(e => e.ClientSecretHash).HasColumnName("client_secret_hash");
            entity.Property(e => e.ClientUri).HasColumnName("client_uri");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");
            entity.Property(e => e.GrantTypes).HasColumnName("grant_types");
            entity.Property(e => e.LogoUri).HasColumnName("logo_uri");
            entity.Property(e => e.RedirectUris).HasColumnName("redirect_uris");
            entity.Property(e => e.TokenEndpointAuthMethod).HasColumnName("token_endpoint_auth_method");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<OauthClientState>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("oauth_client_states_pkey");

            entity.ToTable("oauth_client_states", "auth", tb => tb.HasComment("Stores OAuth states for third-party provider authentication flows where Supabase acts as the OAuth client."));

            entity.HasIndex(e => e.CreatedAt, "idx_oauth_client_states_created_at");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CodeVerifier).HasColumnName("code_verifier");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.ProviderType).HasColumnName("provider_type");
        });

        modelBuilder.Entity<OauthConsent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("oauth_consents_pkey");

            entity.ToTable("oauth_consents", "auth");

            entity.HasIndex(e => e.ClientId, "oauth_consents_active_client_idx").HasFilter("(revoked_at IS NULL)");

            entity.HasIndex(e => new { e.UserId, e.ClientId }, "oauth_consents_active_user_client_idx").HasFilter("(revoked_at IS NULL)");

            entity.HasIndex(e => new { e.UserId, e.ClientId }, "oauth_consents_user_client_unique").IsUnique();

            entity.HasIndex(e => new { e.UserId, e.GrantedAt }, "oauth_consents_user_order_idx").IsDescending(false, true);

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.ClientId).HasColumnName("client_id");
            entity.Property(e => e.GrantedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("granted_at");
            entity.Property(e => e.RevokedAt).HasColumnName("revoked_at");
            entity.Property(e => e.Scopes).HasColumnName("scopes");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.Client).WithMany(p => p.OauthConsents)
                .HasForeignKey(d => d.ClientId)
                .HasConstraintName("oauth_consents_client_id_fkey");

            entity.HasOne(d => d.User).WithMany(p => p.OauthConsents)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("oauth_consents_user_id_fkey");
        });

        modelBuilder.Entity<Object>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("objects_pkey");

            entity.ToTable("objects", "storage");

            entity.HasIndex(e => new { e.BucketId, e.Name }, "bucketid_objname").IsUnique();

            entity.HasIndex(e => new { e.BucketId, e.Name }, "idx_objects_bucket_id_name").UseCollation(new[] { null, "C" });

            entity.HasIndex(e => e.Name, "name_prefix_search").HasOperators(new[] { "text_pattern_ops" });

            entity.Property(e => e.Id)
                .HasDefaultValueSql("gen_random_uuid()")
                .HasColumnName("id");
            entity.Property(e => e.BucketId).HasColumnName("bucket_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.LastAccessedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("last_accessed_at");
            entity.Property(e => e.Metadata)
                .HasColumnType("jsonb")
                .HasColumnName("metadata");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Owner)
                .HasComment("Field is deprecated, use owner_id instead")
                .HasColumnName("owner");
            entity.Property(e => e.OwnerId).HasColumnName("owner_id");
            entity.Property(e => e.PathTokens)
                .HasComputedColumnSql("string_to_array(name, '/'::text)", true)
                .HasColumnName("path_tokens");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("updated_at");
            entity.Property(e => e.UserMetadata)
                .HasColumnType("jsonb")
                .HasColumnName("user_metadata");
            entity.Property(e => e.Version).HasColumnName("version");

            entity.HasOne(d => d.Bucket).WithMany(p => p.Objects)
                .HasForeignKey(d => d.BucketId)
                .HasConstraintName("objects_bucketId_fkey");
        });

        modelBuilder.Entity<OneTimeToken>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("one_time_tokens_pkey");

            entity.ToTable("one_time_tokens", "auth");

            entity.HasIndex(e => e.RelatesTo, "one_time_tokens_relates_to_hash_idx").HasMethod("hash");

            entity.HasIndex(e => e.TokenHash, "one_time_tokens_token_hash_hash_idx").HasMethod("hash");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.RelatesTo).HasColumnName("relates_to");
            entity.Property(e => e.TokenHash).HasColumnName("token_hash");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("updated_at");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.User).WithMany(p => p.OneTimeTokens)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("one_time_tokens_user_id_fkey");
        });

        modelBuilder.Entity<PaymentProof>(entity =>
        {
            entity.HasKey(e => e.PpPaymentProofsId).HasName("PaymentProofs_pkey");

            entity.HasIndex(e => e.MStoneMilestonesId, "IX_PaymentProofs_MilestonesId");

            entity.HasIndex(e => e.Status, "IX_PaymentProofs_Status");

            entity.HasIndex(e => e.UsrUploadedById, "IX_PaymentProofs_UploadedById");

            entity.Property(e => e.PpPaymentProofsId)
                .HasDefaultValueSql("gen_random_uuid()")
                .HasColumnName("pp_PaymentProofsId");
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("now()");
            entity.Property(e => e.FileName).HasMaxLength(500);
            entity.Property(e => e.MStoneMilestonesId).HasColumnName("mStone_MilestonesId");
            entity.Property(e => e.Status)
                .HasDefaultValue(0)
                .HasComment("Enum PaymentProofStatus: 0=Pending, 1=Confirmed, 2=Disputed");
            entity.Property(e => e.UsrUploadedById).HasColumnName("usr_UploadedById");

            entity.HasOne(d => d.MStoneMilestones).WithMany(p => p.PaymentProofs)
                .HasForeignKey(d => d.MStoneMilestonesId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("PaymentProofs_mStone_MilestonesId_fkey");

            entity.HasOne(d => d.UsrUploadedBy).WithMany(p => p.PaymentProofs)
                .HasForeignKey(d => d.UsrUploadedById)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("PaymentProofs_usr_UploadedById_fkey");
        });

        modelBuilder.Entity<PlatformSetting>(entity =>
        {
            entity.HasKey(e => e.PsPlatformSettingsId).HasName("PlatformSettings_pkey");

            entity.HasIndex(e => e.Key, "IX_PlatformSettings_Key").IsUnique();

            entity.Property(e => e.PsPlatformSettingsId)
                .HasDefaultValueSql("gen_random_uuid()")
                .HasColumnName("ps_PlatformSettingsId");
            entity.Property(e => e.DataType)
                .HasMaxLength(50)
                .HasDefaultValueSql("'string'::character varying");
            entity.Property(e => e.Key).HasMaxLength(200);

            entity.HasOne(d => d.UpdatedByAdmin).WithMany(p => p.PlatformSettings)
                .HasForeignKey(d => d.UpdatedByAdminId)
                .HasConstraintName("PlatformSettings_UpdatedByAdminId_fkey");
        });

        modelBuilder.Entity<PortfolioItem>(entity =>
        {
            entity.HasKey(e => e.PiPortfolioItemsId).HasName("PortfolioItems_pkey");

            entity.HasIndex(e => e.CategoryId, "IX_PortfolioItems_CategoryId");

            entity.HasIndex(e => e.FlFreelancerId, "IX_PortfolioItems_FreelancerId");

            entity.Property(e => e.PiPortfolioItemsId)
                .HasDefaultValueSql("gen_random_uuid()")
                .HasColumnName("pi_PortfolioItemsId");
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("now()");
            entity.Property(e => e.FlFreelancerId).HasColumnName("fl_FreelancerId");
            entity.Property(e => e.Title).HasMaxLength(300);

            entity.HasOne(d => d.Category).WithMany(p => p.PortfolioItems)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("PortfolioItems_CategoryId_fkey");

            entity.HasOne(d => d.FlFreelancer).WithMany(p => p.PortfolioItems)
                .HasForeignKey(d => d.FlFreelancerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("PortfolioItems_fl_FreelancerId_fkey");
        });

        modelBuilder.Entity<Proposal>(entity =>
        {
            entity.HasKey(e => e.PropoProposalsId).HasName("Proposals_pkey");

            entity.HasIndex(e => e.FlProFreelancerProfilesId, "IX_Proposals_FreelancerProfilesId");

            entity.HasIndex(e => new { e.FlProFreelancerProfilesId, e.Status }, "IX_Proposals_FreelancerProfilesId_Status");

            entity.HasIndex(e => e.JpJobPostsId, "IX_Proposals_JobPostsId");

            entity.HasIndex(e => new { e.JpJobPostsId, e.Status }, "IX_Proposals_JobPostsId_Status");

            entity.HasIndex(e => e.Status, "IX_Proposals_Status");

            entity.HasIndex(e => new { e.JpJobPostsId, e.FlProFreelancerProfilesId }, "Proposals_jp_JobPostsId_flPro_FreelancerProfilesId_key").IsUnique();

            entity.Property(e => e.PropoProposalsId)
                .HasDefaultValueSql("gen_random_uuid()")
                .HasColumnName("propo_ProposalsId");
            entity.Property(e => e.FlProFreelancerProfilesId).HasColumnName("flPro_FreelancerProfilesId");
            entity.Property(e => e.IsAigenerated)
                .HasDefaultValue(false)
                .HasColumnName("IsAIGenerated");
            entity.Property(e => e.JpJobPostsId).HasColumnName("jp_JobPostsId");
            entity.Property(e => e.ProposedDuration).HasMaxLength(100);
            entity.Property(e => e.ProposedRate).HasPrecision(18, 2);
            entity.Property(e => e.Status).HasComment("Enum ProposalStatus: 0=Pending, 1=Shortlisted, 2=Accepted, 3=Rejected, 4=Withdrawn");

            entity.HasOne(d => d.FlProFreelancerProfiles).WithMany(p => p.Proposals)
                .HasForeignKey(d => d.FlProFreelancerProfilesId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Proposals_flPro_FreelancerProfilesId_fkey");

            entity.HasOne(d => d.JpJobPosts).WithMany(p => p.Proposals)
                .HasForeignKey(d => d.JpJobPostsId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Proposals_jp_JobPostsId_fkey");
        });

        modelBuilder.Entity<ProposalAttachment>(entity =>
        {
            entity.HasKey(e => e.PropoAttachProposalAttachmentsId).HasName("ProposalAttachments_pkey");

            entity.HasIndex(e => e.PropoProposalsId, "IX_ProposalAttachments_ProposalsId");

            entity.Property(e => e.PropoAttachProposalAttachmentsId)
                .HasDefaultValueSql("gen_random_uuid()")
                .HasColumnName("propoAttach_ProposalAttachmentsId");
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("now()");
            entity.Property(e => e.FileName).HasMaxLength(500);
            entity.Property(e => e.PropoProposalsId).HasColumnName("propo_ProposalsId");

            entity.HasOne(d => d.PropoProposals).WithMany(p => p.ProposalAttachments)
                .HasForeignKey(d => d.PropoProposalsId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ProposalAttachments_propo_ProposalsId_fkey");
        });

        modelBuilder.Entity<RefreshToken>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("refresh_tokens_pkey");

            entity.ToTable("refresh_tokens", "auth", tb => tb.HasComment("Auth: Store of tokens used to refresh JWT tokens once they expire."));

            entity.HasIndex(e => e.InstanceId, "refresh_tokens_instance_id_idx");

            entity.HasIndex(e => new { e.InstanceId, e.UserId }, "refresh_tokens_instance_id_user_id_idx");

            entity.HasIndex(e => e.Parent, "refresh_tokens_parent_idx");

            entity.HasIndex(e => new { e.SessionId, e.Revoked }, "refresh_tokens_session_id_revoked_idx");

            entity.HasIndex(e => e.Token, "refresh_tokens_token_unique").IsUnique();

            entity.HasIndex(e => e.UpdatedAt, "refresh_tokens_updated_at_idx").IsDescending();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.InstanceId).HasColumnName("instance_id");
            entity.Property(e => e.Parent)
                .HasMaxLength(255)
                .HasColumnName("parent");
            entity.Property(e => e.Revoked).HasColumnName("revoked");
            entity.Property(e => e.SessionId).HasColumnName("session_id");
            entity.Property(e => e.Token)
                .HasMaxLength(255)
                .HasColumnName("token");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            entity.Property(e => e.UserId)
                .HasMaxLength(255)
                .HasColumnName("user_id");

            entity.HasOne(d => d.Session).WithMany(p => p.RefreshTokens)
                .HasForeignKey(d => d.SessionId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("refresh_tokens_session_id_fkey");
        });

        modelBuilder.Entity<RefreshToken1>(entity =>
        {
            entity.HasKey(e => e.RtId).HasName("RefreshTokens_pkey");

            entity.ToTable("RefreshTokens");

            entity.HasIndex(e => e.ExpiresAt, "IX_RefreshTokens_ExpiresAt");

            entity.HasIndex(e => e.Token, "IX_RefreshTokens_Token").IsUnique();

            entity.HasIndex(e => e.UsrUserId, "IX_RefreshTokens_UserId");

            entity.Property(e => e.RtId)
                .HasDefaultValueSql("gen_random_uuid()")
                .HasColumnName("rt_Id");
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("now()");
            entity.Property(e => e.UsrUserId).HasColumnName("usr_UserId");

            entity.HasOne(d => d.UsrUser).WithMany(p => p.RefreshToken1s)
                .HasForeignKey(d => d.UsrUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("RefreshTokens_usr_UserId_fkey");
        });

        modelBuilder.Entity<Report>(entity =>
        {
            entity.HasKey(e => e.RptReportsId).HasName("Reports_pkey");

            entity.HasIndex(e => new { e.ReportedEntityId, e.ReportedEntityType }, "IX_Reports_ReportedEntityId_ReportedEntityType");

            entity.HasIndex(e => e.UsrReporterId, "IX_Reports_ReporterId");

            entity.HasIndex(e => e.ResolvedByAdminId, "IX_Reports_ResolvedByAdminId");

            entity.HasIndex(e => e.Status, "IX_Reports_Status");

            entity.Property(e => e.RptReportsId)
                .HasDefaultValueSql("gen_random_uuid()")
                .HasColumnName("rpt_ReportsId");
            entity.Property(e => e.AdminAttachmentFileName).HasMaxLength(500);
            entity.Property(e => e.AdminAttachmentUrl).HasComment("v1.2: Admin đính kèm bản hợp đồng lao động e-sign PDF cho tranh chấp thanh toán");
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("now()");
            entity.Property(e => e.ReportedEntityType).HasMaxLength(50);
            entity.Property(e => e.Status)
                .HasDefaultValue(0)
                .HasComment("Enum ReportStatus: 0=Pending, 1=Reviewing, 2=Resolved, 3=Dismissed");
            entity.Property(e => e.Type).HasComment("Enum ReportType: 0=Spam, 1=Fraud, 2=InappropriateContent, 3=HarassmentOrAbuse, 4=Other, 5=PaymentDispute");
            entity.Property(e => e.UsrReporterId).HasColumnName("usr_ReporterId");

            entity.HasOne(d => d.ResolvedByAdmin).WithMany(p => p.ReportResolvedByAdmins)
                .HasForeignKey(d => d.ResolvedByAdminId)
                .HasConstraintName("Reports_ResolvedByAdminId_fkey");

            entity.HasOne(d => d.UsrReporter).WithMany(p => p.ReportUsrReporters)
                .HasForeignKey(d => d.UsrReporterId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Reports_usr_ReporterId_fkey");
        });

        modelBuilder.Entity<Review>(entity =>
        {
            entity.HasKey(e => e.RevReviewsId).HasName("Reviews_pkey");

            entity.HasIndex(e => e.ContContractsId, "IX_Reviews_ContractsId");

            entity.HasIndex(e => e.UsrRevieweeId, "IX_Reviews_RevieweeId");

            entity.HasIndex(e => new { e.UsrRevieweeId, e.IsVisible }, "IX_Reviews_RevieweeId_IsVisible");

            entity.HasIndex(e => e.UsrReviewerId, "IX_Reviews_ReviewerId");

            entity.HasIndex(e => new { e.ContContractsId, e.UsrReviewerId }, "Reviews_cont_ContractsId_usr_ReviewerId_key").IsUnique();

            entity.Property(e => e.RevReviewsId)
                .HasDefaultValueSql("gen_random_uuid()")
                .HasColumnName("rev_ReviewsId");
            entity.Property(e => e.ContContractsId).HasColumnName("cont_ContractsId");
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("now()");
            entity.Property(e => e.IsVisible).HasDefaultValue(true);
            entity.Property(e => e.UsrRevieweeId).HasColumnName("usr_RevieweeId");
            entity.Property(e => e.UsrReviewerId).HasColumnName("usr_ReviewerId");

            entity.HasOne(d => d.ContContracts).WithMany(p => p.Reviews)
                .HasForeignKey(d => d.ContContractsId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Reviews_cont_ContractsId_fkey");

            entity.HasOne(d => d.UsrReviewee).WithMany(p => p.ReviewUsrReviewees)
                .HasForeignKey(d => d.UsrRevieweeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Reviews_usr_RevieweeId_fkey");

            entity.HasOne(d => d.UsrReviewer).WithMany(p => p.ReviewUsrReviewers)
                .HasForeignKey(d => d.UsrReviewerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Reviews_usr_ReviewerId_fkey");
        });

        modelBuilder.Entity<S3MultipartUpload>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("s3_multipart_uploads_pkey");

            entity.ToTable("s3_multipart_uploads", "storage");

            entity.HasIndex(e => new { e.BucketId, e.Key, e.CreatedAt }, "idx_multipart_uploads_list").UseCollation(new[] { null, "C", null });

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BucketId).HasColumnName("bucket_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.InProgressSize)
                .HasDefaultValue(0L)
                .HasColumnName("in_progress_size");
            entity.Property(e => e.Key)
                .UseCollation("C")
                .HasColumnName("key");
            entity.Property(e => e.Metadata)
                .HasColumnType("jsonb")
                .HasColumnName("metadata");
            entity.Property(e => e.OwnerId).HasColumnName("owner_id");
            entity.Property(e => e.UploadSignature).HasColumnName("upload_signature");
            entity.Property(e => e.UserMetadata)
                .HasColumnType("jsonb")
                .HasColumnName("user_metadata");
            entity.Property(e => e.Version).HasColumnName("version");

            entity.HasOne(d => d.Bucket).WithMany(p => p.S3MultipartUploads)
                .HasForeignKey(d => d.BucketId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("s3_multipart_uploads_bucket_id_fkey");
        });

        modelBuilder.Entity<S3MultipartUploadsPart>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("s3_multipart_uploads_parts_pkey");

            entity.ToTable("s3_multipart_uploads_parts", "storage");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("gen_random_uuid()")
                .HasColumnName("id");
            entity.Property(e => e.BucketId).HasColumnName("bucket_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.Etag).HasColumnName("etag");
            entity.Property(e => e.Key)
                .UseCollation("C")
                .HasColumnName("key");
            entity.Property(e => e.OwnerId).HasColumnName("owner_id");
            entity.Property(e => e.PartNumber).HasColumnName("part_number");
            entity.Property(e => e.Size)
                .HasDefaultValue(0L)
                .HasColumnName("size");
            entity.Property(e => e.UploadId).HasColumnName("upload_id");
            entity.Property(e => e.Version).HasColumnName("version");

            entity.HasOne(d => d.Bucket).WithMany(p => p.S3MultipartUploadsParts)
                .HasForeignKey(d => d.BucketId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("s3_multipart_uploads_parts_bucket_id_fkey");

            entity.HasOne(d => d.Upload).WithMany(p => p.S3MultipartUploadsParts)
                .HasForeignKey(d => d.UploadId)
                .HasConstraintName("s3_multipart_uploads_parts_upload_id_fkey");
        });

        modelBuilder.Entity<SamlProvider>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("saml_providers_pkey");

            entity.ToTable("saml_providers", "auth", tb => tb.HasComment("Auth: Manages SAML Identity Provider connections."));

            entity.HasIndex(e => e.EntityId, "saml_providers_entity_id_key").IsUnique();

            entity.HasIndex(e => e.SsoProviderId, "saml_providers_sso_provider_id_idx");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.AttributeMapping)
                .HasColumnType("jsonb")
                .HasColumnName("attribute_mapping");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.EntityId).HasColumnName("entity_id");
            entity.Property(e => e.MetadataUrl).HasColumnName("metadata_url");
            entity.Property(e => e.MetadataXml).HasColumnName("metadata_xml");
            entity.Property(e => e.NameIdFormat).HasColumnName("name_id_format");
            entity.Property(e => e.SsoProviderId).HasColumnName("sso_provider_id");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.SsoProvider).WithMany(p => p.SamlProviders)
                .HasForeignKey(d => d.SsoProviderId)
                .HasConstraintName("saml_providers_sso_provider_id_fkey");
        });

        modelBuilder.Entity<SamlRelayState>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("saml_relay_states_pkey");

            entity.ToTable("saml_relay_states", "auth", tb => tb.HasComment("Auth: Contains SAML Relay State information for each Service Provider initiated login."));

            entity.HasIndex(e => e.CreatedAt, "saml_relay_states_created_at_idx").IsDescending();

            entity.HasIndex(e => e.ForEmail, "saml_relay_states_for_email_idx");

            entity.HasIndex(e => e.SsoProviderId, "saml_relay_states_sso_provider_id_idx");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.FlowStateId).HasColumnName("flow_state_id");
            entity.Property(e => e.ForEmail).HasColumnName("for_email");
            entity.Property(e => e.RedirectTo).HasColumnName("redirect_to");
            entity.Property(e => e.RequestId).HasColumnName("request_id");
            entity.Property(e => e.SsoProviderId).HasColumnName("sso_provider_id");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.FlowState).WithMany(p => p.SamlRelayStates)
                .HasForeignKey(d => d.FlowStateId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("saml_relay_states_flow_state_id_fkey");

            entity.HasOne(d => d.SsoProvider).WithMany(p => p.SamlRelayStates)
                .HasForeignKey(d => d.SsoProviderId)
                .HasConstraintName("saml_relay_states_sso_provider_id_fkey");
        });

        modelBuilder.Entity<SavedFreelancer>(entity =>
        {
            entity.HasKey(e => e.SfSavedFreelancersId).HasName("SavedFreelancers_pkey");

            entity.HasIndex(e => e.FlProFreelancerProfilesId, "IX_SavedFreelancers_FreelancerProfilesId");

            entity.HasIndex(e => e.UsrUserId, "IX_SavedFreelancers_UserId");

            entity.HasIndex(e => new { e.UsrUserId, e.FlProFreelancerProfilesId }, "SavedFreelancers_usr_UserId_flPro_FreelancerProfilesId_key").IsUnique();

            entity.Property(e => e.SfSavedFreelancersId)
                .HasDefaultValueSql("gen_random_uuid()")
                .HasColumnName("sf_SavedFreelancersId");
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("now()");
            entity.Property(e => e.FlProFreelancerProfilesId).HasColumnName("flPro_FreelancerProfilesId");
            entity.Property(e => e.UsrUserId).HasColumnName("usr_UserId");

            entity.HasOne(d => d.FlProFreelancerProfiles).WithMany(p => p.SavedFreelancers)
                .HasForeignKey(d => d.FlProFreelancerProfilesId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("SavedFreelancers_flPro_FreelancerProfilesId_fkey");

            entity.HasOne(d => d.UsrUser).WithMany(p => p.SavedFreelancers)
                .HasForeignKey(d => d.UsrUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("SavedFreelancers_usr_UserId_fkey");
        });

        modelBuilder.Entity<SavedJob>(entity =>
        {
            entity.HasKey(e => e.SjSavedJobsId).HasName("SavedJobs_pkey");

            entity.HasIndex(e => e.JpJobPostsId, "IX_SavedJobs_JobPostsId");

            entity.HasIndex(e => e.UsrUserId, "IX_SavedJobs_UserId");

            entity.HasIndex(e => new { e.UsrUserId, e.JpJobPostsId }, "SavedJobs_usr_UserId_jp_JobPostsId_key").IsUnique();

            entity.Property(e => e.SjSavedJobsId)
                .HasDefaultValueSql("gen_random_uuid()")
                .HasColumnName("sj_SavedJobsId");
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("now()");
            entity.Property(e => e.JpJobPostsId).HasColumnName("jp_JobPostsId");
            entity.Property(e => e.UsrUserId).HasColumnName("usr_UserId");

            entity.HasOne(d => d.JpJobPosts).WithMany(p => p.SavedJobs)
                .HasForeignKey(d => d.JpJobPostsId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("SavedJobs_jp_JobPostsId_fkey");

            entity.HasOne(d => d.UsrUser).WithMany(p => p.SavedJobs)
                .HasForeignKey(d => d.UsrUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("SavedJobs_usr_UserId_fkey");
        });

        modelBuilder.Entity<SchemaMigration>(entity =>
        {
            entity.HasKey(e => e.Version).HasName("schema_migrations_pkey");

            entity.ToTable("schema_migrations", "auth", tb => tb.HasComment("Auth: Manages updates to the auth system."));

            entity.Property(e => e.Version)
                .HasMaxLength(255)
                .HasColumnName("version");
        });

        modelBuilder.Entity<SchemaMigration1>(entity =>
        {
            entity.HasKey(e => e.Version).HasName("schema_migrations_pkey");

            entity.ToTable("schema_migrations", "realtime");

            entity.Property(e => e.Version)
                .ValueGeneratedNever()
                .HasColumnName("version");
            entity.Property(e => e.InsertedAt)
                .HasColumnType("timestamp(0) without time zone")
                .HasColumnName("inserted_at");
        });

        modelBuilder.Entity<Session>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("sessions_pkey");

            entity.ToTable("sessions", "auth", tb => tb.HasComment("Auth: Stores session data associated to a user."));

            entity.HasIndex(e => e.NotAfter, "sessions_not_after_idx").IsDescending();

            entity.HasIndex(e => e.OauthClientId, "sessions_oauth_client_id_idx");

            entity.HasIndex(e => e.UserId, "sessions_user_id_idx");

            entity.HasIndex(e => new { e.UserId, e.CreatedAt }, "user_id_created_at_idx");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.FactorId).HasColumnName("factor_id");
            entity.Property(e => e.Ip).HasColumnName("ip");
            entity.Property(e => e.NotAfter)
                .HasComment("Auth: Not after is a nullable column that contains a timestamp after which the session should be regarded as expired.")
                .HasColumnName("not_after");
            entity.Property(e => e.OauthClientId).HasColumnName("oauth_client_id");
            entity.Property(e => e.RefreshTokenCounter)
                .HasComment("Holds the ID (counter) of the last issued refresh token.")
                .HasColumnName("refresh_token_counter");
            entity.Property(e => e.RefreshTokenHmacKey)
                .HasComment("Holds a HMAC-SHA256 key used to sign refresh tokens for this session.")
                .HasColumnName("refresh_token_hmac_key");
            entity.Property(e => e.RefreshedAt)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("refreshed_at");
            entity.Property(e => e.Scopes).HasColumnName("scopes");
            entity.Property(e => e.Tag).HasColumnName("tag");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            entity.Property(e => e.UserAgent).HasColumnName("user_agent");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.OauthClient).WithMany(p => p.Sessions)
                .HasForeignKey(d => d.OauthClientId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("sessions_oauth_client_id_fkey");

            entity.HasOne(d => d.User).WithMany(p => p.Sessions)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("sessions_user_id_fkey");
        });

        modelBuilder.Entity<Skill>(entity =>
        {
            entity.HasKey(e => e.SkSkillsId).HasName("Skills_pkey");

            entity.HasIndex(e => e.CateCategoriesId, "IX_Skills_CategoriesId");

            entity.HasIndex(e => e.IsActive, "IX_Skills_IsActive");

            entity.HasIndex(e => e.Name, "IX_Skills_Name");

            entity.Property(e => e.SkSkillsId)
                .HasDefaultValueSql("gen_random_uuid()")
                .HasColumnName("sk_SkillsId");
            entity.Property(e => e.CateCategoriesId).HasColumnName("cate_CategoriesId");
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("now()");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.NameVi).HasMaxLength(200);

            entity.HasOne(d => d.CateCategories).WithMany(p => p.Skills)
                .HasForeignKey(d => d.CateCategoriesId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Skills_cate_CategoriesId_fkey");
        });

        modelBuilder.Entity<SsoDomain>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("sso_domains_pkey");

            entity.ToTable("sso_domains", "auth", tb => tb.HasComment("Auth: Manages SSO email address domain mapping to an SSO Identity Provider."));

            entity.HasIndex(e => e.SsoProviderId, "sso_domains_sso_provider_id_idx");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.Domain).HasColumnName("domain");
            entity.Property(e => e.SsoProviderId).HasColumnName("sso_provider_id");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

            entity.HasOne(d => d.SsoProvider).WithMany(p => p.SsoDomains)
                .HasForeignKey(d => d.SsoProviderId)
                .HasConstraintName("sso_domains_sso_provider_id_fkey");
        });

        modelBuilder.Entity<SsoProvider>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("sso_providers_pkey");

            entity.ToTable("sso_providers", "auth", tb => tb.HasComment("Auth: Manages SSO identity provider information; see saml_providers for SAML."));

            entity.HasIndex(e => e.ResourceId, "sso_providers_resource_id_pattern_idx").HasOperators(new[] { "text_pattern_ops" });

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.Disabled).HasColumnName("disabled");
            entity.Property(e => e.ResourceId)
                .HasComment("Auth: Uniquely identifies a SSO provider according to a user-chosen resource ID (case insensitive), useful in infrastructure as code.")
                .HasColumnName("resource_id");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
        });

        modelBuilder.Entity<Subscription>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pk_subscription");

            entity.ToTable("subscription", "realtime");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.ActionFilter)
                .HasDefaultValueSql("'*'::text")
                .HasColumnName("action_filter");
            entity.Property(e => e.Claims)
                .HasColumnType("jsonb")
                .HasColumnName("claims");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("timezone('utc'::text, now())")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("created_at");
            entity.Property(e => e.SubscriptionId).HasColumnName("subscription_id");
        });

        modelBuilder.Entity<Subscription1>(entity =>
        {
            entity.HasKey(e => e.SubSubscriptionsId).HasName("Subscriptions_pkey");

            entity.ToTable("Subscriptions");

            entity.HasIndex(e => e.EndDate, "IX_Subscriptions_EndDate");

            entity.HasIndex(e => e.SubPlanSubscriptionPlansId, "IX_Subscriptions_SubscriptionPlansId");

            entity.HasIndex(e => new { e.UsrUserId, e.Status }, "IX_Subscriptions_UserId_Status");

            entity.Property(e => e.SubSubscriptionsId)
                .HasDefaultValueSql("gen_random_uuid()")
                .HasColumnName("sub_SubscriptionsId");
            entity.Property(e => e.AutoRenew).HasDefaultValue(false);
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("now()");
            entity.Property(e => e.PaymentReference).HasMaxLength(200);
            entity.Property(e => e.Status).HasComment("Enum SubscriptionStatus: 0=Active, 1=Expired, 2=Cancelled");
            entity.Property(e => e.SubPlanSubscriptionPlansId).HasColumnName("subPlan_SubscriptionPlansId");
            entity.Property(e => e.UsrUserId).HasColumnName("usr_UserId");

            entity.HasOne(d => d.SubPlanSubscriptionPlans).WithMany(p => p.Subscription1s)
                .HasForeignKey(d => d.SubPlanSubscriptionPlansId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Subscriptions_subPlan_SubscriptionPlansId_fkey");

            entity.HasOne(d => d.UsrUser).WithMany(p => p.Subscription1s)
                .HasForeignKey(d => d.UsrUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Subscriptions_usr_UserId_fkey");
        });

        modelBuilder.Entity<SubscriptionPlan>(entity =>
        {
            entity.HasKey(e => e.SubPlanSubscriptionPlansId).HasName("SubscriptionPlans_pkey");

            entity.HasIndex(e => e.IsActive, "IX_SubscriptionPlans_IsActive");

            entity.HasIndex(e => e.TargetRole, "IX_SubscriptionPlans_TargetRole");

            entity.Property(e => e.SubPlanSubscriptionPlansId)
                .HasDefaultValueSql("gen_random_uuid()")
                .HasColumnName("subPlan_SubscriptionPlansId");
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("now()");
            entity.Property(e => e.Currency)
                .HasMaxLength(5)
                .HasDefaultValueSql("'VND'::character varying");
            entity.Property(e => e.Features).HasColumnType("jsonb");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.NameVi).HasMaxLength(200);
            entity.Property(e => e.Price).HasPrecision(18, 2);
            entity.Property(e => e.SortOrder).HasDefaultValue(0);
            entity.Property(e => e.TargetRole).HasComment("Enum UserRole: 0=Client, 1=Freelancer, NULL=Both");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UsrUserId).HasName("Users_pkey");

            entity.HasIndex(e => e.IsActive, "IX_Users_IsActive");

            entity.HasIndex(e => e.Role, "IX_Users_Role");

            entity.Property(e => e.UsrUserId)
                .HasDefaultValueSql("gen_random_uuid()")
                .HasColumnName("usr_UserId");
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("now()");
            entity.Property(e => e.FullName).HasMaxLength(200);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.IsEmailVerified).HasDefaultValue(false);
            entity.Property(e => e.PhoneNumber).HasMaxLength(20);
            entity.Property(e => e.PreferredLanguage)
                .HasMaxLength(5)
                .HasDefaultValueSql("'vi'::character varying");
            entity.Property(e => e.Role).HasComment("Enum UserRole: 0=Client, 1=Freelancer, 2=Admin");
        });

        modelBuilder.Entity<User1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("users_pkey");

            entity.ToTable("users", "auth", tb => tb.HasComment("Auth: Stores user login data within a secure schema."));

            entity.HasIndex(e => e.ConfirmationToken, "confirmation_token_idx")
                .IsUnique()
                .HasFilter("((confirmation_token)::text !~ '^[0-9 ]*$'::text)");

            entity.HasIndex(e => e.EmailChangeTokenCurrent, "email_change_token_current_idx")
                .IsUnique()
                .HasFilter("((email_change_token_current)::text !~ '^[0-9 ]*$'::text)");

            entity.HasIndex(e => e.EmailChangeTokenNew, "email_change_token_new_idx")
                .IsUnique()
                .HasFilter("((email_change_token_new)::text !~ '^[0-9 ]*$'::text)");

            entity.HasIndex(e => e.CreatedAt, "idx_users_created_at_desc").IsDescending();

            entity.HasIndex(e => e.Email, "idx_users_email");

            entity.HasIndex(e => e.LastSignInAt, "idx_users_last_sign_in_at_desc").IsDescending();

            entity.HasIndex(e => e.ReauthenticationToken, "reauthentication_token_idx")
                .IsUnique()
                .HasFilter("((reauthentication_token)::text !~ '^[0-9 ]*$'::text)");

            entity.HasIndex(e => e.RecoveryToken, "recovery_token_idx")
                .IsUnique()
                .HasFilter("((recovery_token)::text !~ '^[0-9 ]*$'::text)");

            entity.HasIndex(e => e.Email, "users_email_partial_key")
                .IsUnique()
                .HasFilter("(is_sso_user = false)");

            entity.HasIndex(e => e.InstanceId, "users_instance_id_idx");

            entity.HasIndex(e => e.IsAnonymous, "users_is_anonymous_idx");

            entity.HasIndex(e => e.Phone, "users_phone_key").IsUnique();

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Aud)
                .HasMaxLength(255)
                .HasColumnName("aud");
            entity.Property(e => e.BannedUntil).HasColumnName("banned_until");
            entity.Property(e => e.ConfirmationSentAt).HasColumnName("confirmation_sent_at");
            entity.Property(e => e.ConfirmationToken)
                .HasMaxLength(255)
                .HasColumnName("confirmation_token");
            entity.Property(e => e.ConfirmedAt)
                .HasComputedColumnSql("LEAST(email_confirmed_at, phone_confirmed_at)", true)
                .HasColumnName("confirmed_at");
            entity.Property(e => e.CreatedAt).HasColumnName("created_at");
            entity.Property(e => e.DeletedAt).HasColumnName("deleted_at");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("email");
            entity.Property(e => e.EmailChange)
                .HasMaxLength(255)
                .HasColumnName("email_change");
            entity.Property(e => e.EmailChangeConfirmStatus)
                .HasDefaultValue((short)0)
                .HasColumnName("email_change_confirm_status");
            entity.Property(e => e.EmailChangeSentAt).HasColumnName("email_change_sent_at");
            entity.Property(e => e.EmailChangeTokenCurrent)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("email_change_token_current");
            entity.Property(e => e.EmailChangeTokenNew)
                .HasMaxLength(255)
                .HasColumnName("email_change_token_new");
            entity.Property(e => e.EmailConfirmedAt).HasColumnName("email_confirmed_at");
            entity.Property(e => e.EncryptedPassword)
                .HasMaxLength(255)
                .HasColumnName("encrypted_password");
            entity.Property(e => e.InstanceId).HasColumnName("instance_id");
            entity.Property(e => e.InvitedAt).HasColumnName("invited_at");
            entity.Property(e => e.IsAnonymous)
                .HasDefaultValue(false)
                .HasColumnName("is_anonymous");
            entity.Property(e => e.IsSsoUser)
                .HasDefaultValue(false)
                .HasComment("Auth: Set this column to true when the account comes from SSO. These accounts can have duplicate emails.")
                .HasColumnName("is_sso_user");
            entity.Property(e => e.IsSuperAdmin).HasColumnName("is_super_admin");
            entity.Property(e => e.LastSignInAt).HasColumnName("last_sign_in_at");
            entity.Property(e => e.Phone)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("phone");
            entity.Property(e => e.PhoneChange)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("phone_change");
            entity.Property(e => e.PhoneChangeSentAt).HasColumnName("phone_change_sent_at");
            entity.Property(e => e.PhoneChangeToken)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("phone_change_token");
            entity.Property(e => e.PhoneConfirmedAt).HasColumnName("phone_confirmed_at");
            entity.Property(e => e.RawAppMetaData)
                .HasColumnType("jsonb")
                .HasColumnName("raw_app_meta_data");
            entity.Property(e => e.RawUserMetaData)
                .HasColumnType("jsonb")
                .HasColumnName("raw_user_meta_data");
            entity.Property(e => e.ReauthenticationSentAt).HasColumnName("reauthentication_sent_at");
            entity.Property(e => e.ReauthenticationToken)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("reauthentication_token");
            entity.Property(e => e.RecoverySentAt).HasColumnName("recovery_sent_at");
            entity.Property(e => e.RecoveryToken)
                .HasMaxLength(255)
                .HasColumnName("recovery_token");
            entity.Property(e => e.Role)
                .HasMaxLength(255)
                .HasColumnName("role");
            entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
        });

        modelBuilder.Entity<VectorIndex>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("vector_indexes_pkey");

            entity.ToTable("vector_indexes", "storage");

            entity.HasIndex(e => new { e.Name, e.BucketId }, "vector_indexes_name_bucket_id_idx")
                .IsUnique()
                .UseCollation(new[] { "C", null });

            entity.Property(e => e.Id)
                .HasDefaultValueSql("gen_random_uuid()")
                .HasColumnName("id");
            entity.Property(e => e.BucketId).HasColumnName("bucket_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.DataType).HasColumnName("data_type");
            entity.Property(e => e.Dimension).HasColumnName("dimension");
            entity.Property(e => e.DistanceMetric).HasColumnName("distance_metric");
            entity.Property(e => e.MetadataConfiguration)
                .HasColumnType("jsonb")
                .HasColumnName("metadata_configuration");
            entity.Property(e => e.Name)
                .UseCollation("C")
                .HasColumnName("name");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("updated_at");

            entity.HasOne(d => d.Bucket).WithMany(p => p.VectorIndices)
                .HasForeignKey(d => d.BucketId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("vector_indexes_bucket_id_fkey");
        });

        modelBuilder.Entity<WebauthnChallenge>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("webauthn_challenges_pkey");

            entity.ToTable("webauthn_challenges", "auth");

            entity.HasIndex(e => e.ExpiresAt, "webauthn_challenges_expires_at_idx");

            entity.HasIndex(e => e.UserId, "webauthn_challenges_user_id_idx");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("gen_random_uuid()")
                .HasColumnName("id");
            entity.Property(e => e.ChallengeType).HasColumnName("challenge_type");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.ExpiresAt).HasColumnName("expires_at");
            entity.Property(e => e.SessionData)
                .HasColumnType("jsonb")
                .HasColumnName("session_data");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.User).WithMany(p => p.WebauthnChallenges)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("webauthn_challenges_user_id_fkey");
        });

        modelBuilder.Entity<WebauthnCredential>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("webauthn_credentials_pkey");

            entity.ToTable("webauthn_credentials", "auth");

            entity.HasIndex(e => e.CredentialId, "webauthn_credentials_credential_id_key").IsUnique();

            entity.HasIndex(e => e.UserId, "webauthn_credentials_user_id_idx");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("gen_random_uuid()")
                .HasColumnName("id");
            entity.Property(e => e.Aaguid).HasColumnName("aaguid");
            entity.Property(e => e.AttestationType)
                .HasDefaultValueSql("''::text")
                .HasColumnName("attestation_type");
            entity.Property(e => e.BackedUp)
                .HasDefaultValue(false)
                .HasColumnName("backed_up");
            entity.Property(e => e.BackupEligible)
                .HasDefaultValue(false)
                .HasColumnName("backup_eligible");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("created_at");
            entity.Property(e => e.CredentialId).HasColumnName("credential_id");
            entity.Property(e => e.FriendlyName)
                .HasDefaultValueSql("''::text")
                .HasColumnName("friendly_name");
            entity.Property(e => e.LastUsedAt).HasColumnName("last_used_at");
            entity.Property(e => e.PublicKey).HasColumnName("public_key");
            entity.Property(e => e.SignCount)
                .HasDefaultValue(0L)
                .HasColumnName("sign_count");
            entity.Property(e => e.Transports)
                .HasDefaultValueSql("'[]'::jsonb")
                .HasColumnType("jsonb")
                .HasColumnName("transports");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("now()")
                .HasColumnName("updated_at");
            entity.Property(e => e.UserId).HasColumnName("user_id");

            entity.HasOne(d => d.User).WithMany(p => p.WebauthnCredentials)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("webauthn_credentials_user_id_fkey");
        });

        modelBuilder.Entity<WorkExperience>(entity =>
        {
            entity.HasKey(e => e.WeWorkExperiencesId).HasName("WorkExperiences_pkey");

            entity.HasIndex(e => e.FlFreelancerId, "IX_WorkExperiences_FreelancerId");

            entity.Property(e => e.WeWorkExperiencesId)
                .HasDefaultValueSql("gen_random_uuid()")
                .HasColumnName("we_WorkExperiencesId");
            entity.Property(e => e.CompanyName).HasMaxLength(300);
            entity.Property(e => e.FlFreelancerId).HasColumnName("fl_FreelancerId");
            entity.Property(e => e.IsCurrentJob).HasDefaultValue(false);
            entity.Property(e => e.Title).HasMaxLength(300);

            entity.HasOne(d => d.FlFreelancer).WithMany(p => p.WorkExperiences)
                .HasForeignKey(d => d.FlFreelancerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("WorkExperiences_fl_FreelancerId_fkey");
        });
        modelBuilder.HasSequence<int>("seq_schema_version", "graphql").IsCyclic();

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
