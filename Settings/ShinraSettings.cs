﻿using System.ComponentModel;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Windows.Input;
using ff14bot.Helpers;
using Newtonsoft.Json;

namespace ShinraCo.Settings
{
    #region Enums

    public enum Modes
    {
        Smart,
        Single,
        Multi
    }

    public enum Stances
    {
        Free,
        Attacker,
        Healer,
        Defender
    }

    public enum AstrologianSects
    {
        None,
        Diurnal,
        Nocturnal
    }

    public enum PaladinOaths
    {
        None,
        Shield,
        Sword
    }

    public enum SummonerPets
    {
        None,
        Garuda,
        Titan,
        Ifrit
    }

    public enum WarriorStances
    {
        None,
        Defiance,
        Deliverance
    }

    #endregion

    public class ShinraSettings : JsonSettings
    {
        [JsonIgnore]
        public static ShinraSettings Instance { get; } = new ShinraSettings("ShinraSettings");
        private ShinraSettings(string filename) : base(Path.Combine(CharacterSettingsDirectory, filename + ".json")) { }

        #region Form Settings

        [Setting]
        public Point WindowLocation { get; set; }

        #endregion

        #region Main Settings

        #region Chocobo

        [Setting, DefaultValue(true)]
        public bool SummonChocobo { get; set; }

        [Setting, DefaultValue(true)]
        public bool ChocoboStanceDance { get; set; }

        [Setting, DefaultValue(70)]
        public int ChocoboStanceDancePct { get; set; }

        [Setting, DefaultValue(Stances.Free)]
        public Stances ChocoboStance { get; set; }

        #endregion

        #region Item

        [Setting, DefaultValue(true)]
        public bool UsePotion { get; set; }

        [Setting, DefaultValue(70)]
        public int UsePotionPct { get; set; }

        #endregion

        #region Rotation

        [Setting, DefaultValue(true)]
        public bool RotationOverlay { get; set; }

        [Setting, DefaultValue(Modes.Smart)]
        public Modes RotationMode { get; set; }

        [Setting, DefaultValue(Keys.None)]
        public Keys RotationKey { get; set; }

        [Setting, DefaultValue(ModifierKeys.None)]
        public ModifierKeys RotationModKey { get; set; }

        #endregion

        #endregion

        #region Job Settings

        #region Astrologian

        #region Role

        [Setting, DefaultValue(true)]
        public bool AstrologianClericStance { get; set; }

        [Setting, DefaultValue(true)]
        public bool AstrologianProtect { get; set; }

        [Setting, DefaultValue(true)]
        public bool AstrologianEsuna { get; set; }

        [Setting, DefaultValue(true)]
        public bool AstrologianLucidDreaming { get; set; }

        [Setting, DefaultValue(true)]
        public bool AstrologianSwiftcast { get; set; }

        [Setting, DefaultValue(60)]
        public int AstrologianLucidDreamingPct { get; set; }

        #endregion

        #region AoE

        [Setting, DefaultValue(true)]
        public bool AstrologianEarthlyStar { get; set; }

        #endregion

        #region Heal

        [Setting, DefaultValue(true)]
        public bool AstrologianPartyHeal { get; set; }

        [Setting, DefaultValue(true)]
        public bool AstrologianBenefic { get; set; }

        [Setting, DefaultValue(true)]
        public bool AstrologianBeneficII { get; set; }

        [Setting, DefaultValue(true)]
        public bool AstrologianEssDignity { get; set; }

        [Setting, DefaultValue(true)]
        public bool AstrologianAspBenefic { get; set; }

        [Setting, DefaultValue(true)]
        public bool AstrologianHelios { get; set; }

        [Setting, DefaultValue(true)]
        public bool AstrologianAspHelios { get; set; }

        [Setting, DefaultValue(true)]
        public bool AstrologianAscend { get; set; }

        [Setting, DefaultValue(50)]
        public int AstrologianBeneficPct { get; set; }

        [Setting, DefaultValue(40)]
        public int AstrologianBeneficIIPct { get; set; }

        [Setting, DefaultValue(30)]
        public int AstrologianEssDignityPct { get; set; }

        [Setting, DefaultValue(70)]
        public int AstrologianAspBeneficPct { get; set; }

        [Setting, DefaultValue(60)]
        public int AstrologianHeliosPct { get; set; }

        [Setting, DefaultValue(60)]
        public int AstrologianAspHeliosPct { get; set; }

        #endregion

        #region Card

        [Setting, DefaultValue(true)]
        public bool AstrologianDraw { get; set; }

        [Setting, DefaultValue(true)]
        public bool AstrologianSleeveDraw { get; set; }

        #endregion

        #region Sect

        [Setting, DefaultValue(AstrologianSects.Diurnal)]
        public AstrologianSects AstrologianSect { get; set; }

        #endregion

        #endregion

        #region Bard

        #region Role

        [Setting, DefaultValue(true)]
        public bool BardSecondWind { get; set; }

        [Setting, DefaultValue(false)]
        public bool BardFootGraze { get; set; }

        [Setting, DefaultValue(false)]
        public bool BardLegGraze { get; set; }

        [Setting, DefaultValue(true)]
        public bool BardPeloton { get; set; }

        [Setting, DefaultValue(true)]
        public bool BardInvigorate { get; set; }

        [Setting, DefaultValue(true)]
        public bool BardTactician { get; set; }

        [Setting, DefaultValue(60)]
        public int BardSecondWindPct { get; set; }

        [Setting, DefaultValue(40)]
        public int BardInvigoratePct { get; set; }

        [Setting, DefaultValue(30)]
        public int BardTacticianPct { get; set; }

        #endregion

        #region Cooldown

        [Setting, DefaultValue(true)]
        public bool BardSongs { get; set; }

        [Setting, DefaultValue(true)]
        public bool BardSidewinder { get; set; }

        #endregion

        #region Buff

        [Setting, DefaultValue(true)]
        public bool BardRagingStrikes { get; set; }

        [Setting, DefaultValue(true)]
        public bool BardBarrage { get; set; }

        [Setting, DefaultValue(true)]
        public bool BardBattleVoice { get; set; }

        #endregion

        #endregion

        #region Dragoon

        #region Role

        [Setting, DefaultValue(true)]
        public bool DragoonSecondWind { get; set; }

        [Setting, DefaultValue(true)]
        public bool DragoonInvigorate { get; set; }

        [Setting, DefaultValue(true)]
        public bool DragoonBloodbath { get; set; }

        [Setting, DefaultValue(true)]
        public bool DragoonTrueNorth { get; set; }

        [Setting, DefaultValue(50)]
        public int DragoonSecondWindPct { get; set; }

        [Setting, DefaultValue(40)]
        public int DragoonInvigoratePct { get; set; }

        [Setting, DefaultValue(70)]
        public int DragoonBloodbathPct { get; set; }

        #endregion

        #region Cooldown

        [Setting, DefaultValue(true)]
        public bool DragoonJump { get; set; }

        [Setting, DefaultValue(true)]
        public bool DragoonSpineshatter { get; set; }

        [Setting, DefaultValue(true)]
        public bool DragoonDragonfire { get; set; }

        [Setting, DefaultValue(true)]
        public bool DragoonGeirskogul { get; set; }

        [Setting, DefaultValue(true)]
        public bool DragoonMirage { get; set; }

        #endregion

        #region Buff

        [Setting, DefaultValue(true)]
        public bool DragoonLifeSurge { get; set; }

        [Setting, DefaultValue(true)]
        public bool DragoonBloodForBlood { get; set; }

        [Setting, DefaultValue(true)]
        public bool DragoonBattleLitany { get; set; }

        [Setting, DefaultValue(true)]
        public bool DragoonBloodOfTheDragon { get; set; }

        #endregion

        #endregion

        #region Paladin

        #region Role

        [Setting, DefaultValue(true)]
        public bool PaladinRampart { get; set; }

        [Setting, DefaultValue(true)]
        public bool PaladinConvalescence { get; set; }

        [Setting, DefaultValue(true)]
        public bool PaladinAnticipation { get; set; }

        [Setting, DefaultValue(true)]
        public bool PaladinReprisal { get; set; }

        [Setting, DefaultValue(true)]
        public bool PaladinAwareness { get; set; }

        [Setting, DefaultValue(60)]
        public int PaladinRampartPct { get; set; }

        [Setting, DefaultValue(70)]
        public int PaladinConvalescencePct { get; set; }

        [Setting, DefaultValue(80)]
        public int PaladinAnticipationPct { get; set; }

        [Setting, DefaultValue(80)]
        public int PaladinAwarenessPct { get; set; }

        #endregion

        #region Damage

        [Setting, DefaultValue(true)]
        public bool PaladinGoringBlade { get; set; }

        [Setting, DefaultValue(true)]
        public bool PaladinRoyalAuthority { get; set; }

        [Setting, DefaultValue(true)]
        public bool PaladinHolySpirit { get; set; }

        #endregion

        #region AoE

        [Setting, DefaultValue(true)]
        public bool PaladinFlash { get; set; }

        [Setting, DefaultValue(true)]
        public bool PaladinTotalEclipse { get; set; }

        #endregion

        #region Cooldown

        [Setting, DefaultValue(true)]
        public bool PaladinShieldSwipe { get; set; }

        [Setting, DefaultValue(true)]
        public bool PaladinSpiritsWithin { get; set; }

        [Setting, DefaultValue(true)]
        public bool PaladinCircleOfScorn { get; set; }

        [Setting, DefaultValue(true)]
        public bool PaladinRequiescat { get; set; }

        #endregion

        #region Buff

        [Setting, DefaultValue(true)]
        public bool PaladinFightOrFlight { get; set; }

        [Setting, DefaultValue(true)]
        public bool PaladinBulwark { get; set; }

        [Setting, DefaultValue(true)]
        public bool PaladinSentinel { get; set; }

        [Setting, DefaultValue(true)]
        public bool PaladinHallowedGround { get; set; }

        [Setting, DefaultValue(true)]
        public bool PaladinSheltron { get; set; }

        [Setting, DefaultValue(60)]
        public int PaladinSentinelPct { get; set; }

        [Setting, DefaultValue(60)]
        public int PaladinBulwarkPct { get; set; }

        [Setting, DefaultValue(10)]
        public int PaladinHallowedGroundPct { get; set; }

        #endregion

        #region Heal

        [Setting, DefaultValue(true)]
        public bool PaladinClemency { get; set; }

        [Setting, DefaultValue(50)]
        public int PaladinClemencyPct { get; set; }

        #endregion

        #region Oath

        [Setting, DefaultValue(PaladinOaths.Shield)]
        public PaladinOaths PaladinOath { get; set; }

        #endregion

        #endregion

        #region Red Mage

        #region Role

        [Setting, DefaultValue(true)]
        public bool RedMageDrain { get; set; }

        [Setting, DefaultValue(true)]
        public bool RedMageLucidDreaming { get; set; }

        [Setting, DefaultValue(true)]
        public bool RedMageSwiftcast { get; set; }

        [Setting, DefaultValue(50)]
        public int RedMageDrainPct { get; set; }

        [Setting, DefaultValue(60)]
        public int RedMageLucidDreamingPct { get; set; }

        #endregion

        #region Cooldown

        [Setting, DefaultValue(true)]
        public bool RedMageCorpsACorps { get; set; }

        #endregion

        #region Buff

        [Setting, DefaultValue(true)]
        public bool RedMageEmbolden { get; set; }

        [Setting, DefaultValue(true)]
        public bool RedMageManafication { get; set; }

        #endregion

        #region Heal

        [Setting, DefaultValue(true)]
        public bool RedMageVercure { get; set; }

        [Setting, DefaultValue(50)]
        public int RedMageVercurePct { get; set; }

        #endregion

        #endregion

        #region Samurai

        #region Role

        [Setting, DefaultValue(true)]
        public bool SamuraiSecondWind { get; set; }

        [Setting, DefaultValue(true)]
        public bool SamuraiInvigorate { get; set; }

        [Setting, DefaultValue(true)]
        public bool SamuraiBloodbath { get; set; }

        [Setting, DefaultValue(true)]
        public bool SamuraiTrueNorth { get; set; }

        [Setting, DefaultValue(50)]
        public int SamuraiSecondWindPct { get; set; }

        [Setting, DefaultValue(40)]
        public int SamuraiInvigoratePct { get; set; }

        [Setting, DefaultValue(70)]
        public int SamuraiBloodbathPct { get; set; }

        #endregion

        #region DoT

        [Setting, DefaultValue(true)]
        public bool SamuraiHiganbana { get; set; }

        [Setting, DefaultValue(500000)]
        public int SamuraiHiganbanaHP { get; set; }

        #endregion

        #region Cooldown

        [Setting, DefaultValue(true)]
        public bool SamuraiGuren { get; set; }

        #endregion

        #region Buff

        [Setting, DefaultValue(true)]
        public bool SamuraiMeikyo { get; set; }

        [Setting, DefaultValue(true)]
        public bool SamuraiHagakure { get; set; }

        #endregion

        #endregion

        #region Summoner

        #region Role

        [Setting, DefaultValue(true)]
        public bool SummonerDrain { get; set; }

        [Setting, DefaultValue(true)]
        public bool SummonerLucidDreaming { get; set; }

        [Setting, DefaultValue(true)]
        public bool SummonerSwiftcast { get; set; }

        [Setting, DefaultValue(50)]
        public int SummonerDrainPct { get; set; }

        [Setting, DefaultValue(60)]
        public int SummonerLucidDreamingPct { get; set; }

        #endregion

        #region Heal

        [Setting, DefaultValue(true)]
        public bool SummonerPhysick { get; set; }

        [Setting, DefaultValue(50)]
        public int SummonerPhysickPct { get; set; }

        #endregion

        #region Pet

        [Setting, DefaultValue(SummonerPets.Garuda)]
        public SummonerPets SummonerPet { get; set; }

        #endregion

        #endregion

        #region Warrior

        #region Role

        [Setting, DefaultValue(true)]
        public bool WarriorRampart { get; set; }

        [Setting, DefaultValue(true)]
        public bool WarriorConvalescence { get; set; }

        [Setting, DefaultValue(true)]
        public bool WarriorAnticipation { get; set; }

        [Setting, DefaultValue(true)]
        public bool WarriorReprisal { get; set; }

        [Setting, DefaultValue(true)]
        public bool WarriorAwareness { get; set; }

        [Setting, DefaultValue(60)]
        public int WarriorRampartPct { get; set; }

        [Setting, DefaultValue(70)]
        public int WarriorConvalescencePct { get; set; }

        [Setting, DefaultValue(80)]
        public int WarriorAnticipationPct { get; set; }

        [Setting, DefaultValue(80)]
        public int WarriorAwarenessPct { get; set; }

        #endregion

        #region Damage

        [Setting, DefaultValue(true)]
        public bool WarriorMaim { get; set; }

        [Setting, DefaultValue(true)]
        public bool WarriorStormsPath { get; set; }

        [Setting, DefaultValue(true)]
        public bool WarriorStormsEye { get; set; }

        [Setting, DefaultValue(true)]
        public bool WarriorInnerBeast { get; set; }

        [Setting, DefaultValue(true)]
        public bool WarriorFellCleave { get; set; }

        #endregion

        #region AoE

        [Setting, DefaultValue(true)]
        public bool WarriorOverpower { get; set; }

        [Setting, DefaultValue(true)]
        public bool WarriorSteelCyclone { get; set; }

        [Setting, DefaultValue(true)]
        public bool WarriorDecimate { get; set; }

        #endregion

        #region Cooldown

        [Setting, DefaultValue(true)]
        public bool WarriorOnslaught { get; set; }

        [Setting, DefaultValue(true)]
        public bool WarriorUpheaval { get; set; }

        #endregion

        #region Buff

        [Setting, DefaultValue(true)]
        public bool WarriorBerserk { get; set; }

        [Setting, DefaultValue(true)]
        public bool WarriorThrillOfBattle { get; set; }

        [Setting, DefaultValue(true)]
        public bool WarriorUnchained { get; set; }

        [Setting, DefaultValue(true)]
        public bool WarriorVengeance { get; set; }

        [Setting, DefaultValue(true)]
        public bool WarriorInfuriate { get; set; }

        [Setting, DefaultValue(true)]
        public bool WarriorEquilibriumTP { get; set; }

        [Setting, DefaultValue(true)]
        public bool WarriorShakeItOff { get; set; }

        [Setting, DefaultValue(true)]
        public bool WarriorInnerRelease { get; set; }

        [Setting, DefaultValue(30)]
        public int WarriorThrillOfBattlePct { get; set; }

        [Setting, DefaultValue(60)]
        public int WarriorVengeancePct { get; set; }

        [Setting, DefaultValue(40)]
        public int WarriorEquilibriumTPPct { get; set; }

        #endregion

        #region Heal

        [Setting, DefaultValue(true)]
        public bool WarriorEquilibrium { get; set; }

        [Setting, DefaultValue(50)]
        public int WarriorEquilibriumPct { get; set; }

        #endregion

        #region Stance

        [Setting, DefaultValue(WarriorStances.Defiance)]
        public WarriorStances WarriorStance { get; set; }

        #endregion

        #endregion

        #endregion
    }
}