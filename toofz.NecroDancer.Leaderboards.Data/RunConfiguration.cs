﻿using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace toofz.NecroDancer.Leaderboards
{
    sealed class RunConfiguration : EntityTypeConfiguration<Run>
    {
        public RunConfiguration()
        {
            this.HasKey(c => c.RunId);
            this.Property(c => c.RunId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(32)
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(
                        new IndexAttribute { IsUnique = true }));
            this.Property(c => c.DisplayName)
                .IsRequired();
        }
    }
}
