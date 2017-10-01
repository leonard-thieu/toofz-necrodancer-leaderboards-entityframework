﻿using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace toofz.NecroDancer.Leaderboards
{
    sealed class ModeConfiguration : EntityTypeConfiguration<Mode>
    {
        public ModeConfiguration()
        {
            this.HasKey(c => c.ModeId);
            this.Property(c => c.ModeId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            this.Property(c => c.Name)
                .IsRequired();
            this.Property(c => c.DisplayName)
                .IsRequired();
        }
    }
}