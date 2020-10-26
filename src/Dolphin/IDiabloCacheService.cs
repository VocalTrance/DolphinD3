﻿using Dolphin.Enum;
using System.Drawing;

namespace Dolphin
{
    public interface IDiabloCacheService : ICacheService
    {
        void AddSkillBitmap(SkillName skillName, bool isMouse, Bitmap bitmap);

        Bitmap GetSkillBitmap(SkillName skillName, bool isMouse);
    }
}