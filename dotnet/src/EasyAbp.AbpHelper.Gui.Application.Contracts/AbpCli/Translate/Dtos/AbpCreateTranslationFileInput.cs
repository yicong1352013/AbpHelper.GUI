﻿using System;
using System.ComponentModel.DataAnnotations;
using EasyAbp.AbpHelper.Gui.Shared.Dtos;
using JetBrains.Annotations;

namespace EasyAbp.AbpHelper.Gui.AbpCli.Translate.Dtos
{
    [Serializable]
    public class AbpCreateTranslationFileInput : InputDtoWithRunningPath
    {
        [Required]
        [NotNull]
        public virtual string Culture { get; set; }
        
        [CanBeNull]
        public virtual string ReferenceCulture { get; set; }
        
        [CanBeNull]
        public virtual string Output { get; set; }
        
        public virtual bool AllValues { get; set; }

        public AbpCreateTranslationFileInput()
        {
        }

        protected AbpCreateTranslationFileInput([NotNull] string runningPath, [NotNull] string culture,
            [CanBeNull] string referenceCulture, [CanBeNull] string output, bool allValues) : base(runningPath)
        {
            Culture = culture;
            ReferenceCulture = referenceCulture;
            Output = output;
            AllValues = allValues;
        }
    }
}