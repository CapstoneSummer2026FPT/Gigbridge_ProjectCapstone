using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class FixVariableID : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "fl_FreelancerId",
                table: "WorkExperiences",
                newName: "FreelancerId");

            migrationBuilder.RenameColumn(
                name: "we_WorkExperiencesId",
                table: "WorkExperiences",
                newName: "WorkExperiencesId");

            migrationBuilder.RenameColumn(
                name: "usr_UserId",
                table: "Users",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "usr_UserId",
                table: "Subscriptions",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "subPlan_SubscriptionPlansId",
                table: "Subscriptions",
                newName: "SubscriptionPlansId");

            migrationBuilder.RenameColumn(
                name: "sub_SubscriptionsId",
                table: "Subscriptions",
                newName: "SubscriptionsId");

            migrationBuilder.RenameColumn(
                name: "subPlan_SubscriptionPlansId",
                table: "SubscriptionPlans",
                newName: "SubscriptionPlansId");

            migrationBuilder.RenameColumn(
                name: "cate_CategoriesId",
                table: "Skills",
                newName: "CategoriesId");

            migrationBuilder.RenameColumn(
                name: "sk_SkillsId",
                table: "Skills",
                newName: "SkillsId");

            migrationBuilder.RenameColumn(
                name: "usr_UserId",
                table: "SavedJobs",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "jp_JobPostsId",
                table: "SavedJobs",
                newName: "JobPostsId");

            migrationBuilder.RenameColumn(
                name: "sj_SavedJobsId",
                table: "SavedJobs",
                newName: "SavedJobsId");

            migrationBuilder.RenameColumn(
                name: "usr_UserId",
                table: "SavedFreelancers",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "flPro_FreelancerProfilesId",
                table: "SavedFreelancers",
                newName: "FreelancerProfilesId");

            migrationBuilder.RenameColumn(
                name: "sf_SavedFreelancersId",
                table: "SavedFreelancers",
                newName: "SavedFreelancersId");

            migrationBuilder.RenameColumn(
                name: "usr_ReviewerId",
                table: "Reviews",
                newName: "ReviewerId");

            migrationBuilder.RenameColumn(
                name: "usr_RevieweeId",
                table: "Reviews",
                newName: "RevieweeId");

            migrationBuilder.RenameColumn(
                name: "cont_ContractsId",
                table: "Reviews",
                newName: "ContractsId");

            migrationBuilder.RenameColumn(
                name: "rev_ReviewsId",
                table: "Reviews",
                newName: "ReviewsId");

            migrationBuilder.RenameColumn(
                name: "usr_ReporterId",
                table: "Reports",
                newName: "ReporterId");

            migrationBuilder.RenameColumn(
                name: "rpt_ReportsId",
                table: "Reports",
                newName: "ReportsId");

            migrationBuilder.RenameColumn(
                name: "usr_UserId",
                table: "RefreshTokens",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "rt_Id",
                table: "RefreshTokens",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "jp_JobPostsId",
                table: "Proposals",
                newName: "JobPostsId");

            migrationBuilder.RenameColumn(
                name: "flPro_FreelancerProfilesId",
                table: "Proposals",
                newName: "FreelancerProfilesId");

            migrationBuilder.RenameColumn(
                name: "propo_ProposalsId",
                table: "Proposals",
                newName: "ProposalsId");

            migrationBuilder.RenameColumn(
                name: "propo_ProposalsId",
                table: "ProposalAttachments",
                newName: "ProposalsId");

            migrationBuilder.RenameColumn(
                name: "propoAttach_ProposalAttachmentsId",
                table: "ProposalAttachments",
                newName: "ProposalAttachmentsId");

            migrationBuilder.RenameColumn(
                name: "fl_FreelancerId",
                table: "PortfolioItems",
                newName: "FreelancerId");

            migrationBuilder.RenameColumn(
                name: "pi_PortfolioItemsId",
                table: "PortfolioItems",
                newName: "PortfolioItemsId");

            migrationBuilder.RenameColumn(
                name: "ps_PlatformSettingsId",
                table: "PlatformSettings",
                newName: "PlatformSettingsId");

            migrationBuilder.RenameColumn(
                name: "usr_UploadedById",
                table: "PaymentProofs",
                newName: "UploadedById");

            migrationBuilder.RenameColumn(
                name: "mStone_MilestonesId",
                table: "PaymentProofs",
                newName: "MilestonesId");

            migrationBuilder.RenameColumn(
                name: "pp_PaymentProofsId",
                table: "PaymentProofs",
                newName: "PaymentProofsId");

            migrationBuilder.RenameColumn(
                name: "usr_UserId",
                table: "Notifications",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "noti_NotificationsId",
                table: "Notifications",
                newName: "NotificationsId");

            migrationBuilder.RenameColumn(
                name: "cont_ContractsId",
                table: "Milestones",
                newName: "ContractsId");

            migrationBuilder.RenameColumn(
                name: "mStone_MilestonesId",
                table: "Milestones",
                newName: "MilestonesId");

            migrationBuilder.RenameColumn(
                name: "mStone_MilestonesId",
                table: "MilestoneAttachments",
                newName: "MilestonesId");

            migrationBuilder.RenameColumn(
                name: "mStoneAttach_MilestoneAttachmentsId",
                table: "MilestoneAttachments",
                newName: "MilestoneAttachmentsId");

            migrationBuilder.RenameColumn(
                name: "usr_SenderId",
                table: "Messages",
                newName: "SenderId");

            migrationBuilder.RenameColumn(
                name: "conv_ConversationsId",
                table: "Messages",
                newName: "ConversationsId");

            migrationBuilder.RenameColumn(
                name: "msg_MessagesId",
                table: "Messages",
                newName: "MessagesId");

            migrationBuilder.RenameColumn(
                name: "msg_MessagesId",
                table: "MessageAttachments",
                newName: "MessagesId");

            migrationBuilder.RenameColumn(
                name: "msgAttach_MessageAttachmentsId",
                table: "MessageAttachments",
                newName: "MessageAttachmentsId");

            migrationBuilder.RenameColumn(
                name: "sk_SkillsId",
                table: "JobPostSkills",
                newName: "SkillsId");

            migrationBuilder.RenameColumn(
                name: "jp_JobPostsId",
                table: "JobPostSkills",
                newName: "JobPostsId");

            migrationBuilder.RenameColumn(
                name: "jpSkill_JobPostSkillsId",
                table: "JobPostSkills",
                newName: "JobPostSkillsId");

            migrationBuilder.RenameColumn(
                name: "clPro_ClientProfilesId",
                table: "JobPosts",
                newName: "ClientProfilesId");

            migrationBuilder.RenameColumn(
                name: "jp_JobPostsId",
                table: "JobPosts",
                newName: "JobPostsId");

            migrationBuilder.RenameColumn(
                name: "jp_JobPostsId",
                table: "JobPostAttachments",
                newName: "JobPostsId");

            migrationBuilder.RenameColumn(
                name: "jpAttach_JobPostAttachmentsId",
                table: "JobPostAttachments",
                newName: "JobPostAttachmentsId");

            migrationBuilder.RenameColumn(
                name: "sk_SkillsId",
                table: "FreelancerSkills",
                newName: "SkillsId");

            migrationBuilder.RenameColumn(
                name: "fl_FreelancerId",
                table: "FreelancerSkills",
                newName: "FreelancerId");

            migrationBuilder.RenameColumn(
                name: "fSkill_FreelancerSkillsId",
                table: "FreelancerSkills",
                newName: "FreelancerSkillsId");

            migrationBuilder.RenameColumn(
                name: "usr_UserId",
                table: "FreelancerProfiles",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "flPro_FreelancerProfilesId",
                table: "FreelancerProfiles",
                newName: "FreelancerProfilesId");

            migrationBuilder.RenameColumn(
                name: "faqCat_FAQCategoriesId",
                table: "FAQs",
                newName: "FAQCategoriesId");

            migrationBuilder.RenameColumn(
                name: "faq_FAQsId",
                table: "FAQs",
                newName: "FAQsId");

            migrationBuilder.RenameColumn(
                name: "faqCat_FAQCategoriesId",
                table: "FAQCategories",
                newName: "FAQCategoriesId");

            migrationBuilder.RenameColumn(
                name: "eTpl_ESignTemplatesId",
                table: "ESignTemplates",
                newName: "ESignTemplatesId");

            migrationBuilder.RenameColumn(
                name: "usr_UserId",
                table: "ESignSignatures",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "eDoc_ESignDocumentsId",
                table: "ESignSignatures",
                newName: "ESignDocumentsId");

            migrationBuilder.RenameColumn(
                name: "eSig_ESignSignaturesId",
                table: "ESignSignatures",
                newName: "ESignSignaturesId");

            migrationBuilder.RenameColumn(
                name: "jp_JobPostsId",
                table: "ESignDocuments",
                newName: "JobPostsId");

            migrationBuilder.RenameColumn(
                name: "eTpl_ESignTemplatesId",
                table: "ESignDocuments",
                newName: "ESignTemplatesId");

            migrationBuilder.RenameColumn(
                name: "cont_ContractsId",
                table: "ESignDocuments",
                newName: "ContractsId");

            migrationBuilder.RenameColumn(
                name: "eDoc_ESignDocumentsId",
                table: "ESignDocuments",
                newName: "ESignDocumentsId");

            migrationBuilder.Sql(@"DO $$ BEGIN IF EXISTS 
                (SELECT 1 FROM pg_indexes 
                    WHERE indexname = 'IX_ESignDocuments_eTpl_ESignTemplatesId') 
                    THEN ALTER INDEX ""IX_ESignDocuments_eTpl_ESignTemplatesId"" 
                    RENAME TO ""IX_ESignDocuments_ESignTemplatesId""; 
                    END IF; END $$;");

            migrationBuilder.RenameColumn(
                name: "usr_UserId",
                table: "ESignAuditTrails",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "eDoc_ESignDocumentsId",
                table: "ESignAuditTrails",
                newName: "ESignDocumentsId");

            migrationBuilder.RenameColumn(
                name: "eAudit_ESignAuditTrailsId",
                table: "ESignAuditTrails",
                newName: "ESignAuditTrailsId");

            migrationBuilder.RenameColumn(
                name: "fl_FreelancerId",
                table: "Educations",
                newName: "FreelancerId");

            migrationBuilder.RenameColumn(
                name: "e_EducationsId",
                table: "Educations",
                newName: "EducationsId");

            migrationBuilder.RenameColumn(
                name: "usr_InitiatorId",
                table: "Disputes",
                newName: "InitiatorId");

            migrationBuilder.RenameColumn(
                name: "mStone_MilestonesId",
                table: "Disputes",
                newName: "MilestonesId");

            migrationBuilder.RenameColumn(
                name: "cont_ContractsId",
                table: "Disputes",
                newName: "ContractsId");

            migrationBuilder.RenameColumn(
                name: "disp_DisputesId",
                table: "Disputes",
                newName: "DisputesId");

            migrationBuilder.Sql(@"DO $$ BEGIN IF EXISTS (SELECT 1 FROM pg_indexes WHERE indexname = 'IX_Disputes_mStone_MilestonesId') THEN ALTER INDEX ""IX_Disputes_mStone_MilestonesId"" RENAME TO ""IX_Disputes_MilestonesId""; END IF; END $$;");
            migrationBuilder.RenameColumn(
                name: "usr_SenderId",
                table: "DisputeMessages",
                newName: "SenderId");

            migrationBuilder.RenameColumn(
                name: "disp_DisputesId",
                table: "DisputeMessages",
                newName: "DisputesId");

            migrationBuilder.RenameColumn(
                name: "dispMsg_DisputeMessagesId",
                table: "DisputeMessages",
                newName: "DisputeMessagesId");

            migrationBuilder.Sql(@"DO $$ BEGIN IF EXISTS (SELECT 1 FROM pg_indexes WHERE indexname = 'IX_DisputeMessages_usr_SenderId') THEN ALTER INDEX ""IX_DisputeMessages_usr_SenderId"" RENAME TO ""IX_DisputeMessages_SenderId""; END IF; END $$;");
            migrationBuilder.RenameColumn(
                name: "usr_UploadedById",
                table: "DisputeEvidence",
                newName: "UploadedById");

            migrationBuilder.RenameColumn(
                name: "disp_DisputesId",
                table: "DisputeEvidence",
                newName: "DisputesId");

            migrationBuilder.RenameColumn(
                name: "dispEv_DisputeEvidenceId",
                table: "DisputeEvidence",
                newName: "DisputeEvidenceId");

            migrationBuilder.Sql(@"DO $$ BEGIN IF EXISTS (SELECT 1 FROM pg_indexes WHERE indexname = 'IX_DisputeEvidence_usr_UploadedById') THEN ALTER INDEX ""IX_DisputeEvidence_usr_UploadedById"" RENAME TO ""IX_DisputeEvidence_UploadedById""; END IF; END $$;");

            migrationBuilder.RenameColumn(
                name: "usr_User2Id",
                table: "Conversations",
                newName: "User2Id");

            migrationBuilder.RenameColumn(
                name: "usr_User1Id",
                table: "Conversations",
                newName: "User1Id");

            migrationBuilder.RenameColumn(
                name: "cont_ContractsId",
                table: "Conversations",
                newName: "ContractsId");

            migrationBuilder.RenameColumn(
                name: "conv_ConversationsId",
                table: "Conversations",
                newName: "ConversationsId");

            migrationBuilder.RenameColumn(
                name: "propo_ProposalsId",
                table: "Contracts",
                newName: "ProposalsId");

            migrationBuilder.RenameColumn(
                name: "jp_JobPostsId",
                table: "Contracts",
                newName: "JobPostsId");

            migrationBuilder.RenameColumn(
                name: "flPro_FreelancerProfilesId",
                table: "Contracts",
                newName: "FreelancerProfilesId");

            migrationBuilder.RenameColumn(
                name: "clPro_ClientProfilesId",
                table: "Contracts",
                newName: "ClientProfilesId");

            migrationBuilder.RenameColumn(
                name: "cont_ContractsId",
                table: "Contracts",
                newName: "ContractsId");

            migrationBuilder.RenameColumn(
                name: "usr_UserId",
                table: "ClientProfiles",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "clPro_ClientProfilesId",
                table: "ClientProfiles",
                newName: "ClientProfilesId");

            migrationBuilder.RenameColumn(
                name: "fl_FreelancerId",
                table: "Certifications",
                newName: "FreelancerId");

            migrationBuilder.RenameColumn(
                name: "cer_CertificationsId",
                table: "Certifications",
                newName: "CertificationsId");

            migrationBuilder.RenameColumn(
                name: "cate_CategoriesId",
                table: "Categories",
                newName: "CategoriesId");

            migrationBuilder.RenameColumn(
                name: "aiSess_AIConversationSessionsId",
                table: "AIMessages",
                newName: "AIConversationSessionsId");

            migrationBuilder.RenameColumn(
                name: "aiMsg_AIMessagesId",
                table: "AIMessages",
                newName: "AIMessagesId");

            migrationBuilder.RenameColumn(
                name: "propo_ProposalsId",
                table: "AIInterviewSessions",
                newName: "ProposalsId");

            migrationBuilder.RenameColumn(
                name: "jp_JobPostsId",
                table: "AIInterviewSessions",
                newName: "JobPostsId");

            migrationBuilder.RenameColumn(
                name: "flPro_FreelancerProfilesId",
                table: "AIInterviewSessions",
                newName: "FreelancerProfilesId");

            migrationBuilder.RenameColumn(
                name: "clPro_ClientProfilesId",
                table: "AIInterviewSessions",
                newName: "ClientProfilesId");

            migrationBuilder.RenameColumn(
                name: "aiIntv_AIInterviewSessionsId",
                table: "AIInterviewSessions",
                newName: "AIInterviewSessionsId");

            migrationBuilder.Sql(@"DO $$ BEGIN IF EXISTS (SELECT 1 FROM pg_indexes WHERE indexname = 'IX_AIInterviewSessions_propo_ProposalsId') THEN ALTER INDEX ""IX_AIInterviewSessions_propo_ProposalsId"" RENAME TO ""IX_AIInterviewSessions_ProposalsId""; END IF; END $$;");

            migrationBuilder.Sql(@"DO $$ BEGIN IF EXISTS (SELECT 1 FROM pg_indexes WHERE indexname = 'IX_AIInterviewSessions_clPro_ClientProfilesId') THEN ALTER INDEX ""IX_AIInterviewSessions_clPro_ClientProfilesId"" RENAME TO ""IX_AIInterviewSessions_ClientProfilesId""; END IF; END $$;");

            migrationBuilder.RenameColumn(
                name: "aiIntv_AIInterviewSessionsId",
                table: "AIInterviewQuestions",
                newName: "AIInterviewSessionsId");

            migrationBuilder.RenameColumn(
                name: "aiQ_AIInterviewQuestionsId",
                table: "AIInterviewQuestions",
                newName: "AIInterviewQuestionsId");

            migrationBuilder.RenameColumn(
                name: "usr_UserId",
                table: "AIConversationSessions",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "jp_JobPostsId",
                table: "AIConversationSessions",
                newName: "JobPostsId");

            migrationBuilder.RenameColumn(
                name: "cont_ContractsId",
                table: "AIConversationSessions",
                newName: "ContractsId");

            migrationBuilder.RenameColumn(
                name: "aiSess_AIConversationSessionsId",
                table: "AIConversationSessions",
                newName: "AIConversationSessionsId");

            migrationBuilder.Sql(@"DO $$ BEGIN IF EXISTS (SELECT 1 FROM pg_indexes WHERE indexname = 'IX_AIConversationSessions_jp_JobPostsId') THEN ALTER INDEX ""IX_AIConversationSessions_jp_JobPostsId"" RENAME TO ""IX_AIConversationSessions_JobPostsId""; END IF; END $$;");

            migrationBuilder.RenameColumn(
                name: "usr_AdminId",
                table: "AdminAuditLogs",
                newName: "AdminId");

            migrationBuilder.RenameColumn(
                name: "aal_AdminAuditLogsId",
                table: "AdminAuditLogs",
                newName: "AdminAuditLogsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FreelancerId",
                table: "WorkExperiences",
                newName: "fl_FreelancerId");

            migrationBuilder.RenameColumn(
                name: "WorkExperiencesId",
                table: "WorkExperiences",
                newName: "we_WorkExperiencesId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Users",
                newName: "usr_UserId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Subscriptions",
                newName: "usr_UserId");

            migrationBuilder.RenameColumn(
                name: "SubscriptionPlansId",
                table: "Subscriptions",
                newName: "subPlan_SubscriptionPlansId");

            migrationBuilder.RenameColumn(
                name: "SubscriptionsId",
                table: "Subscriptions",
                newName: "sub_SubscriptionsId");

            migrationBuilder.RenameColumn(
                name: "SubscriptionPlansId",
                table: "SubscriptionPlans",
                newName: "subPlan_SubscriptionPlansId");

            migrationBuilder.RenameColumn(
                name: "CategoriesId",
                table: "Skills",
                newName: "cate_CategoriesId");

            migrationBuilder.RenameColumn(
                name: "SkillsId",
                table: "Skills",
                newName: "sk_SkillsId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "SavedJobs",
                newName: "usr_UserId");

            migrationBuilder.RenameColumn(
                name: "JobPostsId",
                table: "SavedJobs",
                newName: "jp_JobPostsId");

            migrationBuilder.RenameColumn(
                name: "SavedJobsId",
                table: "SavedJobs",
                newName: "sj_SavedJobsId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "SavedFreelancers",
                newName: "usr_UserId");

            migrationBuilder.RenameColumn(
                name: "FreelancerProfilesId",
                table: "SavedFreelancers",
                newName: "flPro_FreelancerProfilesId");

            migrationBuilder.RenameColumn(
                name: "SavedFreelancersId",
                table: "SavedFreelancers",
                newName: "sf_SavedFreelancersId");

            migrationBuilder.RenameColumn(
                name: "ReviewerId",
                table: "Reviews",
                newName: "usr_ReviewerId");

            migrationBuilder.RenameColumn(
                name: "RevieweeId",
                table: "Reviews",
                newName: "usr_RevieweeId");

            migrationBuilder.RenameColumn(
                name: "ContractsId",
                table: "Reviews",
                newName: "cont_ContractsId");

            migrationBuilder.RenameColumn(
                name: "ReviewsId",
                table: "Reviews",
                newName: "rev_ReviewsId");

            migrationBuilder.RenameColumn(
                name: "ReporterId",
                table: "Reports",
                newName: "usr_ReporterId");

            migrationBuilder.RenameColumn(
                name: "ReportsId",
                table: "Reports",
                newName: "rpt_ReportsId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "RefreshTokens",
                newName: "usr_UserId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "RefreshTokens",
                newName: "rt_Id");

            migrationBuilder.RenameColumn(
                name: "JobPostsId",
                table: "Proposals",
                newName: "jp_JobPostsId");

            migrationBuilder.RenameColumn(
                name: "FreelancerProfilesId",
                table: "Proposals",
                newName: "flPro_FreelancerProfilesId");

            migrationBuilder.RenameColumn(
                name: "ProposalsId",
                table: "Proposals",
                newName: "propo_ProposalsId");

            migrationBuilder.RenameColumn(
                name: "ProposalsId",
                table: "ProposalAttachments",
                newName: "propo_ProposalsId");

            migrationBuilder.RenameColumn(
                name: "ProposalAttachmentsId",
                table: "ProposalAttachments",
                newName: "propoAttach_ProposalAttachmentsId");

            migrationBuilder.RenameColumn(
                name: "FreelancerId",
                table: "PortfolioItems",
                newName: "fl_FreelancerId");

            migrationBuilder.RenameColumn(
                name: "PortfolioItemsId",
                table: "PortfolioItems",
                newName: "pi_PortfolioItemsId");

            migrationBuilder.RenameColumn(
                name: "PlatformSettingsId",
                table: "PlatformSettings",
                newName: "ps_PlatformSettingsId");

            migrationBuilder.RenameColumn(
                name: "UploadedById",
                table: "PaymentProofs",
                newName: "usr_UploadedById");

            migrationBuilder.RenameColumn(
                name: "MilestonesId",
                table: "PaymentProofs",
                newName: "mStone_MilestonesId");

            migrationBuilder.RenameColumn(
                name: "PaymentProofsId",
                table: "PaymentProofs",
                newName: "pp_PaymentProofsId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Notifications",
                newName: "usr_UserId");

            migrationBuilder.RenameColumn(
                name: "NotificationsId",
                table: "Notifications",
                newName: "noti_NotificationsId");

            migrationBuilder.RenameColumn(
                name: "ContractsId",
                table: "Milestones",
                newName: "cont_ContractsId");

            migrationBuilder.RenameColumn(
                name: "MilestonesId",
                table: "Milestones",
                newName: "mStone_MilestonesId");

            migrationBuilder.RenameColumn(
                name: "MilestonesId",
                table: "MilestoneAttachments",
                newName: "mStone_MilestonesId");

            migrationBuilder.RenameColumn(
                name: "MilestoneAttachmentsId",
                table: "MilestoneAttachments",
                newName: "mStoneAttach_MilestoneAttachmentsId");

            migrationBuilder.RenameColumn(
                name: "SenderId",
                table: "Messages",
                newName: "usr_SenderId");

            migrationBuilder.RenameColumn(
                name: "ConversationsId",
                table: "Messages",
                newName: "conv_ConversationsId");

            migrationBuilder.RenameColumn(
                name: "MessagesId",
                table: "Messages",
                newName: "msg_MessagesId");

            migrationBuilder.RenameColumn(
                name: "MessagesId",
                table: "MessageAttachments",
                newName: "msg_MessagesId");

            migrationBuilder.RenameColumn(
                name: "MessageAttachmentsId",
                table: "MessageAttachments",
                newName: "msgAttach_MessageAttachmentsId");

            migrationBuilder.RenameColumn(
                name: "SkillsId",
                table: "JobPostSkills",
                newName: "sk_SkillsId");

            migrationBuilder.RenameColumn(
                name: "JobPostsId",
                table: "JobPostSkills",
                newName: "jp_JobPostsId");

            migrationBuilder.RenameColumn(
                name: "JobPostSkillsId",
                table: "JobPostSkills",
                newName: "jpSkill_JobPostSkillsId");

            migrationBuilder.RenameColumn(
                name: "ClientProfilesId",
                table: "JobPosts",
                newName: "clPro_ClientProfilesId");

            migrationBuilder.RenameColumn(
                name: "JobPostsId",
                table: "JobPosts",
                newName: "jp_JobPostsId");

            migrationBuilder.RenameColumn(
                name: "JobPostsId",
                table: "JobPostAttachments",
                newName: "jp_JobPostsId");

            migrationBuilder.RenameColumn(
                name: "JobPostAttachmentsId",
                table: "JobPostAttachments",
                newName: "jpAttach_JobPostAttachmentsId");

            migrationBuilder.RenameColumn(
                name: "SkillsId",
                table: "FreelancerSkills",
                newName: "sk_SkillsId");

            migrationBuilder.RenameColumn(
                name: "FreelancerId",
                table: "FreelancerSkills",
                newName: "fl_FreelancerId");

            migrationBuilder.RenameColumn(
                name: "FreelancerSkillsId",
                table: "FreelancerSkills",
                newName: "fSkill_FreelancerSkillsId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "FreelancerProfiles",
                newName: "usr_UserId");

            migrationBuilder.RenameColumn(
                name: "FreelancerProfilesId",
                table: "FreelancerProfiles",
                newName: "flPro_FreelancerProfilesId");

            migrationBuilder.RenameColumn(
                name: "FAQCategoriesId",
                table: "FAQs",
                newName: "faqCat_FAQCategoriesId");

            migrationBuilder.RenameColumn(
                name: "FAQsId",
                table: "FAQs",
                newName: "faq_FAQsId");

            migrationBuilder.RenameColumn(
                name: "FAQCategoriesId",
                table: "FAQCategories",
                newName: "faqCat_FAQCategoriesId");

            migrationBuilder.RenameColumn(
                name: "ESignTemplatesId",
                table: "ESignTemplates",
                newName: "eTpl_ESignTemplatesId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "ESignSignatures",
                newName: "usr_UserId");

            migrationBuilder.RenameColumn(
                name: "ESignDocumentsId",
                table: "ESignSignatures",
                newName: "eDoc_ESignDocumentsId");

            migrationBuilder.RenameColumn(
                name: "ESignSignaturesId",
                table: "ESignSignatures",
                newName: "eSig_ESignSignaturesId");

            migrationBuilder.RenameColumn(
                name: "JobPostsId",
                table: "ESignDocuments",
                newName: "jp_JobPostsId");

            migrationBuilder.RenameColumn(
                name: "ESignTemplatesId",
                table: "ESignDocuments",
                newName: "eTpl_ESignTemplatesId");

            migrationBuilder.RenameColumn(
                name: "ContractsId",
                table: "ESignDocuments",
                newName: "cont_ContractsId");

            migrationBuilder.RenameColumn(
                name: "ESignDocumentsId",
                table: "ESignDocuments",
                newName: "eDoc_ESignDocumentsId");

            migrationBuilder.RenameIndex(
                name: "IX_ESignDocuments_ESignTemplatesId",
                table: "ESignDocuments",
                newName: "IX_ESignDocuments_eTpl_ESignTemplatesId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "ESignAuditTrails",
                newName: "usr_UserId");

            migrationBuilder.RenameColumn(
                name: "ESignDocumentsId",
                table: "ESignAuditTrails",
                newName: "eDoc_ESignDocumentsId");

            migrationBuilder.RenameColumn(
                name: "ESignAuditTrailsId",
                table: "ESignAuditTrails",
                newName: "eAudit_ESignAuditTrailsId");

            migrationBuilder.RenameColumn(
                name: "FreelancerId",
                table: "Educations",
                newName: "fl_FreelancerId");

            migrationBuilder.RenameColumn(
                name: "EducationsId",
                table: "Educations",
                newName: "e_EducationsId");

            migrationBuilder.RenameColumn(
                name: "MilestonesId",
                table: "Disputes",
                newName: "mStone_MilestonesId");

            migrationBuilder.RenameColumn(
                name: "InitiatorId",
                table: "Disputes",
                newName: "usr_InitiatorId");

            migrationBuilder.RenameColumn(
                name: "ContractsId",
                table: "Disputes",
                newName: "cont_ContractsId");

            migrationBuilder.RenameColumn(
                name: "DisputesId",
                table: "Disputes",
                newName: "disp_DisputesId");

            migrationBuilder.RenameIndex(
                name: "IX_Disputes_MilestonesId",
                table: "Disputes",
                newName: "IX_Disputes_mStone_MilestonesId");

            migrationBuilder.RenameColumn(
                name: "SenderId",
                table: "DisputeMessages",
                newName: "usr_SenderId");

            migrationBuilder.RenameColumn(
                name: "DisputesId",
                table: "DisputeMessages",
                newName: "disp_DisputesId");

            migrationBuilder.RenameColumn(
                name: "DisputeMessagesId",
                table: "DisputeMessages",
                newName: "dispMsg_DisputeMessagesId");

            migrationBuilder.RenameIndex(
                name: "IX_DisputeMessages_SenderId",
                table: "DisputeMessages",
                newName: "IX_DisputeMessages_usr_SenderId");

            migrationBuilder.RenameColumn(
                name: "UploadedById",
                table: "DisputeEvidence",
                newName: "usr_UploadedById");

            migrationBuilder.RenameColumn(
                name: "DisputesId",
                table: "DisputeEvidence",
                newName: "disp_DisputesId");

            migrationBuilder.RenameColumn(
                name: "DisputeEvidenceId",
                table: "DisputeEvidence",
                newName: "dispEv_DisputeEvidenceId");

            migrationBuilder.RenameIndex(
                name: "IX_DisputeEvidence_UploadedById",
                table: "DisputeEvidence",
                newName: "IX_DisputeEvidence_usr_UploadedById");

            migrationBuilder.RenameColumn(
                name: "User2Id",
                table: "Conversations",
                newName: "usr_User2Id");

            migrationBuilder.RenameColumn(
                name: "User1Id",
                table: "Conversations",
                newName: "usr_User1Id");

            migrationBuilder.RenameColumn(
                name: "ContractsId",
                table: "Conversations",
                newName: "cont_ContractsId");

            migrationBuilder.RenameColumn(
                name: "ConversationsId",
                table: "Conversations",
                newName: "conv_ConversationsId");

            migrationBuilder.RenameColumn(
                name: "ProposalsId",
                table: "Contracts",
                newName: "propo_ProposalsId");

            migrationBuilder.RenameColumn(
                name: "JobPostsId",
                table: "Contracts",
                newName: "jp_JobPostsId");

            migrationBuilder.RenameColumn(
                name: "FreelancerProfilesId",
                table: "Contracts",
                newName: "flPro_FreelancerProfilesId");

            migrationBuilder.RenameColumn(
                name: "ClientProfilesId",
                table: "Contracts",
                newName: "clPro_ClientProfilesId");

            migrationBuilder.RenameColumn(
                name: "ContractsId",
                table: "Contracts",
                newName: "cont_ContractsId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "ClientProfiles",
                newName: "usr_UserId");

            migrationBuilder.RenameColumn(
                name: "ClientProfilesId",
                table: "ClientProfiles",
                newName: "clPro_ClientProfilesId");

            migrationBuilder.RenameColumn(
                name: "FreelancerId",
                table: "Certifications",
                newName: "fl_FreelancerId");

            migrationBuilder.RenameColumn(
                name: "CertificationsId",
                table: "Certifications",
                newName: "cer_CertificationsId");

            migrationBuilder.RenameColumn(
                name: "CategoriesId",
                table: "Categories",
                newName: "cate_CategoriesId");

            migrationBuilder.RenameColumn(
                name: "AIConversationSessionsId",
                table: "AIMessages",
                newName: "aiSess_AIConversationSessionsId");

            migrationBuilder.RenameColumn(
                name: "AIMessagesId",
                table: "AIMessages",
                newName: "aiMsg_AIMessagesId");

            migrationBuilder.RenameColumn(
                name: "ProposalsId",
                table: "AIInterviewSessions",
                newName: "propo_ProposalsId");

            migrationBuilder.RenameColumn(
                name: "JobPostsId",
                table: "AIInterviewSessions",
                newName: "jp_JobPostsId");

            migrationBuilder.RenameColumn(
                name: "FreelancerProfilesId",
                table: "AIInterviewSessions",
                newName: "flPro_FreelancerProfilesId");

            migrationBuilder.RenameColumn(
                name: "ClientProfilesId",
                table: "AIInterviewSessions",
                newName: "clPro_ClientProfilesId");

            migrationBuilder.RenameColumn(
                name: "AIInterviewSessionsId",
                table: "AIInterviewSessions",
                newName: "aiIntv_AIInterviewSessionsId");

            migrationBuilder.RenameIndex(
                name: "IX_AIInterviewSessions_ProposalsId",
                table: "AIInterviewSessions",
                newName: "IX_AIInterviewSessions_propo_ProposalsId");

            migrationBuilder.RenameIndex(
                name: "IX_AIInterviewSessions_ClientProfilesId",
                table: "AIInterviewSessions",
                newName: "IX_AIInterviewSessions_clPro_ClientProfilesId");

            migrationBuilder.RenameColumn(
                name: "AIInterviewSessionsId",
                table: "AIInterviewQuestions",
                newName: "aiIntv_AIInterviewSessionsId");

            migrationBuilder.RenameColumn(
                name: "AIInterviewQuestionsId",
                table: "AIInterviewQuestions",
                newName: "aiQ_AIInterviewQuestionsId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "AIConversationSessions",
                newName: "usr_UserId");

            migrationBuilder.RenameColumn(
                name: "JobPostsId",
                table: "AIConversationSessions",
                newName: "jp_JobPostsId");

            migrationBuilder.RenameColumn(
                name: "ContractsId",
                table: "AIConversationSessions",
                newName: "cont_ContractsId");

            migrationBuilder.RenameColumn(
                name: "AIConversationSessionsId",
                table: "AIConversationSessions",
                newName: "aiSess_AIConversationSessionsId");

            migrationBuilder.RenameIndex(
                name: "IX_AIConversationSessions_JobPostsId",
                table: "AIConversationSessions",
                newName: "IX_AIConversationSessions_jp_JobPostsId");

            migrationBuilder.RenameColumn(
                name: "AdminId",
                table: "AdminAuditLogs",
                newName: "usr_AdminId");

            migrationBuilder.RenameColumn(
                name: "AdminAuditLogsId",
                table: "AdminAuditLogs",
                newName: "aal_AdminAuditLogsId");
        }
    }
}
