﻿namespace HunterPie.Core.Client.Localization.Entity;

public record LocalizationData(
    string String,
    string Description,
    Affixation Affixation,
    short Order
);