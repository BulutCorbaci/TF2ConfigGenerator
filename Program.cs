using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.ComponentModel;
using System.Reflection;
using System.IO.Compression;
using System.Security.Principal;
using System.Diagnostics;

Console.Title = "BLT.CFG 1.0";
Console.ForegroundColor = ConsoleColor.White;

Console.WriteLine("/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-");
Console.WriteLine("/-/-/-/-/-/-/-/BulutCorbaci's Config Generator/-/-/-/-/-/-/-/-");
Console.WriteLine("/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-");
Console.WriteLine("/-/-/-/-/-/-LightWeight Local TF2 Config Generator/-/-/-/-/-/-");
Console.WriteLine("/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-");
Console.WriteLine("/-/-/-/-/-/-/-/-/-/-Generator Version v1.0/-/-/-/-/-/-/-/-/-/-");
Console.WriteLine("/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-");



//Console.WriteLine("Checking For Updates...");
//Console.WriteLine("Fetching Web Data...");
//if (File.Exists(@"C:\BLT.CFG\version.json"))
//{
//    File.Delete(@"C:\BLT.CFG\version.json");
//}
//Directory.CreateDirectory(@"C:\BLT.CFG\");
//using (WebClient wc = new WebClient())
//{
//wc.DownloadProgressChanged += wc_DownloadProgressChanged;
//wc.DownloadFileCompleted += new AsyncCompletedEventHandler(wc_DownloadComplete);
//wc.DownloadFileAsync(
// Param1 = Link of file
//new System.Uri("https://bulutcorbaci.com.tr/blt.cfg.json"),
// Param2 = Path to save
//@"C:\BLT.CFG\version.json"
//);
//}
//void wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
//{
//Console.WriteLine("Fetching Data %" + e.ProgressPercentage + " done.");
//}
//void wc_DownloadComplete(object sender, AsyncCompletedEventArgs e)
//{
//    if (!File.Exists(@"C:\BLT.CFG\blt.local.version.json"))
//    {
//        Console.WriteLine("Version File Does Not Exist Creating One");
//        StreamWriter SW = new System.IO.StreamWriter(@"C:\BLT.CFG\blt.local.version.json");
//        SW.WriteLine("000");
//        SW.Flush();77
//        SW.Close();
//        SW.Dispose();
//        SW = null;
//    }
//    Console.WriteLine("Fetching Complete");
//    int localVersion = int.Parse(File.ReadAllText(@"C:\BLT.CFG\blt.local.version.json"));
//    int remoteVersion = int.Parse(File.ReadAllText(@"C:\BLT.CFG\version.json"));

//if (localVersion < remoteVersion)
//{
//Console.WriteLine("Update Required");
//Console.WriteLine("Downloading Update " + remoteVersion);
//using (WebClient wc = new WebClient())
//{
//wc.DownloadProgressChanged += wc_DownloadProgressChanged;
//wc.DownloadFileCompleted += new AsyncCompletedEventHandler(wc_UpdateDownloadComplete);
//wc.DownloadFileAsync(
// Param1 = Link of file
//new System.Uri("https://bulutcorbaci.com.tr/blt.cfg.latest.zip"),
// Param2 = Path to save
//@"C:\BLT.CFG\latest.update.zip"
//);
//}
//}
//else if (localVersion == remoteVersion)
//{
//    Console.WriteLine("Version Up to Date");
//}
//else if (localVersion > remoteVersion)
//{
//    Console.WriteLine("Version Unknown Continuing Anyway");
//}
//}

//void wc_UpdateDownloadComplete(object sender, AsyncCompletedEventArgs e)
//{
//    WindowsIdentity identity = WindowsIdentity.GetCurrent();
//    WindowsPrincipal principal = new WindowsPrincipal(identity);
//    if (!principal.IsInRole(WindowsBuiltInRole.Administrator))
//    {
//        Console.WriteLine("Administrator Rights Needed");
//StartAsAdmin(Assembly.GetExecutingAssembly().Location);


//    }
//    if (!Directory.Exists(@"C:\Program Files (x86)\BLT.CFG\"))
//    {
//        Directory.CreateDirectory(@"C:\Program Files (x86)\BLT.CFG\");
//    }
//    if (!File.Exists(@"C:\BLT.CFG\manifest.json"))
//    {
//        Console.WriteLine("Manifest File Does Not Exist Creating One From Defaults");
//        StreamWriter SW = new System.IO.StreamWriter(@"C:\BLT.CFG\manifest.json");
//        SW.WriteLine(@"C:\Program Files (x86)\BLT.CFG\");
//        SW.Flush();
//        SW.Close();
//        SW.Dispose();
//        SW = null;
//    }

//    ZipFile.ExtractToDirectory(@"C:\BLT.CFG\latest.update.zip", File.ReadAllText(@"C:\BLT.CFG\manifest.json"));
//}
//void StartAsAdmin(string fileName)
//{
//    var proc = new Process
//    {
//        StartInfo =
//        {
//            FileName = Assembly.GetEntryAssembly().Location,
//            UseShellExecute = true,
//            Verb = "runas"
//        }
//    };
//
//    proc.Start();
//}

Console.WriteLine("Press Any Key To Start...");
Console.ReadKey();
Console.Clear();

Console.WriteLine("Select A Config Name: ");
string configName = Console.ReadLine();

Console.WriteLine("The Config Name is " + configName + ". Are you sure? (Y/n)");
string configNameSure = Console.ReadLine();


bool configNameSet = false;

if (configNameSure == "Y")
{
    Console.WriteLine("Using The Name " + configName);
    configNameSet = true;
}
else if (configNameSure == "y")
{
    Console.WriteLine("Using The Name " + configName);
    configNameSet = true;
}
else if (configNameSure == "N")
{
    Console.WriteLine("Retype A Config Name: ");
    configName = Console.ReadLine();
    configNameSet = true;
}
else if (configNameSure == "n")
{
    Console.WriteLine("Retype A Config Name: ");
    configName = Console.ReadLine();
    configNameSet = true;
}
else if (configNameSure == "")
{
    Console.WriteLine("Using The Name " + configName);
    configNameSet = true;
}
else
{
    Console.WriteLine("Retype A Config Name: ");
    configName = Console.ReadLine();
    configNameSet = true;
}

Console.Clear();

Console.WriteLine("Select A Graphic Config Type");
Console.WriteLine("1) MasterComfig");
Console.WriteLine("2) Comanglia");
Console.WriteLine("3) None");
string configGraphics = Console.ReadLine();

bool configGraphicSet = false;
string configGraphicsQuality = "";
if (configGraphics == "1")
{
    Console.WriteLine("Selected MasterComfig");
    configGraphicSet = true;
    Console.WriteLine("");
    Console.WriteLine("Select Quality");
    Console.WriteLine("1) Very Low");
    Console.WriteLine("2) Low");
    Console.WriteLine("3) Medium");
    Console.WriteLine("4) High");
    Console.WriteLine("5) Ultra");
    configGraphicsQuality = Console.ReadLine();
}
else if (configGraphics == "2")
{
    Console.WriteLine("Selected Comanglia");
    configGraphicSet = true;
    Console.WriteLine("");
    Console.WriteLine("Select Quality");
    Console.WriteLine("1) Very Low");
    Console.WriteLine("2) Medium");
    Console.WriteLine("3) Ultra");
    configGraphicsQuality = Console.ReadLine();
}
else if (configGraphics == "3")
{
    Console.WriteLine("Did Not Selected Graphic Config");
    configGraphicSet = true;

}


Console.WriteLine("Enable Fast Weapon Switch(Y/n)");
string fastWeaponSwitch = Console.ReadLine(); // hud_fastswitch

Console.WriteLine("Enable Auto-Reload(Y/n)");
string autoReload = Console.ReadLine(); // cl_autoreload

Console.WriteLine("Use Advanced Spectator Hud(y/N)");
string advancedSpectator = Console.ReadLine(); // cl_use_tournament_specgui

Console.WriteLine("Disable HTML MOTD(y/N)");
string disableHtmlMotd = Console.ReadLine(); // cl_disablehtmlmotd

Console.WriteLine("Use 3D Player Model in Hud(Y/n)");
string playerModel = Console.ReadLine(); // cl_hud_playerclass_use_playermodel

Console.WriteLine("Suicide after Class Change(Y/n)");
string dieAfterClassChange = Console.ReadLine(); // hud_classautokill

Console.WriteLine("Sniper: Rezoom After Sniper Shot(Y/n)");
string rezoomSniper = Console.ReadLine(); // cl_autorezoom

Console.WriteLine("Sniper: Hide Crosshair When Zoomed in(y/N)");
string hideCrosshair = Console.ReadLine(); // tf_hud_no_crosshair_on_scope_zoom

Console.WriteLine("Medic: Keep Healing Target with Medigun(Y/n)");
string medigunAutoHeal = Console.ReadLine(); // tf_medigun_autoheal

Console.WriteLine("Medic: Show Marker over Heal Target(y/N)");
string showMarkerOverHeal = Console.ReadLine(); // hud_medichealtargetmarker

Console.WriteLine("Spy: Concise Disguise Menu(y/N)");
string conciseDisguise = Console.ReadLine(); // tf_simple_disguise_menu

Console.WriteLine("Sniper: Ring Bell on Sniper Rifle Full Charge(y/N)");
string fullChargeBell = Console.ReadLine(); // tf_sniper_fullcharge_bell

Console.WriteLine("Remember Active Weapon Between Lives(y/N)");
string rememberActiveWeapon = Console.ReadLine(); // tf_remember_activeweapon


Console.Clear();

Console.WriteLine("Tweaks");

Console.WriteLine("Null-Cancelling Movement(Y/n/help)");
string nullCancellingScript = Console.ReadLine(); 

if (nullCancellingScript == "help")
{
    Console.WriteLine("Allows Movement Keys to Cancel Each Other Out Rather Than Overriding Each Other");
    Console.WriteLine("Null-Cancelling Movement(Y/n)");
    nullCancellingScript = Console.ReadLine();

}
else if (nullCancellingScript == "Help")
{

    Console.WriteLine("Allows Movement Keys to Cancel Each Other Out Rather Than Overriding Each Other");
    Console.WriteLine("Null-Cancelling Movement(Y/n)");
    nullCancellingScript = Console.ReadLine();

}


Console.WriteLine("Draw Viewmodels(Y/n)");
string drawViewmodels = Console.ReadLine(); // r_drawviewmodel
string minimizedViewmodels = "";
string flipViewmodels = "";

if (drawViewmodels == "y")
{
    Console.WriteLine("Draw Viewmodels as Minimized(Y/n)");
    minimizedViewmodels = Console.ReadLine(); // tf_use_min_viewmodels

    Console.WriteLine("Flip Viewmodels(y/N)");
    flipViewmodels = Console.ReadLine(); // cl_flipviewmodels
}
else if (drawViewmodels == "Y")
{
    Console.WriteLine("Draw Viewmodels as Minimized(Y/n)");
    minimizedViewmodels = Console.ReadLine(); // tf_use_min_viewmodels

    Console.WriteLine("Flip Viewmodels(y/N)");
    flipViewmodels = Console.ReadLine(); // cl_flipviewmodels
}

Console.WriteLine("Enable Damage Numbers(Y/n)");
string damageNumbers = Console.ReadLine(); // hud_combattext
string damageBatching = "";

if (damageNumbers == "y")
{
    Console.WriteLine("Enable Damage Number Batching(Y/n)");
    damageBatching = Console.ReadLine(); // hud_combattext_batching
}
else if (damageNumbers == "Y")
{
    Console.WriteLine("Enable Damage Number Batching(Y/n)");
    damageBatching = Console.ReadLine(); // hud_combattext_batching
}

Console.Clear();

Console.WriteLine("Networking - Leave empty if you dont understand");

Console.WriteLine("cl_cmdrate(66)");
string cmdRate = Console.ReadLine();

Console.WriteLine("cl_interp(0)");
string interp = Console.ReadLine();

Console.WriteLine("cl_interp_ratio(1)");
string interpRatio = Console.ReadLine();

Console.WriteLine("cl_updaterate(66)");
string updateRate = Console.ReadLine();

Console.WriteLine("rate(196608)");
string rate = Console.ReadLine();

Console.Clear();

Console.WriteLine("About To Generate Your Config");
Console.WriteLine("Write Your TF2 Folder to Continue(Leave Empty For Default)");
string tf2Folder = Console.ReadLine();
Console.WriteLine("Press Any Key to Generate your Config");
Console.ReadKey();


//////////////////////////////////////////////////////////////
/////////////////////MasterComfig Data////////////////////////
//////////////////////////////////////////////////////////////

//////////////////////////////////////////////////////////////
////////////////////MasterComfig Ultra////////////////////////
//////////////////////////////////////////////////////////////

string mcUltraAutoexec = "exec comfig/define_presets.cfg;preset=ultra;exec user/pre_comfig.cfg;exec comfig/comfig.cfg;exec user/post_comfig.cfg;preset;exec comfig/addons_setup.cfg;exec comfig/addons.cfg;modules_c;run_modules;exec comfig/addons.cfg;exec comfig/echo.cfg;autoexec_c;exec comfig/finalize.cfg";

string mcUltraMtpCfg = "VisionFilterShadersMapWhitelist{arena_badlands.bsp 1 arena_byre.bsp 1 arena_granary.bsp 1 arena_lumberyard.bsp 1 arena_offblast_final.bsp 1 arena_ravine.bsp 1 arena_sawmill.bsp 1 arena_watchtower.bsp 1 arena_well.bsp 1 cp_5gorge.bsp 1 cp_badlands.bsp 1 cp_degrootkeep.bsp 1 cp_dustbowl.bsp 1 cp_egypt_final.bsp 1 cp_fastlane.bsp 1 cp_foundry.bsp 1 cp_freight_final1.bsp 1 cp_gorge.bsp 1 cp_granary.bsp 1 cp_gravelpit.bsp 1 cp_gullywash_final1.bsp 1 cp_metalworks.bsp 1 cp_powerhouse.bsp 1 cp_process_final.bsp 1 cp_snakewater_final1.bsp 1 cp_standin_final.bsp 1 cp_steel.bsp 1 cp_sunshine.bsp 1 cp_vanguard.bsp 1 cp_well.bsp 1 cp_yukon_final.bsp 1 ctf_2fort.bsp 1 ctf_doublecross.bsp 1 ctf_foundry.bsp 1 ctf_gorge.bsp 1 ctf_hellfire.bsp 1 ctf_landfall.bsp 1 ctf_sawmill.bsp 1 ctf_thundermountain.bsp 1 ctf_turbine.bsp 1 ctf_well.bsp 1 itemtest.bsp 1 koth_badlands.bsp 1 koth_harvest_final.bsp 1 koth_highpass.bsp 1 koth_king.bsp 1 koth_lakeside_final.bsp 1 koth_sawmill.bsp 1 pass_brickyard.bsp 1 pass_timbertown.bsp 1 pl_badwater.bsp 1 pl_cactuscanyon.bsp 1 pl_frontier_final.bsp 1 pl_goldrush.bsp 1 pl_hoodoo_final.bsp 1 pl_swiftwater_final1.bsp 1 pl_thundermountain.bsp 1 plr_hightower.bsp 1 plr_nightfall_final.bsp 1 plr_pipeline.bsp 1 sd_doomsday.bsp 1 tc_hydro.bsp 1 tr_dustbowl.bsp 1 tr_target.bsp 1}";

string mcUltraProjectile1 = "net_projectiles;snapshot_buffer"; //demo medic pyro soldier
string mcUltraClass2 = "run_game_overrides";                   //all
string mcUltraDemoman3 = "class_config_demoman";
string mcUltraHitscan1 = "net_hitscan;snapshot_buffer";        //engi heavy scout sniper
string mcUltraEngineer3 = "class_config_engineer";
string mcUltraHeavy3 = "class_config_heavyweapons";
string mcUltraPyro3 = "class_config_pyro";
string mcUltraScout3 = "class_config_scout";
string mcUltraSniper3 = "class_config_sniper";
string mcUltraSoldier3 = "class_config_soldier";
string mcUltraSpy1 = "net_spy;snapshot_buffer";
string mcUltraSpy3 = "class_config_spy";
string mcUltraMedic3 = "class_config_medic";

string mcUltraPreset = @"lod=ultra
lighting=ultra
lighting_ex=high
shadows=ultra
flashlight=on
effects=ultra
water=ultra
particles=ultra
post_processing=high
pyrovision=high
romevision=on
motion_blur=off
anti_aliasing=msaa_8x
texture_filter=aniso16x
characters=ultra
decals=ultra
decals_models=high
decals_art=on
sprays=off
gibs=high
props=ultra
ragdolls=high
3dsky=on
jigglebones=force_on
textures=very_high
ropes=ultra
hud_player_model=on
outlines=high
sound=ultra
echo""Ultra preset selected""";

string mcUltraAddons = @"addon_flat-mouse
addon_lowmem
addon_no-tutorial
addon_null-movement
addon_opengl
addon_transparent-vm";

string mcUltraAddonsSetup = @"alias addon_flat-mouse
exec addons/flat-mouse.cfg
alias addon_lowmem
exec addons/lowmem.cfg
alias addon_no-tutorial
exec addons/no-tutorial.cfg
alias addon_null-movement
exec addons/null-canceling-movement.cfg
alias addon_opengl
exec addons/opengl.cfg
alias addon_transparent-vm
exec addons/transparent-viewmodels.cfg";

string mcUltraComfig = @"net_maxpacketdrop 0
cl_timeout 60
cl_smoothtime .05
hud_escort_interp .1
net_chokeloop 1
sv_lan 1
cl_localnetworkbackdoor 0
host_limitlocal 1
alias resetclass""cmd resetclass""
alias menuopen""cmd menuopen""
alias menuclosed""cmd menuclosed""
alias stop_taunt""cmd stop_taunt""
alias td_buyback""cmd td_buyback""
alias arena_changeclass""cmd arena_changeclass""
alias extendfreeze""cmd extendfreeze""
alias show_motd""cmd show_motd""
alias showroundinfo""cmd showroundinfo""
alias autoteam""cmd autoteam""
alias boo""cmd boo""
alias done_viewing_loot""cmd done_viewing_loot""
alias spectate""cmd spectate""
alias demorestart""cmd demorestart""
alias fade""cmd fade""
alias nextmap""cmd nextmap""
alias timeleft""cmd timeleft""
alias ignoremsg""cmd ignoremsg""
alias commentary_finishnode""cmd commentary_finishnode""
alias kill""cmd kill""
alias explode""cmd explode""
alias sourcetv_off""alias spec_next cmd spec_next;alias spec_prev cmd spec_prev;alias sourcetv_level echo sourcetv=off;alias sourcetv_on""
alias sourcetv_on""alias sourcetv_level echo sourcetv=on""
alias sourcetv sourcetv_on
alias interp_congestion_high""cl_interp .090909;setinfo cl_interp .090909""
alias interp_congestion_safe""cl_interp .060606;setinfo cl_interp .060606""
alias interp_congestion_low""cl_interp .030303;setinfo cl_interp .030303""
alias interp_congestion_spy""cl_interp .037499;setinfo cl_interp .037499""
alias interp_standard_high""cl_interp .045454;setinfo cl_interp .045454""
alias interp_standard_safe""cl_interp .030303;setinfo cl_interp .030303""
alias interp_standard_low""cl_interp .015151;setinfo cl_interp .015151""
alias interp_standard_spy""cl_interp .022499;setinfo cl_interp .022499""
alias interp_max_high""cl_interp .03;setinfo cl_interp .03""
alias interp_max_safe""cl_interp .02;setinfo cl_interp .02""
alias interp_max_low""cl_interp .01;setinfo cl_interp .01""
alias interp_max_spy""cl_interp .015;setinfo cl_interp .015""
alias packet_rate_congestion_aliases""alias interp_high interp_congestion_high;alias interp_safe interp_congestion_safe;alias interp_low interp_congestion_low;alias interp_spy interp_congestion_spy""
alias packet_rate_standard_aliases""alias interp_high interp_standard_high;alias interp_safe interp_standard_safe;alias interp_low interp_standard_low;alias interp_spy interp_standard_spy""
alias packet_rate_max_aliases""alias interp_high interp_max_high;alias interp_safe interp_max_safe;alias interp_low interp_max_low;alias interp_spy interp_max_spy""
alias packet_rate_congestion""cl_cmdrate 33;cl_updaterate 33;packet_rate_congestion_aliases;alias packet_rate_level echo packet_rate=congestion""
alias packet_rate_standard""cl_cmdrate 66;cl_updaterate 66;packet_rate_standard_aliases;alias packet_rate_level echo packet_rate=standard""
alias packet_rate_max""cl_cmdrate 100;cl_updaterate 100;packet_rate_max_aliases;alias packet_rate_level echo packet_rate=max""
alias packet_rate packet_rate_standard
alias snapshot_buffer_high""cl_interp_ratio 3;setinfo cl_interp_ratio 3;interp_high;alias snapshot_buffer_level echo snapshot_buffer=high""
alias snapshot_buffer_safe""cl_interp_ratio 2;setinfo cl_interp_ratio 2;interp_safe;alias snapshot_buffer_level echo snapshot_buffer=safe""
alias snapshot_buffer_low""cl_interp_ratio 1;setinfo cl_interp_ratio 1;interp_low;alias snapshot_buffer_level echo snapshot_buffer=low""
alias snapshot_buffer_auto""alias snapshot_buffer_level echo snapshot_buffer=auto""
alias snapshot_buffer_spy""cl_interp_ratio 1;setinfo cl_interp_ratio 1;interp_spy;alias snapshot_buffer_level echo snapshot_buffer=spy""
alias snapshot_buffer snapshot_buffer_safe
alias net_hitscan snapshot_buffer_safe
alias net_projectiles snapshot_buffer_low
alias net_spy snapshot_buffer_low
alias packet_size_small""net_compresspackets 1;net_compresspackets_minsize 200;net_maxroutable 512;net_maxfragments 512;alias packet_size_level echo packet_size=small""
alias packet_size_conservative""net_compresspackets 1;net_compresspackets_minsize 200;net_maxroutable 956;net_maxfragments 956;alias packet_size_level echo packet_size=conservative""
alias packet_size_saver""net_compresspackets 1;net_compresspackets_minsize 200;net_maxroutable 1200;net_maxfragments 1200;alias packet_size_level echo packet_size=saver""
alias packet_size_speed""net_compresspackets 0;net_compresspackets_minsize 4097;net_maxroutable 1200;net_maxfragments 1200;alias packet_size_level echo packet_size=speed""
alias packet_size packet_size_speed
net_maxcleartime 0
net_splitpacket_maxrate 50000
alias bandwidth_128Kbps""rate 16000;alias bandwidth_level echo bandwidth=128Kbps""
alias bandwidth_192Kbps""rate 24576;alias bandwidth_level echo bandwidth=192Kbps""
alias bandwidth_384Kbps""rate 49152;alias bandwidth_level echo bandwidth=384Kbps""
alias bandwidth_512Kbps""rate 65536;alias bandwidth_level echo bandwidth=512Kbps""
alias bandwidth_762Kbps""rate 80000;alias bandwidth_level echo bandwidth=762Kbps""
alias bandwidth_1.0Mbps""rate 131072;alias bandwidth_level echo bandwidth=1.0Mbps""
alias bandwidth_1.5Mbps""rate 196608;alias bandwidth_level echo bandwidth=1.5Mbps""
alias bandwidth_2.0Mbps""rate 262144;alias bandwidth_level echo bandwidth=2.0Mbps""
alias bandwidth_2.5Mbps""rate 327680;alias bandwidth_level echo bandwidth=2.5Mbps""
alias bandwidth_3.0Mbps""rate 393216;alias bandwidth_level echo bandwidth=3.0Mbps""
alias bandwidth_4.0Mbps""rate 524288;alias bandwidth_level echo bandwidth=4.0Mbps""
alias bandwidth_6.0Mbps""rate 786432;alias bandwidth_level echo bandwidth=6.0Mbps""
alias bandwidth_8.0Mbps""rate 1048576;alias bandwidth_level echo bandwidth=8.0Mbps""
alias bandwidth bandwidth_762Kbps
alias mm_queue_casual""quit smoking""
net_maxfilesize 64
alias download_all""cl_downloadfilter all;alias download_level echo download=all""
alias download_nosounds""cl_downloadfilter nosounds;alias download_level echo download=nosounds""
alias download_mapsonly""cl_downloadfilter mapsonly;alias download_level echo download=mapsonly""
alias download_none""cl_downloadfilter none;alias download_level echo download=none""
alias download_auto""alias download_level echo download=auto""
alias download download_auto
tf_mm_debug_level 0
sdr_spew_level 0
alias party_mode_open""tf_party_join_request_mode 0;alias party_mode_level echo party_mode=open""
alias party_mode_request""tf_party_join_request_mode 1;alias party_mode_level echo party_mode=request""
alias party_mode_invite""tf_party_join_request_mode 2;alias party_mode_level echo party_mode=invite""
alias party_mode party_mode_request
alias lod_low""r_rootlod 2;r_lod -1;alias lod_level echo lod=low""
alias lod_medium""r_rootlod 1;r_lod -1;alias lod_level echo lod=medium""
alias lod_high""r_rootlod 0;r_lod -1;alias lod_level echo lod=high""
alias lod_ultra""r_rootlod 0;r_lod 0;alias lod_level echo lod=ultra""
alias lod
r_lightcache_zbuffercache 1
mat_parallaxmap 0
mat_softwarelighting 0
r_hunkalloclightmaps 0
alias lightmaps_off""toggle mat_filterlightmaps""
alias lighting_very_low""mat_filterlightmaps 0;alias lightmaps_override lightmaps_off;r_ambientboost 0;r_lightaverage 0;r_dynamic 0;r_maxdlights 0;r_worldlightmin 999999;r_lightcache_zbuffercache 0;r_worldlights 0;mat_disable_lightwarp 1;mat_reducefillrate 1;r_rimlight 0;mat_bumpmap 0;mat_specular 0;building_cubemaps 1;alias lighting_level echo lighting=very_low""
alias lighting_low""mat_filterlightmaps 0;alias lightmaps_override lightmaps_off;r_ambientboost 0;r_lightaverage 0;r_dynamic 0;r_maxdlights 0;r_worldlightmin .0008;r_lightcache_zbuffercache 1;r_worldlights 0;mat_disable_lightwarp 1;mat_reducefillrate 1;r_rimlight 0;mat_bumpmap 0;mat_specular 0;building_cubemaps 1;alias lighting_level echo lighting=low""
alias lighting_medium""mat_filterlightmaps 1;alias lightmaps_override;r_ambientboost 0;r_lightaverage 0;r_dynamic 0;r_maxdlights 0;r_worldlightmin .0002;r_lightcache_zbuffercache 1;r_worldlights 0;mat_disable_lightwarp 1;mat_reducefillrate 1;r_rimlight 0;mat_bumpmap 1;mat_specular 1;building_cubemaps 1;alias lighting_level echo lighting=medium""
alias lighting_medium_high""mat_filterlightmaps 1;alias lightmaps_override;r_ambientboost 1;r_lightaverage 1;r_dynamic 0;r_maxdlights 0;r_worldlightmin .0002;r_lightcache_zbuffercache 1;r_worldlights 2;mat_disable_lightwarp 0;mat_reducefillrate 0;r_rimlight 0;mat_bumpmap 1;mat_specular 1;building_cubemaps 0;alias lighting_level echo lighting=medium_high""
alias lighting_high""mat_filterlightmaps 1;alias lightmaps_override;r_ambientboost 1;r_lightaverage 1;r_dynamic 1;r_maxdlights 6;r_worldlightmin .0002;r_lightcache_zbuffercache 1;r_worldlights 4;mat_disable_lightwarp 0;mat_reducefillrate 0;r_rimlight 1;mat_bumpmap 1;mat_specular 1;building_cubemaps 0;alias lighting_level echo lighting=high""
alias lighting_very_high""mat_filterlightmaps 1;alias lightmaps_override;r_ambientboost 1;r_lightaverage 1;r_dynamic 1;r_maxdlights 12;r_worldlightmin .0002;r_lightcache_zbuffercache 1;r_worldlights 4;mat_disable_lightwarp 0;mat_reducefillrate 0;r_rimlight 1;mat_bumpmap 1;mat_specular 1;building_cubemaps 0;alias lighting_level echo lighting=very_high""
alias lighting_ultra""mat_filterlightmaps 1;alias lightmaps_override;r_ambientboost 1;r_lightaverage 1;r_dynamic 1;r_maxdlights 32;r_worldlightmin .0002;r_lightcache_zbuffercache 0;r_worldlights 4;mat_disable_lightwarp 0;mat_reducefillrate 0;r_rimlight 1;mat_bumpmap 1;mat_specular 1;building_cubemaps 0;alias lighting_level echo lighting=ultra""
alias lighting
alias lighting_ex_low""mat_phong 0;alias lighting_ex_level echo lighting_ex=low""
alias lighting_ex_high""mat_phong 1;alias lighting_ex_level echo lighting_ex=high""
alias lighting_ex
r_shadowlod -2
alias shadowlod_low""r_shadowlod -2""
alias shadowlod_high""r_shadowlod 0""
alias sha_fla_support_aliases""shadows=very_low;shadows_very_low""
alias shadows_off""r_shadows 0;r_shadowrendertotexture 0;cl_blobbyshadows 1;r_shadowmaxrendered 0;nb_shadow_dist 0;alias shadowlod_override;alias sha_fla_support sha_fla_support_aliases;alias shadows_level echo shadows=off""
alias shadows_very_low""r_shadows 1;r_shadowrendertotexture 0;cl_blobbyshadows 1;r_shadowmaxrendered 0;nb_shadow_dist 0;alias shadowlod_override;alias sha_fla_support;alias shadows_level echo shadows=very_low""
alias shadows_low""r_shadows 1;r_shadowrendertotexture 0;cl_blobbyshadows 0;r_shadowmaxrendered 3;nb_shadow_dist 0;alias shadowlod_override;alias sha_fla_support;alias shadows_level echo shadows=low""
alias shadows_medium""r_shadows 1;r_shadowrendertotexture 1;cl_blobbyshadows 0;r_shadowmaxrendered 7;nb_shadow_dist 100;shadowlod_low;alias shadowlod_override shadowlod_low;alias sha_fla_support;alias shadows_level echo shadows=medium""
alias shadows_high""r_shadows 1;r_shadowrendertotexture 1;cl_blobbyshadows 0;r_shadowmaxrendered 11;nb_shadow_dist 400;shadowlod_low;alias shadowlod_override shadowlod_low;alias sha_fla_support;alias shadows_level echo shadows=high""
alias shadows_very_high""r_shadows 1;r_shadowrendertotexture 1;cl_blobbyshadows 0;r_shadowmaxrendered 23;nb_shadow_dist 1000;shadowlod_low;alias shadowlod_override shadowlod_low;alias sha_fla_support;alias shadows_level echo shadows=very_high""
alias shadows_ultra""r_shadows 1;r_shadowrendertotexture 1;cl_blobbyshadows 0;r_shadowmaxrendered 23;nb_shadow_dist 1000;shadowlod_high;alias shadowlod_override shadowlod_high;alias sha_fla_support;alias shadows_level echo shadows=ultra""
alias shadows
alias flashlight_off""mat_supportflashlight 0;r_flashlightculldepth 0;r_flashlightdepthtexture 0;r_flashlightmodels 0;r_flashlightrender 0;r_flashlightscissor 0;alias flashlight_level echo flashlight=off""
alias flashlight_on""mat_supportflashlight 1;r_flashlightculldepth 1;r_flashlightdepthtexture 1;r_flashlightmodels 1;r_flashlightrender 1;r_flashlightscissor 1;sha_fla_support;alias flashlight_level echo flashlight=on""
alias flashlight
ipc_exec_all quit smoking
alias effects_low""tracer_extra 0;r_drawtracers_firstperson 0;cl_show_splashes 0;cl_ejectbrass 0;cl_muzzleflash_dlight_1st 0;cl_drawmonitors 0;muzzleflash_light 0;cl_fasttempentcollision 1000000;alias effects_level echo effects=low""
alias effects_medium""tracer_extra 0;r_drawtracers_firstperson 1;cl_show_splashes 1;cl_ejectbrass 0;cl_muzzleflash_dlight_1st 0;cl_drawmonitors 1;muzzleflash_light 0;cl_fasttempentcollision 1000000;alias effects_level echo effects=medium""
alias effects_high""tracer_extra 1;r_drawtracers_firstperson 1;cl_show_splashes 1;cl_ejectbrass 0;cl_muzzleflash_dlight_1st 0;cl_drawmonitors 1;muzzleflash_light 0;cl_fasttempentcollision 5;alias effects_level echo effects=high""
alias effects_ultra""tracer_extra 1;r_drawtracers_firstperson 1;cl_show_splashes 1;cl_ejectbrass 1;cl_muzzleflash_dlight_1st 1;cl_drawmonitors 1;muzzleflash_light 1;cl_fasttempentcollision 0;alias effects_level echo effects=ultra""
alias effects
alias cheap_water_full""r_cheapwaterstart 0;r_cheapwaterend .1""
alias cheap_water_partial""r_cheapwaterstart 0;r_cheapwaterend 284""
alias cheap_water_minimal""r_cheapwaterstart 284;r_cheapwaterend 736""
alias cheap_water_never""r_cheapwaterstart 3000;r_cheapwaterend 3500""
alias water_very_low""r_WaterDrawReflection 0;r_waterforceexpensive 0;r_waterforcereflectentities 0;r_WaterDrawRefraction 0;cheap_water_full;alias cheap_water_override cheap_water_full;alias water_level echo water=very_low""
alias water_low""r_WaterDrawReflection 0;r_waterforceexpensive 0;r_waterforcereflectentities 0;r_WaterDrawRefraction 0;cheap_water_partial;alias cheap_water_override cheap_water_partial;alias water_level echo water=low""
alias water_medium""r_WaterDrawReflection 0;r_waterforceexpensive 0;r_waterforcereflectentities 0;r_WaterDrawRefraction 1;cheap_water_minimal;alias cheap_water_override cheap_water_minimal;alias water_level echo water=medium""
alias water_medium_high""r_WaterDrawReflection 1;r_waterforceexpensive 0;r_waterforcereflectentities 0;r_WaterDrawRefraction 1;cheap_water_minimal;alias cheap_water_override cheap_water_minimal;alias water_level echo water=medium_high""
alias water_high""r_WaterDrawReflection 1;r_waterforceexpensive 0;r_waterforcereflectentities 1;r_WaterDrawRefraction 1;cheap_water_minimal;alias cheap_water_override cheap_water_minimal;alias water_level echo water=high""
alias water_very_high""r_WaterDrawReflection 1;r_waterforceexpensive 1;r_waterforcereflectentities 1;r_WaterDrawRefraction 1;cheap_water_minimal;alias cheap_water_override cheap_water_minimal;alias water_level echo water=very_high""
alias water_ultra""r_WaterDrawReflection 1;r_waterforceexpensive 1;r_waterforcereflectentities 1;r_WaterDrawRefraction 1;cheap_water_never;alias cheap_water_override cheap_water_never;alias water_level echo water=ultra""
alias water
alias particles_very_low""tf_impactwatertimeenable 1;fx_drawimpactdebris 0;fx_drawimpactdust 0;fx_drawmetalspark 0;cl_particle_batch_mode 2;tf_particles_disable_weather 1;mat_reduceparticles 1;cl_new_impact_effects 0;r_drawflecks 0;cl_particle_retire_cost .0001;alias particles_level echo particles=very_low""
alias particles_low""tf_impactwatertimeenable 1;fx_drawimpactdebris 0;fx_drawimpactdust 0;fx_drawmetalspark 0;cl_particle_batch_mode 1;tf_particles_disable_weather 1;mat_reduceparticles 1;cl_new_impact_effects 0;r_drawflecks 0;cl_particle_retire_cost .0001;alias particles_level echo particles=low""
alias particles_medium""tf_impactwatertimeenable 1;fx_drawimpactdebris 0;fx_drawimpactdust 0;fx_drawmetalspark 0;cl_particle_batch_mode 1;tf_particles_disable_weather 1;mat_reduceparticles 1;cl_new_impact_effects 0;r_drawflecks 1;cl_particle_retire_cost .0001;alias particles_level echo particles=medium""
alias particles_high""tf_impactwatertimeenable 0;fx_drawimpactdebris 1;fx_drawimpactdust 1;fx_drawmetalspark 1;cl_particle_batch_mode 1;tf_particles_disable_weather 0;mat_reduceparticles 0;cl_new_impact_effects 0;r_drawflecks 1;cl_particle_retire_cost 0;alias particles_level echo particles=high""
alias particles_ultra""tf_impactwatertimeenable 0;fx_drawimpactdebris 1;fx_drawimpactdust 1;fx_drawmetalspark 1;cl_particle_batch_mode 0;tf_particles_disable_weather 0;mat_reduceparticles 0;cl_new_impact_effects 1;r_drawflecks 1;cl_particle_retire_cost 0;alias particles_level echo particles=ultra""
alias particles
mat_postprocess_x 1
alias post_processing_off""mat_hdr_level 0;mat_colorcorrection 0;mat_colcorrection_disableentities 1;r_bloomtintr .333;r_bloomtintg .333;r_bloomtintb .333;r_bloomtintexponent 1;alias post_processing_level echo post_processing=off""
alias post_processing_low""mat_hdr_level 0;mat_colorcorrection 1;mat_colcorrection_disableentities 0;r_bloomtintr .3;r_bloomtintg .59;r_bloomtintb .11;r_bloomtintexponent 2.2;alias post_processing_level echo post_processing=low""
alias post_processing_medium""mat_hdr_level 1;mat_colorcorrection 1;mat_colcorrection_disableentities 0;mat_bloom_scalefactor_scalar 1;r_bloomtintr .3;r_bloomtintg .59;r_bloomtintb .11;r_bloomtintexponent 2.2;alias post_processing_level echo post_processing=medium""
alias post_processing_high""mat_hdr_level 2;mat_colorcorrection 1;mat_colcorrection_disableentities 0;mat_bloom_scalefactor_scalar .75;r_bloomtintr .3;r_bloomtintg .59;r_bloomtintb .11;r_bloomtintexponent 2.2;alias post_processing_level echo post_processing=high""
alias post_processing
alias pyrovision_low""pyro_dof 0;pyro_vignette 0;alias pyrovision_level echo pyrovision=low""
alias pyrovision_medium""pyro_dof 0;pyro_vignette 1;pyro_vignette_distortion 0;alias pyrovision_level echo pyrovision=medium""
alias pyrovision_high""pyro_dof 1;pyro_vignette 2;pyro_vignette_distortion 1;alias pyrovision_level echo pyrovision=high""
alias pyrovision
alias romevision_off""tf_romevision_opt_in 0;alias romevision_level echo romevision=off""
alias romevision_on""tf_romevision_opt_in 1;alias romevision_level echo romevision=on""
alias romevision
alias motion_blur_off""mat_motion_blur_enabled 0;alias motion_blur_level echo motion_blur=off""
alias motion_blur_low""mat_motion_blur_enabled 1;mat_motion_blur_falling_intensity 0;mat_motion_blur_percent_of_screen_max 1.5;mat_motion_blur_rotation_intensity .05;mat_motion_blur_strength .5;alias motion_blur_level echo motion_blur=low""
alias motion_blur_high""mat_motion_blur_enabled 1;mat_motion_blur_falling_intensity 1;mat_motion_blur_falling_max 20;mat_motion_blur_falling_min 10;mat_motion_blur_percent_of_screen_max 2.5;mat_motion_blur_rotation_intensity .05;mat_motion_blur_strength .5;alias motion_blur_level echo motion_blur=high""
alias motion_blur
mat_software_aa_strength 0
mat_software_aa_strength_vgui 0
alias anti_aliasing_off""mat_alphacoverage 0;mat_antialias 1;alias anti_aliasing_level echo anti_aliasing=off""
alias anti_aliasing_msaa_2x""mat_alphacoverage 1;mat_antialias 2;alias anti_aliasing_level echo anti_aliasing=msaa_2x""
alias anti_aliasing_msaa_4x""mat_alphacoverage 1;mat_antialias 4;alias anti_aliasing_level echo anti_aliasing=msaa_4x""
alias anti_aliasing_msaa_8x""mat_alphacoverage 1;mat_antialias 8;alias anti_aliasing_level echo anti_aliasing=msaa_8x""
alias anti_aliasing
alias texture_filter_bilinear""mat_forceaniso 1;mat_trilinear 0;alias texture_filter_level echo texture_filter=bilinear""
alias texture_filter_trilinear""mat_forceaniso 1;mat_trilinear 1;alias texture_filter_level echo texture_filter=trilinear""
alias texture_filter_aniso2x""mat_forceaniso 2;alias texture_filter_level echo texture_filter=aniso2x""
alias texture_filter_aniso4x""mat_forceaniso 4;alias texture_filter_level echo texture_filter=aniso4x""
alias texture_filter_aniso8x""mat_forceaniso 8;alias texture_filter_level echo texture_filter=aniso8x""
alias texture_filter_aniso16x""mat_forceaniso 16;alias texture_filter_level echo texture_filter=aniso16x""
alias texture_filter
alias characters_very_low""r_flex 0;flex_rules 0;anim_3wayblend 0;r_teeth 0;flex_smooth 0;r_eyes 0;r_eyemove 0;tf_clientsideeye_lookats 0;blink_duration 0;phonemefilter .001;phonemedelay -30;phonemesnap 0;alias characters_level echo characters=very_low""
alias characters_low""r_flex 0;flex_rules 0;anim_3wayblend 0;r_teeth 0;flex_smooth 0;r_eyes 1;r_eyemove 0;tf_clientsideeye_lookats 0;blink_duration 0;phonemefilter .001;phonemedelay -30;phonemesnap 0;alias characters_level echo characters=low""
alias characters_medium""r_flex 1;flex_rules 1;anim_3wayblend 0;r_teeth 1;flex_smooth 0;r_eyes 1;r_eyemove 0;tf_clientsideeye_lookats 0;blink_duration 0;phonemefilter .001;phonemedelay -30;phonemesnap 0;alias characters_level echo characters=medium""
alias characters_medium_high""r_flex 1;flex_rules 1;anim_3wayblend 0;r_teeth 1;flex_smooth 0;r_eyes 1;r_eyemove 1;tf_clientsideeye_lookats 1;blink_duration .2;phonemefilter .08;phonemedelay 0;phonemesnap 1;alias characters_level echo characters=medium_high""
alias characters_high""r_flex 1;flex_rules 1;anim_3wayblend 1;r_teeth 1;flex_smooth 1;r_eyes 1;r_eyemove 1;tf_clientsideeye_lookats 1;blink_duration .2;phonemefilter .08;phonemedelay 0;phonemesnap 2;alias characters_level echo characters=high""
alias characters_ultra""r_flex 1;flex_rules 1;anim_3wayblend 1;r_teeth 1;flex_smooth 1;r_eyes 1;r_eyemove 1;tf_clientsideeye_lookats 1;blink_duration .2;phonemefilter .08;phonemedelay 0;phonemesnap 4;alias characters_level echo characters=ultra""
alias characters
alias decals_clear_all""r_cleardecals permanent""
alias decals_sprays_support_aliases""decals=low;decals_low""
alias decals_off""r_decals 1;mp_decals 1;r_decal_cover_count 10;r_decal_overlap_area 1.1;r_decal_overlap_count 10;r_drawbatchdecals 0;alias decals_sprays_support decals_sprays_support_aliases;alias decals_level echo decals=off""
alias decals_low""r_decals 9;mp_decals 9;r_decal_cover_count 4;r_decal_overlap_area .4;r_decal_overlap_count 3;r_drawbatchdecals 1;alias decals_sprays_support;alias decals_level echo decals=low""
alias decals_medium""r_decals 32;mp_decals 32;r_decal_cover_count 4;r_decal_overlap_area .4;r_decal_overlap_count 3;r_drawbatchdecals 1;alias decals_sprays_support;alias decals_level echo decals=decals_medium""
alias decals_high""r_decals 80;mp_decals 80;r_decal_cover_count 4;r_decal_overlap_area .4;r_decal_overlap_count 3;r_drawbatchdecals 1;alias decals_sprays_support;alias decals_level echo decals=decals_high""
alias decals_ultra""r_decals 256;mp_decals 256;r_decal_cover_count 4;r_decal_overlap_area .4;r_decal_overlap_count 3;r_drawbatchdecals 1;alias decals_sprays_support;alias decals_level echo decals=decals_ultra""
alias decals
alias decals_models_off""r_drawmodeldecals 0;alias decals_models_level echo decals_models=off""
alias decals_models_low""r_drawmodeldecals 1;r_maxmodeldecal 9;alias decals_models_level echo decals_models=low""
alias decals_models_high""r_drawmodeldecals 1;r_maxmodeldecal 32;alias decals_models_level echo decals_models=high""
alias decals_models
alias decals_art_off""r_renderoverlayfragment 0;alias decals_clear decals_clear_all;alias decals_art_level echo decals_art=off""
alias decals_art_on""r_renderoverlayfragment 1;alias decals_clear;alias decals_art_level echo decals_art=on""
alias decals_art
alias sprays_off""cl_allowdownload 0;cl_allowupload 0;r_spray_lifetime 0;cl_spraydisable 1;alias sprays_level echo sprays=off""
alias sprays_on""cl_allowdownload 1;cl_allowupload 1;r_spray_lifetime 2;cl_spraydisable 0;alias decals_clear;decals_sprays_support;alias sprays_level echo sprays=on""
alias sprays
alias sillygibs_off""violence_hgibs 1;violence_hblood 1;violence_agibs 1;violence_ablood 1;alias sillygibs_level echo sillygibs=off""
alias sillygibs_on""violence_hgibs 0;violence_hblood 0;violence_agibs 0;violence_ablood 0;alias sillygibs_level echo sillygibs=on""
alias sillygibs_auto""alias sillygibs_level echo sillygibs=auto""
alias sillygibs sillygibs_auto
alias gibs_off""cl_burninggibs 0;props_break_max_pieces 0;tf_playergib 0;sillygibs_on;sillygibs;alias gibs_level echo gibs=off""
alias gibs_low""cl_burninggibs 0;props_break_max_pieces 2;tf_playergib 1;sillygibs_off;sillygibs;alias gibs_level echo gibs=low""
alias gibs_medium_low""cl_burninggibs 0;props_break_max_pieces 4;tf_playergib 1;sillygibs_off;sillygibs;alias gibs_level echo gibs=medium_low""
alias gibs_medium""cl_burninggibs 0;props_break_max_pieces -1;tf_playergib 1;sillygibs_off;sillygibs;alias gibs_level echo gibs=medium""
alias gibs_high""cl_burninggibs 1;props_break_max_pieces -1;tf_playergib 1;sillygibs_off;sillygibs;alias gibs_level echo gibs=high""
alias gibs
alias detail_props_none""r_drawdetailprops 0;cl_detaildist 1;cl_detailfade 0""
alias detail_props_medium""r_drawdetailprops 1;cl_detaildist 1200;cl_detailfade 0""
alias detail_props_full""r_drawdetailprops 1;cl_detaildist 1200;cl_detailfade 400""
alias props_low""r_decalstaticprops 0;cl_phys_props_enable 0;r_staticprop_lod 7;r_propsmaxdist 0;lod_TransitionDist -1;detail_props_none;alias detail_props_override detail_props_none;alias props_level echo props=low""
alias props_medium""r_decalstaticprops 0;cl_phys_props_enable 0;r_staticprop_lod -1;r_propsmaxdist 0;lod_TransitionDist -1;detail_props_none;alias detail_props_override detail_props_none;alias props_level echo props=medium""
alias props_high""r_decalstaticprops 1;cl_phys_props_enable 1;r_staticprop_lod -1;r_propsmaxdist 500;lod_TransitionDist -5000;cl_phys_props_max 20;cl_phys_props_respawndist 500;cl_phys_props_respawnrate 120;detail_props_medium;alias detail_props_override detail_props_medium;alias props_level echo props=high""
alias props_ultra""r_decalstaticprops 1;cl_phys_props_enable 1;r_staticprop_lod 0;r_propsmaxdist 900;lod_TransitionDist 400;cl_phys_props_max 100;cl_phys_props_respawndist 901;cl_phys_props_respawnrate 60;detail_props_full;alias detail_props_override detail_props_full;alias props_level echo props=ultra""
alias props
alias ragdolls_hidden""cl_ragdoll_fade_time -3;cl_ragdoll_forcefade 1;cl_ragdoll_physics_enable 0;cl_ragdoll_collide 0;ragdoll_sleepaftertime 0;alias ragdolls_level echo ragdolls=hidden""
alias ragdolls_off""cl_ragdoll_fade_time -3;cl_ragdoll_forcefade 1;cl_ragdoll_physics_enable 1;cl_ragdoll_collide 0;ragdoll_sleepaftertime 0;alias ragdolls_level echo ragdolls=off""
alias ragdolls_low ragdolls_off
alias ragdolls_medium""cl_ragdoll_fade_time 5;cl_ragdoll_forcefade 0;cl_ragdoll_physics_enable 1;cl_ragdoll_collide 0;ragdoll_sleepaftertime 1.5;alias ragdolls_level echo ragdolls=medium""
alias ragdolls_high""cl_ragdoll_fade_time 10;cl_ragdoll_forcefade 0;cl_ragdoll_physics_enable 1;cl_ragdoll_collide 1;ragdoll_sleepaftertime 5;alias ragdolls_level echo ragdolls=high""
alias ragdolls
mat_viewportscale 1
alias 3dsky_off""r_3dsky 0;alias 3dsky_level echo 3dsky=off""
alias 3dsky_on""r_3dsky 1;alias 3dsky_level echo 3dsky=on""
alias 3dsky
alias jigglebones_off""cl_jiggle_bone_framerate_cutoff 0;alias jigglebones_level echo jigglesbones=off""
alias jigglebones_on""cl_jiggle_bone_framerate_cutoff 67;alias jigglebones_level echo jigglesbones=on""
alias jigglebones_force_on""cl_jiggle_bone_framerate_cutoff 1;alias jigglebones_level echo jigglesbones=force_on""
alias jigglebones
alias sheens_speed_off""tf_sheen_framerate 0;alias sheens_speed_level echo sheens_speed=off""
alias sheens_speed_slow""tf_sheen_framerate 15;alias sheens_speed_level echo sheens_speed=slow""
alias sheens_speed_medium""tf_sheen_framerate 25;alias sheens_speed_level echo sheens_speed=medium""
alias sheens_speed_fast""tf_sheen_framerate 55;alias sheens_speed_level echo sheens_speed=fast""
alias sheens_speed sheens_speed_slow
alias sheens_tint_low""tf_sheen_alpha_firstperson 0;alias sheens_tint_level echo sheens_tint=low""
alias sheens_tint_medium""tf_sheen_alpha_firstperson .1;alias sheens_tint_level echo sheens_tint=medium""
alias sheens_tint_high""tf_sheen_alpha_firstperson .5;alias sheens_tint_level echo sheens_tint=high""
alias sheens_tint_full""tf_sheen_alpha_firstperson 1;alias sheens_tint_level echo sheens_tint=full""
alias sheens_tint sheens_tint_high
alias textures_very_low""mat_filtertextures 0;mat_picmip 2;mat_disable_fancy_blending 1;alias textures_level echo textures=very_low""
alias textures_low""mat_filtertextures 1;mat_picmip 2;mat_disable_fancy_blending 1;alias textures_level echo textures=low""
alias textures_medium""mat_filtertextures 1;mat_picmip 1;mat_disable_fancy_blending 0;alias textures_level echo textures=medium""
alias textures_high""mat_filtertextures 1;mat_picmip 0;mat_disable_fancy_blending 0;alias textures_level echo textures=high""
alias textures_very_high""mat_filtertextures 1;mat_picmip -1;mat_disable_fancy_blending 0;alias textures_level echo textures=very_high""
alias textures
alias ropes_off""r_drawropes 0;rope_rendersolid 0;r_ropetranslucent 0;rope_smooth 0;rope_subdiv 0;rope_collide 0;rope_wind_dist 0;alias ropes_level echo ropes=off""
alias ropes_low""r_drawropes 1;rope_rendersolid 1;r_ropetranslucent 0;rope_smooth 0;rope_subdiv 1;rope_collide 0;rope_wind_dist 0;alias ropes_level echo ropes=low""
alias ropes_high""r_drawropes 1;rope_rendersolid 1;r_ropetranslucent 1;rope_smooth 1;rope_subdiv 2;rope_collide 0;rope_wind_dist 0;alias ropes_level echo ropes=high""
alias ropes_ultra""r_drawropes 1;rope_rendersolid 1;r_ropetranslucent 1;rope_smooth 1;rope_subdiv 7;rope_collide 1;rope_wind_dist 1000;alias ropes_level echo ropes=ultra""
alias ropes
engine_no_focus_sleep 1
r_fastzreject 1
mat_tonemapping_occlusion_use_stencil 0
r_norefresh 1
fast_fogvolume 1
mod_offline_hdr_switch 1
mat_forcemanagedtextureintohardware 0
mat_requires_rt_alloc_first 0
sys_minidumpspewlines 0
sv_logdownloadlist 0
mat_forcehardwaresync 1
mat_managedtextures 0
mat_queue_mode -1
alias mm_queue_party""quit smoking""
alias fpscap_powersaver""mat_powersavingsmode 1;alias fpscap_level echo fpscap=powersaver""
alias fpscap_30""mat_powersavingsmode 0;fps_max 30;alias fpscap_level echo fpscap=30""
alias fpscap_60""mat_powersavingsmode 0;fps_max 60;alias fpscap_level echo fpscap=60""
alias fpscap_75""mat_powersavingsmode 0;fps_max 75;alias fpscap_level echo fpscap=75""
alias fpscap_120""mat_powersavingsmode 0;fps_max 120;alias fpscap_level echo fpscap=120""
alias fpscap_144""mat_powersavingsmode 0;fps_max 144;alias fpscap_level echo fpscap=144""
alias fpscap_160""mat_powersavingsmode 0;fps_max 160;alias fpscap_level echo fpscap=160""
alias fpscap_165""mat_powersavingsmode 0;fps_max 165;alias fpscap_level echo fpscap=165""
alias fpscap_180""mat_powersavingsmode 0;fps_max 180;alias fpscap_level echo fpscap=180""
alias fpscap_200""mat_powersavingsmode 0;fps_max 200;alias fpscap_level echo fpscap=200""
alias fpscap_240""mat_powersavingsmode 0;fps_max 240;alias fpscap_level echo fpscap=240""
alias fpscap_300""mat_powersavingsmode 0;fps_max 300;alias fpscap_level echo fpscap=300""
alias fpscap_360""mat_powersavingsmode 0;fps_max 360;alias fpscap_level echo fpscap=360""
alias fpscap_400""mat_powersavingsmode 0;fps_max 400;alias fpscap_level echo fpscap=400""
alias fpscap_1000""mat_powersavingsmode 0;fps_max 1000;alias fpscap_level echo fpscap=1000""
alias fpscap_unlimited""mat_powersavingsmode 0;fps_max 0;alias fpscap_level echo fpscap=unlimited""
alias fpscap fpscap_1000
alias vsync_off""mat_vsync 0;alias vsync_level echo vsync=off""
alias vsync_on""mat_vsync 1;alias vsync_level echo vsync=on""
alias vsync vsync_off
tf_dashboard_slide_time .1
tf_item_inspect_model_auto_spin 1
tf_item_inspect_model_spin_rate 30
tf_quest_map_tuner_wobble_magnitude .01
tf_colorblindassist 1
sv_motd_unload_on_dismissal 1
tf_halloween_bonus_ducks_cooldown 20
tf_hud_num_building_alert_beeps 2
tf_hud_show_servertimelimit 1
scr_centertime 5
hud_medichealtargetmarker 1
tf_scoreboard_ping_as_text 1
alias hud_player_model_off""cl_hud_playerclass_use_playermodel 0;alias hud_player_model_level hud_player_model=off""
alias hud_player_model_on""cl_hud_playerclass_use_playermodel 1;alias hud_player_model_level hud_player_model=on""
alias hud_player_model
alias hud_panels_off""tf_healthicon_height_offset -10000;tf_hud_target_id_offset -10000;tf_hud_target_id_alpha 0;alias hud_panels_level echo hud_panels=off""
alias hud_panels_low""tf_healthicon_height_offset 10;tf_hud_target_id_offset 0;tf_hud_target_id_alpha 255;alias hud_panels_level echo hud_panels=low""
alias hud_panels_high""tf_healthicon_height_offset 10;tf_hud_target_id_offset 0;tf_hud_target_id_alpha 100;alias hud_panels_level echo hud_panels=high""
alias hud_panels hud_panels_high
alias hud_avatars_off""tf_hud_target_id_show_avatars 0;alias hud_avatars_level echo hud_avatars=off""
alias hud_avatars_everyone""tf_hud_target_id_show_avatars 1;alias hud_avatars_level echo hud_avatars=everyone""
alias hud_avatars_friends""tf_hud_target_id_show_avatars 2;alias hud_avatars_level echo hud_avatars=friends""
alias hud_avatars hud_avatars_friends
alias match_hud_alias""tf_use_match_hud 0;alias match_hud_level echo match_hud=off""
alias match_hud_alias2""alias match_hud_off match_hud_alias""
alias match_hud_off""tf_use_match_hud 1;alias match_hud_once match_hud_alias;alias match_hud_level echo match_hud=off""
alias match_hud_on""tf_use_match_hud 1;alias match_hud_once;alias match_hud_level echo match_hud=on""
alias match_hud match_hud_on
alias dynamic_background_off""alias dynamic_background_level echo dynamic_background=off""
alias dynamic_background_preload""map_background preload_room;wait 10;disconnect;alias dynamic_background_level echo dynamic_background=preload""
alias dynamic_background_itemtest""map_background itemtest;wait 10;disconnect;alias dynamic_background_level echo dynamic_background=itemtest""
alias dynamic_background_dustbowl""map_background background01;wait 1000;stop;alias dynamic_background_level echo dynamic_background=dustbowl""
alias dynamic_background dynamic_background_off
alias htmlmotd_off""cl_disablehtmlmotd 1;alias htmlmotd_level echo htmlmotd=off""
alias htmlmotd_on""cl_disablehtmlmotd 0;alias htmlmotd_level echo htmlmotd=on""
alias htmlmotd htmlmotd_off
cl_mute_all_comms 1
tf_chat_popup_hold_time 3
alias messages_off""hud_saytext_time 0;cl_enable_text_chat 0;cl_showtextmsg 0;alias messages_level echo messages=off""
alias messages_hide""hud_saytext_time 0;cl_enable_text_chat 1;cl_showtextmsg 1;alias messages_level echo messages=hide""
alias messages_on""hud_saytext_time 10;cl_enable_text_chat 1;cl_showtextmsg 1;alias messages_level echo messages=on""
alias messages messages_on
alias killfeed_off""hud_deathnotice_time 0;alias killfeed_level echo killfeed=off""
alias killfeed_on""hud_deathnotice_time 5;alias killfeed_level echo killfeed=on""
alias killfeed killfeed_on
tf_time_loading_item_panels .0005
tf_backpack_page_button_delay .25
alias killstreaks_off""cl_hud_killstreak_display_time 0;alias killstreaks_level echo killstreaks=off""
alias killstreaks_low""cl_hud_killstreak_display_alpha 255;cl_hud_killstreak_display_time 2;alias killstreaks_level echo killstreaks=low""
alias killstreaks_high""cl_hud_killstreak_display_alpha 100;cl_hud_killstreak_display_time 2;alias killstreaks_level echo killstreaks=high""
alias killstreaks killstreaks_high
cl_notifications_max_num_visible 3
cl_notifications_move_time .1
cl_notifications_show_ingame 1
cl_vote_ui_active_after_voting 1
alias hud_achievement_off""hud_achievement_description 0;hud_achievement_tracker 0;hud_achievement_count 0;hud_achievement_count_engineer 0;hud_achievement_glowtime 0;alias hud_achievement_level hud_achievement=off""
alias hud_achievement_on""hud_achievement_description 1;hud_achievement_tracker 1;hud_achievement_count 8;hud_achievement_count_engineer 3;hud_achievement_glowtime 2.5;alias hud_achievement_level hud_achievement=on""
alias hud_achievement hud_achievement_on
cl_mvm_wave_status_visible_during_wave 1
con_nprint_bgalpha 100
alias console_off""con_filter_text zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz;con_filter_enable 1;con_enable 0;alias console_level echo console=off""
alias console_on""con_filter_enable 0;con_enable 1;alias console_level echo console=on""
alias console console_on
alias console_off_flip""hideconsole;console_off;alias switchconsole console_on_flip""
alias console_on_flip""console_on;showconsole;alias switchconsole console_off_flip""
alias switchconsole console_on_flip
alias debug_output""debug_output_1""
alias debug_output_toggle""incrementvar developer -1 2 1""
alias debug_output_display""developer -1""
alias debug_output_1""developer 1""
alias debug_output_2""developer 2""
alias debug_instant_respawn""sv_cheats 1;mp_disable_respawn_times 1;spec_freeze_time 0;spec_freeze_traveltime 0;mp_respawnwavetime 0""
alias debug_invulnerable""sv_cheats 1;buddha""
alias debug_bots""tf_bot_kick all;tf_bot_quota_mode normal;tf_bot_difficulty 3;tf_bot_quota 32""
alias debug_target""sv_cheats 1;bot -targetdummy""
alias debug_occlusion""sv_cheats 1;r_visocclusion 1;r_occlusionspew 1""
alias debug_pixelvis""r_drawpixelvisibility 1;r_pixelvisibility_spew 1""
alias debug_fillrate""sv_cheats 1;mat_fillrate 1""
alias debug_matsys_reload""toggle mat_aaquality""
alias debug_sound_loads""snd_async_showmem;snd_async_spew 1;snd_async_spew_blocking 2;snd_async_stream_spew 2""
alias debug_sound_dsp""sv_cheats 1;snd_showstart 2;adsp_debug 6""
alias debug_network_packets""net_showudp 1""
alias debug_network_drops""net_showdrop 1""
alias debug_network_graph""net_graph 4""
alias debug_network_pred""cl_showerror 2""
alias debug_fps""net_graph 1""
alias debug_fps_range""cl_showfps 0;cl_showfps 2""
alias debug_vprof_log_spike""con_logfile vprof_spike.log""
alias debug_vprof_log""con_logfile vprof.log""
alias debug_vprof_spike""vprof_dump_spikes 100""
alias debug_vprof_spikes""vprof_off;vprof_reset;debug_vprof_log_spike;vprof_dump_oninterval 0;vprof_report_oninterval 0;debug_vprof_spike;vprof_on""
alias debug_vprof_dump""vprof_off;vprof_reset;debug_vprof_log;vprof_dump_oninterval 10;vprof_report_oninterval 0;vprof_dump_spikes 0;vprof_on""
alias debug_vprof_report""vprof_off;vprof_reset;debug_vprof_log;vprof_dump_oninterval 0;vprof_report_oninterval 10;vprof_dump_spikes 0;vprof_on""
alias debug_vprof_off""vprof_off;vprof_reset;con_logfile 0;vprof_dump_oninterval 0;vprof_report_oninterval 0;vprof_dump_spikes 0""
net_graphsolid 1
fov_desired 90
alias outlines_off""glow_outline_effect_enable 0;tf_enable_glows_after_respawn 0;tf_spec_xray_disable 1;alias outlines_level echo outlines=off""
alias outlines_low""glow_outline_effect_enable 0;tf_enable_glows_after_respawn 1;tf_spec_xray_disable 0;alias outlines_level echo outlines=low""
alias outlines_medium""glow_outline_effect_enable 1;tf_enable_glows_after_respawn 0;tf_spec_xray_disable 1;alias outlines_level echo outlines=medium""
alias outlines_high""glow_outline_effect_enable 1;tf_enable_glows_after_respawn 1;tf_spec_xray_disable 0;alias outlines_level echo outlines=high""
alias outlines
bugreporter_uploadasync 1
lzma_persistent_buffer 1
cl_always_flush_models 0
filesystem_buffer_size 1
filesystem_max_stdio_read 64
alias flush_models_on""cl_always_flush_models 1""
alias mod_support_off""alias flush_models flush_models_on;alias mod_support_level echo mod_support=off""
alias mod_support_on""alias flush_models;alias mod_support_level echo mod_support=on""
alias mod_support mod_support_on
tf_dingalingaling_repeat_delay .007
snd_async_fullyasync 1
snd_async_minsize 0
snd_mixahead .05
snd_delay_sound_shift .001
snd_legacy_surround 0
snd_noextraupdate 1
snd_async_spew_blocking 0
alias sound_low""snd_disable_mixer_duck 1;snd_pitchquality 0;dsp_slow_cpu 1;snd_spatialize_roundrobin 3;dsp_room 0;dsp_speaker 0;dsp_water 0;dsp_spatial 0;snd_defer_trace 1;dsp_enhance_stereo 0;alias sound_level echo sound=low""
alias sound_medium""snd_disable_mixer_duck 0;snd_pitchquality 0;dsp_slow_cpu 1;snd_spatialize_roundrobin 1;dsp_room 0;dsp_speaker 50;dsp_water 0;dsp_spatial 40;snd_defer_trace 1;dsp_enhance_stereo 0;alias sound_level echo sound=medium""
alias sound_high""snd_disable_mixer_duck 0;snd_pitchquality 1;dsp_slow_cpu 0;snd_spatialize_roundrobin 1;dsp_room 0;dsp_speaker 50;dsp_water 14;dsp_spatial 40;snd_defer_trace 1;dsp_enhance_stereo 0;alias sound_level echo sound=high""
alias sound_very_high""snd_disable_mixer_duck 0;snd_pitchquality 1;dsp_slow_cpu 0;snd_spatialize_roundrobin 0;dsp_room 0;dsp_speaker 50;dsp_water 14;dsp_spatial 40;snd_defer_trace 0;dsp_enhance_stereo 0;alias sound_level echo sound=very_high""
alias sound_ultra""snd_disable_mixer_duck 0;snd_pitchquality 1;dsp_slow_cpu 0;snd_spatialize_roundrobin 0;dsp_room 1;dsp_speaker 50;dsp_water 14;dsp_spatial 40;snd_defer_trace 0;dsp_enhance_stereo 1;alias sound_level echo sound=ultra""
alias sound
alias voice_chat_off""voice_enable 0;voice_modenable 0;cmd VModEnable 0;alias voice_chat_level echo voice_chat=off""
alias voice_chat_on""voice_enable 1;voice_modenable 1;cmd VModEnable 1;alias voice_chat_level echo voice_chat=on""
alias voice_chat voice_chat_on
detach
alias logo_off""alias logo_level echo logo=off""
alias logo_on""startlogo;alias logo_level echo logo=on""
alias logo logo_on
alias sourcetv=off""alias sourcetv sourcetv_off""
alias sourcetv=on""alias sourcetv sourcetv_on""
alias packet_rate=congestion""alias packet_rate packet_rate_congestion""
alias packet_rate=standard""alias packet_rate packet_rate_standard""
alias packet_rate=max""alias packet_rate packet_rate_max""
alias snapshot_buffer=auto""alias snapshot_buffer snapshot_buffer_auto""
alias snapshot_buffer=high""alias snapshot_buffer snapshot_buffer_high""
alias snapshot_buffer=safe""alias snapshot_buffer snapshot_buffer_safe""
alias snapshot_buffer=low""alias snapshot_buffer snapshot_buffer_low""
alias packet_size=small""alias packet_size packet_size_small""
alias packet_size=conservative""alias packet_size packet_size_conservative""
alias packet_size=saver""alias packet_size packet_size_saver""
alias packet_size=speed""alias packet_size packet_size_speed""
alias bandwidth=128Kbps""alias bandwidth bandwidth_128Kbps""
alias bandwidth=192Kbps""alias bandwidth bandwidth_192Kbps""
alias bandwidth=384Kbps""alias bandwidth bandwidth_384Kbps""
alias bandwidth=512Kbps""alias bandwidth bandwidth_512Kbps""
alias bandwidth=762Kbps""alias bandwidth bandwidth_762Kbps""
alias bandwidth=1.0Mbps""alias bandwidth bandwidth_1.0Mbps""
alias bandwidth=1.5Mbps""alias bandwidth bandwidth_1.5Mbps""
alias bandwidth=2.0Mbps""alias bandwidth bandwidth_2.0Mbps""
alias bandwidth=2.5Mbps""alias bandwidth bandwidth_2.5Mbps""
alias bandwidth=3.0Mbps""alias bandwidth bandwidth_3.0Mbps""
alias bandwidth=4.0Mbps""alias bandwidth bandwidth_4.0Mbps""
alias bandwidth=6.0Mbps""alias bandwidth bandwidth_6.0Mbps""
alias bandwidth=8.0Mbps""alias bandwidth bandwidth_8.0Mbps""
alias download=auto""alias download download_auto""
alias download=all""alias download download_all""
alias download=nosounds""alias download download_nosounds""
alias download=mapsonly""alias download download_mapsonly""
alias download=none""alias download download_none""
alias lod=low""alias lod lod_low""
alias lod=medium""alias lod lod_medium""
alias lod=high""alias lod lod_high""
alias lod=ultra""alias lod lod_ultra""
alias lighting=very_low""alias lighting lighting_very_low""
alias lighting=low""alias lighting lighting_low""
alias lighting=medium""alias lighting lighting_medium""
alias lighting=medium_high""alias lighting lighting_medium_high""
alias lighting=high""alias lighting lighting_high""
alias lighting=very_high""alias lighting lighting_very_high""
alias lighting=ultra""alias lighting lighting_ultra""
alias lighting_ex=low""alias lighting_ex lighting_ex_low""
alias lighting_ex=high""alias lighting_ex lighting_ex_high""
alias shadows=off""alias shadows shadows_off""
alias shadows=very_low""alias shadows shadows_very_low""
alias shadows=low""alias shadows shadows_low""
alias shadows=medium""alias shadows shadows_medium""
alias shadows=high""alias shadows shadows_high""
alias shadows=very_high""alias shadows shadows_very_high""
alias shadows=ultra""alias shadows shadows_ultra""
alias flashlight=off""alias flashlight flashlight=off""
alias flashlight=on""alias flashlight flashlight=on""
alias effects=low""alias effects effects_low""
alias effects=medium""alias effects effects_medium""
alias effects=high""alias effects effects_high""
alias effects=ultra""alias effects effects_ultra""
alias water=very_low""alias water water_very_low""
alias water=low""alias water water_low""
alias water=medium""alias water water_medium""
alias water=medium_high""alias water water_medium_high""
alias water=high""alias water water_high""
alias water=very_high""alias water water_very_high""
alias water=ultra""alias water water_ultra""
alias particles=very_low""alias particles particles_very_low""
alias particles=low""alias particles particles_low""
alias particles=medium""alias particles particles_medium""
alias particles=high""alias particles particles_high""
alias particles=ultra""alias particles particles_ultra""
alias post_processing=off""alias post_processing post_processing_off""
alias post_processing=low""alias post_processing post_processing_low""
alias post_processing=medium""alias post_processing post_processing_medium""
alias post_processing=high""alias post_processing post_processing_high""
alias pyrovision=low""alias pyrovision pyrovision_low""
alias pyrovision=medium""alias pyrovision pyrovision_medium""
alias pyrovision=high""alias pyrovision pyrovision_high""
alias romevision=off""alias romevision romevision_off""
alias romevision=on""alias romevision romevision_on""
alias motion_blur=off""alias motion_blur motion_blur_off""
alias motion_blur=low""alias motion_blur motion_blur_low""
alias motion_blur=high""alias motion_blur motion_blur_high""
alias anti_aliasing=off""alias anti_aliasing anti_aliasing_off""
alias anti_aliasing=msaa_2x""alias anti_aliasing anti_aliasing_msaa_2x""
alias anti_aliasing=msaa_4x""alias anti_aliasing anti_aliasing_msaa_4x""
alias anti_aliasing=msaa_8x""alias anti_aliasing anti_aliasing_msaa_8x""
alias texture_filter=bilinear""alias texture_filter texture_filter_bilinear""
alias texture_filter=trilinear""alias texture_filter texture_filter_trilinear""
alias texture_filter=aniso2x""alias texture_filter texture_filter_aniso2x""
alias texture_filter=aniso4x""alias texture_filter texture_filter_aniso4x""
alias texture_filter=aniso8x""alias texture_filter texture_filter_aniso8x""
alias texture_filter=aniso16x""alias texture_filter texture_filter_aniso16x""
alias characters=very_low""alias characters characters_very_low""
alias characters=low""alias characters characters_low""
alias characters=medium""alias characters characters_medium""
alias characters=medium_high""alias characters characters_medium_high""
alias characters=high""alias characters characters_high""
alias characters=ultra""alias characters characters_ultra""
alias decals=off""alias decals decals_off""
alias decals=low""alias decals decals_low""
alias decals=medium""alias decals decals_medium""
alias decals=high""alias decals decals_high""
alias decals=ultra""alias decals decals_ultra""
alias decals_models=off""alias decals_models decals_models_off""
alias decals_models=low""alias decals_models decals_models_low""
alias decals_models=high""alias decals_models decals_models_high""
alias decals_art=off""alias decals_art decals_art_off""
alias decals_art=on""alias decals_art decals_art_on""
alias sprays=off""alias sprays sprays_off""
alias sprays=on""alias sprays sprays_on""
alias gibs=off""alias gibs gibs_off""
alias gibs=low""alias gibs gibs_low""
alias gibs=medium_low""alias gibs gibs_medium_low""
alias gibs=medium""alias gibs gibs_medium""
alias gibs=high""alias gibs gibs_high""
alias sillygibs=auto""alias sillygibs sillygibs_auto""
alias sillygibs=off""alias sillygibs sillygibs_off""
alias sillygibs=on""alias sillygibs sillygibs_on""
alias props=low""alias props props_low""
alias props=medium""alias props props_medium""
alias props=high""alias props props_high""
alias props=ultra""alias props props_ultra""
alias ragdolls=hidden""alias ragdolls ragdolls_hidden""
alias ragdolls=off""alias ragdolls ragdolls_off""
alias ragdolls=low""alias ragdolls ragdolls_low""
alias ragdolls=medium""alias ragdolls ragdolls_medium""
alias ragdolls=high""alias ragdolls ragdolls_high""
alias 3dsky=off""alias 3dsky 3dsky_off""
alias 3dsky=on""alias 3dsky 3dsky_on""
alias jigglebones=off""alias jigglebones jigglebones_off""
alias jigglebones=on""alias jigglebones jigglebones_on""
alias jigglebones=force_on""alias jigglebones jigglebones_force_on""
alias sheens_speed=off""alias sheens_speed sheens_speed_off""
alias sheens_speed=slow""alias sheens_speed sheens_speed_slow""
alias sheens_speed=medium""alias sheens_speed sheens_speed_medium""
alias sheens_speed=fast""alias sheens_speed sheens_speed_fast""
alias sheens_tint=low""alias sheens_tint sheens_tint_low""
alias sheens_tint=medium""alias sheens_tint sheens_tint_medium""
alias sheens_tint=high""alias sheens_tint sheens_tint_high""
alias sheens_tint=full""alias sheens_tint sheens_tint_full""
alias textures=very_low""alias textures textures_very_low""
alias textures=low""alias textures textures_low""
alias textures=medium""alias textures textures_medium""
alias textures=high""alias textures textures_high""
alias textures=very_high""alias textures textures_very_high""
alias ropes=off""alias ropes ropes_off""
alias ropes=low""alias ropes ropes_low""
alias ropes=high""alias ropes ropes_high""
alias ropes=ultra""alias ropes ropes_ultra""
alias fpscap=powersaver""alias fpscap fpscap_powersaver""
alias fpscap=30""alias fpscap fpscap_30""
alias fpscap=60""alias fpscap fpscap_60""
alias fpscap=75""alias fpscap fpscap_75""
alias fpscap=120""alias fpscap fpscap_120""
alias fpscap=144""alias fpscap fpscap_144""
alias fpscap=160""alias fpscap fpscap_160""
alias fpscap=165""alias fpscap fpscap_165""
alias fpscap=180""alias fpscap fpscap_180""
alias fpscap=200""alias fpscap fpscap_200""
alias fpscap=240""alias fpscap fpscap_240""
alias fpscap=300""alias fpscap fpscap_300""
alias fpscap=360""alias fpscap fpscap_360""
alias fpscap=400""alias fpscap fpscap_400""
alias fpscap=1000""alias fpscap fpscap_1000""
alias fpscap=unlimited""alias fpscap fpscap_unlimited""
alias vsync=off""alias vsync vsync_off""
alias vsync=on""alias vsync vsync_on""
alias hud_player_model=off""alias hud_player_model hud_player_model_off""
alias hud_player_model=on""alias hud_player_model hud_player_model_on""
alias hud_panels=off""alias hud_panels hud_panels_off""
alias hud_panels=low""alias hud_panels hud_panels_low""
alias hud_panels=high""alias hud_panels hud_panels_high""
alias hud_avatars=off""alias hud_avatars hud_avatars_off""
alias hud_avatars=everyone""alias hud_avatars hud_avatars_everyone""
alias hud_avatars=friends""alias hud_avatars hud_avatars_friends""
alias match_hud=off""alias match_hud match_hud_off""
alias match_hud=on""alias match_hud match_hud_on""
alias messages=off""alias messages messages_off""
alias messages=hide""alias messages messages_hide""
alias messages=on""alias messages messages_on""
alias killfeed=off""alias killfeed killfeed_off""
alias killfeed=on""alias killfeed killfeed_on""
alias killstreaks=off""alias killstreaks killstreaks_off""
alias killstreaks=low""alias killstreaks killstreaks_low""
alias killstreaks=high""alias killstreaks killstreaks_high""
alias hud_achievement=off""alias hud_achievement hud_achievement_off""
alias hud_achievement=on""alias hud_achievement hud_achievement_on""
alias console=off""alias console console_off""
alias console=on""alias console console_on""
alias htmlmotd=off""alias htmlmotd htmlmotd_off""
alias htmlmotd=on""alias htmlmotd htmlmotd_on""
alias outlines=off""alias outlines outlines_off""
alias outlines=low""alias outlines outlines_low""
alias outlines=medium""alias outlines outlines_medium""
alias outlines=high""alias outlines outlines_high""
alias dynamic_background=off""alias dynamic_background dynamic_background_off""
alias dynamic_background=preload""alias dynamic_background dynamic_background_preload""
alias dynamic_background=itemtest""alias dynamic_background dynamic_background_itemtest""
alias dynamic_background=dustbowl""alias dynamic_background dynamic_background_dustbowl""
alias sound=low""alias sound sound_low""
alias sound=medium""alias sound sound_medium""
alias sound=high""alias sound sound_high""
alias sound=very_high""alias sound sound_very_high""
alias sound=ultra""alias sound sound_ultra""
alias voice_chat=off""alias voice_chat voice_chat_off""
alias voice_chat=on""alias voice_chat voice_chat_on""
alias mod_support=off""alias mod_support mod_support_off""
alias mod_support=on""alias mod_support mod_support_on""
alias party_mode=open""alias party_mode party_mode_open""
alias party_mode=request""alias party_mode party_mode_request""
alias party_mode=invite""alias party_mode party_mode_invite""
alias logo=off""alias logo logo_off""
alias logo=on""alias logo logo_on""
alias class_config_scout""exec user/scout.cfg""
alias class_config_soldier""exec user/soldier.cfg""
alias class_config_pyro""exec user/pyro.cfg""
alias class_config_demoman""exec user/demoman.cfg""
alias class_config_heavyweapons""exec user/heavyweapons.cfg""
alias class_config_engineer""exec user/engineer.cfg""
alias class_config_medic""exec user/medic.cfg""
alias class_config_sniper""exec user/sniper.cfg""
alias class_config_spy""exec user/spy.cfg""
alias game_overrides_c""exec user/game_overrides.cfg""
alias game_overrides_once_c
alias block_antialias""alias mat_antialias block_antialias_echo""
alias block_antialias_echo""echo This command is blocked to prevent a material system reload. If you want to change it, use the Anti-Aliasing module inside the modules.cfg file.""
alias mm_override""exec comfig/mm_override.cfg""
alias very_low_reset""exec comfig/very_low_reset.cfg""
alias modules_c""exec user/modules.cfg""
alias autoexec_c""exec user/autoexec.cfg""
alias run_modules""exec comfig/modules_run.cfg""
alias module_levels""exec comfig/module_levels.cfg""
alias apply_user""modules_c;run_modules;autoexec_c""
alias restore_preset""exec comfig/comfig.cfg;preset;run_modules""
alias restore_config""exec autoexec.cfg""
alias run_game_overrides""exec comfig/game_overrides.cfg;lightmaps_override""
alias game_overrides""cheap_water_override;detail_props_override;shadowlod_override;lightmaps_override""
alias game_overrides_once""match_hud_once;game_overrides_once_c""
block_game_overrides_once";

string mcUltraFinalize = @"mat_savechanges
block_antialias
dynamic_background";

string mcUltraGameOverrides = @"setinfo cl_predict 1
voice_steal 2
snd_soundmixer Default_Mix
decals_clear
cmd demorestart
game_overrides_once
alias block_game_overrides_once""alias game_overrides_once;match_hud_alias2"";block_game_overrides_once
game_overrides
game_overrides_c";

string mcUltraMMOverride = @"alias game_overrides
cl_blobbyshadows 0
cl_detaildist 1200
cl_detailfade 400
cl_phys_props_enable 1
cl_phys_props_max 300
cl_phys_props_respawndist 1500
cl_phys_props_respawnrate 60
dsp_room 0
filesystem_buffer_size 0
flex_rules 1
flex_smooth 1
fps_max 300
mat_alphacoverage 1
mat_bumpmap 1
mat_disable_fancy_blending 0
mat_disable_lightwarp 0
mat_filterlightmaps 1
mat_filtertextures 1
mat_phong 1
mat_reducefillrate 0
mat_reduceparticles 0
mat_specular 1
mat_supportflashlight 1
mat_trilinear 1
mp_decals 200
nb_shadow_dist 400
net_splitpacket_maxrate 80000
r_3dsky 1
r_WaterDrawReflection 1
r_WaterDrawRefraction 1
r_decal_cover_count 4
r_decal_overlap_area .4
r_decal_overlap_count 3
r_decals 2048
r_decalstaticprops 1
r_dopixelvisibility 1
r_drawbatchdecals 1
r_drawdetailprops 1
r_drawflecks 1
r_drawmodeldecals 1
r_dynamic 1
r_eyes 1
r_flashlightculldepth 1
r_flashlightdepthtexture 1
r_flashlightmodels 1
r_flashlightrender 1
r_flashlightscissor 1
r_flex 1
r_lightcache_zbuffercache 0
r_lod -1
r_maxdlights 32
r_maxmodeldecal 50
r_pixelfog 1
r_pixelvisibility_partial 1
r_shadows 1
r_staticprop_lod -1
r_teeth 1
r_worldlightmin .0002
r_worldlights 4
ragdoll_sleepaftertime 5.0f
echo""Cleaned up mastercomfig settings for use in Competitive Matchmaking""";

string mcUltraEcho = @"alias startlogo""echo""---------------|||||--------------------"";l1""
alias l1""echo""----------||||||||||--------------------"";l2""
alias l2""echo""-------||||||||-------------------------"";l3""
alias l3""echo""-----||||||-----||||||||----------------"";l4""
alias l4""echo""---|||||----||||||||||||||||------------"";l5""
alias l5""echo""--||||----|||||||------|||||||----------"";l6""
alias l6""echo""-||||---|||||--------------|||||--------"";l7""
alias l7""echo""-|||---||||------------------||||-------"";l8""
alias l8""echo""|||---||||--------------------||||------"";l9""
alias l9""echo""|||---|||----------------------|||------"";l10""
alias l10""echo""|||---|||----------------------|||---|||"";l11""
alias l11""echo""|||---|||----------------------|||---|||"";l12""
alias l12""echo""|||---||||--------------------||||---|||"";l13""
alias l13""echo""||||---||||------------------||||---||||"";l14""
alias l14""echo""|||||---|||||--------------|||||---|||||"";l15""
alias l15""echo""||||||---||||||||------|||||||----||||||"";l16""
alias l16""echo""||||||||----||||||||||||||||----||||||||"";l17""
alias l17""echo""|||--||||||-----||||||||-----||||||--|||"";l18""
alias l18""echo""|||----||||||||----------||||||||----|||"";l19""
alias l19""echo""|||-------||||||||||||||||||||-------|||"";l20""
alias l20""echo""|||-----------||||||||||||-----------|||""
alias version_comfig""echo mastercomfig version: 9.6.3 | September 20, 2021""
echo""""
echo""""
echo""""
echo""""
logo
echo""""
echo""""
echo""""
echo""""
echo""  **********************************""
echo""  **********************************""
echo""  mastercomfig 9.6.3 loaded""
echo""  September 20, 2021""
echo""  **********************************""
echo""  **********************************""
echo""""
echo""""
echo""""
echo""""
echo""  ##################################################""
echo""  This release took 2 hours to produce.""
echo""  If you like the work I do, consider supporting me!""
echo""""
echo""  docs.mastercomfig.com/page/support_me""
echo""""
echo""  I accept Ko-fi, Liberapay, and trade offers!""
echo""""
echo""  Your continued support, gratitude and dedication""
echo""  are much appreciated. Thank you so much!""
echo""  ##################################################""
echo""""
echo""""
echo""""
echo""""";

string mcUltraDefinePresets = @"alias preset_very-low""exec presets/very-low.cfg;alias preset_level echo preset=very-low""
alias preset_low""exec presets/low.cfg;alias preset_level echo preset=low""
alias preset_medium-low""exec presets/medium-low.cfg;alias preset_level echo preset=medium-low""
alias preset_medium""exec presets/medium.cfg;alias preset_level echo preset=medium""
alias preset_medium-high""exec presets/medium-high.cfg;alias preset_level echo preset=medium-high""
alias preset_high""exec presets/high.cfg;alias preset_level echo preset=high""
alias preset_ultra""exec presets/ultra.cfg;alias preset_level echo preset=ultra""
alias preset_none""alias preset_level echo preset=none""
alias preset=very-low""alias preset preset_very-low""
alias preset=low""alias preset preset_low""
alias preset=medium-low""alias preset preset_medium-low""
alias preset=medium""alias preset preset_medium""
alias preset=medium-high""alias preset preset_medium-high""
alias preset=high""alias preset preset_high""
alias preset=ultra""alias preset preset_ultra""
alias preset=none""alias preset preset_none""";

string mcUltraModuleLevels = @"preset_level
sourcetv_level
packet_rate_level
snapshot_buffer_level
packet_size_level
bandwidth_level
download_level
lod_level
lighting_level
lighting_ex_level
shadows_level
flashlight_level
effects_level
water_level
particles_level
post_processing_level
pyrovision_level
romevision_level
motion_blur_level
anti_aliasing_level
texture_filter_level
characters_level
decals_level
decals_models_level
decals_art_level
sprays_level
gibs_level
sillygibs_level
props_level
ragdolls_level
3dsky_level
jigglebones_level
sheens_speed_level
sheens_tint_level
textures_level
ropes_level
fpscap_level
vsync_level
hud_player_model_level
hud_panels_level
hud_avatars_level
match_hud_level
messages_level
killfeed_level
killstreaks_level
hud_achievement_level
console_level
htmlmotd_level
outlines_level
dynamic_background_level
sound_level
voice_chat_level
mod_support_level
party_mode_level
logo_level
move_bind_level";

string mcUltraModulesRun = @"sourcetv
packet_rate
snapshot_buffer_safe
snapshot_buffer
packet_size
bandwidth
download
lod
lighting
lighting_ex
shadows
flashlight
effects
water
particles
post_processing
pyrovision
romevision
motion_blur
anti_aliasing
texture_filter
characters
decals
decals_models
decals_art
sprays
gibs
props
ragdolls
3dsky
jigglebones
sheens_speed
sheens_tint
textures
ropes
fpscap
vsync
hud_player_model
hud_panels
hud_avatars
match_hud
messages
killfeed
killstreaks
hud_achievement
console
htmlmotd
outlines
sound
voice_chat
mod_support
party_mode
echo""Modules applied""";

string mcUltraVeryLowReset = @"cl_crosshairalpha 200
cl_hud_minmode 0
cl_show_market_data_on_items 1
cl_spec_carrieditems 1
hud_freezecamhide 0
tf_contract_competitive_show 2
tf_contract_progress_show 1
tf_hud_target_id_disable_floating_health 0
tf_simple_disguise_menu 0
tf_use_min_viewmodels 0
viewmodel_fov 54
echo""Very Low preset settings have been reset""";

string mcUltraDxSupportOverride = @"dxsupport{0{name 80 ConVar.r_drawropes 0 ConVar.mem_min_heapsize 144 ConVar.mem_max_heapsize 1024 ConVar.fx_drawimpactdebris 0 ConVar.fx_drawimpactdust 0 ConVar.fx_drawmetalspark 0 ConVar.tf_impactwatertimeenable 1 ConVar.dsp_off 0 ConVar.cl_particle_retire_cost 0 ConVar.mat_slopescaledepthbias_decal -0.5}1{name 81 ConVar.r_drawropes 0 ConVar.mem_min_heapsize 144 ConVar.mem_max_heapsize 1024 ConVar.fx_drawimpactdebris 0 ConVar.fx_drawimpactdust 0 ConVar.fx_drawmetalspark 0 ConVar.tf_impactwatertimeenable 1 ConVar.dsp_off 0 ConVar.cl_particle_retire_cost 0 ConVar.mat_slopescaledepthbias_decal -0.5}2{name 90 ConVar.r_drawropes 0 ConVar.mem_min_heapsize 144 ConVar.mem_max_heapsize 1024 ConVar.fx_drawimpactdebris 0 ConVar.fx_drawimpactdust 0 ConVar.fx_drawmetalspark 0 ConVar.tf_impactwatertimeenable 1 ConVar.dsp_off 0 ConVar.cl_particle_retire_cost 0 ConVar.mat_slopescaledepthbias_decal -0.5}3{name 92 ConVar.r_drawropes 0 ConVar.mem_min_heapsize 144 ConVar.mem_max_heapsize 1024 ConVar.fx_drawimpactdebris 0 ConVar.fx_drawimpactdust 0 ConVar.fx_drawmetalspark 0 ConVar.tf_impactwatertimeenable 1 ConVar.dsp_off 0 ConVar.cl_particle_retire_cost 0 ConVar.mat_slopescaledepthbias_decal -0.5}4{name 95 ConVar.r_drawropes 0 ConVar.mem_min_heapsize 144 ConVar.mem_max_heapsize 1024 ConVar.fx_drawimpactdebris 0 ConVar.fx_drawimpactdust 0 ConVar.fx_drawmetalspark 0 ConVar.tf_impactwatertimeenable 1 ConVar.dsp_off 0 ConVar.cl_particle_retire_cost 0 ConVar.mat_slopescaledepthbias_decal -0.5}}";
string mcUltraTexturePreloadList = @"models/bots/boss_bot/tank_tracks
models/bots/boss_bot/tankbody1
models/bots/boss_bot/tankbody1_damage1
models/bots/boss_bot/tankbody1_damage2
models/bots/boss_bot/tankbody1_damage3
models/bots/boss_bot/tankbody2
models/bots/boss_bot/tankbody2_final
models/bots/demo/demo_bot_blue
models/bots/demo/demo_bot_exp
models/bots/demo/demo_bot_head_blue
models/bots/demo/demo_bot_head_normal
models/bots/demo/demo_bot_head_red
models/bots/demo/demo_bot_red
models/bots/engineer/engineer_bot_blue
models/bots/engineer/engineer_bot_head_blue
models/bots/engineer/engineer_bot_head_red
models/bots/engineer/engineer_bot_red
models/bots/heavy/heavy_bot_blue
models/bots/heavy/heavy_bot_exp
models/bots/heavy/heavy_bot_head
models/bots/heavy/heavy_bot_head_exp
models/bots/heavy/heavy_bot_red
models/bots/medic/bot_medic_blue
models/bots/medic/bot_medic_exp
models/bots/medic/bot_medic_head_blue
models/bots/medic/bot_medic_head_normal
models/bots/medic/bot_medic_head_red
models/bots/medic/bot_medic_red
models/bots/pyro/pyro_bot_blue
models/bots/pyro/pyro_bot_exp
models/bots/pyro/pyro_bot_head
models/bots/pyro/pyro_bot_head_exp
models/bots/pyro/pyro_bot_red
models/bots/scout/bot_scout_blue
models/bots/scout/bot_scout_exp
models/bots/scout/bot_scout_head_blue
models/bots/scout/bot_scout_head_red
models/bots/scout/bot_scout_red
models/bots/skeleton/hwn_skeleton_blue
models/bots/skeleton/hwn_skeleton_green
models/bots/skeleton/hwn_skeleton_orange
models/bots/skeleton/hwn_skeleton_red
models/bots/sniper/sniper_bot_blue
models/bots/sniper/sniper_bot_exp
models/bots/sniper/sniper_bot_head_blue
models/bots/sniper/sniper_bot_head_exp
models/bots/sniper/sniper_bot_head_normal
models/bots/sniper/sniper_bot_head_red
models/bots/sniper/sniper_bot_red
models/bots/soldier/bot_soldier_blue
models/bots/soldier/bot_soldier_exp
models/bots/soldier/bot_soldier_head_blue
models/bots/soldier/bot_soldier_head_normal
models/bots/soldier/bot_soldier_head_red
models/bots/soldier/bot_soldier_red
models/bots/spy/spy_bot_body_blue
models/bots/spy/spy_bot_body_red
models/bots/spy/spy_bot_head_blue
models/bots/spy/spy_bot_head_red
models/bots/tw2/boss_bot/tw2_tankbody1
models/bots/tw2/boss_bot/tw2_tankbody1_damage1
models/bots/tw2/boss_bot/tw2_tankbody1_damage2
models/bots/tw2/boss_bot/tw2_tankbody1_damage3
models/bots/tw2/boss_bot/tw2_tankbody2
models/bots/tw2/boss_bot/tw2_tankbody2_final
models/buildables/dispenser/disp_blueprint_build
models/buildables/dispenser/disp_blueprint_model
models/buildables/dispenser/dispenser
models/buildables/dispenser/dispenser_blue
models/buildables/dispenser/dispenser_gibs
models/buildables/dispenser/dispenser_gibs_blue
models/buildables/dispenser/dispenser_phongmask
models/buildables/dispenser/dispenser_upgrades_animated
models/buildables/dispenser/dispenser_upgrades_animated2
models/buildables/dispenser/dispenser_upgrades_blue
models/buildables/dispenser/dispenser_upgrades_red
models/buildables/dispenser/dispenser_upgrades_selfillum
models/buildables/sapper/sapper_deployed
models/buildables/sapper/sapper_deployed_phongmask
models/buildables/sentry1/blueprint_build
models/buildables/sentry1/blueprint_model
models/buildables/sentry1/mini_sentry_blue
models/buildables/sentry1/mini_sentry_light_blue
models/buildables/sentry1/mini_sentry_light_red
models/buildables/sentry1/mini_sentry_red
models/buildables/sentry1/sentry1
models/buildables/sentry1/sentry1_blue
models/buildables/sentry1/sentry1_gibs
models/buildables/sentry1/sentry1_gibs_blue
models/buildables/sentry1/sentry1_normal
models/buildables/sentry1/sentry_pulse
models/buildables/sentry1/sentry_pulse2
models/buildables/sentry1/sentry_pulse_blue
models/buildables/sentry1/sentry_pulse_red
models/buildables/sentry2/sentry2
models/buildables/sentry2/sentry2_blue
models/buildables/sentry2/sentry2_gibs
models/buildables/sentry2/sentry2_gibs_blue
models/buildables/sentry2/sentry2_normal
models/buildables/sentry3/4rockets
models/buildables/sentry3/sentry3
models/buildables/sentry3/sentry3_blue
models/buildables/sentry3/sentry3_gibs
models/buildables/sentry3/sentry3_gibs_blue
models/buildables/sentry3/sentry3_normal
models/buildables/teleporter/teleporter_blueprint_enter
models/buildables/teleporter/teleporter_blueprint_exit
models/buildables/teleporter/teleporter_blueprint_model
models/buildables/teleporter/teleporter_gibs
models/buildables/teleporter/teleporter_gibs_blue
models/buildables/teleporter/teleportspin_blue
models/buildables/teleporter/teleportspin_red
models/buildables/teleporter/tp_direction
models/buildables/teleporter/tp_direction1
models/buildables/teleporter/tp_lights_blue
models/buildables/teleporter/tp_lights_red
models/buildables/teleporter/tp_sheet_blue
models/buildables/teleporter/tp_sheet_red
models/buildables/toolbox/toolbox_blue
models/buildables/toolbox/toolbox_red
models/passtime/ball/passtime_ball_blu
models/passtime/ball/passtime_ball_neu
models/passtime/ball/passtime_ball_normal_spec
models/passtime/ball/passtime_ball_red
models/player/items/all_class/all_class_ring
models/player/items/all_class/all_class_ring_warp
models/player/items/all_class/all_guts
models/player/items/all_class/drg_badge
models/player/items/all_class/drg_badge_copper
models/player/items/all_class/drg_badge_normal
models/player/items/all_class/drg_badge_silver
models/player/items/crafting/coin_invasion
models/player/items/crafting/coin_invasion_exponent
models/player/items/crafting/coin_invasion_normal
models/player/items/crafting/coin_summer2015_bronze
models/player/items/crafting/coin_summer2015_bronze_back
models/player/items/crafting/coin_summer2015_bronze_normal
models/player/items/crafting/coin_summer2015_bronze_normal_back
models/player/items/crafting/coin_summer2015_gold
models/player/items/crafting/coin_summer2015_gold_back
models/player/items/crafting/coin_summer2015_gold_normal
models/player/items/crafting/coin_summer2015_gold_normal_back
models/player/items/crafting/coin_summer2015_gravel
models/player/items/crafting/coin_summer2015_gravel_back
models/player/items/crafting/coin_summer2015_gravel_normal
models/player/items/crafting/coin_summer2015_gravel_normal_back
models/player/items/crafting/coin_summer2015_silver
models/player/items/crafting/coin_summer2015_silver_back
models/player/items/crafting/coin_summer2015_silver_normal
models/player/items/crafting/coin_summer2015_silver_normal_back
models/player/items/crafting/stat_clock_blue_happy
models/player/items/crafting/stat_clock_blue_sad
models/player/items/crafting/stat_clock_red_happy
models/player/items/crafting/stat_clock_red_sad
models/player/items/crafting/weapons_case
models/player/items/crafting/weapons_case_01_concealed
models/player/items/crafting/weapons_case_02_powerhouse
models/player/items/demo/crown
models/player/items/engineer/guitar/strings
models/player/items/engineer/guitar/w_guitar
models/player/items/engineer/guitar/w_guitar_normal
models/player/items/heavy/hwn_heavy_hat
models/player/items/heavy/sr3_heavy_mask
models/player/items/heavy/sr3_heavy_warp
models/player/items/heavy/xms_colored_lights_normal
models/player/items/heavy/xms_coloredlights_anim
models/player/items/heavy/xms_coloredlights_blue_anim
models/player/items/heavy/xms_coloredlights_exponent
models/player/items/heavy/xms_coloredlights_white_anim
models/player/items/mvm_loot/all_class/fob_engy
models/player/items/mvm_loot/all_class/fob_engy_blue
models/player/items/mvm_loot/all_class/fob_engy_gold
models/player/items/mvm_loot/all_class/fob_heavy
models/player/items/mvm_loot/all_class/fob_heavy_diamond
models/player/items/mvm_loot/all_class/fob_heavy_diamond_black
models/player/items/mvm_loot/all_class/fob_heavy_gold
models/player/items/mvm_loot/all_class/fob_heavy_normal
models/player/items/mvm_loot/all_class/fob_heavy_rust
models/player/items/mvm_loot/all_class/fob_heavy_rust_paint
models/player/items/mvm_loot/all_class/mvm_flask_ammo
models/player/items/mvm_loot/all_class/mvm_flask_build
models/player/items/mvm_loot/all_class/mvm_flask_generic
models/player/items/mvm_loot/all_class/mvm_flask_krit
models/player/items/mvm_loot/all_class/mvm_flask_tele
models/player/items/mvm_loot/all_class/mvm_flask_uber
models/player/items/mvm_loot/engineer/chain_engineer
models/player/items/mvm_loot/heavy/chain_heavy
models/player/items/mvm_loot/medic/chain_medic
models/player/items/mvm_loot/medic/chain_medic_blue
models/player/items/mvm_loot/scout/chain_scout
models/player/items/mvm_loot/sniper/chain_sniper
models/player/items/mvm_loot/soldier/chain_soldier
models/player/items/mvm_loot/spy/chain_spy
models/player/items/mvm_loot/spy/chain_spy_blue
models/player/items/pyro/drg_pyro_bubblehelmet
models/player/items/pyro/drg_pyro_fueltank
models/player/items/pyro/drg_pyro_fueltank_normal
models/player/items/pyro/mtp_bubble_wand
models/player/items/scout/scout_skeleton
models/player/items/sniper/knife_shield
models/player/items/soldier/medals
models/player/items/soldier/medals_blue
models/player/items/taunts/anim_beer_bottle_cerveza
models/player/items/taunts/beercrate_taunt
models/player/items/taunts/bumpercar/bumpercar_base_blue
models/player/items/taunts/bumpercar/bumpercar_base_exponent
models/player/items/taunts/bumpercar/bumpercar_base_red
models/player/items/taunts/cash_wad
models/player/items/taunts/chicken
models/player/items/taunts/chicken_bucket
models/player/items/taunts/chicken_normal
models/player/items/taunts/coffee_bag_blue
models/player/items/taunts/coffee_bag_normal
models/player/items/taunts/coffee_bag_red
models/player/items/taunts/engy_chair_toolbox_blue
models/player/items/taunts/engy_chair_toolbox_red
models/player/items/taunts/engy_chair_umbrella_blue
models/player/items/taunts/engy_chair_umbrella_red
models/player/items/taunts/engy_new_chair_beer_bottle_blue
models/player/items/taunts/engy_new_chair_beer_bottle_red
models/player/items/taunts/lighter_taunt
models/player/items/taunts/limes
models/player/items/taunts/medic_xray_viewer
models/player/items/taunts/nuke_bottle
models/player/items/taunts/soldier_mug
models/weapons/c_items/c_8mm_camera
models/weapons/c_items/c_ambassador_opt
models/weapons/c_items/c_ambassador_opt_blue
models/weapons/c_items/c_ambassador_opt_blue_gold
models/weapons/c_items/c_ambassador_opt_blue_xmas
models/weapons/c_items/c_ambassador_opt_gold
models/weapons/c_items/c_ambassador_opt_xmas
models/weapons/c_items/c_arrow
models/weapons/c_items/c_arrow_xmas
models/weapons/c_items/c_axtinguisher
models/weapons/c_items/c_axtinguisher_gold
models/weapons/c_items/c_axtinguisher_xmas
models/weapons/c_items/c_backburn
models/weapons/c_items/c_backburn_blue
models/weapons/c_items/c_bow
models/weapons/c_items/c_boxing_gloves
models/weapons/c_items/c_boxing_gloves_blue
models/weapons/c_items/c_boxing_gloves_flames
models/weapons/c_items/c_boxing_gloves_flames_blue
models/weapons/c_items/c_boxing_gloves_normal
models/weapons/c_items/c_boxing_gloves_xmas
models/weapons/c_items/c_boxing_gloves_xmas_blue
models/weapons/c_items/c_bread_baguette
models/weapons/c_items/c_bread_burnt
models/weapons/c_items/c_bread_burnt_normal
models/weapons/c_items/c_bread_cinnamon_normal
models/weapons/c_items/c_bread_cornbread
models/weapons/c_items/c_bread_cornbread_normal
models/weapons/c_items/c_bread_crumpet
models/weapons/c_items/c_bread_crumpet_exponent
models/weapons/c_items/c_bread_crumpet_normal
models/weapons/c_items/c_bread_plainloaf
models/weapons/c_items/c_bread_pretzel
models/weapons/c_items/c_bread_ration
models/weapons/c_items/c_bread_russianblack
models/weapons/c_items/c_breadmonster
models/weapons/c_items/c_breadmonster_exp
models/weapons/c_items/c_breadmonster_goo
models/weapons/c_items/c_breadmonster_normal
models/weapons/c_items/c_breadmonster_sapper
models/weapons/c_items/c_breadmonster_sapper_normal
models/weapons/c_items/c_buffbanner
models/weapons/c_items/c_buffpack
models/weapons/c_items/c_buffpack_xmas
models/weapons/c_items/c_buffpack_xmas_normal
models/weapons/c_items/c_bugle
models/weapons/c_items/c_carnival_mallet
models/weapons/c_items/c_carnival_mallet_blue
models/weapons/c_items/c_claymore
models/weapons/c_items/c_claymore_gold
models/weapons/c_items/c_claymore_ice
models/weapons/c_items/c_claymore_xmas
models/weapons/c_items/c_claymore_xmas_blue
models/weapons/c_items/c_directhit
models/weapons/c_items/c_double_barrel
models/weapons/c_items/c_double_barrel_gold
models/weapons/c_items/c_energydrink
models/weapons/c_items/c_energydrink_blu
models/weapons/c_items/c_energydrink_purp
models/weapons/c_items/c_fireaxe
models/weapons/c_items/c_flaregun
models/weapons/c_items/c_flaregun_blue
models/weapons/c_items/c_flaregun_shell
models/weapons/c_items/c_flaregun_shell_blue
models/weapons/c_items/c_frontierjustice
models/weapons/c_items/c_frontierjustice_blue
models/weapons/c_items/c_frontierjustice_gold
models/weapons/c_items/c_frontierjustice_phongmask
models/weapons/c_items/c_frontierjustice_xmas
models/weapons/c_items/c_frying_pan
models/weapons/c_items/c_frying_pan_gold
models/weapons/c_items/c_grappling_hook
models/weapons/c_items/c_hippocrates_bust
models/weapons/c_items/c_hippocrates_bust_normal
models/weapons/c_items/c_leather_watch
models/weapons/c_items/c_leather_watch_normal
models/weapons/c_items/c_leechgun
models/weapons/c_items/c_leechgun_blu
models/weapons/c_items/c_leechgun_gold
models/weapons/c_items/c_lollichop
models/weapons/c_items/c_medigun
models/weapons/c_items/c_natascha
models/weapons/c_items/c_p2rec
models/weapons/c_items/c_p2rec_eye
models/weapons/c_items/c_pickaxe
models/weapons/c_items/c_pickaxe_s2
models/weapons/c_items/c_pocket_watch
models/weapons/c_items/c_proto_backpack_blue
models/weapons/c_items/c_proto_backpack_red
models/weapons/c_items/c_proto_medigun
models/weapons/c_items/c_proto_medigun_blue
models/weapons/c_items/c_proto_medigun_glass
models/weapons/c_items/c_proto_syringegun
models/weapons/c_items/c_proto_syringegun_blue
models/weapons/c_items/c_rainblower
models/weapons/c_items/c_rainblower_blue
models/weapons/c_items/c_revolver
models/weapons/c_items/c_robo_sandwich
models/weapons/c_items/c_robo_sandwich_blue
models/weapons/c_items/c_sandwich
models/weapons/c_items/c_sandwich_xmas
models/weapons/c_items/c_sandwich_xmas_blue
models/weapons/c_items/c_sandwich_xmas_normal
models/weapons/c_items/c_sapper
models/weapons/c_items/c_sapper_xmas
models/weapons/c_items/c_sapper_xmas_blue
models/weapons/c_items/c_shovel
models/weapons/c_items/c_sniperrifle_scope
models/weapons/c_items/c_specimin_jar
models/weapons/c_items/c_syringegun
models/weapons/c_items/c_syringegun_blue
models/weapons/c_items/c_syringegun_glass
models/weapons/c_items/c_targe
models/weapons/c_items/c_targe_ice
models/weapons/c_items/c_targe_xmas
models/weapons/c_items/c_targe_xmas_cables
models/weapons/c_items/c_tfc_sniperrifle
models/weapons/c_items/c_toolbox_blue
models/weapons/c_items/c_toolbox_red
models/weapons/c_items/c_ubersaw
models/weapons/c_items/c_ubersaw_xms
models/weapons/c_items/c_urinejar_cap
models/weapons/c_items/c_urinejar_glass
models/weapons/c_items/c_urinejar_glass_phongmask
models/weapons/c_items/c_urinejar_urine
models/weapons/c_items/c_wrangler
models/weapons/c_items/c_wrangler_blue
models/weapons/c_items/c_wrangler_phongmask
models/weapons/c_items/c_wrangler_xmas
models/weapons/c_items/c_wrangler_xmas_blue
models/weapons/c_items/c_wrangler_xmas_phongmask
models/weapons/c_items/c_wrench
models/weapons/c_items/c_wrench_gold
models/weapons/v_rocketlauncher/v_rocketlauncher01_gold
models/weapons/c_items/c_xms_backburner_horns
models/weapons/c_items/c_xms_double_barrel
models/weapons/c_items/c_xms_double_barrel_blue
models/weapons/c_items/c_xms_energydrink
models/weapons/c_items/c_xms_energydrink_blu
models/weapons/c_items/c_xms_energydrink_bow
models/weapons/c_items/c_xms_energydrink_bow_blue
models/weapons/c_items/c_xms_festive_ornament
models/weapons/c_items/c_xms_festive_ornament_blue
models/weapons/c_items/c_xms_flaregun_festives
models/weapons/c_items/c_xms_flaregun_festives_blue
models/weapons/c_items/c_xms_urinejar
models/weapons/c_items/c_xms_urinejar_blue
models/weapons/c_items/c_xms_urinejar_glass
models/weapons/c_items/c_xms_urinejar_glass_blue
models/weapons/c_items/c_xms_urinejar_glass_phongmask
models/weapons/c_items/festive_battery
models/weapons/c_items/festive_lights_blue
models/weapons/c_items/festive_lights_red
models/weapons/c_items/pumpkin_axe
models/weapons/c_items/ttg_watch
models/weapons/c_models/c_flamethrower/c_flamethrower
models/weapons/c_models/c_flamethrower/c_flamethrower_blue
models/weapons/c_models/c_flamethrower/c_flamethrower_exp
models/weapons/c_models/c_flamethrower/c_flamethrower_gold
models/weapons/c_models/c_grenadelauncher/c_grenadelauncher
models/weapons/c_models/c_grenadelauncher/c_grenadelauncher_exp
models/weapons/c_models/c_grenadelauncher/c_grenadelauncher_gold
models/weapons/c_models/c_knife/c_knife
models/weapons/c_models/c_knife/c_knife_gold
models/weapons/c_models/c_medigun/c_medigun
models/weapons/c_models/c_medigun/c_medigun_blue
models/weapons/c_models/c_medigun/c_medigun_exp
models/weapons/c_models/c_medigun/c_medigun_gold
models/weapons/c_models/c_minigun/c_minigun
models/weapons/c_models/c_minigun/c_minigun_exp
models/weapons/c_models/c_minigun/c_minigun_gold
models/weapons/c_models/c_minigun/c_minigun_natascha
models/weapons/c_models/c_pistol/c_pistol
models/weapons/c_models/c_pistol/c_pistol_exp
models/weapons/c_models/c_revolver/c_revolver
models/weapons/c_models/c_revolver/c_revolver_exp
models/weapons/c_models/c_revolver/c_revolver_xmas
models/weapons/c_models/c_rocketjumper/c_rocketjumper
models/weapons/c_models/c_rocketlauncher/c_rocketlauncher
models/weapons/c_models/c_rocketlauncher/c_rocketlauncher_exp
models/weapons/c_models/c_rocketlauncher/c_rocketlauncher_gold
models/weapons/c_models/c_scattergun/c_scattergun
models/weapons/c_models/c_scattergun/c_scattergun_exp
models/weapons/c_models/c_scattergun/c_scattergun_gold
models/weapons/c_models/c_shotgun/c_shotgun
models/weapons/c_models/c_shotgun/c_shotgun_exp
models/weapons/c_models/c_smg/c_smg
models/weapons/c_models/c_smg/c_smg_exp
models/weapons/c_models/c_smg/c_smg_gold
models/weapons/c_models/c_sniperrifle/c_sniperrifle
models/weapons/c_models/c_sniperrifle/c_sniperrifle_exp
models/weapons/c_models/c_sniperrifle/c_sniperrifle_gold
models/weapons/c_models/c_sniperrifle/c_sniperrifle_scope
models/weapons/c_models/c_sticky_jumper/c_sticky_jumper
models/weapons/c_models/c_stickybomb_launcher/c_stickybomb_launcher
models/weapons/c_models/c_stickybomb_launcher/c_stickybomb_launcher_exp
models/weapons/c_models/c_stickybomb_launcher/c_stickybomb_launcher_gold
models/weapons/c_models/c_ubersaw/c_ubersaw
models/weapons/c_models/c_ubersaw/c_ubersaw_selfillummask
models/weapons/c_models/c_wrench/c_wrench
models/weapons/c_models/c_wrench/c_wrench_gold
models/weapons/csgo_awp/w_csgo_awp
models/weapons/csgo_awp/w_csgo_awp_normal
models/weapons/shells/all_shells
models/weapons/shells/all_shells_normal
models/weapons/syringe_projectile/syringe_projectile
models/weapons/syringe_projectile/syringe_projectile_blue
models/weapons/v_baseball/baseball_normal
models/weapons/v_baseball/baseball_sheet
models/weapons/v_bat/v_bat
models/weapons/v_bat/v_bat_phongwarp
models/weapons/v_bat/v_wooden_bat
models/weapons/v_bonesaw/c_bonesaw_xmas
models/weapons/v_bonesaw/c_bonesaw_xmas_lights
models/weapons/v_bonesaw/v_bonesaw
models/weapons/v_bottle/v_bottle
models/weapons/v_builder/v_builder
models/weapons/v_cigarette_case/v_cigarette_case
models/weapons/v_grenadelauncher/v_grenadelauncher
models/weapons/v_grenadelauncher/v_grenadelauncher_gold
models/weapons/v_grenadelauncher/v_grenadelauncher_phongmask
models/weapons/v_knife/v_knife
models/weapons/v_knife/v_knife_gold
models/weapons/v_machete/v_machete
models/weapons/v_pda_engineer/v_pda_engineer
models/weapons/v_pda_engineer/v_pda_engineer_screen
models/weapons/v_revolver/v_revolver
models/weapons/v_sapper/v_sapper_glass
models/weapons/v_sapper/v_sapper_glass_normal
models/weapons/v_shotgun/v_shotgun
models/weapons/v_sniperrifle/v_sniperrifle_scope
models/weapons/v_stickybomb_defender/v_stickybomb_defender
models/weapons/v_stickybomb_defender/v_stickybomb_defender_phongmask
models/weapons/v_syringegun/v_syringegun_glass
models/weapons/v_watch/v_watch
models/weapons/w_cannonball/w_cannonball_blue
models/weapons/w_cannonball/w_cannonball_red
models/weapons/w_grenade_grenadelauncher/w_grenade_blue
models/weapons/w_grenade_grenadelauncher/w_grenade_red
models/weapons/w_repair_claw/w_repair_claw_blue
models/weapons/w_repair_claw/w_repair_claw_gib
models/weapons/w_repair_claw/w_repair_claw_red
models/weapons/w_revolver/w_revolver01
models/weapons/w_rocketlauncher/w_rocket01
models/weapons/w_stickybomb/w_stickybomb2_blue
models/weapons/w_stickybomb/w_stickybomb2_red
models/weapons/w_stickybomb/w_stickybomb_blue_noalpha
models/weapons/w_stickybomb/w_stickybomb_d_blue
models/weapons/w_stickybomb/w_stickybomb_d_red
models/weapons/w_stickybomb/w_stickybomb_destroyed
models/weapons/w_stickybomb/w_stickybomb_red_noalpha
models/weapons/w_stickybomb/w_stickybomb_selfillum
models/weapons/w_stickybomb_launcher/w_stickybomb_launcher_defender
models/weapons/w_stickybomb_launcher/w_stickybomb_launcher_normal
models/workshop/cases/invasion_case/invasion_case
models/workshop/cases/invasion_case/invasion_case_cordon
models/workshop/cases/invasion_case/invasion_case_normal
models/workshop/cases/invasion_case/invasion_case_rare
models/workshop/cases/invasion_case/invasion_case_rare_cordon
models/workshop/player/items/all_class/taunt_burstchester/taunt_burstchester_1_blue_color
models/workshop/player/items/all_class/taunt_burstchester/taunt_burstchester_1_color
models/workshop/player/items/all_class/taunt_burstchester/taunt_burstchester_color
models/workshop/player/items/all_class/taunt_burstchester/taunt_burstchester_normal
models/workshop/player/items/all_class/zoomin_broom/zoomin_broom_color
models/workshop/player/items/demo/demo_booties/demo_booties
models/workshop/player/items/demo/pegleg/pegleg
models/workshop/player/items/engineer/bucking_bronco/bucking_bronco_blue_color
models/workshop/player/items/engineer/bucking_bronco/bucking_bronco_color
models/workshop/player/items/engineer/bucking_bronco/bucking_bronco_normal
models/workshop/player/items/pyro/eotl_ducky/eotl_ducky_base
models/workshop/player/items/pyro/eotl_ducky/eotl_ducky_blue
models/workshop/player/items/pyro/eotl_ducky/eotl_ducky_demo
models/workshop/player/items/pyro/eotl_ducky/eotl_ducky_demo_blue
models/workshop/player/items/pyro/eotl_ducky/eotl_ducky_engy
models/workshop/player/items/pyro/eotl_ducky/eotl_ducky_engy_blue
models/workshop/player/items/pyro/eotl_ducky/eotl_ducky_heavy
models/workshop/player/items/pyro/eotl_ducky/eotl_ducky_heavy_blue
models/workshop/player/items/pyro/eotl_ducky/eotl_ducky_medic
models/workshop/player/items/pyro/eotl_ducky/eotl_ducky_medic_blue
models/workshop/player/items/pyro/eotl_ducky/eotl_ducky_phongexponent
models/workshop/player/items/pyro/eotl_ducky/eotl_ducky_pyro
models/workshop/player/items/pyro/eotl_ducky/eotl_ducky_pyro_blue
models/workshop/player/items/pyro/eotl_ducky/eotl_ducky_red
models/workshop/player/items/pyro/eotl_ducky/eotl_ducky_saxton
models/workshop/player/items/pyro/eotl_ducky/eotl_ducky_scout
models/workshop/player/items/pyro/eotl_ducky/eotl_ducky_scout_blue
models/workshop/player/items/pyro/eotl_ducky/eotl_ducky_sniper
models/workshop/player/items/pyro/eotl_ducky/eotl_ducky_sniper_blue
models/workshop/player/items/pyro/eotl_ducky/eotl_ducky_soldier
models/workshop/player/items/pyro/eotl_ducky/eotl_ducky_soldier_blue
models/workshop/player/items/pyro/eotl_ducky/eotl_ducky_spy
models/workshop/player/items/pyro/eotl_ducky/eotl_ducky_spy_blue
models/workshop/player/items/pyro/ghost_aspect/ghost_aspect_1_color
models/workshop/player/items/pyro/ghost_aspect/ghost_aspect_blue_color
models/workshop/player/items/pyro/ghost_aspect/ghost_aspect_color
models/workshop/player/items/pyro/pyro_halloween_gasmask/pyro_halloween_gasmask_blue_color
models/workshop/player/items/pyro/pyro_halloween_gasmask/pyro_halloween_gasmask_color
models/workshop/player/items/pyro/pyro_halloween_gasmask/pyro_halloween_gasmask_normal
models/workshop/player/items/pyro/threea_nabler/threea_nabler
models/workshop/player/items/sniper/croc_shield/croc_shield
models/workshop/player/items/sniper/croc_shield/croc_shield_normal
models/workshop/player/items/sniper/killer_solo/killer_solo_color
models/workshop/player/items/sniper/killer_solo/killer_solo_normal
models/workshop/player/items/sniper/killer_solo/sax
models/workshop/player/items/sniper/killer_solo/sax_normal
models/workshop/player/items/sniper/taunt_most_wanted/taunt_most_wanted_color
models/workshop/player/items/sniper/taunt_most_wanted/taunt_most_wanted_normal
models/workshop/player/items/sniper/xms_sniper_commandobackpack/xms_sniper_commandobackpack
models/workshop/player/items/sniper/xms_sniper_commandobackpack/xms_sniper_commandobackpack_blue
models/workshop/player/items/sniper/xms_sniper_commandobackpack/xms_sniper_commandobackpack_phongmask
models/workshop/player/items/sniper/xms_sniper_commandobackpack/xms_sniper_commandobackpack_phongmask_jar
models/workshop/player/items/soldier/mantreads/mantreads
models/workshop/player/items/soldier/taunt_maggots_condolence/taunt_maggots_condolence_color
models/workshop/player/items/spy/taunt_spy_boxtrot/taunt_spy_boxtrot_blue_color
models/workshop/player/items/spy/taunt_spy_boxtrot/taunt_spy_boxtrot_color
models/workshop/player/items/spy/taunt_spy_boxtrot/taunt_spy_boxtrot_normal
models/workshop/player/items/taunts/pyro_poolparty/pyro_poolparty
models/workshop/player/items/taunts/pyro_poolparty/pyro_poolparty_blue
models/workshop/weapons/c_models/c_acr_hookblade/c_acr_hookblade
models/workshop/weapons/c_models/c_acr_hookblade/c_acr_hookblade_normal
models/workshop/weapons/c_models/c_amputator/c_amputator
models/workshop/weapons/c_models/c_amputator/c_amputator_blue
models/workshop/weapons/c_models/c_atom_launcher/c_atom_launcher
models/workshop/weapons/c_models/c_ava_roseknife/c_ava_roseknife
models/workshop/weapons/c_models/c_ava_roseknife/c_ava_roseknife_black
models/workshop/weapons/c_models/c_ava_roseknife/c_ava_roseknife_blue
models/workshop/weapons/c_models/c_back_scratcher/c_back_scratcher
models/workshop/weapons/c_models/c_battalion_buffbanner/c_battalion_buffbanner
models/workshop/weapons/c_models/c_battalion_buffpack/c_battalion_buffpack
models/workshop/weapons/c_models/c_battalion_bugle/c_battalion_bugle
models/workshop/weapons/c_models/c_battalion_bugle/c_battalion_bugle_normal
models/workshop/weapons/c_models/c_battleaxe/c_battleaxe
models/workshop/weapons/c_models/c_bazaar_sniper/c_bazaar_sniper
models/workshop/weapons/c_models/c_bazaar_sniper/c_bazaar_sniper_lens
models/workshop/weapons/c_models/c_bear_claw/c_bear_claw_blue
models/workshop/weapons/c_models/c_bear_claw/c_bear_claw_red
models/workshop/weapons/c_models/c_blackbox/c_blackbox
models/workshop/weapons/c_models/c_blackbox/c_blackbox_gold
models/workshop/weapons/c_models/c_blackbox/c_blackbox_xmas
models/workshop/weapons/c_models/c_blackbox/c_blackbox_xmas_blue
models/workshop/weapons/c_models/c_bonk_bat/c_bonk_bat_blue
models/workshop/weapons/c_models/c_bonk_bat/c_bonk_bat_red
models/workshop/weapons/c_models/c_boston_basher/c_boston_basher
models/workshop/weapons/c_models/c_buffalo_steak/c_buffalo_steak
models/workshop/weapons/c_models/c_caber/c_caber
models/workshop/weapons/c_models/c_candy_cane/c_candy_cane_blue
models/workshop/weapons/c_models/c_candy_cane/c_candy_cane_bow_blue
models/workshop/weapons/c_models/c_candy_cane/c_candy_cane_bow_red
models/workshop/weapons/c_models/c_candy_cane/c_candy_cane_red
models/workshop/weapons/c_models/c_chocolate/c_chocolate
models/workshop/weapons/c_models/c_chocolate/c_chocolate_blue
models/workshop/weapons/c_models/c_claidheamohmor/c_claidheamohmor
models/workshop/weapons/c_models/c_claidheamohmor/c_claidheamohmor_blu
models/workshop/weapons/c_models/c_croc_knife/c_croc_knife
models/workshop/weapons/c_models/c_crossing_guard/c_crossing_guard
models/workshop/weapons/c_models/c_crossing_guard/c_crossing_guard_lights
models/workshop/weapons/c_models/c_crossing_guard/c_crossing_guard_lights_blue
models/workshop/weapons/c_models/c_crusaders_crossbow/c_crusaders_crossbow
models/workshop/weapons/c_models/c_crusaders_crossbow/c_crusaders_crossbow_blue
models/workshop/weapons/c_models/c_crusaders_crossbow/c_crusaders_crossbow_xmas
models/workshop/weapons/c_models/c_crusaders_crossbow/c_crusaders_crossbow_xmas_blue
models/workshop/weapons/c_models/c_crusaders_crossbow/c_crusaders_crossbow_xmas_proj
models/workshop/weapons/c_models/c_crusaders_crossbow/c_crusaders_crossbow_xmas_proj_blue
models/workshop/weapons/c_models/c_degreaser/c_degreaser_blue
models/workshop/weapons/c_models/c_degreaser/c_degreaser_red
models/workshop/weapons/c_models/c_demo_cannon/c_demo_cannon
models/workshop/weapons/c_models/c_demo_sultan_sword/c_demo_sultan_sword
models/workshop/weapons/c_models/c_detonator/c_detonator
models/workshop/weapons/c_models/c_detonator/c_detonator_blue
models/workshop/weapons/c_models/c_detonator/c_detonator_shell
models/workshop/weapons/c_models/c_detonator/c_detonator_shell_blue
models/workshop/weapons/c_models/c_detonator/c_detonator_shell_phongmask
models/workshop/weapons/c_models/c_drg_cowmangler/c_drg_cowmangler
models/workshop/weapons/c_models/c_drg_cowmangler/c_drg_cowmangler_normal
models/workshop/weapons/c_models/c_drg_manmelter/c_drg_manmelter
models/workshop/weapons/c_models/c_drg_manmelter/c_drg_manmelter_glass
models/workshop/weapons/c_models/c_drg_manmelter/c_drg_manmelter_glass_blue
models/workshop/weapons/c_models/c_drg_manmelter/c_drg_manmelter_normal
models/workshop/weapons/c_models/c_drg_phlogistinator/c_drg_phlogistinator
models/workshop/weapons/c_models/c_drg_phlogistinator/c_drg_phlogistinator_02
models/workshop/weapons/c_models/c_drg_phlogistinator/c_drg_phlogistinator_02_blue
models/workshop/weapons/c_models/c_drg_phlogistinator/c_drg_phlogistinator_02_normal
models/workshop/weapons/c_models/c_drg_phlogistinator/c_drg_phlogistinator_blue
models/workshop/weapons/c_models/c_drg_pomson/c_drg_pomson
models/workshop/weapons/c_models/c_drg_pomson/c_drg_pomson_blue
models/workshop/weapons/c_models/c_drg_righteousbison/c_drg_righteousbison
models/workshop/weapons/c_models/c_drg_righteousbison/c_drg_righteousbison_normal
models/workshop/weapons/c_models/c_drg_thirddegree/c_drg_thirddegree
models/workshop/weapons/c_models/c_drg_thirddegree/c_drg_thirddegree_blue
models/workshop/weapons/c_models/c_drg_thirddegree/c_drg_thirddegree_normal
models/workshop/weapons/c_models/c_drg_wrenchmotron/c_drg_wrenchmotron
models/workshop/weapons/c_models/c_drg_wrenchmotron/c_drg_wrenchmotron_blue
models/workshop/weapons/c_models/c_dumpster_device/c_dumpster_device
models/workshop/weapons/c_models/c_eternal_reward/c_eternal_reward_blue
models/workshop/weapons/c_models/c_eternal_reward/c_eternal_reward_normal
models/workshop/weapons/c_models/c_eternal_reward/c_eternal_reward_red
models/workshop/weapons/c_models/c_eviction_notice/c_eviction_notice
models/workshop/weapons/c_models/c_fishcake/c_fishcake
models/workshop/weapons/c_models/c_fishcake/c_fishcake_blue
models/workshop/weapons/c_models/c_fishcake/c_fishcake_phong_mask
models/workshop/weapons/c_models/c_fists_of_steel/c_fists_of_steel
models/workshop/weapons/c_models/c_fists_of_steel/c_fists_of_steel_blue
models/workshop/weapons/c_models/c_gatling_gun/c_gatling_gun
models/workshop/weapons/c_models/c_golfclub/c_golfclub
models/workshop/weapons/c_models/c_ham/c_ham
models/workshop/weapons/c_models/c_holymackerel/c_holymackerel
models/workshop/weapons/c_models/c_holymackerel/c_holymackerel_xmas
models/workshop/weapons/c_models/c_holymackerel/c_holymackerel_xmas_blue
models/workshop/weapons/c_models/c_invasion_bat/c_invasion_bat
models/workshop/weapons/c_models/c_invasion_bat/c_invasion_bat_blue
models/workshop/weapons/c_models/c_invasion_bat/c_invasion_bat_laser
models/workshop/weapons/c_models/c_invasion_pistol/c_invasion_pistol
models/workshop/weapons/c_models/c_invasion_pistol/c_invasion_pistol_blue
models/workshop/weapons/c_models/c_invasion_pistol/c_invasion_pistol_spec
models/workshop/weapons/c_models/c_invasion_sniperrifle/c_invasion_sniperrifle
models/workshop/weapons/c_models/c_invasion_sniperrifle/c_invasion_sniperrifle_blue
models/workshop/weapons/c_models/c_invasion_sniperrifle/c_invasion_sniperrifle_spec
models/workshop/weapons/c_models/c_invasion_wrangler/c_invasion_wrangler
models/workshop/weapons/c_models/c_invasion_wrangler/c_invasion_wrangler_blue
models/workshop/weapons/c_models/c_invasion_wrangler/c_invasion_wrangler_screen
models/workshop/weapons/c_models/c_invasion_wrangler/c_invasion_wrangler_screen_sweep
models/workshop/weapons/c_models/c_iron_curtain/c_iron_curtain
models/workshop/weapons/c_models/c_jag/c_jag
models/workshop/weapons/c_models/c_kingmaker_sticky/c_kingmaker_sticky
models/workshop/weapons/c_models/c_kingmaker_sticky/w_kingmaker_stickybomb_blue
models/workshop/weapons/c_models/c_kingmaker_sticky/w_kingmaker_stickybomb_normal
models/workshop/weapons/c_models/c_kingmaker_sticky/w_kingmaker_stickybomb_red
models/workshop/weapons/c_models/c_letranger/c_letranger
models/workshop/weapons/c_models/c_letranger/c_letranger_normal
models/workshop/weapons/c_models/c_liberty_launcher/c_liberty_launcher
models/workshop/weapons/c_models/c_lochnload/c_lochnload
models/workshop/weapons/c_models/c_madmilk/c_madmilk_glass
models/workshop/weapons/c_models/c_madmilk/c_madmilk_liquid
models/workshop/weapons/c_models/c_market_gardener/c_market_gardener
models/workshop/weapons/c_models/c_medigun_defense/c_medigun_defense
models/workshop/weapons/c_models/c_medigun_defense/c_medigun_defense_blue
models/workshop/weapons/c_models/c_medigun_defense/c_medigun_defensepack
models/workshop/weapons/c_models/c_medigun_defense/c_medigun_defensepack_blue
models/workshop/weapons/c_models/c_paintrain/c_paintrain
models/workshop/weapons/c_models/c_paratrooper_pack/c_paratrooper_pack
models/workshop/weapons/c_models/c_paratrooper_pack/c_paratrooper_pack_normal
models/workshop/weapons/c_models/c_pep_pistol/c_pep_pistol
models/workshop/weapons/c_models/c_pep_scattergun/c_pep_scattergun
models/workshop/weapons/c_models/c_persian_shield/c_persian_shield
models/workshop/weapons/c_models/c_persian_shield/c_persian_shield_spike
models/workshop/weapons/c_models/c_picket/c_picket
models/workshop/weapons/c_models/c_picket/c_picket_paper
models/workshop/weapons/c_models/c_powerjack/c_powerjack_blue
models/workshop/weapons/c_models/c_powerjack/c_powerjack_red
models/workshop/weapons/c_models/c_pro_rifle/c_pro_rifle
models/workshop/weapons/c_models/c_pro_smg/c_pro_smg
models/workshop/weapons/c_models/c_quadball/c_quadball
models/workshop/weapons/c_models/c_quadball/w_quadball_grenade_blue
models/workshop/weapons/c_models/c_quadball/w_quadball_grenade_red
models/workshop/weapons/c_models/c_reserve_shooter/c_reserve_shooter
models/workshop/weapons/c_models/c_rfa_hammer/c_rfa_hammer
models/workshop/weapons/c_models/c_riding_crop/c_riding_crop
models/workshop/weapons/c_models/c_rift_fire_axe/c_rift_fire_axe
models/workshop/weapons/c_models/c_rift_fire_axe/c_rift_fire_axe_normal
models/workshop/weapons/c_models/c_rift_fire_mace/c_rift_fire_mace
models/workshop/weapons/c_models/c_rift_fire_mace/c_rift_fire_mace_normal
models/workshop/weapons/c_models/c_russian_riot/c_russian_riot
models/workshop/weapons/c_models/c_scatterdrum/c_scatterdrum
models/workshop/weapons/c_models/c_scimitar/c_scimitar
models/workshop/weapons/c_models/c_scorch_shot/c_scorch_shot
models/workshop/weapons/c_models/c_scotland_shard/c_scotland_shard
models/workshop/weapons/c_models/c_scout_sword/c_scout_sword
models/workshop/weapons/c_models/c_shortstop/c_shortstop
models/workshop/weapons/c_models/c_skullbat/c_skullbat_hats
models/workshop/weapons/c_models/c_skullbat/c_skullbat_hats_blue
models/workshop/weapons/c_models/c_skullbat/c_skullbat_skeleton
models/workshop/weapons/c_models/c_sledgehammer/c_sledgehammer
models/workshop/weapons/c_models/c_sledgehammer/c_sledgehammer_phongmask
models/workshop/weapons/c_models/c_snub_nose/c_snub_nose
models/workshop/weapons/c_models/c_soda_popper/c_soda_popper
models/workshop/weapons/c_models/c_spikewrench/c_spikewrench
models/workshop/weapons/c_models/c_sr3_punch/c_sr3_punch
models/workshop/weapons/c_models/c_switchblade/c_switchblade
models/workshop/weapons/c_models/c_sydney_sleeper/c_sydney_sleeper
models/workshop/weapons/c_models/c_sydney_sleeper/c_sydney_sleeper_phongmask
models/workshop/weapons/c_models/c_tele_shotgun/c_tele_shotgun
models/workshop/weapons/c_models/c_tele_shotgun/c_tele_shotgun_blue
models/workshop/weapons/c_models/c_tele_shotgun/c_tele_shotgun_illum
models/workshop/weapons/c_models/c_tele_shotgun/c_tele_shotgun_tv
models/workshop/weapons/c_models/c_tomislav/c_tomislav
models/workshop/weapons/c_models/c_tomislav/c_tomislav_gold
models/workshop/weapons/c_models/c_trenchgun/c_trenchgun
models/workshop/weapons/c_models/c_ttg_max_gun/c_ttg_max_gun
models/workshop/weapons/c_models/c_ttg_sam_gun/c_ttg_sam_gun
models/workshop/weapons/c_models/c_uberneedle/c_uberneedle
models/workshop/weapons/c_models/c_unarmed_combat/c_unarmed_combat_blu
models/workshop/weapons/c_models/c_unarmed_combat/c_unarmed_combat_red
models/workshop/weapons/c_models/c_voodoo_pin/c_voodoo_pin
models/workshop/weapons/c_models/c_wheel_shield/c_wheel_shield
models/workshop/weapons/c_models/c_winger_pistol/c_winger_pistol
models/workshop/weapons/c_models/c_wood_machete/c_wood_machete
models/workshop/weapons/c_models/c_xms_cold_shoulder/c_xms_cold_shoulder
models/workshop/weapons/c_models/c_xms_cold_shoulder/c_xms_cold_shoulder_normal
models/workshop/weapons/c_models/c_xms_giftwrap/c_xms_giftwrap
models/workshop/weapons/c_models/c_xms_giftwrap/c_xms_giftwrap_blue
models/workshop/weapons/c_models/c_xms_gloves/c_xms_gloves
models/workshop/weapons/c_models/c_xms_gloves/c_xms_gloves_blue
models/workshop/weapons/c_models/c_xms_gloves/c_xms_gloves_normal
models/workshop_partner/weapons/c_models/c_ai_flamethrower/c_ai_flamethrower
models/workshop_partner/weapons/c_models/c_ai_flamethrower/c_ai_flamethrower_blue
models/workshop_partner/weapons/c_models/c_bet_rocketlauncher/c_bet_rocketlauncher
models/workshop_partner/weapons/c_models/c_bow_thief/c_bow_thief
models/workshop_partner/weapons/c_models/c_bow_thief/c_bow_thief_n
models/workshop_partner/weapons/c_models/c_canton/c_canton
models/workshop_partner/weapons/c_models/c_canton/c_canton_blue
models/workshop_partner/weapons/c_models/c_dex_arm/c_dex_arm
models/workshop_partner/weapons/c_models/c_dex_revolver/c_dex_revolver
models/workshop_partner/weapons/c_models/c_dex_shotgun/c_dex_shotgun
models/workshop_partner/weapons/c_models/c_dex_sniperrifle/c_dex_sniperrifle
models/workshop_partner/weapons/c_models/c_prinny_knife/c_prinny_knife
models/workshop_partner/weapons/c_models/c_sd_cleaver/c_sd_cleaver
models/workshop_partner/weapons/c_models/c_sd_cleaver/c_sd_cleaver_bloody
models/workshop_partner/weapons/c_models/c_sd_neonsign/c_sd_neonsign
models/workshop_partner/weapons/c_models/c_sd_neonsign/c_sd_neonsign_blue
models/workshop_partner/weapons/c_models/c_sd_neonsign/c_sd_neonsign_normal
models/workshop_partner/weapons/c_models/c_sd_sapper/c_sd_sapper
models/workshop_partner/weapons/c_models/c_shogun_katana/c_shogun_katana
models/workshop_partner/weapons/c_models/c_shogun_katana/c_shogun_katana_blood
models/workshop_partner/weapons/c_models/c_shogun_kunai/c_shogun_kunai
models/workshop_partner/weapons/c_models/c_shogun_warbanner/c_shogun_warbanner
models/workshop_partner/weapons/c_models/c_shogun_warfan/c_shogun_warfan
models/workshop_partner/weapons/c_models/c_shogun_warhorn/c_shogun_warhorn
models/workshop_partner/weapons/c_models/c_shogun_warpack/c_shogun_warpack_blu
models/workshop_partner/weapons/c_models/c_shogun_warpack/c_shogun_warpack_red
models/workshop_partner/weapons/c_models/c_tw_eagle/c_tw_eagle
models/workshop_partner/weapons/v_models/v_hm_watch/v_hm_watch";


//////////////////////////////////////////////////////////////
////////////////////MasterComfig High/////////////////////////
//////////////////////////////////////////////////////////////

string mcHighAutoExec = "exec comfig/define_presets.cfg;preset=high;exec user/pre_comfig.cfg;exec comfig/comfig.cfg;exec user/post_comfig.cfg;preset;exec comfig/addons_setup.cfg;exec comfig/addons.cfg;modules_c;run_modules;exec comfig/addons.cfg;exec comfig/echo.cfg;autoexec_c;exec comfig/finalize.cfg";
string mcHighMtpCfg = "VisionFilterShadersMapWhitelist{arena_badlands.bsp 1 arena_byre.bsp 1 arena_granary.bsp 1 arena_lumberyard.bsp 1 arena_offblast_final.bsp 1 arena_ravine.bsp 1 arena_sawmill.bsp 1 arena_watchtower.bsp 1 arena_well.bsp 1 cp_5gorge.bsp 1 cp_badlands.bsp 1 cp_degrootkeep.bsp 1 cp_dustbowl.bsp 1 cp_egypt_final.bsp 1 cp_fastlane.bsp 1 cp_foundry.bsp 1 cp_freight_final1.bsp 1 cp_gorge.bsp 1 cp_granary.bsp 1 cp_gravelpit.bsp 1 cp_gullywash_final1.bsp 1 cp_metalworks.bsp 1 cp_powerhouse.bsp 1 cp_process_final.bsp 1 cp_snakewater_final1.bsp 1 cp_standin_final.bsp 1 cp_steel.bsp 1 cp_sunshine.bsp 1 cp_vanguard.bsp 1 cp_well.bsp 1 cp_yukon_final.bsp 1 ctf_2fort.bsp 1 ctf_doublecross.bsp 1 ctf_foundry.bsp 1 ctf_gorge.bsp 1 ctf_hellfire.bsp 1 ctf_landfall.bsp 1 ctf_sawmill.bsp 1 ctf_thundermountain.bsp 1 ctf_turbine.bsp 1 ctf_well.bsp 1 itemtest.bsp 1 koth_badlands.bsp 1 koth_harvest_final.bsp 1 koth_highpass.bsp 1 koth_king.bsp 1 koth_lakeside_final.bsp 1 koth_sawmill.bsp 1 pass_brickyard.bsp 1 pass_timbertown.bsp 1 pl_badwater.bsp 1 pl_cactuscanyon.bsp 1 pl_frontier_final.bsp 1 pl_goldrush.bsp 1 pl_hoodoo_final.bsp 1 pl_swiftwater_final1.bsp 1 pl_thundermountain.bsp 1 plr_hightower.bsp 1 plr_nightfall_final.bsp 1 plr_pipeline.bsp 1 sd_doomsday.bsp 1 tc_hydro.bsp 1 tr_dustbowl.bsp 1 tr_target.bsp 1}";

string mcHighPreset = @"lod=high
lighting=very_high
lighting_ex=high
shadows=high
flashlight=on
effects=high
water=very_high
particles=high
post_processing=high
pyrovision=high
romevision=on
motion_blur=off
anti_aliasing=msaa_8x
texture_filter=aniso8x
characters=high
decals=medium
decals_models=low
decals_art=on
sprays=off
gibs=medium
props=high
ragdolls=high
3dsky=on
jigglebones=on
textures=very_high
ropes=high
hud_player_model=on
outlines=high
sound=very_high
echo""High preset selected""";

string mcHighComfig = @"net_maxpacketdrop 0
cl_timeout 60
cl_smoothtime .05
hud_escort_interp .1
net_chokeloop 1
sv_lan 1
cl_localnetworkbackdoor 0
host_limitlocal 1
alias resetclass""cmd resetclass""
alias menuopen""cmd menuopen""
alias menuclosed""cmd menuclosed""
alias stop_taunt""cmd stop_taunt""
alias td_buyback""cmd td_buyback""
alias arena_changeclass""cmd arena_changeclass""
alias extendfreeze""cmd extendfreeze""
alias show_motd""cmd show_motd""
alias showroundinfo""cmd showroundinfo""
alias autoteam""cmd autoteam""
alias boo""cmd boo""
alias done_viewing_loot""cmd done_viewing_loot""
alias spectate""cmd spectate""
alias demorestart""cmd demorestart""
alias fade""cmd fade""
alias nextmap""cmd nextmap""
alias timeleft""cmd timeleft""
alias ignoremsg""cmd ignoremsg""
alias commentary_finishnode""cmd commentary_finishnode""
alias kill""cmd kill""
alias explode""cmd explode""
alias sourcetv_off""alias spec_next cmd spec_next;alias spec_prev cmd spec_prev;alias sourcetv_level echo sourcetv=off;alias sourcetv_on""
alias sourcetv_on""alias sourcetv_level echo sourcetv=on""
alias sourcetv sourcetv_on
alias interp_congestion_high""cl_interp .090909;setinfo cl_interp .090909""
alias interp_congestion_safe""cl_interp .060606;setinfo cl_interp .060606""
alias interp_congestion_low""cl_interp .030303;setinfo cl_interp .030303""
alias interp_congestion_spy""cl_interp .037499;setinfo cl_interp .037499""
alias interp_standard_high""cl_interp .045454;setinfo cl_interp .045454""
alias interp_standard_safe""cl_interp .030303;setinfo cl_interp .030303""
alias interp_standard_low""cl_interp .015151;setinfo cl_interp .015151""
alias interp_standard_spy""cl_interp .022499;setinfo cl_interp .022499""
alias interp_max_high""cl_interp .03;setinfo cl_interp .03""
alias interp_max_safe""cl_interp .02;setinfo cl_interp .02""
alias interp_max_low""cl_interp .01;setinfo cl_interp .01""
alias interp_max_spy""cl_interp .015;setinfo cl_interp .015""
alias packet_rate_congestion_aliases""alias interp_high interp_congestion_high;alias interp_safe interp_congestion_safe;alias interp_low interp_congestion_low;alias interp_spy interp_congestion_spy""
alias packet_rate_standard_aliases""alias interp_high interp_standard_high;alias interp_safe interp_standard_safe;alias interp_low interp_standard_low;alias interp_spy interp_standard_spy""
alias packet_rate_max_aliases""alias interp_high interp_max_high;alias interp_safe interp_max_safe;alias interp_low interp_max_low;alias interp_spy interp_max_spy""
alias packet_rate_congestion""cl_cmdrate 33;cl_updaterate 33;packet_rate_congestion_aliases;alias packet_rate_level echo packet_rate=congestion""
alias packet_rate_standard""cl_cmdrate 66;cl_updaterate 66;packet_rate_standard_aliases;alias packet_rate_level echo packet_rate=standard""
alias packet_rate_max""cl_cmdrate 100;cl_updaterate 100;packet_rate_max_aliases;alias packet_rate_level echo packet_rate=max""
alias packet_rate packet_rate_standard
alias snapshot_buffer_high""cl_interp_ratio 3;setinfo cl_interp_ratio 3;interp_high;alias snapshot_buffer_level echo snapshot_buffer=high""
alias snapshot_buffer_safe""cl_interp_ratio 2;setinfo cl_interp_ratio 2;interp_safe;alias snapshot_buffer_level echo snapshot_buffer=safe""
alias snapshot_buffer_low""cl_interp_ratio 1;setinfo cl_interp_ratio 1;interp_low;alias snapshot_buffer_level echo snapshot_buffer=low""
alias snapshot_buffer_auto""alias snapshot_buffer_level echo snapshot_buffer=auto""
alias snapshot_buffer_spy""cl_interp_ratio 1;setinfo cl_interp_ratio 1;interp_spy;alias snapshot_buffer_level echo snapshot_buffer=spy""
alias snapshot_buffer snapshot_buffer_safe
alias net_hitscan snapshot_buffer_safe
alias net_projectiles snapshot_buffer_low
alias net_spy snapshot_buffer_low
alias packet_size_small""net_compresspackets 1;net_compresspackets_minsize 200;net_maxroutable 512;net_maxfragments 512;alias packet_size_level echo packet_size=small""
alias packet_size_conservative""net_compresspackets 1;net_compresspackets_minsize 200;net_maxroutable 956;net_maxfragments 956;alias packet_size_level echo packet_size=conservative""
alias packet_size_saver""net_compresspackets 1;net_compresspackets_minsize 200;net_maxroutable 1200;net_maxfragments 1200;alias packet_size_level echo packet_size=saver""
alias packet_size_speed""net_compresspackets 0;net_compresspackets_minsize 4097;net_maxroutable 1200;net_maxfragments 1200;alias packet_size_level echo packet_size=speed""
alias packet_size packet_size_speed
net_maxcleartime 0
net_splitpacket_maxrate 50000
alias bandwidth_128Kbps""rate 16000;alias bandwidth_level echo bandwidth=128Kbps""
alias bandwidth_192Kbps""rate 24576;alias bandwidth_level echo bandwidth=192Kbps""
alias bandwidth_384Kbps""rate 49152;alias bandwidth_level echo bandwidth=384Kbps""
alias bandwidth_512Kbps""rate 65536;alias bandwidth_level echo bandwidth=512Kbps""
alias bandwidth_762Kbps""rate 80000;alias bandwidth_level echo bandwidth=762Kbps""
alias bandwidth_1.0Mbps""rate 131072;alias bandwidth_level echo bandwidth=1.0Mbps""
alias bandwidth_1.5Mbps""rate 196608;alias bandwidth_level echo bandwidth=1.5Mbps""
alias bandwidth_2.0Mbps""rate 262144;alias bandwidth_level echo bandwidth=2.0Mbps""
alias bandwidth_2.5Mbps""rate 327680;alias bandwidth_level echo bandwidth=2.5Mbps""
alias bandwidth_3.0Mbps""rate 393216;alias bandwidth_level echo bandwidth=3.0Mbps""
alias bandwidth_4.0Mbps""rate 524288;alias bandwidth_level echo bandwidth=4.0Mbps""
alias bandwidth_6.0Mbps""rate 786432;alias bandwidth_level echo bandwidth=6.0Mbps""
alias bandwidth_8.0Mbps""rate 1048576;alias bandwidth_level echo bandwidth=8.0Mbps""
alias bandwidth bandwidth_762Kbps
alias mm_queue_casual""quit smoking""
net_maxfilesize 64
alias download_all""cl_downloadfilter all;alias download_level echo download=all""
alias download_nosounds""cl_downloadfilter nosounds;alias download_level echo download=nosounds""
alias download_mapsonly""cl_downloadfilter mapsonly;alias download_level echo download=mapsonly""
alias download_none""cl_downloadfilter none;alias download_level echo download=none""
alias download_auto""alias download_level echo download=auto""
alias download download_auto
tf_mm_debug_level 0
sdr_spew_level 0
alias party_mode_open""tf_party_join_request_mode 0;alias party_mode_level echo party_mode=open""
alias party_mode_request""tf_party_join_request_mode 1;alias party_mode_level echo party_mode=request""
alias party_mode_invite""tf_party_join_request_mode 2;alias party_mode_level echo party_mode=invite""
alias party_mode party_mode_request
alias lod_low""r_rootlod 2;r_lod -1;alias lod_level echo lod=low""
alias lod_medium""r_rootlod 1;r_lod -1;alias lod_level echo lod=medium""
alias lod_high""r_rootlod 0;r_lod -1;alias lod_level echo lod=high""
alias lod_ultra""r_rootlod 0;r_lod 0;alias lod_level echo lod=ultra""
alias lod
r_lightcache_zbuffercache 1
mat_parallaxmap 0
mat_softwarelighting 0
r_hunkalloclightmaps 0
alias lightmaps_off""toggle mat_filterlightmaps""
alias lighting_very_low""mat_filterlightmaps 0;alias lightmaps_override lightmaps_off;r_ambientboost 0;r_lightaverage 0;r_dynamic 0;r_maxdlights 0;r_worldlightmin 999999;r_lightcache_zbuffercache 0;r_worldlights 0;mat_disable_lightwarp 1;mat_reducefillrate 1;r_rimlight 0;mat_bumpmap 0;mat_specular 0;building_cubemaps 1;alias lighting_level echo lighting=very_low""
alias lighting_low""mat_filterlightmaps 0;alias lightmaps_override lightmaps_off;r_ambientboost 0;r_lightaverage 0;r_dynamic 0;r_maxdlights 0;r_worldlightmin .0008;r_lightcache_zbuffercache 1;r_worldlights 0;mat_disable_lightwarp 1;mat_reducefillrate 1;r_rimlight 0;mat_bumpmap 0;mat_specular 0;building_cubemaps 1;alias lighting_level echo lighting=low""
alias lighting_medium""mat_filterlightmaps 1;alias lightmaps_override;r_ambientboost 0;r_lightaverage 0;r_dynamic 0;r_maxdlights 0;r_worldlightmin .0002;r_lightcache_zbuffercache 1;r_worldlights 0;mat_disable_lightwarp 1;mat_reducefillrate 1;r_rimlight 0;mat_bumpmap 1;mat_specular 1;building_cubemaps 1;alias lighting_level echo lighting=medium""
alias lighting_medium_high""mat_filterlightmaps 1;alias lightmaps_override;r_ambientboost 1;r_lightaverage 1;r_dynamic 0;r_maxdlights 0;r_worldlightmin .0002;r_lightcache_zbuffercache 1;r_worldlights 2;mat_disable_lightwarp 0;mat_reducefillrate 0;r_rimlight 0;mat_bumpmap 1;mat_specular 1;building_cubemaps 0;alias lighting_level echo lighting=medium_high""
alias lighting_high""mat_filterlightmaps 1;alias lightmaps_override;r_ambientboost 1;r_lightaverage 1;r_dynamic 1;r_maxdlights 6;r_worldlightmin .0002;r_lightcache_zbuffercache 1;r_worldlights 4;mat_disable_lightwarp 0;mat_reducefillrate 0;r_rimlight 1;mat_bumpmap 1;mat_specular 1;building_cubemaps 0;alias lighting_level echo lighting=high""
alias lighting_very_high""mat_filterlightmaps 1;alias lightmaps_override;r_ambientboost 1;r_lightaverage 1;r_dynamic 1;r_maxdlights 12;r_worldlightmin .0002;r_lightcache_zbuffercache 1;r_worldlights 4;mat_disable_lightwarp 0;mat_reducefillrate 0;r_rimlight 1;mat_bumpmap 1;mat_specular 1;building_cubemaps 0;alias lighting_level echo lighting=very_high""
alias lighting_ultra""mat_filterlightmaps 1;alias lightmaps_override;r_ambientboost 1;r_lightaverage 1;r_dynamic 1;r_maxdlights 32;r_worldlightmin .0002;r_lightcache_zbuffercache 0;r_worldlights 4;mat_disable_lightwarp 0;mat_reducefillrate 0;r_rimlight 1;mat_bumpmap 1;mat_specular 1;building_cubemaps 0;alias lighting_level echo lighting=ultra""
alias lighting
alias lighting_ex_low""mat_phong 0;alias lighting_ex_level echo lighting_ex=low""
alias lighting_ex_high""mat_phong 1;alias lighting_ex_level echo lighting_ex=high""
alias lighting_ex
r_shadowlod -2
alias shadowlod_low""r_shadowlod -2""
alias shadowlod_high""r_shadowlod 0""
alias sha_fla_support_aliases""shadows=very_low;shadows_very_low""
alias shadows_off""r_shadows 0;r_shadowrendertotexture 0;cl_blobbyshadows 1;r_shadowmaxrendered 0;nb_shadow_dist 0;alias shadowlod_override;alias sha_fla_support sha_fla_support_aliases;alias shadows_level echo shadows=off""
alias shadows_very_low""r_shadows 1;r_shadowrendertotexture 0;cl_blobbyshadows 1;r_shadowmaxrendered 0;nb_shadow_dist 0;alias shadowlod_override;alias sha_fla_support;alias shadows_level echo shadows=very_low""
alias shadows_low""r_shadows 1;r_shadowrendertotexture 0;cl_blobbyshadows 0;r_shadowmaxrendered 3;nb_shadow_dist 0;alias shadowlod_override;alias sha_fla_support;alias shadows_level echo shadows=low""
alias shadows_medium""r_shadows 1;r_shadowrendertotexture 1;cl_blobbyshadows 0;r_shadowmaxrendered 7;nb_shadow_dist 100;shadowlod_low;alias shadowlod_override shadowlod_low;alias sha_fla_support;alias shadows_level echo shadows=medium""
alias shadows_high""r_shadows 1;r_shadowrendertotexture 1;cl_blobbyshadows 0;r_shadowmaxrendered 11;nb_shadow_dist 400;shadowlod_low;alias shadowlod_override shadowlod_low;alias sha_fla_support;alias shadows_level echo shadows=high""
alias shadows_very_high""r_shadows 1;r_shadowrendertotexture 1;cl_blobbyshadows 0;r_shadowmaxrendered 23;nb_shadow_dist 1000;shadowlod_low;alias shadowlod_override shadowlod_low;alias sha_fla_support;alias shadows_level echo shadows=very_high""
alias shadows_ultra""r_shadows 1;r_shadowrendertotexture 1;cl_blobbyshadows 0;r_shadowmaxrendered 23;nb_shadow_dist 1000;shadowlod_high;alias shadowlod_override shadowlod_high;alias sha_fla_support;alias shadows_level echo shadows=ultra""
alias shadows
alias flashlight_off""mat_supportflashlight 0;r_flashlightculldepth 0;r_flashlightdepthtexture 0;r_flashlightmodels 0;r_flashlightrender 0;r_flashlightscissor 0;alias flashlight_level echo flashlight=off""
alias flashlight_on""mat_supportflashlight 1;r_flashlightculldepth 1;r_flashlightdepthtexture 1;r_flashlightmodels 1;r_flashlightrender 1;r_flashlightscissor 1;sha_fla_support;alias flashlight_level echo flashlight=on""
alias flashlight
ipc_exec_all quit smoking
alias effects_low""tracer_extra 0;r_drawtracers_firstperson 0;cl_show_splashes 0;cl_ejectbrass 0;cl_muzzleflash_dlight_1st 0;cl_drawmonitors 0;muzzleflash_light 0;cl_fasttempentcollision 1000000;alias effects_level echo effects=low""
alias effects_medium""tracer_extra 0;r_drawtracers_firstperson 1;cl_show_splashes 1;cl_ejectbrass 0;cl_muzzleflash_dlight_1st 0;cl_drawmonitors 1;muzzleflash_light 0;cl_fasttempentcollision 1000000;alias effects_level echo effects=medium""
alias effects_high""tracer_extra 1;r_drawtracers_firstperson 1;cl_show_splashes 1;cl_ejectbrass 0;cl_muzzleflash_dlight_1st 0;cl_drawmonitors 1;muzzleflash_light 0;cl_fasttempentcollision 5;alias effects_level echo effects=high""
alias effects_ultra""tracer_extra 1;r_drawtracers_firstperson 1;cl_show_splashes 1;cl_ejectbrass 1;cl_muzzleflash_dlight_1st 1;cl_drawmonitors 1;muzzleflash_light 1;cl_fasttempentcollision 0;alias effects_level echo effects=ultra""
alias effects
alias cheap_water_full""r_cheapwaterstart 0;r_cheapwaterend .1""
alias cheap_water_partial""r_cheapwaterstart 0;r_cheapwaterend 284""
alias cheap_water_minimal""r_cheapwaterstart 284;r_cheapwaterend 736""
alias cheap_water_never""r_cheapwaterstart 3000;r_cheapwaterend 3500""
alias water_very_low""r_WaterDrawReflection 0;r_waterforceexpensive 0;r_waterforcereflectentities 0;r_WaterDrawRefraction 0;cheap_water_full;alias cheap_water_override cheap_water_full;alias water_level echo water=very_low""
alias water_low""r_WaterDrawReflection 0;r_waterforceexpensive 0;r_waterforcereflectentities 0;r_WaterDrawRefraction 0;cheap_water_partial;alias cheap_water_override cheap_water_partial;alias water_level echo water=low""
alias water_medium""r_WaterDrawReflection 0;r_waterforceexpensive 0;r_waterforcereflectentities 0;r_WaterDrawRefraction 1;cheap_water_minimal;alias cheap_water_override cheap_water_minimal;alias water_level echo water=medium""
alias water_medium_high""r_WaterDrawReflection 1;r_waterforceexpensive 0;r_waterforcereflectentities 0;r_WaterDrawRefraction 1;cheap_water_minimal;alias cheap_water_override cheap_water_minimal;alias water_level echo water=medium_high""
alias water_high""r_WaterDrawReflection 1;r_waterforceexpensive 0;r_waterforcereflectentities 1;r_WaterDrawRefraction 1;cheap_water_minimal;alias cheap_water_override cheap_water_minimal;alias water_level echo water=high""
alias water_very_high""r_WaterDrawReflection 1;r_waterforceexpensive 1;r_waterforcereflectentities 1;r_WaterDrawRefraction 1;cheap_water_minimal;alias cheap_water_override cheap_water_minimal;alias water_level echo water=very_high""
alias water_ultra""r_WaterDrawReflection 1;r_waterforceexpensive 1;r_waterforcereflectentities 1;r_WaterDrawRefraction 1;cheap_water_never;alias cheap_water_override cheap_water_never;alias water_level echo water=ultra""
alias water
alias particles_very_low""tf_impactwatertimeenable 1;fx_drawimpactdebris 0;fx_drawimpactdust 0;fx_drawmetalspark 0;cl_particle_batch_mode 2;tf_particles_disable_weather 1;mat_reduceparticles 1;cl_new_impact_effects 0;r_drawflecks 0;cl_particle_retire_cost .0001;alias particles_level echo particles=very_low""
alias particles_low""tf_impactwatertimeenable 1;fx_drawimpactdebris 0;fx_drawimpactdust 0;fx_drawmetalspark 0;cl_particle_batch_mode 1;tf_particles_disable_weather 1;mat_reduceparticles 1;cl_new_impact_effects 0;r_drawflecks 0;cl_particle_retire_cost .0001;alias particles_level echo particles=low""
alias particles_medium""tf_impactwatertimeenable 1;fx_drawimpactdebris 0;fx_drawimpactdust 0;fx_drawmetalspark 0;cl_particle_batch_mode 1;tf_particles_disable_weather 1;mat_reduceparticles 1;cl_new_impact_effects 0;r_drawflecks 1;cl_particle_retire_cost .0001;alias particles_level echo particles=medium""
alias particles_high""tf_impactwatertimeenable 0;fx_drawimpactdebris 1;fx_drawimpactdust 1;fx_drawmetalspark 1;cl_particle_batch_mode 1;tf_particles_disable_weather 0;mat_reduceparticles 0;cl_new_impact_effects 0;r_drawflecks 1;cl_particle_retire_cost 0;alias particles_level echo particles=high""
alias particles_ultra""tf_impactwatertimeenable 0;fx_drawimpactdebris 1;fx_drawimpactdust 1;fx_drawmetalspark 1;cl_particle_batch_mode 0;tf_particles_disable_weather 0;mat_reduceparticles 0;cl_new_impact_effects 1;r_drawflecks 1;cl_particle_retire_cost 0;alias particles_level echo particles=ultra""
alias particles
mat_postprocess_x 1
alias post_processing_off""mat_hdr_level 0;mat_colorcorrection 0;mat_colcorrection_disableentities 1;r_bloomtintr .333;r_bloomtintg .333;r_bloomtintb .333;r_bloomtintexponent 1;alias post_processing_level echo post_processing=off""
alias post_processing_low""mat_hdr_level 0;mat_colorcorrection 1;mat_colcorrection_disableentities 0;r_bloomtintr .3;r_bloomtintg .59;r_bloomtintb .11;r_bloomtintexponent 2.2;alias post_processing_level echo post_processing=low""
alias post_processing_medium""mat_hdr_level 1;mat_colorcorrection 1;mat_colcorrection_disableentities 0;mat_bloom_scalefactor_scalar 1;r_bloomtintr .3;r_bloomtintg .59;r_bloomtintb .11;r_bloomtintexponent 2.2;alias post_processing_level echo post_processing=medium""
alias post_processing_high""mat_hdr_level 2;mat_colorcorrection 1;mat_colcorrection_disableentities 0;mat_bloom_scalefactor_scalar .75;r_bloomtintr .3;r_bloomtintg .59;r_bloomtintb .11;r_bloomtintexponent 2.2;alias post_processing_level echo post_processing=high""
alias post_processing
alias pyrovision_low""pyro_dof 0;pyro_vignette 0;alias pyrovision_level echo pyrovision=low""
alias pyrovision_medium""pyro_dof 0;pyro_vignette 1;pyro_vignette_distortion 0;alias pyrovision_level echo pyrovision=medium""
alias pyrovision_high""pyro_dof 1;pyro_vignette 2;pyro_vignette_distortion 1;alias pyrovision_level echo pyrovision=high""
alias pyrovision
alias romevision_off""tf_romevision_opt_in 0;alias romevision_level echo romevision=off""
alias romevision_on""tf_romevision_opt_in 1;alias romevision_level echo romevision=on""
alias romevision
alias motion_blur_off""mat_motion_blur_enabled 0;alias motion_blur_level echo motion_blur=off""
alias motion_blur_low""mat_motion_blur_enabled 1;mat_motion_blur_falling_intensity 0;mat_motion_blur_percent_of_screen_max 1.5;mat_motion_blur_rotation_intensity .05;mat_motion_blur_strength .5;alias motion_blur_level echo motion_blur=low""
alias motion_blur_high""mat_motion_blur_enabled 1;mat_motion_blur_falling_intensity 1;mat_motion_blur_falling_max 20;mat_motion_blur_falling_min 10;mat_motion_blur_percent_of_screen_max 2.5;mat_motion_blur_rotation_intensity .05;mat_motion_blur_strength .5;alias motion_blur_level echo motion_blur=high""
alias motion_blur
mat_software_aa_strength 0
mat_software_aa_strength_vgui 0
alias anti_aliasing_off""mat_alphacoverage 0;mat_antialias 1;alias anti_aliasing_level echo anti_aliasing=off""
alias anti_aliasing_msaa_2x""mat_alphacoverage 1;mat_antialias 2;alias anti_aliasing_level echo anti_aliasing=msaa_2x""
alias anti_aliasing_msaa_4x""mat_alphacoverage 1;mat_antialias 4;alias anti_aliasing_level echo anti_aliasing=msaa_4x""
alias anti_aliasing_msaa_8x""mat_alphacoverage 1;mat_antialias 8;alias anti_aliasing_level echo anti_aliasing=msaa_8x""
alias anti_aliasing
alias texture_filter_bilinear""mat_forceaniso 1;mat_trilinear 0;alias texture_filter_level echo texture_filter=bilinear""
alias texture_filter_trilinear""mat_forceaniso 1;mat_trilinear 1;alias texture_filter_level echo texture_filter=trilinear""
alias texture_filter_aniso2x""mat_forceaniso 2;alias texture_filter_level echo texture_filter=aniso2x""
alias texture_filter_aniso4x""mat_forceaniso 4;alias texture_filter_level echo texture_filter=aniso4x""
alias texture_filter_aniso8x""mat_forceaniso 8;alias texture_filter_level echo texture_filter=aniso8x""
alias texture_filter_aniso16x""mat_forceaniso 16;alias texture_filter_level echo texture_filter=aniso16x""
alias texture_filter
alias characters_very_low""r_flex 0;flex_rules 0;anim_3wayblend 0;r_teeth 0;flex_smooth 0;r_eyes 0;r_eyemove 0;tf_clientsideeye_lookats 0;blink_duration 0;phonemefilter .001;phonemedelay -30;phonemesnap 0;alias characters_level echo characters=very_low""
alias characters_low""r_flex 0;flex_rules 0;anim_3wayblend 0;r_teeth 0;flex_smooth 0;r_eyes 1;r_eyemove 0;tf_clientsideeye_lookats 0;blink_duration 0;phonemefilter .001;phonemedelay -30;phonemesnap 0;alias characters_level echo characters=low""
alias characters_medium""r_flex 1;flex_rules 1;anim_3wayblend 0;r_teeth 1;flex_smooth 0;r_eyes 1;r_eyemove 0;tf_clientsideeye_lookats 0;blink_duration 0;phonemefilter .001;phonemedelay -30;phonemesnap 0;alias characters_level echo characters=medium""
alias characters_medium_high""r_flex 1;flex_rules 1;anim_3wayblend 0;r_teeth 1;flex_smooth 0;r_eyes 1;r_eyemove 1;tf_clientsideeye_lookats 1;blink_duration .2;phonemefilter .08;phonemedelay 0;phonemesnap 1;alias characters_level echo characters=medium_high""
alias characters_high""r_flex 1;flex_rules 1;anim_3wayblend 1;r_teeth 1;flex_smooth 1;r_eyes 1;r_eyemove 1;tf_clientsideeye_lookats 1;blink_duration .2;phonemefilter .08;phonemedelay 0;phonemesnap 2;alias characters_level echo characters=high""
alias characters_ultra""r_flex 1;flex_rules 1;anim_3wayblend 1;r_teeth 1;flex_smooth 1;r_eyes 1;r_eyemove 1;tf_clientsideeye_lookats 1;blink_duration .2;phonemefilter .08;phonemedelay 0;phonemesnap 4;alias characters_level echo characters=ultra""
alias characters
alias decals_clear_all""r_cleardecals permanent""
alias decals_sprays_support_aliases""decals=low;decals_low""
alias decals_off""r_decals 1;mp_decals 1;r_decal_cover_count 10;r_decal_overlap_area 1.1;r_decal_overlap_count 10;r_drawbatchdecals 0;alias decals_sprays_support decals_sprays_support_aliases;alias decals_level echo decals=off""
alias decals_low""r_decals 9;mp_decals 9;r_decal_cover_count 4;r_decal_overlap_area .4;r_decal_overlap_count 3;r_drawbatchdecals 1;alias decals_sprays_support;alias decals_level echo decals=low""
alias decals_medium""r_decals 32;mp_decals 32;r_decal_cover_count 4;r_decal_overlap_area .4;r_decal_overlap_count 3;r_drawbatchdecals 1;alias decals_sprays_support;alias decals_level echo decals=decals_medium""
alias decals_high""r_decals 80;mp_decals 80;r_decal_cover_count 4;r_decal_overlap_area .4;r_decal_overlap_count 3;r_drawbatchdecals 1;alias decals_sprays_support;alias decals_level echo decals=decals_high""
alias decals_ultra""r_decals 256;mp_decals 256;r_decal_cover_count 4;r_decal_overlap_area .4;r_decal_overlap_count 3;r_drawbatchdecals 1;alias decals_sprays_support;alias decals_level echo decals=decals_ultra""
alias decals
alias decals_models_off""r_drawmodeldecals 0;alias decals_models_level echo decals_models=off""
alias decals_models_low""r_drawmodeldecals 1;r_maxmodeldecal 9;alias decals_models_level echo decals_models=low""
alias decals_models_high""r_drawmodeldecals 1;r_maxmodeldecal 32;alias decals_models_level echo decals_models=high""
alias decals_models
alias decals_art_off""r_renderoverlayfragment 0;alias decals_clear decals_clear_all;alias decals_art_level echo decals_art=off""
alias decals_art_on""r_renderoverlayfragment 1;alias decals_clear;alias decals_art_level echo decals_art=on""
alias decals_art
alias sprays_off""cl_allowdownload 0;cl_allowupload 0;r_spray_lifetime 0;cl_spraydisable 1;alias sprays_level echo sprays=off""
alias sprays_on""cl_allowdownload 1;cl_allowupload 1;r_spray_lifetime 2;cl_spraydisable 0;alias decals_clear;decals_sprays_support;alias sprays_level echo sprays=on""
alias sprays
alias sillygibs_off""violence_hgibs 1;violence_hblood 1;violence_agibs 1;violence_ablood 1;alias sillygibs_level echo sillygibs=off""
alias sillygibs_on""violence_hgibs 0;violence_hblood 0;violence_agibs 0;violence_ablood 0;alias sillygibs_level echo sillygibs=on""
alias sillygibs_auto""alias sillygibs_level echo sillygibs=auto""
alias sillygibs sillygibs_auto
alias gibs_off""cl_burninggibs 0;props_break_max_pieces 0;tf_playergib 0;sillygibs_on;sillygibs;alias gibs_level echo gibs=off""
alias gibs_low""cl_burninggibs 0;props_break_max_pieces 2;tf_playergib 1;sillygibs_off;sillygibs;alias gibs_level echo gibs=low""
alias gibs_medium_low""cl_burninggibs 0;props_break_max_pieces 4;tf_playergib 1;sillygibs_off;sillygibs;alias gibs_level echo gibs=medium_low""
alias gibs_medium""cl_burninggibs 0;props_break_max_pieces -1;tf_playergib 1;sillygibs_off;sillygibs;alias gibs_level echo gibs=medium""
alias gibs_high""cl_burninggibs 1;props_break_max_pieces -1;tf_playergib 1;sillygibs_off;sillygibs;alias gibs_level echo gibs=high""
alias gibs
alias detail_props_none""r_drawdetailprops 0;cl_detaildist 1;cl_detailfade 0""
alias detail_props_medium""r_drawdetailprops 1;cl_detaildist 1200;cl_detailfade 0""
alias detail_props_full""r_drawdetailprops 1;cl_detaildist 1200;cl_detailfade 400""
alias props_low""r_decalstaticprops 0;cl_phys_props_enable 0;r_staticprop_lod 7;r_propsmaxdist 0;lod_TransitionDist -1;detail_props_none;alias detail_props_override detail_props_none;alias props_level echo props=low""
alias props_medium""r_decalstaticprops 0;cl_phys_props_enable 0;r_staticprop_lod -1;r_propsmaxdist 0;lod_TransitionDist -1;detail_props_none;alias detail_props_override detail_props_none;alias props_level echo props=medium""
alias props_high""r_decalstaticprops 1;cl_phys_props_enable 1;r_staticprop_lod -1;r_propsmaxdist 500;lod_TransitionDist -5000;cl_phys_props_max 20;cl_phys_props_respawndist 500;cl_phys_props_respawnrate 120;detail_props_medium;alias detail_props_override detail_props_medium;alias props_level echo props=high""
alias props_ultra""r_decalstaticprops 1;cl_phys_props_enable 1;r_staticprop_lod 0;r_propsmaxdist 900;lod_TransitionDist 400;cl_phys_props_max 100;cl_phys_props_respawndist 901;cl_phys_props_respawnrate 60;detail_props_full;alias detail_props_override detail_props_full;alias props_level echo props=ultra""
alias props
alias ragdolls_hidden""cl_ragdoll_fade_time -3;cl_ragdoll_forcefade 1;cl_ragdoll_physics_enable 0;cl_ragdoll_collide 0;ragdoll_sleepaftertime 0;alias ragdolls_level echo ragdolls=hidden""
alias ragdolls_off""cl_ragdoll_fade_time -3;cl_ragdoll_forcefade 1;cl_ragdoll_physics_enable 1;cl_ragdoll_collide 0;ragdoll_sleepaftertime 0;alias ragdolls_level echo ragdolls=off""
alias ragdolls_low ragdolls_off
alias ragdolls_medium""cl_ragdoll_fade_time 5;cl_ragdoll_forcefade 0;cl_ragdoll_physics_enable 1;cl_ragdoll_collide 0;ragdoll_sleepaftertime 1.5;alias ragdolls_level echo ragdolls=medium""
alias ragdolls_high""cl_ragdoll_fade_time 10;cl_ragdoll_forcefade 0;cl_ragdoll_physics_enable 1;cl_ragdoll_collide 1;ragdoll_sleepaftertime 5;alias ragdolls_level echo ragdolls=high""
alias ragdolls
mat_viewportscale 1
alias 3dsky_off""r_3dsky 0;alias 3dsky_level echo 3dsky=off""
alias 3dsky_on""r_3dsky 1;alias 3dsky_level echo 3dsky=on""
alias 3dsky
alias jigglebones_off""cl_jiggle_bone_framerate_cutoff 0;alias jigglebones_level echo jigglesbones=off""
alias jigglebones_on""cl_jiggle_bone_framerate_cutoff 67;alias jigglebones_level echo jigglesbones=on""
alias jigglebones_force_on""cl_jiggle_bone_framerate_cutoff 1;alias jigglebones_level echo jigglesbones=force_on""
alias jigglebones
alias sheens_speed_off""tf_sheen_framerate 0;alias sheens_speed_level echo sheens_speed=off""
alias sheens_speed_slow""tf_sheen_framerate 15;alias sheens_speed_level echo sheens_speed=slow""
alias sheens_speed_medium""tf_sheen_framerate 25;alias sheens_speed_level echo sheens_speed=medium""
alias sheens_speed_fast""tf_sheen_framerate 55;alias sheens_speed_level echo sheens_speed=fast""
alias sheens_speed sheens_speed_slow
alias sheens_tint_low""tf_sheen_alpha_firstperson 0;alias sheens_tint_level echo sheens_tint=low""
alias sheens_tint_medium""tf_sheen_alpha_firstperson .1;alias sheens_tint_level echo sheens_tint=medium""
alias sheens_tint_high""tf_sheen_alpha_firstperson .5;alias sheens_tint_level echo sheens_tint=high""
alias sheens_tint_full""tf_sheen_alpha_firstperson 1;alias sheens_tint_level echo sheens_tint=full""
alias sheens_tint sheens_tint_high
alias textures_very_low""mat_filtertextures 0;mat_picmip 2;mat_disable_fancy_blending 1;alias textures_level echo textures=very_low""
alias textures_low""mat_filtertextures 1;mat_picmip 2;mat_disable_fancy_blending 1;alias textures_level echo textures=low""
alias textures_medium""mat_filtertextures 1;mat_picmip 1;mat_disable_fancy_blending 0;alias textures_level echo textures=medium""
alias textures_high""mat_filtertextures 1;mat_picmip 0;mat_disable_fancy_blending 0;alias textures_level echo textures=high""
alias textures_very_high""mat_filtertextures 1;mat_picmip -1;mat_disable_fancy_blending 0;alias textures_level echo textures=very_high""
alias textures
alias ropes_off""r_drawropes 0;rope_rendersolid 0;r_ropetranslucent 0;rope_smooth 0;rope_subdiv 0;rope_collide 0;rope_wind_dist 0;alias ropes_level echo ropes=off""
alias ropes_low""r_drawropes 1;rope_rendersolid 1;r_ropetranslucent 0;rope_smooth 0;rope_subdiv 1;rope_collide 0;rope_wind_dist 0;alias ropes_level echo ropes=low""
alias ropes_high""r_drawropes 1;rope_rendersolid 1;r_ropetranslucent 1;rope_smooth 1;rope_subdiv 2;rope_collide 0;rope_wind_dist 0;alias ropes_level echo ropes=high""
alias ropes_ultra""r_drawropes 1;rope_rendersolid 1;r_ropetranslucent 1;rope_smooth 1;rope_subdiv 7;rope_collide 1;rope_wind_dist 1000;alias ropes_level echo ropes=ultra""
alias ropes
engine_no_focus_sleep 1
r_fastzreject 1
mat_tonemapping_occlusion_use_stencil 0
r_norefresh 1
fast_fogvolume 1
mod_offline_hdr_switch 1
mat_forcemanagedtextureintohardware 0
mat_requires_rt_alloc_first 0
sys_minidumpspewlines 0
sv_logdownloadlist 0
mat_forcehardwaresync 1
mat_managedtextures 0
mat_queue_mode -1
alias mm_queue_party""quit smoking""
alias fpscap_powersaver""mat_powersavingsmode 1;alias fpscap_level echo fpscap=powersaver""
alias fpscap_30""mat_powersavingsmode 0;fps_max 30;alias fpscap_level echo fpscap=30""
alias fpscap_60""mat_powersavingsmode 0;fps_max 60;alias fpscap_level echo fpscap=60""
alias fpscap_75""mat_powersavingsmode 0;fps_max 75;alias fpscap_level echo fpscap=75""
alias fpscap_120""mat_powersavingsmode 0;fps_max 120;alias fpscap_level echo fpscap=120""
alias fpscap_144""mat_powersavingsmode 0;fps_max 144;alias fpscap_level echo fpscap=144""
alias fpscap_160""mat_powersavingsmode 0;fps_max 160;alias fpscap_level echo fpscap=160""
alias fpscap_165""mat_powersavingsmode 0;fps_max 165;alias fpscap_level echo fpscap=165""
alias fpscap_180""mat_powersavingsmode 0;fps_max 180;alias fpscap_level echo fpscap=180""
alias fpscap_200""mat_powersavingsmode 0;fps_max 200;alias fpscap_level echo fpscap=200""
alias fpscap_240""mat_powersavingsmode 0;fps_max 240;alias fpscap_level echo fpscap=240""
alias fpscap_300""mat_powersavingsmode 0;fps_max 300;alias fpscap_level echo fpscap=300""
alias fpscap_360""mat_powersavingsmode 0;fps_max 360;alias fpscap_level echo fpscap=360""
alias fpscap_400""mat_powersavingsmode 0;fps_max 400;alias fpscap_level echo fpscap=400""
alias fpscap_1000""mat_powersavingsmode 0;fps_max 1000;alias fpscap_level echo fpscap=1000""
alias fpscap_unlimited""mat_powersavingsmode 0;fps_max 0;alias fpscap_level echo fpscap=unlimited""
alias fpscap fpscap_1000
alias vsync_off""mat_vsync 0;alias vsync_level echo vsync=off""
alias vsync_on""mat_vsync 1;alias vsync_level echo vsync=on""
alias vsync vsync_off
tf_dashboard_slide_time .1
tf_item_inspect_model_auto_spin 1
tf_item_inspect_model_spin_rate 30
tf_quest_map_tuner_wobble_magnitude .01
tf_colorblindassist 1
sv_motd_unload_on_dismissal 1
tf_halloween_bonus_ducks_cooldown 20
tf_hud_num_building_alert_beeps 2
tf_hud_show_servertimelimit 1
scr_centertime 5
hud_medichealtargetmarker 1
tf_scoreboard_ping_as_text 1
alias hud_player_model_off""cl_hud_playerclass_use_playermodel 0;alias hud_player_model_level hud_player_model=off""
alias hud_player_model_on""cl_hud_playerclass_use_playermodel 1;alias hud_player_model_level hud_player_model=on""
alias hud_player_model
alias hud_panels_off""tf_healthicon_height_offset -10000;tf_hud_target_id_offset -10000;tf_hud_target_id_alpha 0;alias hud_panels_level echo hud_panels=off""
alias hud_panels_low""tf_healthicon_height_offset 10;tf_hud_target_id_offset 0;tf_hud_target_id_alpha 255;alias hud_panels_level echo hud_panels=low""
alias hud_panels_high""tf_healthicon_height_offset 10;tf_hud_target_id_offset 0;tf_hud_target_id_alpha 100;alias hud_panels_level echo hud_panels=high""
alias hud_panels hud_panels_high
alias hud_avatars_off""tf_hud_target_id_show_avatars 0;alias hud_avatars_level echo hud_avatars=off""
alias hud_avatars_everyone""tf_hud_target_id_show_avatars 1;alias hud_avatars_level echo hud_avatars=everyone""
alias hud_avatars_friends""tf_hud_target_id_show_avatars 2;alias hud_avatars_level echo hud_avatars=friends""
alias hud_avatars hud_avatars_friends
alias match_hud_alias""tf_use_match_hud 0;alias match_hud_level echo match_hud=off""
alias match_hud_alias2""alias match_hud_off match_hud_alias""
alias match_hud_off""tf_use_match_hud 1;alias match_hud_once match_hud_alias;alias match_hud_level echo match_hud=off""
alias match_hud_on""tf_use_match_hud 1;alias match_hud_once;alias match_hud_level echo match_hud=on""
alias match_hud match_hud_on
alias dynamic_background_off""alias dynamic_background_level echo dynamic_background=off""
alias dynamic_background_preload""map_background preload_room;wait 10;disconnect;alias dynamic_background_level echo dynamic_background=preload""
alias dynamic_background_itemtest""map_background itemtest;wait 10;disconnect;alias dynamic_background_level echo dynamic_background=itemtest""
alias dynamic_background_dustbowl""map_background background01;wait 1000;stop;alias dynamic_background_level echo dynamic_background=dustbowl""
alias dynamic_background dynamic_background_off
alias htmlmotd_off""cl_disablehtmlmotd 1;alias htmlmotd_level echo htmlmotd=off""
alias htmlmotd_on""cl_disablehtmlmotd 0;alias htmlmotd_level echo htmlmotd=on""
alias htmlmotd htmlmotd_off
cl_mute_all_comms 1
tf_chat_popup_hold_time 3
alias messages_off""hud_saytext_time 0;cl_enable_text_chat 0;cl_showtextmsg 0;alias messages_level echo messages=off""
alias messages_hide""hud_saytext_time 0;cl_enable_text_chat 1;cl_showtextmsg 1;alias messages_level echo messages=hide""
alias messages_on""hud_saytext_time 10;cl_enable_text_chat 1;cl_showtextmsg 1;alias messages_level echo messages=on""
alias messages messages_on
alias killfeed_off""hud_deathnotice_time 0;alias killfeed_level echo killfeed=off""
alias killfeed_on""hud_deathnotice_time 5;alias killfeed_level echo killfeed=on""
alias killfeed killfeed_on
tf_time_loading_item_panels .0005
tf_backpack_page_button_delay .25
alias killstreaks_off""cl_hud_killstreak_display_time 0;alias killstreaks_level echo killstreaks=off""
alias killstreaks_low""cl_hud_killstreak_display_alpha 255;cl_hud_killstreak_display_time 2;alias killstreaks_level echo killstreaks=low""
alias killstreaks_high""cl_hud_killstreak_display_alpha 100;cl_hud_killstreak_display_time 2;alias killstreaks_level echo killstreaks=high""
alias killstreaks killstreaks_high
cl_notifications_max_num_visible 3
cl_notifications_move_time .1
cl_notifications_show_ingame 1
cl_vote_ui_active_after_voting 1
alias hud_achievement_off""hud_achievement_description 0;hud_achievement_tracker 0;hud_achievement_count 0;hud_achievement_count_engineer 0;hud_achievement_glowtime 0;alias hud_achievement_level hud_achievement=off""
alias hud_achievement_on""hud_achievement_description 1;hud_achievement_tracker 1;hud_achievement_count 8;hud_achievement_count_engineer 3;hud_achievement_glowtime 2.5;alias hud_achievement_level hud_achievement=on""
alias hud_achievement hud_achievement_on
cl_mvm_wave_status_visible_during_wave 1
con_nprint_bgalpha 100
alias console_off""con_filter_text zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz;con_filter_enable 1;con_enable 0;alias console_level echo console=off""
alias console_on""con_filter_enable 0;con_enable 1;alias console_level echo console=on""
alias console console_on
alias console_off_flip""hideconsole;console_off;alias switchconsole console_on_flip""
alias console_on_flip""console_on;showconsole;alias switchconsole console_off_flip""
alias switchconsole console_on_flip
alias debug_output""debug_output_1""
alias debug_output_toggle""incrementvar developer -1 2 1""
alias debug_output_display""developer -1""
alias debug_output_1""developer 1""
alias debug_output_2""developer 2""
alias debug_instant_respawn""sv_cheats 1;mp_disable_respawn_times 1;spec_freeze_time 0;spec_freeze_traveltime 0;mp_respawnwavetime 0""
alias debug_invulnerable""sv_cheats 1;buddha""
alias debug_bots""tf_bot_kick all;tf_bot_quota_mode normal;tf_bot_difficulty 3;tf_bot_quota 32""
alias debug_target""sv_cheats 1;bot -targetdummy""
alias debug_occlusion""sv_cheats 1;r_visocclusion 1;r_occlusionspew 1""
alias debug_pixelvis""r_drawpixelvisibility 1;r_pixelvisibility_spew 1""
alias debug_fillrate""sv_cheats 1;mat_fillrate 1""
alias debug_matsys_reload""toggle mat_aaquality""
alias debug_sound_loads""snd_async_showmem;snd_async_spew 1;snd_async_spew_blocking 2;snd_async_stream_spew 2""
alias debug_sound_dsp""sv_cheats 1;snd_showstart 2;adsp_debug 6""
alias debug_network_packets""net_showudp 1""
alias debug_network_drops""net_showdrop 1""
alias debug_network_graph""net_graph 4""
alias debug_network_pred""cl_showerror 2""
alias debug_fps""net_graph 1""
alias debug_fps_range""cl_showfps 0;cl_showfps 2""
alias debug_vprof_log_spike""con_logfile vprof_spike.log""
alias debug_vprof_log""con_logfile vprof.log""
alias debug_vprof_spike""vprof_dump_spikes 100""
alias debug_vprof_spikes""vprof_off;vprof_reset;debug_vprof_log_spike;vprof_dump_oninterval 0;vprof_report_oninterval 0;debug_vprof_spike;vprof_on""
alias debug_vprof_dump""vprof_off;vprof_reset;debug_vprof_log;vprof_dump_oninterval 10;vprof_report_oninterval 0;vprof_dump_spikes 0;vprof_on""
alias debug_vprof_report""vprof_off;vprof_reset;debug_vprof_log;vprof_dump_oninterval 0;vprof_report_oninterval 10;vprof_dump_spikes 0;vprof_on""
alias debug_vprof_off""vprof_off;vprof_reset;con_logfile 0;vprof_dump_oninterval 0;vprof_report_oninterval 0;vprof_dump_spikes 0""
net_graphsolid 1
fov_desired 90
alias outlines_off""glow_outline_effect_enable 0;tf_enable_glows_after_respawn 0;tf_spec_xray_disable 1;alias outlines_level echo outlines=off""
alias outlines_low""glow_outline_effect_enable 0;tf_enable_glows_after_respawn 1;tf_spec_xray_disable 0;alias outlines_level echo outlines=low""
alias outlines_medium""glow_outline_effect_enable 1;tf_enable_glows_after_respawn 0;tf_spec_xray_disable 1;alias outlines_level echo outlines=medium""
alias outlines_high""glow_outline_effect_enable 1;tf_enable_glows_after_respawn 1;tf_spec_xray_disable 0;alias outlines_level echo outlines=high""
alias outlines
bugreporter_uploadasync 1
lzma_persistent_buffer 1
cl_always_flush_models 0
filesystem_buffer_size 1
filesystem_max_stdio_read 64
alias flush_models_on""cl_always_flush_models 1""
alias mod_support_off""alias flush_models flush_models_on;alias mod_support_level echo mod_support=off""
alias mod_support_on""alias flush_models;alias mod_support_level echo mod_support=on""
alias mod_support mod_support_on
tf_dingalingaling_repeat_delay .007
snd_async_fullyasync 1
snd_async_minsize 0
snd_mixahead .05
snd_delay_sound_shift .001
snd_legacy_surround 0
snd_noextraupdate 1
snd_async_spew_blocking 0
alias sound_low""snd_disable_mixer_duck 1;snd_pitchquality 0;dsp_slow_cpu 1;snd_spatialize_roundrobin 3;dsp_room 0;dsp_speaker 0;dsp_water 0;dsp_spatial 0;snd_defer_trace 1;dsp_enhance_stereo 0;alias sound_level echo sound=low""
alias sound_medium""snd_disable_mixer_duck 0;snd_pitchquality 0;dsp_slow_cpu 1;snd_spatialize_roundrobin 1;dsp_room 0;dsp_speaker 50;dsp_water 0;dsp_spatial 40;snd_defer_trace 1;dsp_enhance_stereo 0;alias sound_level echo sound=medium""
alias sound_high""snd_disable_mixer_duck 0;snd_pitchquality 1;dsp_slow_cpu 0;snd_spatialize_roundrobin 1;dsp_room 0;dsp_speaker 50;dsp_water 14;dsp_spatial 40;snd_defer_trace 1;dsp_enhance_stereo 0;alias sound_level echo sound=high""
alias sound_very_high""snd_disable_mixer_duck 0;snd_pitchquality 1;dsp_slow_cpu 0;snd_spatialize_roundrobin 0;dsp_room 0;dsp_speaker 50;dsp_water 14;dsp_spatial 40;snd_defer_trace 0;dsp_enhance_stereo 0;alias sound_level echo sound=very_high""
alias sound_ultra""snd_disable_mixer_duck 0;snd_pitchquality 1;dsp_slow_cpu 0;snd_spatialize_roundrobin 0;dsp_room 1;dsp_speaker 50;dsp_water 14;dsp_spatial 40;snd_defer_trace 0;dsp_enhance_stereo 1;alias sound_level echo sound=ultra""
alias sound
alias voice_chat_off""voice_enable 0;voice_modenable 0;cmd VModEnable 0;alias voice_chat_level echo voice_chat=off""
alias voice_chat_on""voice_enable 1;voice_modenable 1;cmd VModEnable 1;alias voice_chat_level echo voice_chat=on""
alias voice_chat voice_chat_on
detach
alias logo_off""alias logo_level echo logo=off""
alias logo_on""startlogo;alias logo_level echo logo=on""
alias logo logo_on
alias sourcetv=off""alias sourcetv sourcetv_off""
alias sourcetv=on""alias sourcetv sourcetv_on""
alias packet_rate=congestion""alias packet_rate packet_rate_congestion""
alias packet_rate=standard""alias packet_rate packet_rate_standard""
alias packet_rate=max""alias packet_rate packet_rate_max""
alias snapshot_buffer=auto""alias snapshot_buffer snapshot_buffer_auto""
alias snapshot_buffer=high""alias snapshot_buffer snapshot_buffer_high""
alias snapshot_buffer=safe""alias snapshot_buffer snapshot_buffer_safe""
alias snapshot_buffer=low""alias snapshot_buffer snapshot_buffer_low""
alias packet_size=small""alias packet_size packet_size_small""
alias packet_size=conservative""alias packet_size packet_size_conservative""
alias packet_size=saver""alias packet_size packet_size_saver""
alias packet_size=speed""alias packet_size packet_size_speed""
alias bandwidth=128Kbps""alias bandwidth bandwidth_128Kbps""
alias bandwidth=192Kbps""alias bandwidth bandwidth_192Kbps""
alias bandwidth=384Kbps""alias bandwidth bandwidth_384Kbps""
alias bandwidth=512Kbps""alias bandwidth bandwidth_512Kbps""
alias bandwidth=762Kbps""alias bandwidth bandwidth_762Kbps""
alias bandwidth=1.0Mbps""alias bandwidth bandwidth_1.0Mbps""
alias bandwidth=1.5Mbps""alias bandwidth bandwidth_1.5Mbps""
alias bandwidth=2.0Mbps""alias bandwidth bandwidth_2.0Mbps""
alias bandwidth=2.5Mbps""alias bandwidth bandwidth_2.5Mbps""
alias bandwidth=3.0Mbps""alias bandwidth bandwidth_3.0Mbps""
alias bandwidth=4.0Mbps""alias bandwidth bandwidth_4.0Mbps""
alias bandwidth=6.0Mbps""alias bandwidth bandwidth_6.0Mbps""
alias bandwidth=8.0Mbps""alias bandwidth bandwidth_8.0Mbps""
alias download=auto""alias download download_auto""
alias download=all""alias download download_all""
alias download=nosounds""alias download download_nosounds""
alias download=mapsonly""alias download download_mapsonly""
alias download=none""alias download download_none""
alias lod=low""alias lod lod_low""
alias lod=medium""alias lod lod_medium""
alias lod=high""alias lod lod_high""
alias lod=ultra""alias lod lod_ultra""
alias lighting=very_low""alias lighting lighting_very_low""
alias lighting=low""alias lighting lighting_low""
alias lighting=medium""alias lighting lighting_medium""
alias lighting=medium_high""alias lighting lighting_medium_high""
alias lighting=high""alias lighting lighting_high""
alias lighting=very_high""alias lighting lighting_very_high""
alias lighting=ultra""alias lighting lighting_ultra""
alias lighting_ex=low""alias lighting_ex lighting_ex_low""
alias lighting_ex=high""alias lighting_ex lighting_ex_high""
alias shadows=off""alias shadows shadows_off""
alias shadows=very_low""alias shadows shadows_very_low""
alias shadows=low""alias shadows shadows_low""
alias shadows=medium""alias shadows shadows_medium""
alias shadows=high""alias shadows shadows_high""
alias shadows=very_high""alias shadows shadows_very_high""
alias shadows=ultra""alias shadows shadows_ultra""
alias flashlight=off""alias flashlight flashlight=off""
alias flashlight=on""alias flashlight flashlight=on""
alias effects=low""alias effects effects_low""
alias effects=medium""alias effects effects_medium""
alias effects=high""alias effects effects_high""
alias effects=ultra""alias effects effects_ultra""
alias water=very_low""alias water water_very_low""
alias water=low""alias water water_low""
alias water=medium""alias water water_medium""
alias water=medium_high""alias water water_medium_high""
alias water=high""alias water water_high""
alias water=very_high""alias water water_very_high""
alias water=ultra""alias water water_ultra""
alias particles=very_low""alias particles particles_very_low""
alias particles=low""alias particles particles_low""
alias particles=medium""alias particles particles_medium""
alias particles=high""alias particles particles_high""
alias particles=ultra""alias particles particles_ultra""
alias post_processing=off""alias post_processing post_processing_off""
alias post_processing=low""alias post_processing post_processing_low""
alias post_processing=medium""alias post_processing post_processing_medium""
alias post_processing=high""alias post_processing post_processing_high""
alias pyrovision=low""alias pyrovision pyrovision_low""
alias pyrovision=medium""alias pyrovision pyrovision_medium""
alias pyrovision=high""alias pyrovision pyrovision_high""
alias romevision=off""alias romevision romevision_off""
alias romevision=on""alias romevision romevision_on""
alias motion_blur=off""alias motion_blur motion_blur_off""
alias motion_blur=low""alias motion_blur motion_blur_low""
alias motion_blur=high""alias motion_blur motion_blur_high""
alias anti_aliasing=off""alias anti_aliasing anti_aliasing_off""
alias anti_aliasing=msaa_2x""alias anti_aliasing anti_aliasing_msaa_2x""
alias anti_aliasing=msaa_4x""alias anti_aliasing anti_aliasing_msaa_4x""
alias anti_aliasing=msaa_8x""alias anti_aliasing anti_aliasing_msaa_8x""
alias texture_filter=bilinear""alias texture_filter texture_filter_bilinear""
alias texture_filter=trilinear""alias texture_filter texture_filter_trilinear""
alias texture_filter=aniso2x""alias texture_filter texture_filter_aniso2x""
alias texture_filter=aniso4x""alias texture_filter texture_filter_aniso4x""
alias texture_filter=aniso8x""alias texture_filter texture_filter_aniso8x""
alias texture_filter=aniso16x""alias texture_filter texture_filter_aniso16x""
alias characters=very_low""alias characters characters_very_low""
alias characters=low""alias characters characters_low""
alias characters=medium""alias characters characters_medium""
alias characters=medium_high""alias characters characters_medium_high""
alias characters=high""alias characters characters_high""
alias characters=ultra""alias characters characters_ultra""
alias decals=off""alias decals decals_off""
alias decals=low""alias decals decals_low""
alias decals=medium""alias decals decals_medium""
alias decals=high""alias decals decals_high""
alias decals=ultra""alias decals decals_ultra""
alias decals_models=off""alias decals_models decals_models_off""
alias decals_models=low""alias decals_models decals_models_low""
alias decals_models=high""alias decals_models decals_models_high""
alias decals_art=off""alias decals_art decals_art_off""
alias decals_art=on""alias decals_art decals_art_on""
alias sprays=off""alias sprays sprays_off""
alias sprays=on""alias sprays sprays_on""
alias gibs=off""alias gibs gibs_off""
alias gibs=low""alias gibs gibs_low""
alias gibs=medium_low""alias gibs gibs_medium_low""
alias gibs=medium""alias gibs gibs_medium""
alias gibs=high""alias gibs gibs_high""
alias sillygibs=auto""alias sillygibs sillygibs_auto""
alias sillygibs=off""alias sillygibs sillygibs_off""
alias sillygibs=on""alias sillygibs sillygibs_on""
alias props=low""alias props props_low""
alias props=medium""alias props props_medium""
alias props=high""alias props props_high""
alias props=ultra""alias props props_ultra""
alias ragdolls=hidden""alias ragdolls ragdolls_hidden""
alias ragdolls=off""alias ragdolls ragdolls_off""
alias ragdolls=low""alias ragdolls ragdolls_low""
alias ragdolls=medium""alias ragdolls ragdolls_medium""
alias ragdolls=high""alias ragdolls ragdolls_high""
alias 3dsky=off""alias 3dsky 3dsky_off""
alias 3dsky=on""alias 3dsky 3dsky_on""
alias jigglebones=off""alias jigglebones jigglebones_off""
alias jigglebones=on""alias jigglebones jigglebones_on""
alias jigglebones=force_on""alias jigglebones jigglebones_force_on""
alias sheens_speed=off""alias sheens_speed sheens_speed_off""
alias sheens_speed=slow""alias sheens_speed sheens_speed_slow""
alias sheens_speed=medium""alias sheens_speed sheens_speed_medium""
alias sheens_speed=fast""alias sheens_speed sheens_speed_fast""
alias sheens_tint=low""alias sheens_tint sheens_tint_low""
alias sheens_tint=medium""alias sheens_tint sheens_tint_medium""
alias sheens_tint=high""alias sheens_tint sheens_tint_high""
alias sheens_tint=full""alias sheens_tint sheens_tint_full""
alias textures=very_low""alias textures textures_very_low""
alias textures=low""alias textures textures_low""
alias textures=medium""alias textures textures_medium""
alias textures=high""alias textures textures_high""
alias textures=very_high""alias textures textures_very_high""
alias ropes=off""alias ropes ropes_off""
alias ropes=low""alias ropes ropes_low""
alias ropes=high""alias ropes ropes_high""
alias ropes=ultra""alias ropes ropes_ultra""
alias fpscap=powersaver""alias fpscap fpscap_powersaver""
alias fpscap=30""alias fpscap fpscap_30""
alias fpscap=60""alias fpscap fpscap_60""
alias fpscap=75""alias fpscap fpscap_75""
alias fpscap=120""alias fpscap fpscap_120""
alias fpscap=144""alias fpscap fpscap_144""
alias fpscap=160""alias fpscap fpscap_160""
alias fpscap=165""alias fpscap fpscap_165""
alias fpscap=180""alias fpscap fpscap_180""
alias fpscap=200""alias fpscap fpscap_200""
alias fpscap=240""alias fpscap fpscap_240""
alias fpscap=300""alias fpscap fpscap_300""
alias fpscap=360""alias fpscap fpscap_360""
alias fpscap=400""alias fpscap fpscap_400""
alias fpscap=1000""alias fpscap fpscap_1000""
alias fpscap=unlimited""alias fpscap fpscap_unlimited""
alias vsync=off""alias vsync vsync_off""
alias vsync=on""alias vsync vsync_on""
alias hud_player_model=off""alias hud_player_model hud_player_model_off""
alias hud_player_model=on""alias hud_player_model hud_player_model_on""
alias hud_panels=off""alias hud_panels hud_panels_off""
alias hud_panels=low""alias hud_panels hud_panels_low""
alias hud_panels=high""alias hud_panels hud_panels_high""
alias hud_avatars=off""alias hud_avatars hud_avatars_off""
alias hud_avatars=everyone""alias hud_avatars hud_avatars_everyone""
alias hud_avatars=friends""alias hud_avatars hud_avatars_friends""
alias match_hud=off""alias match_hud match_hud_off""
alias match_hud=on""alias match_hud match_hud_on""
alias messages=off""alias messages messages_off""
alias messages=hide""alias messages messages_hide""
alias messages=on""alias messages messages_on""
alias killfeed=off""alias killfeed killfeed_off""
alias killfeed=on""alias killfeed killfeed_on""
alias killstreaks=off""alias killstreaks killstreaks_off""
alias killstreaks=low""alias killstreaks killstreaks_low""
alias killstreaks=high""alias killstreaks killstreaks_high""
alias hud_achievement=off""alias hud_achievement hud_achievement_off""
alias hud_achievement=on""alias hud_achievement hud_achievement_on""
alias console=off""alias console console_off""
alias console=on""alias console console_on""
alias htmlmotd=off""alias htmlmotd htmlmotd_off""
alias htmlmotd=on""alias htmlmotd htmlmotd_on""
alias outlines=off""alias outlines outlines_off""
alias outlines=low""alias outlines outlines_low""
alias outlines=medium""alias outlines outlines_medium""
alias outlines=high""alias outlines outlines_high""
alias dynamic_background=off""alias dynamic_background dynamic_background_off""
alias dynamic_background=preload""alias dynamic_background dynamic_background_preload""
alias dynamic_background=itemtest""alias dynamic_background dynamic_background_itemtest""
alias dynamic_background=dustbowl""alias dynamic_background dynamic_background_dustbowl""
alias sound=low""alias sound sound_low""
alias sound=medium""alias sound sound_medium""
alias sound=high""alias sound sound_high""
alias sound=very_high""alias sound sound_very_high""
alias sound=ultra""alias sound sound_ultra""
alias voice_chat=off""alias voice_chat voice_chat_off""
alias voice_chat=on""alias voice_chat voice_chat_on""
alias mod_support=off""alias mod_support mod_support_off""
alias mod_support=on""alias mod_support mod_support_on""
alias party_mode=open""alias party_mode party_mode_open""
alias party_mode=request""alias party_mode party_mode_request""
alias party_mode=invite""alias party_mode party_mode_invite""
alias logo=off""alias logo logo_off""
alias logo=on""alias logo logo_on""
alias class_config_scout""exec user/scout.cfg""
alias class_config_soldier""exec user/soldier.cfg""
alias class_config_pyro""exec user/pyro.cfg""
alias class_config_demoman""exec user/demoman.cfg""
alias class_config_heavyweapons""exec user/heavyweapons.cfg""
alias class_config_engineer""exec user/engineer.cfg""
alias class_config_medic""exec user/medic.cfg""
alias class_config_sniper""exec user/sniper.cfg""
alias class_config_spy""exec user/spy.cfg""
alias game_overrides_c""exec user/game_overrides.cfg""
alias game_overrides_once_c
alias block_antialias""alias mat_antialias block_antialias_echo""
alias block_antialias_echo""echo This command is blocked to prevent a material system reload. If you want to change it, use the Anti-Aliasing module inside the modules.cfg file.""
alias mm_override""exec comfig/mm_override.cfg""
alias very_low_reset""exec comfig/very_low_reset.cfg""
alias modules_c""exec user/modules.cfg""
alias autoexec_c""exec user/autoexec.cfg""
alias run_modules""exec comfig/modules_run.cfg""
alias module_levels""exec comfig/module_levels.cfg""
alias apply_user""modules_c;run_modules;autoexec_c""
alias restore_preset""exec comfig/comfig.cfg;preset;run_modules""
alias restore_config""exec autoexec.cfg""
alias run_game_overrides""exec comfig/game_overrides.cfg;lightmaps_override""
alias game_overrides""cheap_water_override;detail_props_override;shadowlod_override;lightmaps_override""
alias game_overrides_once""match_hud_once;game_overrides_once_c""
block_game_overrides_once";

string mcHighGameOverrides = @"setinfo cl_predict 1
voice_steal 2
snd_soundmixer Default_Mix
decals_clear
cmd demorestart
game_overrides_once
alias block_game_overrides_once""alias game_overrides_once; match_hud_alias2 "";block_game_overrides_once
game_overrides
game_overrides_c";

string mcMidAutoExec = "exec comfig/define_presets.cfg;preset=medium;exec user/pre_comfig.cfg;exec comfig/comfig.cfg;exec user/post_comfig.cfg;preset;exec comfig/addons_setup.cfg;exec comfig/addons.cfg;modules_c;run_modules;exec comfig/addons.cfg;exec comfig/echo.cfg;autoexec_c;exec comfig/finalize.cfg";
string mcMidPreset = @"lod=low
lighting=medium_high
lighting_ex=high
shadows=medium
flashlight=off
effects=medium
water=medium
particles=low
post_processing=low
pyrovision=low
romevision=off
motion_blur=off
anti_aliasing=off
texture_filter=trilinear
characters=low
decals=low
decals_models=off
decals_art=on
sprays=off
gibs=off
props=medium
ragdolls=off
3dsky=off
jigglebones=off
textures=medium
ropes=off
hud_player_model=off
outlines=low
sound=medium
tf_quest_map_tuner_wobble_magnitude 0
tf_item_inspect_model_auto_spin 0
tf_dashboard_slide_time 0
echo""Medium preset selected""";

string mcLowAutoExec = "exec comfig/define_presets.cfg;preset=medium-low;exec user/pre_comfig.cfg;exec comfig/comfig.cfg;exec user/post_comfig.cfg;preset;exec comfig/addons_setup.cfg;exec comfig/addons.cfg;modules_c;run_modules;exec comfig/addons.cfg;exec comfig/echo.cfg;autoexec_c;exec comfig/finalize.cfg";
string mcLowPreset = @"lod=low
lighting=medium
lighting_ex=low
shadows=off
flashlight=off
effects=low
water=medium
particles=low
post_processing=off
pyrovision=low
romevision=off
motion_blur=off
anti_aliasing=off
texture_filter=trilinear
characters=low
decals=off
decals_models=off
decals_art=off
sprays=off
gibs=off
props=medium
ragdolls=off
3dsky=off
jigglebones=off
textures=low
ropes=off
hud_player_model=off
outlines=low
sound=low
tf_quest_map_tuner_wobble_magnitude 0
tf_item_inspect_model_auto_spin 0
tf_dashboard_slide_time 0
echo""Medium Low preset selected""";

string mcVLowAutoExec = "exec comfig/define_presets.cfg;preset=very-low;exec user/pre_comfig.cfg;exec comfig/comfig.cfg;exec user/post_comfig.cfg;preset;exec comfig/addons_setup.cfg;exec comfig/addons.cfg;modules_c;run_modules;exec comfig/addons.cfg;exec comfig/echo.cfg;autoexec_c;exec comfig/finalize.cfg";
string mcVLowPreset = @"packet_rate=congestion
lod=low
lighting=very_low
lighting_ex=low
shadows=off
flashlight=off
effects=low
water=very_low
particles=very_low
post_processing=off
pyrovision=low
romevision=off
motion_blur=off
anti_aliasing=off
texture_filter=bilinear
characters=very_low
decals=off
decals_models=off
decals_art=off
sprays=off
gibs=off
props=low
ragdolls=off
3dsky=off
jigglebones=off
sheens_speed=off
textures=very_low
ropes=off
hud_player_model=off
hud_panels=off
hud_avatars=off
hud_achievement=off
match_hud=off
messages=off
killfeed=off
killstreaks=off
console=off
outlines=off
sound=low
voice_chat=off
logo=off
tf_quest_map_tuner_wobble_magnitude 0
tf_item_inspect_model_auto_spin 0
tf_dashboard_slide_time 0
cl_smooth 0
snd_cull_duplicates 1
tf_dingalingaling_repeat_delay .3
mat_viewportscale .71
gl_mtglflush_at_tof 0
cl_hud_minmode 1
hud_freezecamhide 1
cl_showbackpackrarities 0
cl_show_market_data_on_items 0
tf_halloween_bonus_ducks_cooldown 10000
tf_hud_target_id_disable_floating_health 1
tf_hud_num_building_alert_beeps 0
tf_simple_disguise_menu 1
tf_chat_popup_hold_time .1
cl_notifications_max_num_visible 0
cl_notifications_move_time 0
cl_notifications_show_ingame 0
con_drawnotify 0
cl_spec_carrieditems 0
tf_hud_notification_duration 0
tf_contract_competitive_show 0
tf_contract_progress_show 0
cl_mvm_wave_status_visible_during_wave 0
con_nprint_bgalpha 0
fov_desired 75
r_drawviewmodel 0
viewmodel_fov 0
tf_use_min_viewmodels 1
in_usekeyboardsampletime 0
tf_colorblindassist 0
net_graphsolid 0
scr_centertime 0
tf_hud_show_servertimelimit 0
hud_medichealtargetmarker 0
tf_sniper_fullcharge_bell 0
hud_escort_interp 0
cl_crosshairalpha 255
tf_time_loading_item_panels 0
echo""Very Low preset selected""";




//////////////////////////////////////////////////////////////
/////////////////////Comanglia Toaster////////////////////////
//////////////////////////////////////////////////////////////

string comangliaToaster = @"//--------------------------------------------------------------
// Comanglia Stability config + Blocky Textures + Null-Cancel
//--------------------------------------------------------------
// FPS related
net_graph 0
cl_showfps 0
fps_max 0

//--------------------------------------------------------------
// Remove sprays
cl_playerspraydisable 1
r_spray_lifetime 0

//--------------------------------------------------------------
// Remove shadows
mat_shadowstate 0
r_shadowmaxrendered 0
r_shadowrendertotexture 0
r_shadows 0

//--------------------------------------------------------------
// Remove face movement
r_eyes 0
r_flex 0
r_lod 2
r_rootlod 2
r_teeth 0

//--------------------------------------------------------------
// Remove ragdolls
cl_ragdoll_fade_time 0
cl_ragdoll_forcefade 1
cl_ragdoll_physics_enable 0
g_ragdoll_fadespeed 0
g_ragdoll_lvfadespeed 0
ragdoll_sleepaftertime 0

//--------------------------------------------------------------
// Remove gibs
cl_phys_props_enable 0
cl_phys_props_max 0
props_break_max_pieces 0
r_propsmaxdist 1
violence_agibs 0
violence_hgibs 0

//--------------------------------------------------------------
// Graphics, main FPS booster.
sv_cheats 1
cl_hud_playerclass_use_playermodel 0
mat_filtertextures 0
mat_phong 0
cl_muzzleflash_dlight_1st 0  
cl_detaildist 0
cl_detailfade 0
cl_drawmonitors 0
cl_ejectbrass 0
cl_jiggle_bone_framerate_cutoff 0
cl_new_impact_effects 0
cl_show_splashes 0
func_break_max_pieces 0
glow_outline_effect_enable 0
lod_transitiondist 0
mat_antialias 0
mat_bumpmap 0
mat_colcorrection_disableentities 0
mat_colorcorrection 0
mat_disable_bloom 1
mat_disable_fancy_blending 1
mat_disable_lightwarp 1
mat_envmapsize 8
mat_envmaptgasize 8
mat_filterlightmaps 1
mat_filtertextures 1
mat_forceaniso 0
mat_hdr_level 0
mat_max_worldmesh_vertices 512
mat_monitorgamma 2.2
mat_motion_blur_enabled 0
mat_parallaxmap 0
mat_picmip 2
mat_reducefillrate 1
mat_reduceparticles 1
mat_specular 1
mat_trilinear 1
mat_viewportscale 1
mat_viewportupscale 1
mat_wateroverlaysize 1
mp_decals 9
r_ambientfactor 0
r_ambientmin 0
r_avglight 0
r_cheapwaterend 1
r_cheapwaterstart 1
r_decals 9
r_maxmodeldecal 9
r_decalstaticprops 0
r_decal_cullsize 15
r_drawdetailprops 0
r_drawmodeldecals 0
r_drawflecks 0
r_dynamic 0
r_flashlightdepthtexture 0
r_forcewaterleaf 1
r_lightaverage 0
r_maxnewsamples 0
r_maxsampledist 1
r_occlusion 0
r_pixelfog 1
r_propsmaxdist 0
r_renderoverlayfragment 0
r_staticprop_lod 4
r_waterdrawreflection 0
r_waterdrawrefraction 1
r_waterforceexpensive 0
r_waterforcereflectentities 0
r_drawtracers_firstperson 0
rope_averagelight 0
rope_collide 0
rope_rendersolid 0
rope_shake 0
rope_smooth 0
rope_subdiv 0
rope_wind_dist 0 // I didn't actually know that there is wind in TF2. I'm stupid.  -Pellyx
tf_particles_disable_weather 1
tracer_extra 0
violence_ablood 1
violence_hblood 1
sv_cheats 0

//--------------------------------------------------------------
// Misc
in_usekeyboardsampletime 0
//mat_clipz 1 // FX card users should set this to 0  -Comanglia
mat_forcehardwaresync 0
mat_levelflush 1
mat_vsync 0
r_fastzreject -1
ai_expression_optimization 1
fast_fogvolume 1
host_thread_mode 0
mod_load_anims_async 1
mod_load_mesh_async 1
mod_load_vcollide_async 1
cl_forcepreload 1
cl_ask_blacklist_opt_out ""1""
cl_ask_favorite_opt_out ""1""
sb_dontshow_maxplayer_warning ""1""
tf_explanations_backpackpanel ""1""
tf_explanations_charinfo_armory_panel ""1""
tf_explanations_charinfopanel ""1""
tf_explanations_craftingpanel ""1""
tf_explanations_discardpanel ""1""
tf_explanations_store ""1""
tf_training_has_prompted_for_forums ""1""
tf_training_has_prompted_for_loadout ""1""
tf_training_has_prompted_for_offline_practice ""1""
tf_training_has_prompted_for_options ""1""
tf_training_has_prompted_for_training ""1""

//--------------------------------------------------------------
// Sound
// Everyone agrees that you should not decrease sound quality
// in games such as TF2 but it's proven to boost FPS.
dsp_enhance_stereo 0
dsp_slow_cpu 1
snd_async_fullyasync 1
snd_pitchquality 0
snd_spatialize_roundrobin 1
snd_mixahead .06

//--------------------------------------------------------------
// HUD related
hud_saytext_time 5
voice_enable 1
hud_deathnotice_time 5
hud_achievement_glowtime 0
hud_achievement_count 0
hud_achievement_tracker 0

//--------------------------------------------------------------
// Test
cl_localnetworkbackdoor 1
cl_cloud_settings 0
sys_minidumpspewlines 500
cl_loadondemand_default 0

//--------------------------------------------------------------
// Important settings
// These are things that every TF2 player should use.

fov_desired 90
//viewmodel_fov 70 // This is optional.
hud_fastswitch 1
cl_autoreload ""1""
cl_hud_minmode ""1"" // This actually boosts FPS.

//--------------------------------------------------------------
// Null-cancel + settings 
mat_filterlightmaps 1
alias +mfwd ""-back;+forward;alias checkfwd +forward;mat_filterlightmaps 0""
alias +mback ""-forward;+back;alias checkback +back;mat_filterlightmaps 0""
alias +mleft ""-moveright;+moveleft;alias checkleft +moveleft;mat_filterlightmaps 0""
alias +mright ""-moveleft;+moveright;alias checkright +moveright;mat_filterlightmaps 0""
alias -mfwd ""-forward;checkback;alias checkfwd none""
alias -mback ""-back;checkfwd;alias checkback none""
alias -mleft ""-moveleft;checkright;alias checkleft none""
alias -mright ""-moveright;checkleft;alias checkright none""
alias checkfwd none
alias checkback none
alias checkleft none
alias checkright none
 
bind w +mfwd
bind s +mback
bind d +mright
bind a +mleft
alias none """"";


string comangliaMedium = @"// Unexplained crashes? Try changing mat_queue_mode to `-1'.
// ----------------------------------------------------------------------------
// Comanglia' frames config inspired by chris, designed to get you a large performance boost
// v1.8beta | 18 December 2015 | https://dl.dropboxusercontent.com/u/92187841/gfx.cfg
// ----------------------------------------------------------------------------
// Launch options:
// You don't have to remove -dxlevel from the launch options after the first launch!
//
// Fullscreen: -dxlevel 81 -full -w WIDTH -h HEIGHT -console -novid 
// Windowed:   -dxlevel 81 -sw -w WIDTH -h HEIGHT -console -noborder -novid 
// -useforcedmparms -noforcemaccel -noforcemspd // All of these are outdated and don't matter anymore
//
// DX Levels
// -dxlevel 80, -dxlevel 81, -dxlevel 90, -dxlevel 91, -dxlevel 95, -dxlevel 98
// if you can use -dxlevel 81 USE IT your fps will be significantly more stable, some Nvidia users may experience a weird strobing effect 
// (some series of outdated nvidia drivers remove this affect)
// ----------------------------------------------------------------------------

// ----------------------------------------------------------------------------
// FPS cap
// ----------------------------------------------------------------------------
// The primary benefit of an FPS cap is to make the FPS more stable, other than
// that, it doesn't do a lot. A moderate, consistent framerate is much more
// desirable than a variable but sometimes high framerate. A common
// misconception is that if any more frames are generated than your monitor can
// display, they are useless. This is wrong -- frames are used for much more
// than mere display, and affect the way the game feels well past your
// refresh rate.
// ----------------------------------------------------------------------------
cl_showfps 0 // Turning this FPS meter on actually decreases fps by about 3%-4%
fps_max 0 // fps caps on PCs that consistently meet that cap causes horrible input lag when attempting to turn/aim
//fps_max 132 // I'm leaving this in here though because some PCs (usually laptops) tend to overheat and have microstutters without frame caps.
sv_cheats 0

// ----------------------------------------------------------------------------
// Sprays
// ----------------------------------------------------------------------------
// Bear in mind that these are disabled on war servers due to `sv_pure 2'
// anyway, so if you play competitive TF2, this won't help you.
// ----------------------------------------------------------------------------

// Disable sprays
cl_playerspraydisable 1
r_spray_lifetime 0

// Enable sprays -- uncomment this section if you want these settings
//cl_playerspraydisable 0
//r_spray_lifetime 2

// ----------------------------------------------------------------------------
// Shadows
// ----------------------------------------------------------------------------

// Disable shadows
r_shadowmaxrendered 0
r_shadowrendertotexture 0
r_shadows 0
nb_shadow_dist 0 

// Enable shadows -- I highly recommend keeping them off if you're frequently near or below the refresh rate of your monitor as you'll lose about 15-20% of your framerate
//mat_shadowstate 1
//r_shadowmaxrendered 11
//r_shadowrendertotexture 1 // Non-blobby shadows. Sometimes turned on by
                            // competitive TF2 players to see opponents standing
                            // near the other side of a wall. You may see some
                            // performance loss from setting this to `1'.
//r_shadows 1
//nb_shadow_dist 400

// ----------------------------------------------------------------------------
// Facial features
// ----------------------------------------------------------------------------

// Disable facial features
r_eyes 0
r_flex 0
r_lod 2
r_rootlod 2
r_teeth 0
r_eyemove 0
r_eyeshift_x 0
r_eyeshift_y 0
r_eyeshift_z 0
r_eyesize 0
blink_duration 0

// Enable facial features -- turning them on lowers framerate by 5ish%
//r_eyes 1
//r_flex 1
//r_lod 1 // Needs to be set to 1, otherwise they will still be disabled.
//r_rootlod 1
//r_teeth 1

// ----------------------------------------------------------------------------
// Ragdolls
// ----------------------------------------------------------------------------
// You will have reduced performance on deaths which produce ragdolls.
// ----------------------------------------------------------------------------

// Disable ragdolls
cl_ragdoll_fade_time 0
cl_ragdoll_forcefade 1
cl_ragdoll_physics_enable 0
g_ragdoll_fadespeed 0
g_ragdoll_lvfadespeed 0
ragdoll_sleepaftertime 0

// Enable ragdolls -- lowers by 10ish%
//cl_ragdoll_fade_time 15
//cl_ragdoll_forcefade 0
//cl_ragdoll_physics_enable 1
//g_ragdoll_fadespeed 600
//g_ragdoll_lvfadespeed 100
//ragdoll_sleepaftertime ""5.0f""

// ----------------------------------------------------------------------------
// Gibs
// ----------------------------------------------------------------------------
// You will have reduced performance on deaths which produce gibs.
// ----------------------------------------------------------------------------

// Disable gibs
cl_phys_props_enable 0
cl_phys_props_max 0
props_break_max_pieces 0
r_propsmaxdist 1
violence_agibs 0
violence_hgibs 0

// Enable gibs -- 6-7% less framerate
//cl_phys_props_enable 1
//cl_phys_props_max 128
//props_break_max_pieces -1
//r_propsmaxdist 1000
//violence_agibs 1
//violence_hgibs 1

// ----------------------------------------------------------------------------
// Graphical
// ----------------------------------------------------------------------------
// Now we come to the main brunt of the config. You probably don't want to mess
// with this.
// ----------------------------------------------------------------------------
prop_active_gib_limit 0
props_break_max_pieces_perframe 0
fov_desired 90
cl_hud_playerclass_use_playermodel 0 // adds another hud element -3% frames
mat_phong 0 // some people don't like this on I prefer it on for sniper though
cl_muzzleflash_dlight_1st 0  
cl_detaildist 0
cl_detailfade 0
cl_drawmonitors 0
cl_ejectbrass 0
cl_jiggle_bone_framerate_cutoff 0 // Turns off jigglebones
cl_new_impact_effects 0
cl_show_splashes 0
cl_rumblescale 0
cl_showhelp 0
cl_showpluginmessages 0
cl_debugrumble 0
func_break_max_pieces 0
glow_outline_effect_enable 0 // Cart glow effect.
lod_transitiondist 0
//mat_antialias 1 // apparently having this in config can break the mumble overlay for some users
mat_bumpmap 0 // Controls bumpmapping. Setting this to 0 on dx9 will cause
              // a strange `shine' effect to appear on all players. - Chris
			  // In the past I wasn't able to prove that disabling this was significant, 
			  // it effects fps by about 1% after several checks - Comanglia
mat_colcorrection_disableentities 1
mat_colorcorrection 0
mat_disable_bloom 1
mat_disable_fancy_blending 1
mat_disable_lightwarp 1
mat_envmapsize 8
mat_envmaptgasize 8
mat_filterlightmaps 1
mat_filtertextures 1
mat_forceaniso 1
mat_hdr_level 0
mat_autoexposure_max 0
mat_autoexposure_min 0
mat_bloomscale 0
mat_bloom_scalefactor_scalar 0
mat_debug_postprocessing_effects 0
mat_debugdepth 0
mat_disable_bloom 1
mat_postprocessing_combine 0
mat_non_hdr_bloom_scalefactor 0
mat_bufferprimitives 1
mat_compressedtextures 1
mat_forcemanagedtextureintohardware 0
mat_framebuffercopyoverlaysize 0
mat_hdr_enabled 0
mat_hdr_manual_tonemap_rate 0
mat_mipmaptextures 0 // ***
mat_non_hdr_bloom_scalefactor 0
mat_showlightmappage -1
mat_softwarelighting 0
mat_software_aa_blur_one_pixel_lines 0
mat_software_aa_edge_threshold 9
mat_software_aa_quality 0// was 9
mat_software_aa_strength 0
mat_software_aa_strength_vgui 0
mat_software_aa_tap_offset 0
mat_software_aa_quality 0
mat_texture_limit -1
mat_use_compressed_hdr_textures 0
mem_max_heapsize 2048
mod_forcedata 1
mod_forcetouchdata 1
mat_max_worldmesh_vertices 512
mat_monitorgamma 2.2 // Controls brightness, try 1.8 to make it brighter or 2.2
                     // to get it darker. Only works in fullscreen.
mat_parallaxmap 0
mat_picmip 2 // Higher = more mipmapping. Without `sv_cheats 1', you're looking
             // at a range from -1 to 2, -1 being the best quality, 2 being the
             // worst. - Doesn't really matter much what you set this too if you're cpu bound
mat_reducefillrate 1
mat_reduceparticles 1
mat_specular 1 // Controls specularity. Setting this to 0 will make ubers
               // non-shiny, and will remove some specular effects from in-game
               // entities which support it. - Setting this to 0 while trilinear is off lowers framerate for reasons I don't understand
mat_trilinear 1
mat_viewportscale 1 // Almost no performance gain from viewport upscaling.
mat_viewportupscale 1
mat_wateroverlaysize 1
mp_decals 9 // - Just keep this below 60ish and you shouldn't notice much different at all maybe .5 average fps for every 30-40 decals
r_3dsky 0
r_ambientboost 0
r_ambientfactor 0
r_ambientmin 0
r_cheapwaterend 1
r_cheapwaterstart 1
r_decals 9
r_maxmodeldecal 9
r_decalstaticprops 0
r_decal_cullsize 15
r_drawdetailprops 0
r_drawmodeldecals 0
r_drawflecks 0
r_dynamic 0
r_flashlightdepthtexture 0
r_forcewaterleaf 1
r_lightaverage 0
r_maxnewsamples 0
r_maxsampledist 1
r_bloomtintb 0
r_bloomtintexponent 0
r_bloomtintg 0
r_bloomtintr 0
r_occlusion 1
r_pixelfog 1
r_propsmaxdist 0
r_renderoverlayfragment 0
r_staticprop_lod 4
r_waterdrawreflection 0
r_waterdrawrefraction 1
r_waterforceexpensive 0
r_waterforcereflectentities 0
r_drawtracers_firstperson 0 // should give a small fps boost in 1st person
r_dopixelvisibility 0
r_drawbatchdecals 0
r_hunkalloclightmaps 0
r_lightcache_zbuffercache 0
r_PhysPropStaticLighting 0
rope_averagelight 0
rope_collide 0
rope_rendersolid 0
rope_shake 0
rope_smooth 0
rope_subdiv 0
rope_wind_dist 0
tf_particles_disable_weather 1 // Disable weather effects on maps supporting
                               // it, for example, setting this to `1'
                               // disables rain effects on *_sawmill.
tracer_extra 0
violence_ablood 1 // framerates on -most- pcs are higher with these on
violence_hblood 1
mat_motion_blur_enabled 0  // just incase anyone has this added before loading my cfg
mat_motion_blur_forward_enabled 0
mat_motion_blur_strength 0
r_worldlightmin 0.0001
r_worldlights 0
mp_usehwmmodels -1                                  
mp_usehwmvcds   -1   

// ----------------------------------------------------------------------------
// Misc
// ----------------------------------------------------------------------------
in_usekeyboardsampletime 0
mat_clipz 1 // FX card users should set this to 0
mat_forcehardwaresync 0
mat_levelflush 1
m_rawinput 1 // Turn on raw mouse input. Commented out by default due to
               // silly incompatibility with the Xfire overlay. You should use
               // it if you can! - WHO USES XFIRE ANYMORE?
mat_vsync 0 // Turn off vsync to avoid nasty I/O latency.
r_fastzreject -1 // Values >1 enable a fast Z rejection algorithm, to be
                 // performed on the GPU (as opposed to on the CPU). The
                 // value `-1' autodetects hardware support for this
                 // feature, which is safer than forcing it.
				 
ai_expression_optimization 1
fast_fogvolume 1
host_thread_mode 0 // Not exactly stable
mod_load_anims_async 1
mod_load_mesh_async 1
mod_load_vcollide_async 1
con_enable 1
con_filter_enable 1
con_filter_text_out particle
datacachesize 256

// ----------------------------------------------------------------------------
// Sound
// ----------------------------------------------------------------------------
// I'd be hesitant to say that you would see a great deal of performance
// improvement from lowering the sound quality, but in my experience as a
// competitive TF2 player, lowering the sound quality makes determination of
// directionality and distance that much easier. You may see a small FPS gain
// with these settings, or you may not, either way will likely have a
// negligible effect on performance.
// ----------------------------------------------------------------------------
dsp_enhance_stereo 0
dsp_slow_cpu 1
snd_async_fullyasync 1 // Having the sound run fully asynchronous has been
                       // helpful in the past, as it seems to (for whatever
                       // reason) reduce the number of TDRs experienced during
                       // gameplay. There's some pretty good information on
                       // TDRs (nerds only) here:
                       // http://forums.nvidia.com/index.php?showtopic=65161
snd_pitchquality 0
snd_spatialize_roundrobin 1
snd_mixahead .05 // Delay in sound from weapons below .05 has been known to be unstable

// ----------------------------------------------------------------------------
// Threading
// ----------------------------------------------------------------------------
mat_queue_mode 2 // mat_queue mode is another frequently asked about cvar, it
                 // defines the threading method to be used by the material
                 // system. It has been unstable to use in the past, but
                 // nowadays it's generally okay.
                 //
                 // Here are the possible values:
                 //     -2 legacy default
                 //     -1 default
                 //      0 synchronous single thread
                 //      1 queued single thread
                 //      2 queued multithreaded
                 //
                 // If you have problems with the value `2', try setting it to
                 // `-1'.
                 //
                 // As an aside, there are quite a few bugs in the demo system
                 // that occur when mat_queue_mode is set to a value that is
                 // not `-1'. If you intend to do work with the demo system,
                 // maybe you should change this.
				 //
				 //After immense testing I've found that default works perfectly
				 //fine with setting your Thread usage. It automatically set me
				 //to 2 every time. I'd say it's safer and likely less buggy to
				 //leave this at -1 than it is at 2.
				 //
				 //As a side not I've noticed micro stutters with mat_queue_mode 2
				 //at 1000+ fps where mat_queue_mode 1 did not stutter at 1000+ fps				 				 

cl_threaded_bone_setup 1 // WARNING if you don't have a Quad-Core CPU or better you SHOULD NOT LEAVE THIS ON
cl_threaded_client_leaf_system 0 // DO NOT ENABLE cause crashes to desktop within 4-5 minutes of gameplay 4/18 2014
r_queued_decals 0 // lessens the impact of higher decal limits. 
r_queued_ropes 1
r_queued_post_processing 0 // kind of pointless because it's disabled above but if you do like post processing effects keeping this on should lessen the impact on framerate
r_threaded_client_shadow_manager 1
r_threaded_particles 1
r_threaded_renderables 1

// ----------------------------------------------------------------------------
// HUD
// ----------------------------------------------------------------------------
hud_saytext_time 10 //Default is 12 and measured in seconds, this is the amount of time chat stays on your screen
voice_enable 1 //Default is 1, This is the voice chat in the game 1 = on, 0 = off
hud_deathnotice_time 5 // Default is 6, This the the death notices that usually appear at the top right of the screen
hud_achievement_glowtime 0 // Default is 2.5, not 100% what this is about a 1.5% fps boost.
hud_achievement_count 0 //Default is 8, Max number of achievements that can be shown on the HUD
hud_achievement_tracker 0 // Default is 1, Show or hide the achievement tracker

// ----------------------------------------------------------------------------
// Test Shit
// ----------------------------------------------------------------------------
cl_localnetworkbackdoor 1 //Network optimizations for Singleplayer, disabling has about a 1-2% fps boost
cl_cloud_settings 0 // I believe this disables cloud syncing of CFGs but not 100% sure
//cl_notifications_show_ingame 0 // Pretty sure this disables Trade/Duel Notifications
sys_minidumpspewlines 500 // Basically the number of lines saved to a log file from console. No FPS boost but 15% lower FPS variance
tf_scoreboard_ping_as_text 1

// ----------------------------------------------------------------------------
// Misc
// ----------------------------------------------------------------------------
cl_ask_blacklist_opt_out ""1""
cl_ask_favorite_opt_out ""1""
sb_dontshow_maxplayer_warning ""1""
tf_explanations_backpackpanel ""1""
tf_explanations_charinfo_armory_panel ""1""
tf_explanations_charinfopanel ""1""
tf_explanations_craftingpanel ""1""
tf_explanations_discardpanel ""1""
tf_explanations_store ""1""
tf_training_has_prompted_for_forums ""1""
tf_training_has_prompted_for_loadout ""1""
tf_training_has_prompted_for_offline_practice ""1""
tf_training_has_prompted_for_options ""1""
tf_training_has_prompted_for_training ""1""
//net_graph 1 // keeping this on actually lowers your framerate by 3-6% depending on the level of net_graph you have it at 
			 // net_graph 1,2,3,4,5	
hud_fastswitch 1
sv_forcepreload 1

// ----------------------------------------------------------------------------
// Print to console
// ----------------------------------------------------------------------------
echo ""---------------------------------------------------------""
echo ""Comanglia' frames config loaded. Inspired by Chris config""
echo ""---------------------------------------------------------""";

string comangliaCinema = @"// Unexplained crashes? Try changing mat_queue_mode to `-1'.
// ----------------------------------------------------------------------------
// Comanglia's Cinema Config, Designed for Video makers
// v0.3beta | 12 August, 2015 | 
// ----------------------------------------------------------------------------
// Problems or questions? Post at ???
// ----------------------------------------------------------------------------
// Launch options:
// IMPORTANT: Remove -dxlevel 98 isn't exactly necessary cause alt+tabbing during recording is dumb.
//
// Fullscreen: -dxlevel 98 -full -w WIDTH -h HEIGHT -console -novid -useforcedmparms -noforcemaccel -noforcemspd
// Windowed:   -dxlevel 98 -sw -w WIDTH -h HEIGHT -console -noborder -novid -useforcedmparms -noforcemaccel -noforcemspd
// ----------------------------------------------------------------------------

// ----------------------------------------------------------------------------
// FPS cap
// ----------------------------------------------------------------------------
// The primary benefit of an FPS cap is to make the FPS more stable, other than
// that, it doesn't do a lot. A moderate, consistent framerate is much more
// desirable than a variable but sometimes high framerate. A common
// misconception is that if any more frames are generated than your monitor can
// display, they are useless. This is wrong -- frames are used for much more
// than mere display, and affect the way the game feels well past your
// refresh rate.
//
// This FPS cap should *always* be set to a value higher than `cl_cmdrate' in
// any case, or the discrepancy between clientside frame generation and frames
// to be sent to the server will no doubt cause you many a headache, especially
// when it comes down to hit registration. Other than that, I recommend
// for everyone to use the value `132' (2*66), as long as you can generally
// keep that value stable without regular drops.
// ----------------------------------------------------------------------------
cl_showfps 0 // you don't want to record this, and it's rounded and eats fps anyway.
//fps_max 132 // 
fps_max 0

// ----------------------------------------------------------------------------
// Net settings
// ----------------------------------------------------------------------------
// Whilst net settings perhaps aren't an integral part of an FPS config, they
// are a fact of life in competitive TF2, and as such, they are included here.
//
// A common question I am asked -- what defines whether a good connection is
// good or bad? Mostly personal preference. If you're not willing to make the
// choice, try both and see which is better for you.
//
// Generally, meeting both of the following conditions would classify it as a
// good connection:
//
// - Ping of <80 to the average server you join
// - Generally no/negligible choke/loss (can be checked with `net_graph')
//
// There's some pretty good documentation on this here:
// http://developer.valvesoftware.com/wiki/Source_Multiplayer_Networking
//
// Uncomment (remove the `//' from) one of the groups if you want to use them.
// ----------------------------------------------------------------------------
// ----------------------------------------------------------------------------
// Graphical
// ----------------------------------------------------------------------------
// Now we come to the main brunt of the config. You probably don't want to mess
// with this.
// ----------------------------------------------------------------------------
sv_cheats 1 // primarily because this is meant for demos
fov_desired 90 // seriously everyone should use this.
cl_ejectbrass 1
cl_new_impact_effects 1
cl_hud_playerclass_use_playermodel 0 
cl_burninggibs 1
cl_detaildist 8096
cl_detailfade 0
cl_maxrenderable_dist 8096
cl_phys_props_max 1024
cl_ragdoll_collide 1
lod_transitiondist 6400
mat_use_compressed_hdr_textures 1
mat_phong 0
mat_aaquality 2
mat_antialias 8
mat_bumpmap 1
mat_compressedtextures 1 // Set to 0 cause instant crash on map load for me
mat_envmapsize 512
mat_envmaptgasize 512
mat_forceaniso 16
mat_hdr_level 2
mat_monitorgamma 2.2 // Controls brightness, try 1.8 to make it brighter or 2.2
                     // to get it darker. Only works in fullscreen.
mat_motion_blur_enabled 0 
mat_motion_blur_forward_enabled 0
mat_motion_blur_strength 0
mat_parallaxmap 1
mat_picmip -1 // Higher = more mipmapping. Without `sv_cheats 1', you're looking
              // at a range from -1 to 2, -1 being the best quality, 2 being the
              // worst. // Valve has disabled values beyond -1 and 2 even in sv_cheats 1
mat_postprocess_x 8
mat_postprocess_y 8
mat_reducefillrate 0
mat_software_aa_blur_one_pixel_lines 0.5
mat_software_aa_edge_threshold 0.8
mat_software_aa_quality 2
mat_software_aa_strength 2
mat_software_aa_strength_vgui 2
mat_specular 1
mat_wateroverlaysize 512
mp_decals 4096
mp_usehwmmodels 1
mp_usehwmvcds 1
r_avglight 3
r_decals 4096
r_eyeglintlodpixels 4
r_lod 0
r_maxmodeldecal 4096
r_radiosity 3
r_rainradius 2250
r_rainsplashpercentage 100
r_rootlod 0
r_shadowmaxrendered 1024
r_shadowrendertotexture 1
r_shadows 1
r_waterdrawreflection 1
r_waterdrawrefraction 1
r_waterforceexpensive 1
r_waterforcereflectentities 1
r_pixelfog 1 // removes a lot of the map haze in DX 9 doesn't do anything in DX 8
mat_viewportscale 1 // Almost no performance gain from viewport upscaling.
mat_viewportupscale 1

// ----------------------------------------------------------------------------
// Misc
// ----------------------------------------------------------------------------
in_usekeyboardsampletime 0
mat_clipz 1 // FX card users should set this to 0
mat_forcehardwaresync 0
mat_levelflush 1
//m_rawinput 1 // Turn on raw mouse input. Commented out by default due to
               // silly incompatibility with the Xfire overlay. You should use
               // it if you can!
mat_vsync 0 // Turn off vsync to avoid nasty I/O latency.
r_fastzreject -1 // Values >1 enable a fast Z rejection algorithm, to be
                 // performed on the GPU (as opposed to on the CPU). The
                 // value `-1' autodetects hardware support for this
                 // feature.
ai_expression_optimization 1
fast_fogvolume 1
mod_load_anims_async 1
mod_load_mesh_async 1
mod_load_vcollide_async 1

// ----------------------------------------------------------------------------
// Sound
// ----------------------------------------------------------------------------
// I'd be hesitant to say that you would see a great deal of performance
// improvement from lowering the sound quality, but in my experience as a
// competitive TF2 player, lowering the sound quality makes determination of
// directionality and distance that much easier. You may see a small FPS gain
// with these settings, or you may not, either way will likely have a
// negligible effect on performance.
// ----------------------------------------------------------------------------
dsp_enhance_stereo 1
dsp_slow_cpu 0
snd_async_fullyasync 1 // Having the sound run fully asynchronous has been
                       // helpful in the past, as it seems to (for whatever
                       // reason) reduce the number of TDRs experienced during
                       // gameplay. There's some pretty good information on
                       // TDRs (nerds only) here:
                       // http://forums.nvidia.com/index.php?showtopic=65161
snd_pitchquality 1
snd_spatialize_roundrobin 0

// ----------------------------------------------------------------------------
// Threading
// ----------------------------------------------------------------------------
mat_queue_mode -1 // mat_queue mode is another frequently asked about cvar, it
                 // defines the threading method to be used by the material
                 // system. It has been unstable to use in the past, but
                 // nowadays it's generally okay.
                 //
                 // Here are the possible values:
                 //     -2 legacy default
                 //     -1 default
                 //      0 synchronous single thread
                 //      1 queued single thread
                 //      2 queued multithreaded
                 //
                 // If you have problems with the value `2', try setting it to
                 // `-1'.
                 //
                 // As an aside, there are quite a few bugs in the demo system
                 // that occur when mat_queue_mode is set to a value that is
                 // not `-1'. If you intend to do work with the demo system,
                 // maybe you should change this.

cl_threaded_bone_setup 0
cl_threaded_client_leaf_system 0
r_queued_decals 0
r_queued_ropes 1
r_queued_post_processing 0
r_threaded_client_shadow_manager 1
r_threaded_particles 1
r_threaded_renderables 1

// ----------------------------------------------------------------------------
// Misc
// ----------------------------------------------------------------------------
cl_forcepreload 1 // Force preloading
cl_loadondemand_default 0
cl_ask_blacklist_opt_out ""1""
cl_ask_favorite_opt_out ""1""
sb_dontshow_maxplayer_warning ""1""
tf_explanations_backpackpanel ""1""
tf_explanations_charinfo_armory_panel ""1""
tf_explanations_charinfopanel ""1""
tf_explanations_craftingpanel ""1""
tf_explanations_discardpanel ""1""
tf_explanations_store ""1""
tf_training_has_prompted_for_forums ""1""
tf_training_has_prompted_for_loadout ""1""
tf_training_has_prompted_for_offline_practice ""1""
tf_training_has_prompted_for_options ""1""
tf_training_has_prompted_for_training ""1""
hud_fastswitch 1

// ----------------------------------------------------------------------------
// Print to console
// ----------------------------------------------------------------------------
echo ""---------------------------------------------------------""
echo ""Comanglia' Cinema config loaded. Inspired by Chris config""
echo ""---------------------------------------------------------""";

string comangliaAutoExec = "exec gfxc";

string autoExecEcho = @"echo //Config Generated By BLT.CFG
//Config Name :" + configName + @"
exec blt";

//AutoExec
string autoExec0;
string autoExec1;

if (configGraphics == "1") //MasterComfig 
{
    if (configGraphicsQuality == "1") //Very Low
    {
        autoExec0 = mcVLowAutoExec;
        autoExec1 = autoExecEcho;
    }
    else if (configGraphicsQuality == "2") //Low
    {
        autoExec0 = mcLowAutoExec;
        autoExec1 = autoExecEcho;
    } 
    else if (configGraphicsQuality == "3") //Medium
    {
        autoExec0 = mcMidAutoExec;
        autoExec1 = autoExecEcho;
    }
    else if (configGraphicsQuality == "4") //High
    {
        autoExec0 = mcHighAutoExec;
        autoExec1 = autoExecEcho;
    }
    else if (configGraphicsQuality == "5") //Ultra
    {
        autoExec0 = mcUltraAutoexec;
        autoExec1 = autoExecEcho;
    }
    else
    {
        autoExec0 = mcMidAutoExec;
        autoExec1 = autoExecEcho;
    }
}
else if (configGraphics == "2") //Comanglia
{
    autoExec0 = comangliaAutoExec;
    autoExec1 = autoExecEcho;
} 
else //None and Random Type
{
    autoExec0 = "";
    autoExec1 = autoExecEcho;
}

string fastWeaponSwitchCfg = "hud_fastswitch 1";
string autoReloadCfg = "cl_autoreload 1";
string advancedSpecCfg = "cl_use_tournament_specgui 0";
string disableHtmlMotdCfg = "cl_disablehtmlmotd 0";
string usePlayerModelCfg = "cl_hud_playerclass_use_playermodel 1";
string dieAfterClassChangeCfg = "hud_classautokill 1";
string rezoomSniperCfg = "cl_autorezoom 1";
string noCrossHairSniperCfg = "tf_hud_no_crosshair_on_scope_zoom 0";
string autohealMedigunCfg = "tf_medigun_autoheal 1";
string markerOverHealTargetCfg = "hud_medichealtargetmarker 0";
string simpleDisguiseMenuCfg = "tf_simple_disguise_menu 0";
string ringOnFullChargeCfg = "tf_sniper_fullcharge_bell 0";
string rememberActiveWeaponCfg = "tf_remember_activeweapon 0";

if (fastWeaponSwitch == "n")
{
    fastWeaponSwitchCfg = "hud_fastswitch 0";
}
else if (fastWeaponSwitch == "N")
{
    fastWeaponSwitchCfg = "hud_fastswitch 0";
}

if (autoReload == "n")
{
    autoReloadCfg = "cl_autoreload 0";
}
else if (autoReload == "N")
{
    autoReloadCfg = "cl_autoreload 0";
}

if (advancedSpectator == "y")
{
    advancedSpecCfg = "cl_use_tournament_specgui 1";
}
else if (advancedSpectator == "Y")
{
    advancedSpecCfg = "cl_use_tournament_specgui 0";
}

if (disableHtmlMotd == "y")
{
    disableHtmlMotdCfg = "cl_disablehtmlmotd 1";
}
else if (disableHtmlMotd == "Y")
{
    disableHtmlMotdCfg = "cl_disablehtmlmotd 1";
}

if (playerModel == "n")
{
    usePlayerModelCfg = "cl_hud_playerclass_use_playermodel 0";
}
else if (playerModel == "N")
{
    usePlayerModelCfg = "cl_hud_playerclass_use_playermodel 0";
}

if (dieAfterClassChange == "n")
{
    dieAfterClassChangeCfg = "hud_classautokill 0";
}
else if (dieAfterClassChange == "N")
{
    dieAfterClassChangeCfg = "hud_classautokill 0";
}

if (rezoomSniper == "n")
{
    rezoomSniperCfg = "cl_autorezoom 0";
}
else if (rezoomSniper == "N")
{
    rezoomSniperCfg = "cl_autorezoom 0";
}

if (hideCrosshair == "y")
{
    noCrossHairSniperCfg = "tf_hud_no_crosshair_on_scope_zoom 1";
}
else if (hideCrosshair == "Y")
{
    noCrossHairSniperCfg = "tf_hud_no_crosshair_on_scope_zoom 1";
}

if (medigunAutoHeal == "n")
{
    autohealMedigunCfg = "tf_medigun_autoheal 0";
}
else if (medigunAutoHeal == "N")
{
    autohealMedigunCfg = "tf_medigun_autoheal 0";
}

if (showMarkerOverHeal == "y")
{
    markerOverHealTargetCfg = "hud_medichealtargetmarker 1";
}
else if (showMarkerOverHeal == "Y")
{
    markerOverHealTargetCfg = "hud_medichealtargetmarker 1";
}

if (conciseDisguise == "y")
{
    simpleDisguiseMenuCfg = "tf_simple_disguise_menu 1";
}
else if (conciseDisguise == "Y")
{
    simpleDisguiseMenuCfg = "tf_simple_disguise_menu 1";
}

if (fullChargeBell == "y")
{
    ringOnFullChargeCfg = "tf_sniper_fullcharge_bell 1";
}
else if (fullChargeBell == "Y")
{
    ringOnFullChargeCfg = "tf_sniper_fullcharge_bell 1";
}

if (rememberActiveWeapon == "y")
{
    rememberActiveWeaponCfg = "tf_remember_activeweapon 1";
}
else if (rememberActiveWeapon == "Y")
{
    rememberActiveWeaponCfg = "tf_remember_activeweapon 1";
}




string nullCancelling = @"// Null-Canceling Movement script
// Prevents you from pressing two opposing directions, which causes you to stop moving

// SCRIPT SETUP — DON'T MESS WITH THESE COMMANDS

alias move_bind=wasd""bind w +mf; bind a +ml; bind s +mb; bind d +mr""
alias move_bind=esdf""bind e +mf;bind s +ml;bind d +mb;bind f +mr""
alias move_bind=zqsd""bind z +mf;bind q +ml;bind s +mb;bind d +mr""
alias move_bind=arrows""bind UPARROW +mf;bind LEFTARROW +ml;bind DOWNARROW +mb;bind RIGHTARROW +mr""
alias move_bind=asdf""bind a +mf;bind d +ml;bind s +mb;bind f +mr""
alias move_bind=vim""bind k +mf;bind h +ml;bind j +mb;bind l +mr""

alias +mf""-back;+forward;alias cf +forward""
alias +mb""-forward;+back;alias cb +back""
alias +ml""-moveright;+moveleft;alias cl +moveleft""
alias +mr""-moveleft;+moveright;alias cr +moveright""
alias -mf""-forward;cb;alias cf""
alias -mb""-back;cf;alias cb""
alias -ml""-moveleft;cr;alias cl""
alias -mr""-moveright;cl;alias cr""
alias cf
alias cb
alias cl
alias cr

// CHANGE THE VALUE BELOW ACCORDING TO YOUR PREFERENCE

move_bind=wasd

echo""Null-Canceling Movement script applied""";


string autoExec2 = "exec nullcancell";
if (nullCancellingScript == "n")
{
    autoExec2 = "";
}
else if (nullCancellingScript == "n")
{
    autoExec2 = "";
}



string viewmodelDrawCfg = "r_drawviewmodel 1";
string viewmodelMiniCfg = "tf_use_min_viewmodels 1";
string viewmodelFlipCfg = "cl_flipviewmodels 0";

if (drawViewmodels == "n")
{
    viewmodelDrawCfg = "r_drawviewmodel 0";
}
else if (drawViewmodels == "N")
{
    viewmodelDrawCfg = "r_drawviewmodel 0";
}

if (minimizedViewmodels == "n")
{
    viewmodelMiniCfg = "tf_use_min_viewmodels 0";
}
else if (minimizedViewmodels == "N")
{
    viewmodelMiniCfg = "tf_use_min_viewmodels 0";
}

if (flipViewmodels == "y")
{
    viewmodelFlipCfg = "cl_flipviewmodels 0";
}
else if (flipViewmodels == "Y")
{
    viewmodelFlipCfg = "cl_flipviewmodels 0";
}

string damageCfg = "hud_combattext 1";
string damageBatchCfg = "hud_combattext_batching 1";

if (damageNumbers == "n")
{
    damageCfg = "hud_combattext 0";
}
else if (damageNumbers == "N")
{
    damageCfg = "hud_combattext 0";
}

if (damageBatching == "n")
{
    damageBatchCfg = "hud_combattext_batching 0";
}
else if (damageBatching == "N")
{
    damageBatchCfg = "hud_combattext_batching 0";
}


//cmdRate        cl_cmdrate
//interp         cl_interp
//interpRatio    cl_interp_ratio
//updateRate     cl_updaterate
//rate           rate

string cmdRateFix = "66";
string interpFix = "0";
string interpRatioFix = "1";
string updateRateFix = "66";
string rateFix = "196608";
if (cmdRate != "")
{
    cmdRateFix = cmdRate;
}
if (interp != "")
{
    interpFix = interp;
}
if (interpRatio != "")
{
    interpRatioFix = interpRatio;
}
if (updateRate != "")
{
    updateRateFix = updateRate;
}
if (rate != "")
{
    rateFix = rate;
}

string cmdRateCvar = "cl_cmdrate " + cmdRateFix;
string interpCvar = "cl_interp " + interpFix;
string interpRatioCvar = "cl_interp_ratio " + interpRatioFix;
string updateRateCvar = "cl_updaterate " + updateRateFix;
string rateCvar = "rate " + rateFix;

//tf2Folder exist too



Console.WriteLine("Gathered All Information Together");
//////////////////////////////////////////////////////////////////
///////////////Prepare and Compile Parts together/////////////////
//////////////and put them all to the tf2 folder//////////////////
//////////////////////////////////////////////////////////////////
///
Console.WriteLine("Starting Compiling");

Directory.Delete(@"C:\BLT.CFG.TEMPORARY\", true);

Directory.CreateDirectory(@"C:\BLT.CFG.TEMPORARY\");
Directory.CreateDirectory(@"C:\BLT.CFG.TEMPORARY\cfg\");


StreamWriter SW = new System.IO.StreamWriter(@"C:\BLT.CFG.TEMPORARY\cfg\autoexec.cfg");
SW.WriteLine(autoExec0);
SW.WriteLine(autoExec1);
SW.WriteLine(autoExec2);
SW.Flush();
SW.Close();
SW.Dispose();
SW = null;

Console.WriteLine("Compiled the 'autoexec.cfg'");

if (configGraphics == "1")
{
    Directory.CreateDirectory(@"C:\BLT.CFG.TEMPORARY\cfg\comfig\");
    /////////////////////////////////////////////////////////////////
    /////////////////////Class-Specific Options//////////////////////
    /////////////////////////////////////////////////////////////////
    ///Demoman
    StreamWriter SWMCE = new System.IO.StreamWriter(@"C:\BLT.CFG.TEMPORARY\cfg\demoman.cfg");
    SWMCE.WriteLine(mcUltraProjectile1);
    SWMCE.WriteLine(mcUltraClass2);
    SWMCE.WriteLine(mcUltraDemoman3);
    SWMCE.Flush();
    SWMCE.Close();
    SWMCE.Dispose();
    SWMCE = null;

    ///Engineer
    StreamWriter SWMCD = new System.IO.StreamWriter(@"C:\BLT.CFG.TEMPORARY\cfg\engineer.cfg");
    SWMCD.WriteLine(mcUltraHitscan1);
    SWMCD.WriteLine(mcUltraClass2);
    SWMCD.WriteLine(mcUltraEngineer3);
    SWMCD.Flush();
    SWMCD.Close();
    SWMCD.Dispose();
    SWMCD = null;

    ///Heavy
    StreamWriter SWMCH = new System.IO.StreamWriter(@"C:\BLT.CFG.TEMPORARY\cfg\heavyweapons.cfg");
    SWMCH.WriteLine(mcUltraHitscan1);
    SWMCH.WriteLine(mcUltraClass2);
    SWMCH.WriteLine(mcUltraHeavy3);
    SWMCH.Flush();
    SWMCH.Close();
    SWMCH.Dispose();
    SWMCH = null;

    ///Medic
    StreamWriter SWMCM = new System.IO.StreamWriter(@"C:\BLT.CFG.TEMPORARY\cfg\medic.cfg");
    SWMCM.WriteLine(mcUltraProjectile1);
    SWMCM.WriteLine(mcUltraClass2);
    SWMCM.WriteLine(mcUltraMedic3);
    SWMCM.Flush();
    SWMCM.Close();
    SWMCM.Dispose();
    SWMCM = null;

    ///Pyro
    StreamWriter SWMCP = new System.IO.StreamWriter(@"C:\BLT.CFG.TEMPORARY\cfg\pyro.cfg");
    SWMCP.WriteLine(mcUltraProjectile1);
    SWMCP.WriteLine(mcUltraClass2);
    SWMCP.WriteLine(mcUltraPyro3);
    SWMCP.Flush();
    SWMCP.Close();
    SWMCP.Dispose();
    SWMCP = null;

    ///Scout
    StreamWriter SWMCSc = new System.IO.StreamWriter(@"C:\BLT.CFG.TEMPORARY\cfg\scout.cfg");
    SWMCSc.WriteLine(mcUltraHitscan1);
    SWMCSc.WriteLine(mcUltraClass2);
    SWMCSc.WriteLine(mcUltraScout3);
    SWMCSc.Flush();
    SWMCSc.Close();
    SWMCSc.Dispose();
    SWMCSc = null;

    ///Sniper
    StreamWriter SWMCSn = new System.IO.StreamWriter(@"C:\BLT.CFG.TEMPORARY\cfg\sniper.cfg");
    SWMCSn.WriteLine(mcUltraHitscan1);
    SWMCSn.WriteLine(mcUltraClass2);
    SWMCSn.WriteLine(mcUltraSniper3);
    SWMCSn.Flush();
    SWMCSn.Close();
    SWMCSn.Dispose();
    SWMCSn = null;

    ///Soldier
    StreamWriter SWMCSo = new System.IO.StreamWriter(@"C:\BLT.CFG.TEMPORARY\cfg\soldier.cfg");
    SWMCSo.WriteLine(mcUltraProjectile1);
    SWMCSo.WriteLine(mcUltraClass2);
    SWMCSo.WriteLine(mcUltraSoldier3);
    SWMCSo.Flush();
    SWMCSo.Close();
    SWMCSo.Dispose();
    SWMCSo = null;

    ///Spy
    StreamWriter SWMCSp = new System.IO.StreamWriter(@"C:\BLT.CFG.TEMPORARY\cfg\spy.cfg");
    SWMCSp.WriteLine(mcUltraSpy1);
    SWMCSp.WriteLine(mcUltraClass2);
    SWMCSp.WriteLine(mcUltraSpy3);
    SWMCSp.Flush();
    SWMCSp.Close();
    SWMCSp.Dispose();
    SWMCSp = null;

    Console.WriteLine("Mastercomfig Generator: Generated Class Configs");


    //////////////////////////////////////Comfig///////////////////////////////////////
    ///

    StreamWriter SWMComfig = new System.IO.StreamWriter(@"C:\BLT.CFG.TEMPORARY\cfg\comfig\comfig.cfg");
    SWMComfig.WriteLine(mcUltraComfig);
    SWMComfig.Flush();
    SWMComfig.Close();
    SWMComfig.Dispose();
    SWMComfig = null;

    Console.WriteLine("Mastercomfig Generator: Generated Comfig");

    StreamWriter SWMAddons = new System.IO.StreamWriter(@"C:\BLT.CFG.TEMPORARY\cfg\comfig\addons.cfg");
    SWMAddons.WriteLine(mcUltraAddons);
    SWMAddons.Flush();
    SWMAddons.Close();
    SWMAddons.Dispose();
    SWMAddons = null;

    StreamWriter SWMAddonsSetup = new System.IO.StreamWriter(@"C:\BLT.CFG.TEMPORARY\cfg\comfig\addons_setup.cfg");
    SWMAddonsSetup.WriteLine(mcUltraAddonsSetup);
    SWMAddonsSetup.Flush();
    SWMAddonsSetup.Close();
    SWMAddonsSetup.Dispose();
    SWMAddonsSetup = null;

    StreamWriter SWMDefine = new System.IO.StreamWriter(@"C:\BLT.CFG.TEMPORARY\cfg\comfig\define_presets.cfg");
    SWMDefine.WriteLine(mcUltraDefinePresets);
    SWMDefine.Flush();
    SWMDefine.Close();
    SWMDefine.Dispose();
    SWMDefine = null;

    StreamWriter SWMEcho = new System.IO.StreamWriter(@"C:\BLT.CFG.TEMPORARY\cfg\comfig\echo.cfg");
    SWMEcho.WriteLine(mcUltraEcho);
    SWMEcho.Flush();
    SWMEcho.Close();
    SWMEcho.Dispose();
    SWMEcho = null;

    StreamWriter SWMFinalize = new System.IO.StreamWriter(@"C:\BLT.CFG.TEMPORARY\cfg\comfig\finalize.cfg");
    SWMFinalize.WriteLine(mcUltraFinalize);
    SWMFinalize.Flush();
    SWMFinalize.Close();
    SWMFinalize.Dispose();
    SWMFinalize = null;

    StreamWriter SWMGO = new System.IO.StreamWriter(@"C:\BLT.CFG.TEMPORARY\cfg\comfig\game_overrides.cfg");
    SWMGO.WriteLine(mcUltraGameOverrides);
    SWMGO.Flush();
    SWMGO.Close();
    SWMGO.Dispose();
    SWMGO = null;

    StreamWriter SWMMO = new System.IO.StreamWriter(@"C:\BLT.CFG.TEMPORARY\cfg\comfig\mm_override.cfg");
    SWMMO.WriteLine(mcUltraMMOverride);
    SWMMO.Flush();
    SWMMO.Close();
    SWMMO.Dispose();
    SWMMO = null;

    StreamWriter SWML = new System.IO.StreamWriter(@"C:\BLT.CFG.TEMPORARY\cfg\comfig\module_levels.cfg");
    SWML.WriteLine(mcUltraModuleLevels);
    SWML.Flush();
    SWML.Close();
    SWML.Dispose();
    SWML = null;

    StreamWriter SWMR = new System.IO.StreamWriter(@"C:\BLT.CFG.TEMPORARY\cfg\comfig\modules_run.cfg");
    SWMR.WriteLine(mcUltraModulesRun);
    SWMR.Flush();
    SWMR.Close();
    SWMR.Dispose();
    SWMR = null;

    StreamWriter SWMVLR = new System.IO.StreamWriter(@"C:\BLT.CFG.TEMPORARY\cfg\comfig\very_low_reset.cfg");
    SWMVLR.WriteLine(mcUltraVeryLowReset);
    SWMVLR.Flush();
    SWMVLR.Close();
    SWMVLR.Dispose();
    SWMVLR = null;

    Console.WriteLine("Mastercomfig Generator: Generated Utility Configs");

    ///////Presets
    ///
    Directory.CreateDirectory(@"C:\BLT.CFG.TEMPORARY\cfg\presets\");

    StreamWriter SWMVLP = new System.IO.StreamWriter(@"C:\BLT.CFG.TEMPORARY\cfg\presets\very-low.cfg");
    SWMVLP.WriteLine(mcVLowPreset);
    SWMVLP.Flush();
    SWMVLP.Close();
    SWMVLP.Dispose();
    SWMVLP = null;

    StreamWriter SWMLP = new System.IO.StreamWriter(@"C:\BLT.CFG.TEMPORARY\cfg\presets\medium-low.cfg");
    SWMLP.WriteLine(mcLowPreset);
    SWMLP.Flush();
    SWMLP.Close();
    SWMLP.Dispose();
    SWMLP = null;

    StreamWriter SWMMP = new System.IO.StreamWriter(@"C:\BLT.CFG.TEMPORARY\cfg\presets\medium.cfg");
    SWMMP.WriteLine(mcMidPreset);
    SWMMP.Flush();
    SWMMP.Close();
    SWMMP.Dispose();
    SWMMP = null;

    StreamWriter SWMHP = new System.IO.StreamWriter(@"C:\BLT.CFG.TEMPORARY\cfg\presets\high.cfg");
    SWMHP.WriteLine(mcHighPreset);
    SWMHP.Flush();
    SWMHP.Close();
    SWMHP.Dispose();
    SWMHP = null;

    StreamWriter SWMUP = new System.IO.StreamWriter(@"C:\BLT.CFG.TEMPORARY\cfg\presets\ultra.cfg");
    SWMUP.WriteLine(mcUltraPreset);
    SWMUP.Flush();
    SWMUP.Close();
    SWMUP.Dispose();
    SWMUP = null;

    Console.WriteLine("Mastercomfig Generator: Generated Preset Configs");
}
else if (configGraphics == "2")
{
    Console.WriteLine("Comanglia Generator: Generating 'GFXC.cfg'");
    if (configGraphicsQuality == "1")
    {
        StreamWriter SWC = new System.IO.StreamWriter(@"C:\BLT.CFG.TEMPORARY\cfg\gfxc.cfg");
        SWC.WriteLine(comangliaToaster);
        SWC.Flush();
        SWC.Close();
        SWC.Dispose();
        SWC = null;
    }
    else if (configGraphicsQuality == "2")
    {
        StreamWriter SWC = new System.IO.StreamWriter(@"C:\BLT.CFG.TEMPORARY\cfg\gfxc.cfg");
        SWC.WriteLine(comangliaMedium);
        SWC.Flush();
        SWC.Close();
        SWC.Dispose();
        SWC = null;
    }
    else if (configGraphicsQuality == "3")
    {
        StreamWriter SWC = new System.IO.StreamWriter(@"C:\BLT.CFG.TEMPORARY\cfg\gfxc.cfg");
        SWC.WriteLine(comangliaCinema);
        SWC.Flush();
        SWC.Close();
        SWC.Dispose();
        SWC = null;
    }
    else
    {
        StreamWriter SWC = new System.IO.StreamWriter(@"C:\BLT.CFG.TEMPORARY\cfg\gfxc.cfg");
        SWC.WriteLine(comangliaMedium);
        SWC.Flush();
        SWC.Close();
        SWC.Dispose();
        SWC = null;
    }
    Console.WriteLine("Comanglia Generator: Generated 'GFXC.cfg'");
}

StreamWriter SWBLT = new System.IO.StreamWriter(@"C:\BLT.CFG.TEMPORARY\cfg\blt.cfg");
SWBLT.WriteLine(fastWeaponSwitchCfg);
SWBLT.WriteLine(autoReloadCfg);
SWBLT.WriteLine(advancedSpecCfg);
SWBLT.WriteLine(disableHtmlMotdCfg);
SWBLT.WriteLine(usePlayerModelCfg);
SWBLT.WriteLine(dieAfterClassChangeCfg);
SWBLT.WriteLine(rezoomSniperCfg);
SWBLT.WriteLine(noCrossHairSniperCfg);
SWBLT.WriteLine(autohealMedigunCfg);
SWBLT.WriteLine(markerOverHealTargetCfg);
SWBLT.WriteLine(simpleDisguiseMenuCfg);
SWBLT.WriteLine(ringOnFullChargeCfg);
SWBLT.WriteLine(rememberActiveWeaponCfg);
SWBLT.WriteLine(damageCfg);
SWBLT.WriteLine(damageBatchCfg);
SWBLT.WriteLine(cmdRateCvar);
SWBLT.WriteLine(interpCvar);
SWBLT.WriteLine(interpRatioCvar);
SWBLT.WriteLine(updateRateCvar);
SWBLT.WriteLine(rateCvar);
SWBLT.Flush();
SWBLT.Close();
SWBLT.Dispose();
SWBLT = null;

Console.WriteLine("Compiled all Options Together");

if (nullCancellingScript == "Y")
{
    StreamWriter SWNC = new System.IO.StreamWriter(@"C:\BLT.CFG.TEMPORARY\cfg\nullcancell.cfg");
    SWNC.WriteLine(nullCancelling);
    SWNC.Flush();
    SWNC.Close();
    SWNC.Dispose();
    SWNC = null;
}
else if (nullCancellingScript == "y")
{
    StreamWriter SWNC = new System.IO.StreamWriter(@"C:\BLT.CFG.TEMPORARY\cfg\nullcancell.cfg");
    SWNC.WriteLine(nullCancelling);
    SWNC.Flush();
    SWNC.Close();
    SWNC.Dispose();
    SWNC = null;
}
StreamWriter SWCr = new System.IO.StreamWriter(@"C:\BLT.CFG.TEMPORARY\credits.txt");
SWCr.WriteLine("Mastercomfig: https://mastercomfig.com");
SWCr.WriteLine("Comanglia: https://github.com/Comanglia/ComangliaComs");
SWCr.WriteLine("NullCancelling Movement Script: https://gamebanana.com/scripts/9842");
SWCr.WriteLine("Made Using BLT.CFG: https://bulutcorbaci.com.tr/bltcfg");
SWCr.Flush();
SWCr.Close();
SWCr.Dispose();
SWCr = null;

Console.WriteLine("Compiled Null-Cancelling Script");

Console.WriteLine("Generated all Configs");

Console.WriteLine(@"Generating TF\Custom Folder");
string tf2FolderGenuine = @"C:\Program Files (x86)\Steam\steamapps\common\Team Fortress 2";
if (tf2Folder == "")
{
    tf2Folder = tf2FolderGenuine;
}

if (Directory.Exists(tf2Folder + @"\tf\custom\BLT.CFG\"))
{
    Directory.Delete(tf2Folder + @"\tf\custom\BLT.CFG\", true);
}

DirectoryCopy(@"C:\BLT.CFG.TEMPORARY", tf2Folder + @"\tf\custom\BLT.CFG\", true);

static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
{
    // Get the subdirectories for the specified directory.
    DirectoryInfo dir = new DirectoryInfo(sourceDirName);

    if (!dir.Exists)
    {
        throw new DirectoryNotFoundException(
            "Source directory does not exist or could not be found: "
            + sourceDirName);
    }

    DirectoryInfo[] dirs = dir.GetDirectories();

    // If the destination directory doesn't exist, create it.       
    Directory.CreateDirectory(destDirName);

    // Get the files in the directory and copy them to the new location.
    FileInfo[] files = dir.GetFiles();
    foreach (FileInfo file in files)
    {
        string tempPath = Path.Combine(destDirName, file.Name);
        file.CopyTo(tempPath, false);
    }

    // If copying subdirectories, copy them and their contents to new location.
    if (copySubDirs)
    {
        foreach (DirectoryInfo subdir in dirs)
        {
            string tempPath = Path.Combine(destDirName, subdir.Name);
            DirectoryCopy(subdir.FullName, tempPath, copySubDirs);
        }
    }
}

Directory.Delete(@"C:\BLT.CFG.TEMPORARY", true);

Console.WriteLine("Successfully Copied to Custom Folder");
Console.WriteLine("Done");