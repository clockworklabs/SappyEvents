using System;
using System.Diagnostics;
using Sappy;
using UnityEngine;

public partial class SappyBenchmark
{
    public event Action GoodOldEvent;

    private SapStem SappyStem { get; } = new();
    private SapTargets SappyEvent => SappyStem.Targets;
    
    private Stopwatch _stopwatch;
    
    public void GetResults(out double oldSubscription, out double oldResubscription, out double oldInvocation, out double oldUnsubscription, out double newSubscription, out double newResubscription, out double newInvocation, out double newUnsubscription) =>
        GetResults(100, 500, out oldSubscription, out oldResubscription, out oldInvocation, out oldUnsubscription, out newSubscription, out newResubscription, out newInvocation, out newUnsubscription);
    public void GetResults(int loopsCount, int invocationsCount, out double oldSubscription, out double oldResubscription, out double oldInvocation, out double oldUnsubscription, out double newSubscription, out double newResubscription, out double newInvocation, out double newUnsubscription)
    {
        loopsCount = Mathf.Max(loopsCount, 2);
        invocationsCount = Mathf.Max(invocationsCount, 1);
        
        oldSubscription = 0;
        oldResubscription = 0;
        oldInvocation = 0;
        oldUnsubscription = 0;
        newSubscription = 0;
        newResubscription = 0;
        newInvocation = 0;
        newUnsubscription = 0;

        for(var i = 0; i < loopsCount; i++)
        {
            // Old: Initial Subscriptions Start
            if (_stopwatch == null)
            {
                _stopwatch = Stopwatch.StartNew();
            }
            else
            {
                _stopwatch.Restart();
            }

            GoodOldEvent += Callback000;
            GoodOldEvent += Callback001;
            GoodOldEvent += Callback002;
            GoodOldEvent += Callback003;
            GoodOldEvent += Callback004;
            GoodOldEvent += Callback005;
            GoodOldEvent += Callback006;
            GoodOldEvent += Callback007;
            GoodOldEvent += Callback008;
            GoodOldEvent += Callback009;
            GoodOldEvent += Callback010;
            GoodOldEvent += Callback011;
            GoodOldEvent += Callback012;
            GoodOldEvent += Callback013;
            GoodOldEvent += Callback014;
            GoodOldEvent += Callback015;
            GoodOldEvent += Callback016;
            GoodOldEvent += Callback017;
            GoodOldEvent += Callback018;
            GoodOldEvent += Callback019;
            GoodOldEvent += Callback020;
            GoodOldEvent += Callback021;
            GoodOldEvent += Callback022;
            GoodOldEvent += Callback023;
            GoodOldEvent += Callback024;
            GoodOldEvent += Callback025;
            GoodOldEvent += Callback026;
            GoodOldEvent += Callback027;
            GoodOldEvent += Callback028;
            GoodOldEvent += Callback029;
            GoodOldEvent += Callback030;
            GoodOldEvent += Callback031;
            GoodOldEvent += Callback032;
            GoodOldEvent += Callback033;
            GoodOldEvent += Callback034;
            GoodOldEvent += Callback035;
            GoodOldEvent += Callback036;
            GoodOldEvent += Callback037;
            GoodOldEvent += Callback038;
            GoodOldEvent += Callback039;
            GoodOldEvent += Callback040;
            GoodOldEvent += Callback041;
            GoodOldEvent += Callback042;
            GoodOldEvent += Callback043;
            GoodOldEvent += Callback044;
            GoodOldEvent += Callback045;
            GoodOldEvent += Callback046;
            GoodOldEvent += Callback047;
            GoodOldEvent += Callback048;
            GoodOldEvent += Callback049;
            GoodOldEvent += Callback050;
            GoodOldEvent += Callback051;
            GoodOldEvent += Callback052;
            GoodOldEvent += Callback053;
            GoodOldEvent += Callback054;
            GoodOldEvent += Callback055;
            GoodOldEvent += Callback056;
            GoodOldEvent += Callback057;
            GoodOldEvent += Callback058;
            GoodOldEvent += Callback059;
            GoodOldEvent += Callback060;
            GoodOldEvent += Callback061;
            GoodOldEvent += Callback062;
            GoodOldEvent += Callback063;
            GoodOldEvent += Callback064;
            GoodOldEvent += Callback065;
            GoodOldEvent += Callback066;
            GoodOldEvent += Callback067;
            GoodOldEvent += Callback068;
            GoodOldEvent += Callback069;
            GoodOldEvent += Callback070;
            GoodOldEvent += Callback071;
            GoodOldEvent += Callback072;
            GoodOldEvent += Callback073;
            GoodOldEvent += Callback074;
            GoodOldEvent += Callback075;
            GoodOldEvent += Callback076;
            GoodOldEvent += Callback077;
            GoodOldEvent += Callback078;
            GoodOldEvent += Callback079;
            GoodOldEvent += Callback080;
            GoodOldEvent += Callback081;
            GoodOldEvent += Callback082;
            GoodOldEvent += Callback083;
            GoodOldEvent += Callback084;
            GoodOldEvent += Callback085;
            GoodOldEvent += Callback086;
            GoodOldEvent += Callback087;
            GoodOldEvent += Callback088;
            GoodOldEvent += Callback089;
            GoodOldEvent += Callback090;
            GoodOldEvent += Callback091;
            GoodOldEvent += Callback092;
            GoodOldEvent += Callback093;
            GoodOldEvent += Callback094;
            GoodOldEvent += Callback095;
            GoodOldEvent += Callback096;
            GoodOldEvent += Callback097;
            GoodOldEvent += Callback098;
            GoodOldEvent += Callback099;
            GoodOldEvent += Callback100;
            GoodOldEvent += Callback101;
            GoodOldEvent += Callback102;
            GoodOldEvent += Callback103;
            GoodOldEvent += Callback104;
            GoodOldEvent += Callback105;
            GoodOldEvent += Callback106;
            GoodOldEvent += Callback107;
            GoodOldEvent += Callback108;
            GoodOldEvent += Callback109;
            GoodOldEvent += Callback110;
            GoodOldEvent += Callback111;
            GoodOldEvent += Callback112;
            GoodOldEvent += Callback113;
            GoodOldEvent += Callback114;
            GoodOldEvent += Callback115;
            GoodOldEvent += Callback116;
            GoodOldEvent += Callback117;
            GoodOldEvent += Callback118;
            GoodOldEvent += Callback119;
            GoodOldEvent += Callback120;
            GoodOldEvent += Callback121;
            GoodOldEvent += Callback122;
            GoodOldEvent += Callback123;
            GoodOldEvent += Callback124;
            GoodOldEvent += Callback125;
            GoodOldEvent += Callback126;
            GoodOldEvent += Callback127;
            GoodOldEvent += Callback128;
            GoodOldEvent += Callback129;
            GoodOldEvent += Callback130;
            GoodOldEvent += Callback131;
            GoodOldEvent += Callback132;
            GoodOldEvent += Callback133;
            GoodOldEvent += Callback134;
            GoodOldEvent += Callback135;
            GoodOldEvent += Callback136;
            GoodOldEvent += Callback137;
            GoodOldEvent += Callback138;
            GoodOldEvent += Callback139;
            GoodOldEvent += Callback140;
            GoodOldEvent += Callback141;
            GoodOldEvent += Callback142;
            GoodOldEvent += Callback143;
            GoodOldEvent += Callback144;
            GoodOldEvent += Callback145;
            GoodOldEvent += Callback146;
            GoodOldEvent += Callback147;
            GoodOldEvent += Callback148;
            GoodOldEvent += Callback149;
            GoodOldEvent += Callback150;
            GoodOldEvent += Callback151;
            GoodOldEvent += Callback152;
            GoodOldEvent += Callback153;
            GoodOldEvent += Callback154;
            GoodOldEvent += Callback155;
            GoodOldEvent += Callback156;
            GoodOldEvent += Callback157;
            GoodOldEvent += Callback158;
            GoodOldEvent += Callback159;
            GoodOldEvent += Callback160;
            GoodOldEvent += Callback161;
            GoodOldEvent += Callback162;
            GoodOldEvent += Callback163;
            GoodOldEvent += Callback164;
            GoodOldEvent += Callback165;
            GoodOldEvent += Callback166;
            GoodOldEvent += Callback167;
            GoodOldEvent += Callback168;
            GoodOldEvent += Callback169;
            GoodOldEvent += Callback170;
            GoodOldEvent += Callback171;
            GoodOldEvent += Callback172;
            GoodOldEvent += Callback173;
            GoodOldEvent += Callback174;
            GoodOldEvent += Callback175;
            GoodOldEvent += Callback176;
            GoodOldEvent += Callback177;
            GoodOldEvent += Callback178;
            GoodOldEvent += Callback179;
            GoodOldEvent += Callback180;
            GoodOldEvent += Callback181;
            GoodOldEvent += Callback182;
            GoodOldEvent += Callback183;
            GoodOldEvent += Callback184;
            GoodOldEvent += Callback185;
            GoodOldEvent += Callback186;
            GoodOldEvent += Callback187;
            GoodOldEvent += Callback188;
            GoodOldEvent += Callback189;
            GoodOldEvent += Callback190;
            GoodOldEvent += Callback191;
            GoodOldEvent += Callback192;
            GoodOldEvent += Callback193;
            GoodOldEvent += Callback194;
            GoodOldEvent += Callback195;
            GoodOldEvent += Callback196;
            GoodOldEvent += Callback197;
            GoodOldEvent += Callback198;
            GoodOldEvent += Callback199;
            GoodOldEvent += Callback200;
            GoodOldEvent += Callback201;
            GoodOldEvent += Callback202;
            GoodOldEvent += Callback203;
            GoodOldEvent += Callback204;
            GoodOldEvent += Callback205;
            GoodOldEvent += Callback206;
            GoodOldEvent += Callback207;
            GoodOldEvent += Callback208;
            GoodOldEvent += Callback209;
            GoodOldEvent += Callback210;
            GoodOldEvent += Callback211;
            GoodOldEvent += Callback212;
            GoodOldEvent += Callback213;
            GoodOldEvent += Callback214;
            GoodOldEvent += Callback215;
            GoodOldEvent += Callback216;
            GoodOldEvent += Callback217;
            GoodOldEvent += Callback218;
            GoodOldEvent += Callback219;
            GoodOldEvent += Callback220;
            GoodOldEvent += Callback221;
            GoodOldEvent += Callback222;
            GoodOldEvent += Callback223;
            GoodOldEvent += Callback224;
            GoodOldEvent += Callback225;
            GoodOldEvent += Callback226;
            GoodOldEvent += Callback227;
            GoodOldEvent += Callback228;
            GoodOldEvent += Callback229;
            GoodOldEvent += Callback230;
            GoodOldEvent += Callback231;
            GoodOldEvent += Callback232;
            GoodOldEvent += Callback233;
            GoodOldEvent += Callback234;
            GoodOldEvent += Callback235;
            GoodOldEvent += Callback236;
            GoodOldEvent += Callback237;
            GoodOldEvent += Callback238;
            GoodOldEvent += Callback239;
            GoodOldEvent += Callback240;
            GoodOldEvent += Callback241;
            GoodOldEvent += Callback242;
            GoodOldEvent += Callback243;
            GoodOldEvent += Callback244;
            GoodOldEvent += Callback245;
            GoodOldEvent += Callback246;
            GoodOldEvent += Callback247;
            GoodOldEvent += Callback248;
            GoodOldEvent += Callback249;
            GoodOldEvent += Callback250;
            GoodOldEvent += Callback251;
            GoodOldEvent += Callback252;
            GoodOldEvent += Callback253;
            GoodOldEvent += Callback254;
            GoodOldEvent += Callback255;
            GoodOldEvent += Callback256;
            GoodOldEvent += Callback257;
            GoodOldEvent += Callback258;
            GoodOldEvent += Callback259;
            GoodOldEvent += Callback260;
            GoodOldEvent += Callback261;
            GoodOldEvent += Callback262;
            GoodOldEvent += Callback263;
            GoodOldEvent += Callback264;
            GoodOldEvent += Callback265;
            GoodOldEvent += Callback266;
            GoodOldEvent += Callback267;
            GoodOldEvent += Callback268;
            GoodOldEvent += Callback269;
            GoodOldEvent += Callback270;
            GoodOldEvent += Callback271;
            GoodOldEvent += Callback272;
            GoodOldEvent += Callback273;
            GoodOldEvent += Callback274;
            GoodOldEvent += Callback275;
            GoodOldEvent += Callback276;
            GoodOldEvent += Callback277;
            GoodOldEvent += Callback278;
            GoodOldEvent += Callback279;
            GoodOldEvent += Callback280;
            GoodOldEvent += Callback281;
            GoodOldEvent += Callback282;
            GoodOldEvent += Callback283;
            GoodOldEvent += Callback284;
            GoodOldEvent += Callback285;
            GoodOldEvent += Callback286;
            GoodOldEvent += Callback287;
            GoodOldEvent += Callback288;
            GoodOldEvent += Callback289;
            GoodOldEvent += Callback290;
            GoodOldEvent += Callback291;
            GoodOldEvent += Callback292;
            GoodOldEvent += Callback293;
            GoodOldEvent += Callback294;
            GoodOldEvent += Callback295;
            GoodOldEvent += Callback296;
            GoodOldEvent += Callback297;
            GoodOldEvent += Callback298;
            GoodOldEvent += Callback299;
            GoodOldEvent += Callback300;
            GoodOldEvent += Callback301;
            GoodOldEvent += Callback302;
            GoodOldEvent += Callback303;
            GoodOldEvent += Callback304;
            GoodOldEvent += Callback305;
            GoodOldEvent += Callback306;
            GoodOldEvent += Callback307;
            GoodOldEvent += Callback308;
            GoodOldEvent += Callback309;
            GoodOldEvent += Callback310;
            GoodOldEvent += Callback311;
            GoodOldEvent += Callback312;
            GoodOldEvent += Callback313;
            GoodOldEvent += Callback314;
            GoodOldEvent += Callback315;
            GoodOldEvent += Callback316;
            GoodOldEvent += Callback317;
            GoodOldEvent += Callback318;
            GoodOldEvent += Callback319;
            GoodOldEvent += Callback320;
            GoodOldEvent += Callback321;
            GoodOldEvent += Callback322;
            GoodOldEvent += Callback323;
            GoodOldEvent += Callback324;
            GoodOldEvent += Callback325;
            GoodOldEvent += Callback326;
            GoodOldEvent += Callback327;
            GoodOldEvent += Callback328;
            GoodOldEvent += Callback329;
            GoodOldEvent += Callback330;
            GoodOldEvent += Callback331;
            GoodOldEvent += Callback332;
            GoodOldEvent += Callback333;
            GoodOldEvent += Callback334;
            GoodOldEvent += Callback335;
            GoodOldEvent += Callback336;
            GoodOldEvent += Callback337;
            GoodOldEvent += Callback338;
            GoodOldEvent += Callback339;
            GoodOldEvent += Callback340;
            GoodOldEvent += Callback341;
            GoodOldEvent += Callback342;
            GoodOldEvent += Callback343;
            GoodOldEvent += Callback344;
            GoodOldEvent += Callback345;
            GoodOldEvent += Callback346;
            GoodOldEvent += Callback347;
            GoodOldEvent += Callback348;
            GoodOldEvent += Callback349;
            GoodOldEvent += Callback350;
            GoodOldEvent += Callback351;
            GoodOldEvent += Callback352;
            GoodOldEvent += Callback353;
            GoodOldEvent += Callback354;
            GoodOldEvent += Callback355;
            GoodOldEvent += Callback356;
            GoodOldEvent += Callback357;
            GoodOldEvent += Callback358;
            GoodOldEvent += Callback359;
            GoodOldEvent += Callback360;
            GoodOldEvent += Callback361;
            GoodOldEvent += Callback362;
            GoodOldEvent += Callback363;
            GoodOldEvent += Callback364;
            GoodOldEvent += Callback365;
            GoodOldEvent += Callback366;
            GoodOldEvent += Callback367;
            GoodOldEvent += Callback368;
            GoodOldEvent += Callback369;
            GoodOldEvent += Callback370;
            GoodOldEvent += Callback371;
            GoodOldEvent += Callback372;
            GoodOldEvent += Callback373;
            GoodOldEvent += Callback374;
            GoodOldEvent += Callback375;
            GoodOldEvent += Callback376;
            GoodOldEvent += Callback377;
            GoodOldEvent += Callback378;
            GoodOldEvent += Callback379;
            GoodOldEvent += Callback380;
            GoodOldEvent += Callback381;
            GoodOldEvent += Callback382;
            GoodOldEvent += Callback383;
            GoodOldEvent += Callback384;
            GoodOldEvent += Callback385;
            GoodOldEvent += Callback386;
            GoodOldEvent += Callback387;
            GoodOldEvent += Callback388;
            GoodOldEvent += Callback389;
            GoodOldEvent += Callback390;
            GoodOldEvent += Callback391;
            GoodOldEvent += Callback392;
            GoodOldEvent += Callback393;
            GoodOldEvent += Callback394;
            GoodOldEvent += Callback395;
            GoodOldEvent += Callback396;
            GoodOldEvent += Callback397;
            GoodOldEvent += Callback398;
            GoodOldEvent += Callback399;
            GoodOldEvent += Callback400;
            GoodOldEvent += Callback401;
            GoodOldEvent += Callback402;
            GoodOldEvent += Callback403;
            GoodOldEvent += Callback404;
            GoodOldEvent += Callback405;
            GoodOldEvent += Callback406;
            GoodOldEvent += Callback407;
            GoodOldEvent += Callback408;
            GoodOldEvent += Callback409;
            GoodOldEvent += Callback410;
            GoodOldEvent += Callback411;
            GoodOldEvent += Callback412;
            GoodOldEvent += Callback413;
            GoodOldEvent += Callback414;
            GoodOldEvent += Callback415;
            GoodOldEvent += Callback416;
            GoodOldEvent += Callback417;
            GoodOldEvent += Callback418;
            GoodOldEvent += Callback419;
            GoodOldEvent += Callback420;
            GoodOldEvent += Callback421;
            GoodOldEvent += Callback422;
            GoodOldEvent += Callback423;
            GoodOldEvent += Callback424;
            GoodOldEvent += Callback425;
            GoodOldEvent += Callback426;
            GoodOldEvent += Callback427;
            GoodOldEvent += Callback428;
            GoodOldEvent += Callback429;
            GoodOldEvent += Callback430;
            GoodOldEvent += Callback431;
            GoodOldEvent += Callback432;
            GoodOldEvent += Callback433;
            GoodOldEvent += Callback434;
            GoodOldEvent += Callback435;
            GoodOldEvent += Callback436;
            GoodOldEvent += Callback437;
            GoodOldEvent += Callback438;
            GoodOldEvent += Callback439;
            GoodOldEvent += Callback440;
            GoodOldEvent += Callback441;
            GoodOldEvent += Callback442;
            GoodOldEvent += Callback443;
            GoodOldEvent += Callback444;
            GoodOldEvent += Callback445;
            GoodOldEvent += Callback446;
            GoodOldEvent += Callback447;
            GoodOldEvent += Callback448;
            GoodOldEvent += Callback449;
            GoodOldEvent += Callback450;
            GoodOldEvent += Callback451;
            GoodOldEvent += Callback452;
            GoodOldEvent += Callback453;
            GoodOldEvent += Callback454;
            GoodOldEvent += Callback455;
            GoodOldEvent += Callback456;
            GoodOldEvent += Callback457;
            GoodOldEvent += Callback458;
            GoodOldEvent += Callback459;
            GoodOldEvent += Callback460;
            GoodOldEvent += Callback461;
            GoodOldEvent += Callback462;
            GoodOldEvent += Callback463;
            GoodOldEvent += Callback464;
            GoodOldEvent += Callback465;
            GoodOldEvent += Callback466;
            GoodOldEvent += Callback467;
            GoodOldEvent += Callback468;
            GoodOldEvent += Callback469;
            GoodOldEvent += Callback470;
            GoodOldEvent += Callback471;
            GoodOldEvent += Callback472;
            GoodOldEvent += Callback473;
            GoodOldEvent += Callback474;
            GoodOldEvent += Callback475;
            GoodOldEvent += Callback476;
            GoodOldEvent += Callback477;
            GoodOldEvent += Callback478;
            GoodOldEvent += Callback479;
            GoodOldEvent += Callback480;
            GoodOldEvent += Callback481;
            GoodOldEvent += Callback482;
            GoodOldEvent += Callback483;
            GoodOldEvent += Callback484;
            GoodOldEvent += Callback485;
            GoodOldEvent += Callback486;
            GoodOldEvent += Callback487;
            GoodOldEvent += Callback488;
            GoodOldEvent += Callback489;
            GoodOldEvent += Callback490;
            GoodOldEvent += Callback491;
            GoodOldEvent += Callback492;
            GoodOldEvent += Callback493;
            GoodOldEvent += Callback494;
            GoodOldEvent += Callback495;
            GoodOldEvent += Callback496;
            GoodOldEvent += Callback497;
            GoodOldEvent += Callback498;
            GoodOldEvent += Callback499;
            GoodOldEvent += Callback500;
            GoodOldEvent += Callback501;
            GoodOldEvent += Callback502;
            GoodOldEvent += Callback503;
            GoodOldEvent += Callback504;
            GoodOldEvent += Callback505;
            GoodOldEvent += Callback506;
            GoodOldEvent += Callback507;
            GoodOldEvent += Callback508;
            GoodOldEvent += Callback509;
            GoodOldEvent += Callback510;
            GoodOldEvent += Callback511;
            GoodOldEvent += Callback512;
            GoodOldEvent += Callback513;
            GoodOldEvent += Callback514;
            GoodOldEvent += Callback515;
            GoodOldEvent += Callback516;
            GoodOldEvent += Callback517;
            GoodOldEvent += Callback518;
            GoodOldEvent += Callback519;
            GoodOldEvent += Callback520;
            GoodOldEvent += Callback521;
            GoodOldEvent += Callback522;
            GoodOldEvent += Callback523;
            GoodOldEvent += Callback524;
            GoodOldEvent += Callback525;
            GoodOldEvent += Callback526;
            GoodOldEvent += Callback527;
            GoodOldEvent += Callback528;
            GoodOldEvent += Callback529;
            GoodOldEvent += Callback530;
            GoodOldEvent += Callback531;
            GoodOldEvent += Callback532;
            GoodOldEvent += Callback533;
            GoodOldEvent += Callback534;
            GoodOldEvent += Callback535;
            GoodOldEvent += Callback536;
            GoodOldEvent += Callback537;
            GoodOldEvent += Callback538;
            GoodOldEvent += Callback539;
            GoodOldEvent += Callback540;
            GoodOldEvent += Callback541;
            GoodOldEvent += Callback542;
            GoodOldEvent += Callback543;
            GoodOldEvent += Callback544;
            GoodOldEvent += Callback545;
            GoodOldEvent += Callback546;
            GoodOldEvent += Callback547;
            GoodOldEvent += Callback548;
            GoodOldEvent += Callback549;
            GoodOldEvent += Callback550;
            GoodOldEvent += Callback551;
            GoodOldEvent += Callback552;
            GoodOldEvent += Callback553;
            GoodOldEvent += Callback554;
            GoodOldEvent += Callback555;
            GoodOldEvent += Callback556;
            GoodOldEvent += Callback557;
            GoodOldEvent += Callback558;
            GoodOldEvent += Callback559;
            GoodOldEvent += Callback560;
            GoodOldEvent += Callback561;
            GoodOldEvent += Callback562;
            GoodOldEvent += Callback563;
            GoodOldEvent += Callback564;
            GoodOldEvent += Callback565;
            GoodOldEvent += Callback566;
            GoodOldEvent += Callback567;
            GoodOldEvent += Callback568;
            GoodOldEvent += Callback569;
            GoodOldEvent += Callback570;
            GoodOldEvent += Callback571;
            GoodOldEvent += Callback572;
            GoodOldEvent += Callback573;
            GoodOldEvent += Callback574;
            GoodOldEvent += Callback575;
            GoodOldEvent += Callback576;
            GoodOldEvent += Callback577;
            GoodOldEvent += Callback578;
            GoodOldEvent += Callback579;
            GoodOldEvent += Callback580;
            GoodOldEvent += Callback581;
            GoodOldEvent += Callback582;
            GoodOldEvent += Callback583;
            GoodOldEvent += Callback584;
            GoodOldEvent += Callback585;
            GoodOldEvent += Callback586;
            GoodOldEvent += Callback587;
            GoodOldEvent += Callback588;
            GoodOldEvent += Callback589;
            GoodOldEvent += Callback590;
            GoodOldEvent += Callback591;
            GoodOldEvent += Callback592;
            GoodOldEvent += Callback593;
            GoodOldEvent += Callback594;
            GoodOldEvent += Callback595;
            GoodOldEvent += Callback596;
            GoodOldEvent += Callback597;
            GoodOldEvent += Callback598;
            GoodOldEvent += Callback599;
            GoodOldEvent += Callback600;
            GoodOldEvent += Callback601;
            GoodOldEvent += Callback602;
            GoodOldEvent += Callback603;
            GoodOldEvent += Callback604;
            GoodOldEvent += Callback605;
            GoodOldEvent += Callback606;
            GoodOldEvent += Callback607;
            GoodOldEvent += Callback608;
            GoodOldEvent += Callback609;
            GoodOldEvent += Callback610;
            GoodOldEvent += Callback611;
            GoodOldEvent += Callback612;
            GoodOldEvent += Callback613;
            GoodOldEvent += Callback614;
            GoodOldEvent += Callback615;
            GoodOldEvent += Callback616;
            GoodOldEvent += Callback617;
            GoodOldEvent += Callback618;
            GoodOldEvent += Callback619;
            GoodOldEvent += Callback620;
            GoodOldEvent += Callback621;
            GoodOldEvent += Callback622;
            GoodOldEvent += Callback623;
            GoodOldEvent += Callback624;
            GoodOldEvent += Callback625;
            GoodOldEvent += Callback626;
            GoodOldEvent += Callback627;
            GoodOldEvent += Callback628;
            GoodOldEvent += Callback629;
            GoodOldEvent += Callback630;
            GoodOldEvent += Callback631;
            GoodOldEvent += Callback632;
            GoodOldEvent += Callback633;
            GoodOldEvent += Callback634;
            GoodOldEvent += Callback635;
            GoodOldEvent += Callback636;
            GoodOldEvent += Callback637;
            GoodOldEvent += Callback638;
            GoodOldEvent += Callback639;
            GoodOldEvent += Callback640;
            GoodOldEvent += Callback641;
            GoodOldEvent += Callback642;
            GoodOldEvent += Callback643;
            GoodOldEvent += Callback644;
            GoodOldEvent += Callback645;
            GoodOldEvent += Callback646;
            GoodOldEvent += Callback647;
            GoodOldEvent += Callback648;
            GoodOldEvent += Callback649;
            GoodOldEvent += Callback650;
            GoodOldEvent += Callback651;
            GoodOldEvent += Callback652;
            GoodOldEvent += Callback653;
            GoodOldEvent += Callback654;
            GoodOldEvent += Callback655;
            GoodOldEvent += Callback656;
            GoodOldEvent += Callback657;
            GoodOldEvent += Callback658;
            GoodOldEvent += Callback659;
            GoodOldEvent += Callback660;
            GoodOldEvent += Callback661;
            GoodOldEvent += Callback662;
            GoodOldEvent += Callback663;
            GoodOldEvent += Callback664;
            GoodOldEvent += Callback665;
            GoodOldEvent += Callback666;
            GoodOldEvent += Callback667;
            GoodOldEvent += Callback668;
            GoodOldEvent += Callback669;
            GoodOldEvent += Callback670;
            GoodOldEvent += Callback671;
            GoodOldEvent += Callback672;
            GoodOldEvent += Callback673;
            GoodOldEvent += Callback674;
            GoodOldEvent += Callback675;
            GoodOldEvent += Callback676;
            GoodOldEvent += Callback677;
            GoodOldEvent += Callback678;
            GoodOldEvent += Callback679;
            GoodOldEvent += Callback680;
            GoodOldEvent += Callback681;
            GoodOldEvent += Callback682;
            GoodOldEvent += Callback683;
            GoodOldEvent += Callback684;
            GoodOldEvent += Callback685;
            GoodOldEvent += Callback686;
            GoodOldEvent += Callback687;
            GoodOldEvent += Callback688;
            GoodOldEvent += Callback689;
            GoodOldEvent += Callback690;
            GoodOldEvent += Callback691;
            GoodOldEvent += Callback692;
            GoodOldEvent += Callback693;
            GoodOldEvent += Callback694;
            GoodOldEvent += Callback695;
            GoodOldEvent += Callback696;
            GoodOldEvent += Callback697;
            GoodOldEvent += Callback698;
            GoodOldEvent += Callback699;
            GoodOldEvent += Callback700;
            GoodOldEvent += Callback701;
            GoodOldEvent += Callback702;
            GoodOldEvent += Callback703;
            GoodOldEvent += Callback704;
            GoodOldEvent += Callback705;
            GoodOldEvent += Callback706;
            GoodOldEvent += Callback707;
            GoodOldEvent += Callback708;
            GoodOldEvent += Callback709;
            GoodOldEvent += Callback710;
            GoodOldEvent += Callback711;
            GoodOldEvent += Callback712;
            GoodOldEvent += Callback713;
            GoodOldEvent += Callback714;
            GoodOldEvent += Callback715;
            GoodOldEvent += Callback716;
            GoodOldEvent += Callback717;
            GoodOldEvent += Callback718;
            GoodOldEvent += Callback719;
            GoodOldEvent += Callback720;
            GoodOldEvent += Callback721;
            GoodOldEvent += Callback722;
            GoodOldEvent += Callback723;
            GoodOldEvent += Callback724;
            GoodOldEvent += Callback725;
            GoodOldEvent += Callback726;
            GoodOldEvent += Callback727;
            GoodOldEvent += Callback728;
            GoodOldEvent += Callback729;
            GoodOldEvent += Callback730;
            GoodOldEvent += Callback731;
            GoodOldEvent += Callback732;
            GoodOldEvent += Callback733;
            GoodOldEvent += Callback734;
            GoodOldEvent += Callback735;
            GoodOldEvent += Callback736;
            GoodOldEvent += Callback737;
            GoodOldEvent += Callback738;
            GoodOldEvent += Callback739;
            GoodOldEvent += Callback740;
            GoodOldEvent += Callback741;
            GoodOldEvent += Callback742;
            GoodOldEvent += Callback743;
            GoodOldEvent += Callback744;
            GoodOldEvent += Callback745;
            GoodOldEvent += Callback746;
            GoodOldEvent += Callback747;
            GoodOldEvent += Callback748;
            GoodOldEvent += Callback749;
            GoodOldEvent += Callback750;
            GoodOldEvent += Callback751;
            GoodOldEvent += Callback752;
            GoodOldEvent += Callback753;
            GoodOldEvent += Callback754;
            GoodOldEvent += Callback755;
            GoodOldEvent += Callback756;
            GoodOldEvent += Callback757;
            GoodOldEvent += Callback758;
            GoodOldEvent += Callback759;
            GoodOldEvent += Callback760;
            GoodOldEvent += Callback761;
            GoodOldEvent += Callback762;
            GoodOldEvent += Callback763;
            GoodOldEvent += Callback764;
            GoodOldEvent += Callback765;
            GoodOldEvent += Callback766;
            GoodOldEvent += Callback767;
            GoodOldEvent += Callback768;
            GoodOldEvent += Callback769;
            GoodOldEvent += Callback770;
            GoodOldEvent += Callback771;
            GoodOldEvent += Callback772;
            GoodOldEvent += Callback773;
            GoodOldEvent += Callback774;
            GoodOldEvent += Callback775;
            GoodOldEvent += Callback776;
            GoodOldEvent += Callback777;
            GoodOldEvent += Callback778;
            GoodOldEvent += Callback779;
            GoodOldEvent += Callback780;
            GoodOldEvent += Callback781;
            GoodOldEvent += Callback782;
            GoodOldEvent += Callback783;
            GoodOldEvent += Callback784;
            GoodOldEvent += Callback785;
            GoodOldEvent += Callback786;
            GoodOldEvent += Callback787;
            GoodOldEvent += Callback788;
            GoodOldEvent += Callback789;
            GoodOldEvent += Callback790;
            GoodOldEvent += Callback791;
            GoodOldEvent += Callback792;
            GoodOldEvent += Callback793;
            GoodOldEvent += Callback794;
            GoodOldEvent += Callback795;
            GoodOldEvent += Callback796;
            GoodOldEvent += Callback797;
            GoodOldEvent += Callback798;
            GoodOldEvent += Callback799;
            GoodOldEvent += Callback800;
            GoodOldEvent += Callback801;
            GoodOldEvent += Callback802;
            GoodOldEvent += Callback803;
            GoodOldEvent += Callback804;
            GoodOldEvent += Callback805;
            GoodOldEvent += Callback806;
            GoodOldEvent += Callback807;
            GoodOldEvent += Callback808;
            GoodOldEvent += Callback809;
            GoodOldEvent += Callback810;
            GoodOldEvent += Callback811;
            GoodOldEvent += Callback812;
            GoodOldEvent += Callback813;
            GoodOldEvent += Callback814;
            GoodOldEvent += Callback815;
            GoodOldEvent += Callback816;
            GoodOldEvent += Callback817;
            GoodOldEvent += Callback818;
            GoodOldEvent += Callback819;
            GoodOldEvent += Callback820;
            GoodOldEvent += Callback821;
            GoodOldEvent += Callback822;
            GoodOldEvent += Callback823;
            GoodOldEvent += Callback824;
            GoodOldEvent += Callback825;
            GoodOldEvent += Callback826;
            GoodOldEvent += Callback827;
            GoodOldEvent += Callback828;
            GoodOldEvent += Callback829;
            GoodOldEvent += Callback830;
            GoodOldEvent += Callback831;
            GoodOldEvent += Callback832;
            GoodOldEvent += Callback833;
            GoodOldEvent += Callback834;
            GoodOldEvent += Callback835;
            GoodOldEvent += Callback836;
            GoodOldEvent += Callback837;
            GoodOldEvent += Callback838;
            GoodOldEvent += Callback839;
            GoodOldEvent += Callback840;
            GoodOldEvent += Callback841;
            GoodOldEvent += Callback842;
            GoodOldEvent += Callback843;
            GoodOldEvent += Callback844;
            GoodOldEvent += Callback845;
            GoodOldEvent += Callback846;
            GoodOldEvent += Callback847;
            GoodOldEvent += Callback848;
            GoodOldEvent += Callback849;
            GoodOldEvent += Callback850;
            GoodOldEvent += Callback851;
            GoodOldEvent += Callback852;
            GoodOldEvent += Callback853;
            GoodOldEvent += Callback854;
            GoodOldEvent += Callback855;
            GoodOldEvent += Callback856;
            GoodOldEvent += Callback857;
            GoodOldEvent += Callback858;
            GoodOldEvent += Callback859;
            GoodOldEvent += Callback860;
            GoodOldEvent += Callback861;
            GoodOldEvent += Callback862;
            GoodOldEvent += Callback863;
            GoodOldEvent += Callback864;
            GoodOldEvent += Callback865;
            GoodOldEvent += Callback866;
            GoodOldEvent += Callback867;
            GoodOldEvent += Callback868;
            GoodOldEvent += Callback869;
            GoodOldEvent += Callback870;
            GoodOldEvent += Callback871;
            GoodOldEvent += Callback872;
            GoodOldEvent += Callback873;
            GoodOldEvent += Callback874;
            GoodOldEvent += Callback875;
            GoodOldEvent += Callback876;
            GoodOldEvent += Callback877;
            GoodOldEvent += Callback878;
            GoodOldEvent += Callback879;
            GoodOldEvent += Callback880;
            GoodOldEvent += Callback881;
            GoodOldEvent += Callback882;
            GoodOldEvent += Callback883;
            GoodOldEvent += Callback884;
            GoodOldEvent += Callback885;
            GoodOldEvent += Callback886;
            GoodOldEvent += Callback887;
            GoodOldEvent += Callback888;
            GoodOldEvent += Callback889;
            GoodOldEvent += Callback890;
            GoodOldEvent += Callback891;
            GoodOldEvent += Callback892;
            GoodOldEvent += Callback893;
            GoodOldEvent += Callback894;
            GoodOldEvent += Callback895;
            GoodOldEvent += Callback896;
            GoodOldEvent += Callback897;
            GoodOldEvent += Callback898;
            GoodOldEvent += Callback899;
            GoodOldEvent += Callback900;
            GoodOldEvent += Callback901;
            GoodOldEvent += Callback902;
            GoodOldEvent += Callback903;
            GoodOldEvent += Callback904;
            GoodOldEvent += Callback905;
            GoodOldEvent += Callback906;
            GoodOldEvent += Callback907;
            GoodOldEvent += Callback908;
            GoodOldEvent += Callback909;
            GoodOldEvent += Callback910;
            GoodOldEvent += Callback911;
            GoodOldEvent += Callback912;
            GoodOldEvent += Callback913;
            GoodOldEvent += Callback914;
            GoodOldEvent += Callback915;
            GoodOldEvent += Callback916;
            GoodOldEvent += Callback917;
            GoodOldEvent += Callback918;
            GoodOldEvent += Callback919;
            GoodOldEvent += Callback920;
            GoodOldEvent += Callback921;
            GoodOldEvent += Callback922;
            GoodOldEvent += Callback923;
            GoodOldEvent += Callback924;
            GoodOldEvent += Callback925;
            GoodOldEvent += Callback926;
            GoodOldEvent += Callback927;
            GoodOldEvent += Callback928;
            GoodOldEvent += Callback929;
            GoodOldEvent += Callback930;
            GoodOldEvent += Callback931;
            GoodOldEvent += Callback932;
            GoodOldEvent += Callback933;
            GoodOldEvent += Callback934;
            GoodOldEvent += Callback935;
            GoodOldEvent += Callback936;
            GoodOldEvent += Callback937;
            GoodOldEvent += Callback938;
            GoodOldEvent += Callback939;
            GoodOldEvent += Callback940;
            GoodOldEvent += Callback941;
            GoodOldEvent += Callback942;
            GoodOldEvent += Callback943;
            GoodOldEvent += Callback944;
            GoodOldEvent += Callback945;
            GoodOldEvent += Callback946;
            GoodOldEvent += Callback947;
            GoodOldEvent += Callback948;
            GoodOldEvent += Callback949;
            GoodOldEvent += Callback950;
            GoodOldEvent += Callback951;
            GoodOldEvent += Callback952;
            GoodOldEvent += Callback953;
            GoodOldEvent += Callback954;
            GoodOldEvent += Callback955;
            GoodOldEvent += Callback956;
            GoodOldEvent += Callback957;
            GoodOldEvent += Callback958;
            GoodOldEvent += Callback959;
            GoodOldEvent += Callback960;
            GoodOldEvent += Callback961;
            GoodOldEvent += Callback962;
            GoodOldEvent += Callback963;
            GoodOldEvent += Callback964;
            GoodOldEvent += Callback965;
            GoodOldEvent += Callback966;
            GoodOldEvent += Callback967;
            GoodOldEvent += Callback968;
            GoodOldEvent += Callback969;
            GoodOldEvent += Callback970;
            GoodOldEvent += Callback971;
            GoodOldEvent += Callback972;
            GoodOldEvent += Callback973;
            GoodOldEvent += Callback974;
            GoodOldEvent += Callback975;
            GoodOldEvent += Callback976;
            GoodOldEvent += Callback977;
            GoodOldEvent += Callback978;
            GoodOldEvent += Callback979;
            GoodOldEvent += Callback980;
            GoodOldEvent += Callback981;
            GoodOldEvent += Callback982;
            GoodOldEvent += Callback983;
            GoodOldEvent += Callback984;
            GoodOldEvent += Callback985;
            GoodOldEvent += Callback986;
            GoodOldEvent += Callback987;
            GoodOldEvent += Callback988;
            GoodOldEvent += Callback989;
            GoodOldEvent += Callback990;
            GoodOldEvent += Callback991;
            GoodOldEvent += Callback992;
            GoodOldEvent += Callback993;
            GoodOldEvent += Callback994;
            GoodOldEvent += Callback995;
            GoodOldEvent += Callback996;
            GoodOldEvent += Callback997;
            GoodOldEvent += Callback998;
            GoodOldEvent += Callback999;
            
            _stopwatch.Stop();
            var o1 = _stopwatch.Elapsed.TotalSeconds;
            // Old: Initial Subscriptions End
            
            // Old: Invocation Start
            _stopwatch.Restart();
            
            for(var j = 0; j < invocationsCount; j++)
            {
                GoodOldEvent.Invoke();
            }
            
            _stopwatch.Stop();
            var o2 = _stopwatch.Elapsed.TotalSeconds;
            // Old: Invocation End
            
            // Old: Unsubscriptions Start
            _stopwatch.Restart();
            
            GoodOldEvent -= Callback000;
            GoodOldEvent -= Callback001;
            GoodOldEvent -= Callback002;
            GoodOldEvent -= Callback003;
            GoodOldEvent -= Callback004;
            GoodOldEvent -= Callback005;
            GoodOldEvent -= Callback006;
            GoodOldEvent -= Callback007;
            GoodOldEvent -= Callback008;
            GoodOldEvent -= Callback009;
            GoodOldEvent -= Callback010;
            GoodOldEvent -= Callback011;
            GoodOldEvent -= Callback012;
            GoodOldEvent -= Callback013;
            GoodOldEvent -= Callback014;
            GoodOldEvent -= Callback015;
            GoodOldEvent -= Callback016;
            GoodOldEvent -= Callback017;
            GoodOldEvent -= Callback018;
            GoodOldEvent -= Callback019;
            GoodOldEvent -= Callback020;
            GoodOldEvent -= Callback021;
            GoodOldEvent -= Callback022;
            GoodOldEvent -= Callback023;
            GoodOldEvent -= Callback024;
            GoodOldEvent -= Callback025;
            GoodOldEvent -= Callback026;
            GoodOldEvent -= Callback027;
            GoodOldEvent -= Callback028;
            GoodOldEvent -= Callback029;
            GoodOldEvent -= Callback030;
            GoodOldEvent -= Callback031;
            GoodOldEvent -= Callback032;
            GoodOldEvent -= Callback033;
            GoodOldEvent -= Callback034;
            GoodOldEvent -= Callback035;
            GoodOldEvent -= Callback036;
            GoodOldEvent -= Callback037;
            GoodOldEvent -= Callback038;
            GoodOldEvent -= Callback039;
            GoodOldEvent -= Callback040;
            GoodOldEvent -= Callback041;
            GoodOldEvent -= Callback042;
            GoodOldEvent -= Callback043;
            GoodOldEvent -= Callback044;
            GoodOldEvent -= Callback045;
            GoodOldEvent -= Callback046;
            GoodOldEvent -= Callback047;
            GoodOldEvent -= Callback048;
            GoodOldEvent -= Callback049;
            GoodOldEvent -= Callback050;
            GoodOldEvent -= Callback051;
            GoodOldEvent -= Callback052;
            GoodOldEvent -= Callback053;
            GoodOldEvent -= Callback054;
            GoodOldEvent -= Callback055;
            GoodOldEvent -= Callback056;
            GoodOldEvent -= Callback057;
            GoodOldEvent -= Callback058;
            GoodOldEvent -= Callback059;
            GoodOldEvent -= Callback060;
            GoodOldEvent -= Callback061;
            GoodOldEvent -= Callback062;
            GoodOldEvent -= Callback063;
            GoodOldEvent -= Callback064;
            GoodOldEvent -= Callback065;
            GoodOldEvent -= Callback066;
            GoodOldEvent -= Callback067;
            GoodOldEvent -= Callback068;
            GoodOldEvent -= Callback069;
            GoodOldEvent -= Callback070;
            GoodOldEvent -= Callback071;
            GoodOldEvent -= Callback072;
            GoodOldEvent -= Callback073;
            GoodOldEvent -= Callback074;
            GoodOldEvent -= Callback075;
            GoodOldEvent -= Callback076;
            GoodOldEvent -= Callback077;
            GoodOldEvent -= Callback078;
            GoodOldEvent -= Callback079;
            GoodOldEvent -= Callback080;
            GoodOldEvent -= Callback081;
            GoodOldEvent -= Callback082;
            GoodOldEvent -= Callback083;
            GoodOldEvent -= Callback084;
            GoodOldEvent -= Callback085;
            GoodOldEvent -= Callback086;
            GoodOldEvent -= Callback087;
            GoodOldEvent -= Callback088;
            GoodOldEvent -= Callback089;
            GoodOldEvent -= Callback090;
            GoodOldEvent -= Callback091;
            GoodOldEvent -= Callback092;
            GoodOldEvent -= Callback093;
            GoodOldEvent -= Callback094;
            GoodOldEvent -= Callback095;
            GoodOldEvent -= Callback096;
            GoodOldEvent -= Callback097;
            GoodOldEvent -= Callback098;
            GoodOldEvent -= Callback099;
            GoodOldEvent -= Callback100;
            GoodOldEvent -= Callback101;
            GoodOldEvent -= Callback102;
            GoodOldEvent -= Callback103;
            GoodOldEvent -= Callback104;
            GoodOldEvent -= Callback105;
            GoodOldEvent -= Callback106;
            GoodOldEvent -= Callback107;
            GoodOldEvent -= Callback108;
            GoodOldEvent -= Callback109;
            GoodOldEvent -= Callback110;
            GoodOldEvent -= Callback111;
            GoodOldEvent -= Callback112;
            GoodOldEvent -= Callback113;
            GoodOldEvent -= Callback114;
            GoodOldEvent -= Callback115;
            GoodOldEvent -= Callback116;
            GoodOldEvent -= Callback117;
            GoodOldEvent -= Callback118;
            GoodOldEvent -= Callback119;
            GoodOldEvent -= Callback120;
            GoodOldEvent -= Callback121;
            GoodOldEvent -= Callback122;
            GoodOldEvent -= Callback123;
            GoodOldEvent -= Callback124;
            GoodOldEvent -= Callback125;
            GoodOldEvent -= Callback126;
            GoodOldEvent -= Callback127;
            GoodOldEvent -= Callback128;
            GoodOldEvent -= Callback129;
            GoodOldEvent -= Callback130;
            GoodOldEvent -= Callback131;
            GoodOldEvent -= Callback132;
            GoodOldEvent -= Callback133;
            GoodOldEvent -= Callback134;
            GoodOldEvent -= Callback135;
            GoodOldEvent -= Callback136;
            GoodOldEvent -= Callback137;
            GoodOldEvent -= Callback138;
            GoodOldEvent -= Callback139;
            GoodOldEvent -= Callback140;
            GoodOldEvent -= Callback141;
            GoodOldEvent -= Callback142;
            GoodOldEvent -= Callback143;
            GoodOldEvent -= Callback144;
            GoodOldEvent -= Callback145;
            GoodOldEvent -= Callback146;
            GoodOldEvent -= Callback147;
            GoodOldEvent -= Callback148;
            GoodOldEvent -= Callback149;
            GoodOldEvent -= Callback150;
            GoodOldEvent -= Callback151;
            GoodOldEvent -= Callback152;
            GoodOldEvent -= Callback153;
            GoodOldEvent -= Callback154;
            GoodOldEvent -= Callback155;
            GoodOldEvent -= Callback156;
            GoodOldEvent -= Callback157;
            GoodOldEvent -= Callback158;
            GoodOldEvent -= Callback159;
            GoodOldEvent -= Callback160;
            GoodOldEvent -= Callback161;
            GoodOldEvent -= Callback162;
            GoodOldEvent -= Callback163;
            GoodOldEvent -= Callback164;
            GoodOldEvent -= Callback165;
            GoodOldEvent -= Callback166;
            GoodOldEvent -= Callback167;
            GoodOldEvent -= Callback168;
            GoodOldEvent -= Callback169;
            GoodOldEvent -= Callback170;
            GoodOldEvent -= Callback171;
            GoodOldEvent -= Callback172;
            GoodOldEvent -= Callback173;
            GoodOldEvent -= Callback174;
            GoodOldEvent -= Callback175;
            GoodOldEvent -= Callback176;
            GoodOldEvent -= Callback177;
            GoodOldEvent -= Callback178;
            GoodOldEvent -= Callback179;
            GoodOldEvent -= Callback180;
            GoodOldEvent -= Callback181;
            GoodOldEvent -= Callback182;
            GoodOldEvent -= Callback183;
            GoodOldEvent -= Callback184;
            GoodOldEvent -= Callback185;
            GoodOldEvent -= Callback186;
            GoodOldEvent -= Callback187;
            GoodOldEvent -= Callback188;
            GoodOldEvent -= Callback189;
            GoodOldEvent -= Callback190;
            GoodOldEvent -= Callback191;
            GoodOldEvent -= Callback192;
            GoodOldEvent -= Callback193;
            GoodOldEvent -= Callback194;
            GoodOldEvent -= Callback195;
            GoodOldEvent -= Callback196;
            GoodOldEvent -= Callback197;
            GoodOldEvent -= Callback198;
            GoodOldEvent -= Callback199;
            GoodOldEvent -= Callback200;
            GoodOldEvent -= Callback201;
            GoodOldEvent -= Callback202;
            GoodOldEvent -= Callback203;
            GoodOldEvent -= Callback204;
            GoodOldEvent -= Callback205;
            GoodOldEvent -= Callback206;
            GoodOldEvent -= Callback207;
            GoodOldEvent -= Callback208;
            GoodOldEvent -= Callback209;
            GoodOldEvent -= Callback210;
            GoodOldEvent -= Callback211;
            GoodOldEvent -= Callback212;
            GoodOldEvent -= Callback213;
            GoodOldEvent -= Callback214;
            GoodOldEvent -= Callback215;
            GoodOldEvent -= Callback216;
            GoodOldEvent -= Callback217;
            GoodOldEvent -= Callback218;
            GoodOldEvent -= Callback219;
            GoodOldEvent -= Callback220;
            GoodOldEvent -= Callback221;
            GoodOldEvent -= Callback222;
            GoodOldEvent -= Callback223;
            GoodOldEvent -= Callback224;
            GoodOldEvent -= Callback225;
            GoodOldEvent -= Callback226;
            GoodOldEvent -= Callback227;
            GoodOldEvent -= Callback228;
            GoodOldEvent -= Callback229;
            GoodOldEvent -= Callback230;
            GoodOldEvent -= Callback231;
            GoodOldEvent -= Callback232;
            GoodOldEvent -= Callback233;
            GoodOldEvent -= Callback234;
            GoodOldEvent -= Callback235;
            GoodOldEvent -= Callback236;
            GoodOldEvent -= Callback237;
            GoodOldEvent -= Callback238;
            GoodOldEvent -= Callback239;
            GoodOldEvent -= Callback240;
            GoodOldEvent -= Callback241;
            GoodOldEvent -= Callback242;
            GoodOldEvent -= Callback243;
            GoodOldEvent -= Callback244;
            GoodOldEvent -= Callback245;
            GoodOldEvent -= Callback246;
            GoodOldEvent -= Callback247;
            GoodOldEvent -= Callback248;
            GoodOldEvent -= Callback249;
            GoodOldEvent -= Callback250;
            GoodOldEvent -= Callback251;
            GoodOldEvent -= Callback252;
            GoodOldEvent -= Callback253;
            GoodOldEvent -= Callback254;
            GoodOldEvent -= Callback255;
            GoodOldEvent -= Callback256;
            GoodOldEvent -= Callback257;
            GoodOldEvent -= Callback258;
            GoodOldEvent -= Callback259;
            GoodOldEvent -= Callback260;
            GoodOldEvent -= Callback261;
            GoodOldEvent -= Callback262;
            GoodOldEvent -= Callback263;
            GoodOldEvent -= Callback264;
            GoodOldEvent -= Callback265;
            GoodOldEvent -= Callback266;
            GoodOldEvent -= Callback267;
            GoodOldEvent -= Callback268;
            GoodOldEvent -= Callback269;
            GoodOldEvent -= Callback270;
            GoodOldEvent -= Callback271;
            GoodOldEvent -= Callback272;
            GoodOldEvent -= Callback273;
            GoodOldEvent -= Callback274;
            GoodOldEvent -= Callback275;
            GoodOldEvent -= Callback276;
            GoodOldEvent -= Callback277;
            GoodOldEvent -= Callback278;
            GoodOldEvent -= Callback279;
            GoodOldEvent -= Callback280;
            GoodOldEvent -= Callback281;
            GoodOldEvent -= Callback282;
            GoodOldEvent -= Callback283;
            GoodOldEvent -= Callback284;
            GoodOldEvent -= Callback285;
            GoodOldEvent -= Callback286;
            GoodOldEvent -= Callback287;
            GoodOldEvent -= Callback288;
            GoodOldEvent -= Callback289;
            GoodOldEvent -= Callback290;
            GoodOldEvent -= Callback291;
            GoodOldEvent -= Callback292;
            GoodOldEvent -= Callback293;
            GoodOldEvent -= Callback294;
            GoodOldEvent -= Callback295;
            GoodOldEvent -= Callback296;
            GoodOldEvent -= Callback297;
            GoodOldEvent -= Callback298;
            GoodOldEvent -= Callback299;
            GoodOldEvent -= Callback300;
            GoodOldEvent -= Callback301;
            GoodOldEvent -= Callback302;
            GoodOldEvent -= Callback303;
            GoodOldEvent -= Callback304;
            GoodOldEvent -= Callback305;
            GoodOldEvent -= Callback306;
            GoodOldEvent -= Callback307;
            GoodOldEvent -= Callback308;
            GoodOldEvent -= Callback309;
            GoodOldEvent -= Callback310;
            GoodOldEvent -= Callback311;
            GoodOldEvent -= Callback312;
            GoodOldEvent -= Callback313;
            GoodOldEvent -= Callback314;
            GoodOldEvent -= Callback315;
            GoodOldEvent -= Callback316;
            GoodOldEvent -= Callback317;
            GoodOldEvent -= Callback318;
            GoodOldEvent -= Callback319;
            GoodOldEvent -= Callback320;
            GoodOldEvent -= Callback321;
            GoodOldEvent -= Callback322;
            GoodOldEvent -= Callback323;
            GoodOldEvent -= Callback324;
            GoodOldEvent -= Callback325;
            GoodOldEvent -= Callback326;
            GoodOldEvent -= Callback327;
            GoodOldEvent -= Callback328;
            GoodOldEvent -= Callback329;
            GoodOldEvent -= Callback330;
            GoodOldEvent -= Callback331;
            GoodOldEvent -= Callback332;
            GoodOldEvent -= Callback333;
            GoodOldEvent -= Callback334;
            GoodOldEvent -= Callback335;
            GoodOldEvent -= Callback336;
            GoodOldEvent -= Callback337;
            GoodOldEvent -= Callback338;
            GoodOldEvent -= Callback339;
            GoodOldEvent -= Callback340;
            GoodOldEvent -= Callback341;
            GoodOldEvent -= Callback342;
            GoodOldEvent -= Callback343;
            GoodOldEvent -= Callback344;
            GoodOldEvent -= Callback345;
            GoodOldEvent -= Callback346;
            GoodOldEvent -= Callback347;
            GoodOldEvent -= Callback348;
            GoodOldEvent -= Callback349;
            GoodOldEvent -= Callback350;
            GoodOldEvent -= Callback351;
            GoodOldEvent -= Callback352;
            GoodOldEvent -= Callback353;
            GoodOldEvent -= Callback354;
            GoodOldEvent -= Callback355;
            GoodOldEvent -= Callback356;
            GoodOldEvent -= Callback357;
            GoodOldEvent -= Callback358;
            GoodOldEvent -= Callback359;
            GoodOldEvent -= Callback360;
            GoodOldEvent -= Callback361;
            GoodOldEvent -= Callback362;
            GoodOldEvent -= Callback363;
            GoodOldEvent -= Callback364;
            GoodOldEvent -= Callback365;
            GoodOldEvent -= Callback366;
            GoodOldEvent -= Callback367;
            GoodOldEvent -= Callback368;
            GoodOldEvent -= Callback369;
            GoodOldEvent -= Callback370;
            GoodOldEvent -= Callback371;
            GoodOldEvent -= Callback372;
            GoodOldEvent -= Callback373;
            GoodOldEvent -= Callback374;
            GoodOldEvent -= Callback375;
            GoodOldEvent -= Callback376;
            GoodOldEvent -= Callback377;
            GoodOldEvent -= Callback378;
            GoodOldEvent -= Callback379;
            GoodOldEvent -= Callback380;
            GoodOldEvent -= Callback381;
            GoodOldEvent -= Callback382;
            GoodOldEvent -= Callback383;
            GoodOldEvent -= Callback384;
            GoodOldEvent -= Callback385;
            GoodOldEvent -= Callback386;
            GoodOldEvent -= Callback387;
            GoodOldEvent -= Callback388;
            GoodOldEvent -= Callback389;
            GoodOldEvent -= Callback390;
            GoodOldEvent -= Callback391;
            GoodOldEvent -= Callback392;
            GoodOldEvent -= Callback393;
            GoodOldEvent -= Callback394;
            GoodOldEvent -= Callback395;
            GoodOldEvent -= Callback396;
            GoodOldEvent -= Callback397;
            GoodOldEvent -= Callback398;
            GoodOldEvent -= Callback399;
            GoodOldEvent -= Callback400;
            GoodOldEvent -= Callback401;
            GoodOldEvent -= Callback402;
            GoodOldEvent -= Callback403;
            GoodOldEvent -= Callback404;
            GoodOldEvent -= Callback405;
            GoodOldEvent -= Callback406;
            GoodOldEvent -= Callback407;
            GoodOldEvent -= Callback408;
            GoodOldEvent -= Callback409;
            GoodOldEvent -= Callback410;
            GoodOldEvent -= Callback411;
            GoodOldEvent -= Callback412;
            GoodOldEvent -= Callback413;
            GoodOldEvent -= Callback414;
            GoodOldEvent -= Callback415;
            GoodOldEvent -= Callback416;
            GoodOldEvent -= Callback417;
            GoodOldEvent -= Callback418;
            GoodOldEvent -= Callback419;
            GoodOldEvent -= Callback420;
            GoodOldEvent -= Callback421;
            GoodOldEvent -= Callback422;
            GoodOldEvent -= Callback423;
            GoodOldEvent -= Callback424;
            GoodOldEvent -= Callback425;
            GoodOldEvent -= Callback426;
            GoodOldEvent -= Callback427;
            GoodOldEvent -= Callback428;
            GoodOldEvent -= Callback429;
            GoodOldEvent -= Callback430;
            GoodOldEvent -= Callback431;
            GoodOldEvent -= Callback432;
            GoodOldEvent -= Callback433;
            GoodOldEvent -= Callback434;
            GoodOldEvent -= Callback435;
            GoodOldEvent -= Callback436;
            GoodOldEvent -= Callback437;
            GoodOldEvent -= Callback438;
            GoodOldEvent -= Callback439;
            GoodOldEvent -= Callback440;
            GoodOldEvent -= Callback441;
            GoodOldEvent -= Callback442;
            GoodOldEvent -= Callback443;
            GoodOldEvent -= Callback444;
            GoodOldEvent -= Callback445;
            GoodOldEvent -= Callback446;
            GoodOldEvent -= Callback447;
            GoodOldEvent -= Callback448;
            GoodOldEvent -= Callback449;
            GoodOldEvent -= Callback450;
            GoodOldEvent -= Callback451;
            GoodOldEvent -= Callback452;
            GoodOldEvent -= Callback453;
            GoodOldEvent -= Callback454;
            GoodOldEvent -= Callback455;
            GoodOldEvent -= Callback456;
            GoodOldEvent -= Callback457;
            GoodOldEvent -= Callback458;
            GoodOldEvent -= Callback459;
            GoodOldEvent -= Callback460;
            GoodOldEvent -= Callback461;
            GoodOldEvent -= Callback462;
            GoodOldEvent -= Callback463;
            GoodOldEvent -= Callback464;
            GoodOldEvent -= Callback465;
            GoodOldEvent -= Callback466;
            GoodOldEvent -= Callback467;
            GoodOldEvent -= Callback468;
            GoodOldEvent -= Callback469;
            GoodOldEvent -= Callback470;
            GoodOldEvent -= Callback471;
            GoodOldEvent -= Callback472;
            GoodOldEvent -= Callback473;
            GoodOldEvent -= Callback474;
            GoodOldEvent -= Callback475;
            GoodOldEvent -= Callback476;
            GoodOldEvent -= Callback477;
            GoodOldEvent -= Callback478;
            GoodOldEvent -= Callback479;
            GoodOldEvent -= Callback480;
            GoodOldEvent -= Callback481;
            GoodOldEvent -= Callback482;
            GoodOldEvent -= Callback483;
            GoodOldEvent -= Callback484;
            GoodOldEvent -= Callback485;
            GoodOldEvent -= Callback486;
            GoodOldEvent -= Callback487;
            GoodOldEvent -= Callback488;
            GoodOldEvent -= Callback489;
            GoodOldEvent -= Callback490;
            GoodOldEvent -= Callback491;
            GoodOldEvent -= Callback492;
            GoodOldEvent -= Callback493;
            GoodOldEvent -= Callback494;
            GoodOldEvent -= Callback495;
            GoodOldEvent -= Callback496;
            GoodOldEvent -= Callback497;
            GoodOldEvent -= Callback498;
            GoodOldEvent -= Callback499;
            GoodOldEvent -= Callback500;
            GoodOldEvent -= Callback501;
            GoodOldEvent -= Callback502;
            GoodOldEvent -= Callback503;
            GoodOldEvent -= Callback504;
            GoodOldEvent -= Callback505;
            GoodOldEvent -= Callback506;
            GoodOldEvent -= Callback507;
            GoodOldEvent -= Callback508;
            GoodOldEvent -= Callback509;
            GoodOldEvent -= Callback510;
            GoodOldEvent -= Callback511;
            GoodOldEvent -= Callback512;
            GoodOldEvent -= Callback513;
            GoodOldEvent -= Callback514;
            GoodOldEvent -= Callback515;
            GoodOldEvent -= Callback516;
            GoodOldEvent -= Callback517;
            GoodOldEvent -= Callback518;
            GoodOldEvent -= Callback519;
            GoodOldEvent -= Callback520;
            GoodOldEvent -= Callback521;
            GoodOldEvent -= Callback522;
            GoodOldEvent -= Callback523;
            GoodOldEvent -= Callback524;
            GoodOldEvent -= Callback525;
            GoodOldEvent -= Callback526;
            GoodOldEvent -= Callback527;
            GoodOldEvent -= Callback528;
            GoodOldEvent -= Callback529;
            GoodOldEvent -= Callback530;
            GoodOldEvent -= Callback531;
            GoodOldEvent -= Callback532;
            GoodOldEvent -= Callback533;
            GoodOldEvent -= Callback534;
            GoodOldEvent -= Callback535;
            GoodOldEvent -= Callback536;
            GoodOldEvent -= Callback537;
            GoodOldEvent -= Callback538;
            GoodOldEvent -= Callback539;
            GoodOldEvent -= Callback540;
            GoodOldEvent -= Callback541;
            GoodOldEvent -= Callback542;
            GoodOldEvent -= Callback543;
            GoodOldEvent -= Callback544;
            GoodOldEvent -= Callback545;
            GoodOldEvent -= Callback546;
            GoodOldEvent -= Callback547;
            GoodOldEvent -= Callback548;
            GoodOldEvent -= Callback549;
            GoodOldEvent -= Callback550;
            GoodOldEvent -= Callback551;
            GoodOldEvent -= Callback552;
            GoodOldEvent -= Callback553;
            GoodOldEvent -= Callback554;
            GoodOldEvent -= Callback555;
            GoodOldEvent -= Callback556;
            GoodOldEvent -= Callback557;
            GoodOldEvent -= Callback558;
            GoodOldEvent -= Callback559;
            GoodOldEvent -= Callback560;
            GoodOldEvent -= Callback561;
            GoodOldEvent -= Callback562;
            GoodOldEvent -= Callback563;
            GoodOldEvent -= Callback564;
            GoodOldEvent -= Callback565;
            GoodOldEvent -= Callback566;
            GoodOldEvent -= Callback567;
            GoodOldEvent -= Callback568;
            GoodOldEvent -= Callback569;
            GoodOldEvent -= Callback570;
            GoodOldEvent -= Callback571;
            GoodOldEvent -= Callback572;
            GoodOldEvent -= Callback573;
            GoodOldEvent -= Callback574;
            GoodOldEvent -= Callback575;
            GoodOldEvent -= Callback576;
            GoodOldEvent -= Callback577;
            GoodOldEvent -= Callback578;
            GoodOldEvent -= Callback579;
            GoodOldEvent -= Callback580;
            GoodOldEvent -= Callback581;
            GoodOldEvent -= Callback582;
            GoodOldEvent -= Callback583;
            GoodOldEvent -= Callback584;
            GoodOldEvent -= Callback585;
            GoodOldEvent -= Callback586;
            GoodOldEvent -= Callback587;
            GoodOldEvent -= Callback588;
            GoodOldEvent -= Callback589;
            GoodOldEvent -= Callback590;
            GoodOldEvent -= Callback591;
            GoodOldEvent -= Callback592;
            GoodOldEvent -= Callback593;
            GoodOldEvent -= Callback594;
            GoodOldEvent -= Callback595;
            GoodOldEvent -= Callback596;
            GoodOldEvent -= Callback597;
            GoodOldEvent -= Callback598;
            GoodOldEvent -= Callback599;
            GoodOldEvent -= Callback600;
            GoodOldEvent -= Callback601;
            GoodOldEvent -= Callback602;
            GoodOldEvent -= Callback603;
            GoodOldEvent -= Callback604;
            GoodOldEvent -= Callback605;
            GoodOldEvent -= Callback606;
            GoodOldEvent -= Callback607;
            GoodOldEvent -= Callback608;
            GoodOldEvent -= Callback609;
            GoodOldEvent -= Callback610;
            GoodOldEvent -= Callback611;
            GoodOldEvent -= Callback612;
            GoodOldEvent -= Callback613;
            GoodOldEvent -= Callback614;
            GoodOldEvent -= Callback615;
            GoodOldEvent -= Callback616;
            GoodOldEvent -= Callback617;
            GoodOldEvent -= Callback618;
            GoodOldEvent -= Callback619;
            GoodOldEvent -= Callback620;
            GoodOldEvent -= Callback621;
            GoodOldEvent -= Callback622;
            GoodOldEvent -= Callback623;
            GoodOldEvent -= Callback624;
            GoodOldEvent -= Callback625;
            GoodOldEvent -= Callback626;
            GoodOldEvent -= Callback627;
            GoodOldEvent -= Callback628;
            GoodOldEvent -= Callback629;
            GoodOldEvent -= Callback630;
            GoodOldEvent -= Callback631;
            GoodOldEvent -= Callback632;
            GoodOldEvent -= Callback633;
            GoodOldEvent -= Callback634;
            GoodOldEvent -= Callback635;
            GoodOldEvent -= Callback636;
            GoodOldEvent -= Callback637;
            GoodOldEvent -= Callback638;
            GoodOldEvent -= Callback639;
            GoodOldEvent -= Callback640;
            GoodOldEvent -= Callback641;
            GoodOldEvent -= Callback642;
            GoodOldEvent -= Callback643;
            GoodOldEvent -= Callback644;
            GoodOldEvent -= Callback645;
            GoodOldEvent -= Callback646;
            GoodOldEvent -= Callback647;
            GoodOldEvent -= Callback648;
            GoodOldEvent -= Callback649;
            GoodOldEvent -= Callback650;
            GoodOldEvent -= Callback651;
            GoodOldEvent -= Callback652;
            GoodOldEvent -= Callback653;
            GoodOldEvent -= Callback654;
            GoodOldEvent -= Callback655;
            GoodOldEvent -= Callback656;
            GoodOldEvent -= Callback657;
            GoodOldEvent -= Callback658;
            GoodOldEvent -= Callback659;
            GoodOldEvent -= Callback660;
            GoodOldEvent -= Callback661;
            GoodOldEvent -= Callback662;
            GoodOldEvent -= Callback663;
            GoodOldEvent -= Callback664;
            GoodOldEvent -= Callback665;
            GoodOldEvent -= Callback666;
            GoodOldEvent -= Callback667;
            GoodOldEvent -= Callback668;
            GoodOldEvent -= Callback669;
            GoodOldEvent -= Callback670;
            GoodOldEvent -= Callback671;
            GoodOldEvent -= Callback672;
            GoodOldEvent -= Callback673;
            GoodOldEvent -= Callback674;
            GoodOldEvent -= Callback675;
            GoodOldEvent -= Callback676;
            GoodOldEvent -= Callback677;
            GoodOldEvent -= Callback678;
            GoodOldEvent -= Callback679;
            GoodOldEvent -= Callback680;
            GoodOldEvent -= Callback681;
            GoodOldEvent -= Callback682;
            GoodOldEvent -= Callback683;
            GoodOldEvent -= Callback684;
            GoodOldEvent -= Callback685;
            GoodOldEvent -= Callback686;
            GoodOldEvent -= Callback687;
            GoodOldEvent -= Callback688;
            GoodOldEvent -= Callback689;
            GoodOldEvent -= Callback690;
            GoodOldEvent -= Callback691;
            GoodOldEvent -= Callback692;
            GoodOldEvent -= Callback693;
            GoodOldEvent -= Callback694;
            GoodOldEvent -= Callback695;
            GoodOldEvent -= Callback696;
            GoodOldEvent -= Callback697;
            GoodOldEvent -= Callback698;
            GoodOldEvent -= Callback699;
            GoodOldEvent -= Callback700;
            GoodOldEvent -= Callback701;
            GoodOldEvent -= Callback702;
            GoodOldEvent -= Callback703;
            GoodOldEvent -= Callback704;
            GoodOldEvent -= Callback705;
            GoodOldEvent -= Callback706;
            GoodOldEvent -= Callback707;
            GoodOldEvent -= Callback708;
            GoodOldEvent -= Callback709;
            GoodOldEvent -= Callback710;
            GoodOldEvent -= Callback711;
            GoodOldEvent -= Callback712;
            GoodOldEvent -= Callback713;
            GoodOldEvent -= Callback714;
            GoodOldEvent -= Callback715;
            GoodOldEvent -= Callback716;
            GoodOldEvent -= Callback717;
            GoodOldEvent -= Callback718;
            GoodOldEvent -= Callback719;
            GoodOldEvent -= Callback720;
            GoodOldEvent -= Callback721;
            GoodOldEvent -= Callback722;
            GoodOldEvent -= Callback723;
            GoodOldEvent -= Callback724;
            GoodOldEvent -= Callback725;
            GoodOldEvent -= Callback726;
            GoodOldEvent -= Callback727;
            GoodOldEvent -= Callback728;
            GoodOldEvent -= Callback729;
            GoodOldEvent -= Callback730;
            GoodOldEvent -= Callback731;
            GoodOldEvent -= Callback732;
            GoodOldEvent -= Callback733;
            GoodOldEvent -= Callback734;
            GoodOldEvent -= Callback735;
            GoodOldEvent -= Callback736;
            GoodOldEvent -= Callback737;
            GoodOldEvent -= Callback738;
            GoodOldEvent -= Callback739;
            GoodOldEvent -= Callback740;
            GoodOldEvent -= Callback741;
            GoodOldEvent -= Callback742;
            GoodOldEvent -= Callback743;
            GoodOldEvent -= Callback744;
            GoodOldEvent -= Callback745;
            GoodOldEvent -= Callback746;
            GoodOldEvent -= Callback747;
            GoodOldEvent -= Callback748;
            GoodOldEvent -= Callback749;
            GoodOldEvent -= Callback750;
            GoodOldEvent -= Callback751;
            GoodOldEvent -= Callback752;
            GoodOldEvent -= Callback753;
            GoodOldEvent -= Callback754;
            GoodOldEvent -= Callback755;
            GoodOldEvent -= Callback756;
            GoodOldEvent -= Callback757;
            GoodOldEvent -= Callback758;
            GoodOldEvent -= Callback759;
            GoodOldEvent -= Callback760;
            GoodOldEvent -= Callback761;
            GoodOldEvent -= Callback762;
            GoodOldEvent -= Callback763;
            GoodOldEvent -= Callback764;
            GoodOldEvent -= Callback765;
            GoodOldEvent -= Callback766;
            GoodOldEvent -= Callback767;
            GoodOldEvent -= Callback768;
            GoodOldEvent -= Callback769;
            GoodOldEvent -= Callback770;
            GoodOldEvent -= Callback771;
            GoodOldEvent -= Callback772;
            GoodOldEvent -= Callback773;
            GoodOldEvent -= Callback774;
            GoodOldEvent -= Callback775;
            GoodOldEvent -= Callback776;
            GoodOldEvent -= Callback777;
            GoodOldEvent -= Callback778;
            GoodOldEvent -= Callback779;
            GoodOldEvent -= Callback780;
            GoodOldEvent -= Callback781;
            GoodOldEvent -= Callback782;
            GoodOldEvent -= Callback783;
            GoodOldEvent -= Callback784;
            GoodOldEvent -= Callback785;
            GoodOldEvent -= Callback786;
            GoodOldEvent -= Callback787;
            GoodOldEvent -= Callback788;
            GoodOldEvent -= Callback789;
            GoodOldEvent -= Callback790;
            GoodOldEvent -= Callback791;
            GoodOldEvent -= Callback792;
            GoodOldEvent -= Callback793;
            GoodOldEvent -= Callback794;
            GoodOldEvent -= Callback795;
            GoodOldEvent -= Callback796;
            GoodOldEvent -= Callback797;
            GoodOldEvent -= Callback798;
            GoodOldEvent -= Callback799;
            GoodOldEvent -= Callback800;
            GoodOldEvent -= Callback801;
            GoodOldEvent -= Callback802;
            GoodOldEvent -= Callback803;
            GoodOldEvent -= Callback804;
            GoodOldEvent -= Callback805;
            GoodOldEvent -= Callback806;
            GoodOldEvent -= Callback807;
            GoodOldEvent -= Callback808;
            GoodOldEvent -= Callback809;
            GoodOldEvent -= Callback810;
            GoodOldEvent -= Callback811;
            GoodOldEvent -= Callback812;
            GoodOldEvent -= Callback813;
            GoodOldEvent -= Callback814;
            GoodOldEvent -= Callback815;
            GoodOldEvent -= Callback816;
            GoodOldEvent -= Callback817;
            GoodOldEvent -= Callback818;
            GoodOldEvent -= Callback819;
            GoodOldEvent -= Callback820;
            GoodOldEvent -= Callback821;
            GoodOldEvent -= Callback822;
            GoodOldEvent -= Callback823;
            GoodOldEvent -= Callback824;
            GoodOldEvent -= Callback825;
            GoodOldEvent -= Callback826;
            GoodOldEvent -= Callback827;
            GoodOldEvent -= Callback828;
            GoodOldEvent -= Callback829;
            GoodOldEvent -= Callback830;
            GoodOldEvent -= Callback831;
            GoodOldEvent -= Callback832;
            GoodOldEvent -= Callback833;
            GoodOldEvent -= Callback834;
            GoodOldEvent -= Callback835;
            GoodOldEvent -= Callback836;
            GoodOldEvent -= Callback837;
            GoodOldEvent -= Callback838;
            GoodOldEvent -= Callback839;
            GoodOldEvent -= Callback840;
            GoodOldEvent -= Callback841;
            GoodOldEvent -= Callback842;
            GoodOldEvent -= Callback843;
            GoodOldEvent -= Callback844;
            GoodOldEvent -= Callback845;
            GoodOldEvent -= Callback846;
            GoodOldEvent -= Callback847;
            GoodOldEvent -= Callback848;
            GoodOldEvent -= Callback849;
            GoodOldEvent -= Callback850;
            GoodOldEvent -= Callback851;
            GoodOldEvent -= Callback852;
            GoodOldEvent -= Callback853;
            GoodOldEvent -= Callback854;
            GoodOldEvent -= Callback855;
            GoodOldEvent -= Callback856;
            GoodOldEvent -= Callback857;
            GoodOldEvent -= Callback858;
            GoodOldEvent -= Callback859;
            GoodOldEvent -= Callback860;
            GoodOldEvent -= Callback861;
            GoodOldEvent -= Callback862;
            GoodOldEvent -= Callback863;
            GoodOldEvent -= Callback864;
            GoodOldEvent -= Callback865;
            GoodOldEvent -= Callback866;
            GoodOldEvent -= Callback867;
            GoodOldEvent -= Callback868;
            GoodOldEvent -= Callback869;
            GoodOldEvent -= Callback870;
            GoodOldEvent -= Callback871;
            GoodOldEvent -= Callback872;
            GoodOldEvent -= Callback873;
            GoodOldEvent -= Callback874;
            GoodOldEvent -= Callback875;
            GoodOldEvent -= Callback876;
            GoodOldEvent -= Callback877;
            GoodOldEvent -= Callback878;
            GoodOldEvent -= Callback879;
            GoodOldEvent -= Callback880;
            GoodOldEvent -= Callback881;
            GoodOldEvent -= Callback882;
            GoodOldEvent -= Callback883;
            GoodOldEvent -= Callback884;
            GoodOldEvent -= Callback885;
            GoodOldEvent -= Callback886;
            GoodOldEvent -= Callback887;
            GoodOldEvent -= Callback888;
            GoodOldEvent -= Callback889;
            GoodOldEvent -= Callback890;
            GoodOldEvent -= Callback891;
            GoodOldEvent -= Callback892;
            GoodOldEvent -= Callback893;
            GoodOldEvent -= Callback894;
            GoodOldEvent -= Callback895;
            GoodOldEvent -= Callback896;
            GoodOldEvent -= Callback897;
            GoodOldEvent -= Callback898;
            GoodOldEvent -= Callback899;
            GoodOldEvent -= Callback900;
            GoodOldEvent -= Callback901;
            GoodOldEvent -= Callback902;
            GoodOldEvent -= Callback903;
            GoodOldEvent -= Callback904;
            GoodOldEvent -= Callback905;
            GoodOldEvent -= Callback906;
            GoodOldEvent -= Callback907;
            GoodOldEvent -= Callback908;
            GoodOldEvent -= Callback909;
            GoodOldEvent -= Callback910;
            GoodOldEvent -= Callback911;
            GoodOldEvent -= Callback912;
            GoodOldEvent -= Callback913;
            GoodOldEvent -= Callback914;
            GoodOldEvent -= Callback915;
            GoodOldEvent -= Callback916;
            GoodOldEvent -= Callback917;
            GoodOldEvent -= Callback918;
            GoodOldEvent -= Callback919;
            GoodOldEvent -= Callback920;
            GoodOldEvent -= Callback921;
            GoodOldEvent -= Callback922;
            GoodOldEvent -= Callback923;
            GoodOldEvent -= Callback924;
            GoodOldEvent -= Callback925;
            GoodOldEvent -= Callback926;
            GoodOldEvent -= Callback927;
            GoodOldEvent -= Callback928;
            GoodOldEvent -= Callback929;
            GoodOldEvent -= Callback930;
            GoodOldEvent -= Callback931;
            GoodOldEvent -= Callback932;
            GoodOldEvent -= Callback933;
            GoodOldEvent -= Callback934;
            GoodOldEvent -= Callback935;
            GoodOldEvent -= Callback936;
            GoodOldEvent -= Callback937;
            GoodOldEvent -= Callback938;
            GoodOldEvent -= Callback939;
            GoodOldEvent -= Callback940;
            GoodOldEvent -= Callback941;
            GoodOldEvent -= Callback942;
            GoodOldEvent -= Callback943;
            GoodOldEvent -= Callback944;
            GoodOldEvent -= Callback945;
            GoodOldEvent -= Callback946;
            GoodOldEvent -= Callback947;
            GoodOldEvent -= Callback948;
            GoodOldEvent -= Callback949;
            GoodOldEvent -= Callback950;
            GoodOldEvent -= Callback951;
            GoodOldEvent -= Callback952;
            GoodOldEvent -= Callback953;
            GoodOldEvent -= Callback954;
            GoodOldEvent -= Callback955;
            GoodOldEvent -= Callback956;
            GoodOldEvent -= Callback957;
            GoodOldEvent -= Callback958;
            GoodOldEvent -= Callback959;
            GoodOldEvent -= Callback960;
            GoodOldEvent -= Callback961;
            GoodOldEvent -= Callback962;
            GoodOldEvent -= Callback963;
            GoodOldEvent -= Callback964;
            GoodOldEvent -= Callback965;
            GoodOldEvent -= Callback966;
            GoodOldEvent -= Callback967;
            GoodOldEvent -= Callback968;
            GoodOldEvent -= Callback969;
            GoodOldEvent -= Callback970;
            GoodOldEvent -= Callback971;
            GoodOldEvent -= Callback972;
            GoodOldEvent -= Callback973;
            GoodOldEvent -= Callback974;
            GoodOldEvent -= Callback975;
            GoodOldEvent -= Callback976;
            GoodOldEvent -= Callback977;
            GoodOldEvent -= Callback978;
            GoodOldEvent -= Callback979;
            GoodOldEvent -= Callback980;
            GoodOldEvent -= Callback981;
            GoodOldEvent -= Callback982;
            GoodOldEvent -= Callback983;
            GoodOldEvent -= Callback984;
            GoodOldEvent -= Callback985;
            GoodOldEvent -= Callback986;
            GoodOldEvent -= Callback987;
            GoodOldEvent -= Callback988;
            GoodOldEvent -= Callback989;
            GoodOldEvent -= Callback990;
            GoodOldEvent -= Callback991;
            GoodOldEvent -= Callback992;
            GoodOldEvent -= Callback993;
            GoodOldEvent -= Callback994;
            GoodOldEvent -= Callback995;
            GoodOldEvent -= Callback996;
            GoodOldEvent -= Callback997;
            GoodOldEvent -= Callback998;
            GoodOldEvent -= Callback999;
            
            _stopwatch.Stop();
            var o3 = _stopwatch.Elapsed.TotalSeconds;
            // Old: Unsubscriptions End
            
            // New: Subscriptions Start
            _stopwatch.Restart();

            SappyEvent.Add(Sappy.Callback000);
            SappyEvent.Add(Sappy.Callback001);
            SappyEvent.Add(Sappy.Callback002);
            SappyEvent.Add(Sappy.Callback003);
            SappyEvent.Add(Sappy.Callback004);
            SappyEvent.Add(Sappy.Callback005);
            SappyEvent.Add(Sappy.Callback006);
            SappyEvent.Add(Sappy.Callback007);
            SappyEvent.Add(Sappy.Callback008);
            SappyEvent.Add(Sappy.Callback009);
            SappyEvent.Add(Sappy.Callback010);
            SappyEvent.Add(Sappy.Callback011);
            SappyEvent.Add(Sappy.Callback012);
            SappyEvent.Add(Sappy.Callback013);
            SappyEvent.Add(Sappy.Callback014);
            SappyEvent.Add(Sappy.Callback015);
            SappyEvent.Add(Sappy.Callback016);
            SappyEvent.Add(Sappy.Callback017);
            SappyEvent.Add(Sappy.Callback018);
            SappyEvent.Add(Sappy.Callback019);
            SappyEvent.Add(Sappy.Callback020);
            SappyEvent.Add(Sappy.Callback021);
            SappyEvent.Add(Sappy.Callback022);
            SappyEvent.Add(Sappy.Callback023);
            SappyEvent.Add(Sappy.Callback024);
            SappyEvent.Add(Sappy.Callback025);
            SappyEvent.Add(Sappy.Callback026);
            SappyEvent.Add(Sappy.Callback027);
            SappyEvent.Add(Sappy.Callback028);
            SappyEvent.Add(Sappy.Callback029);
            SappyEvent.Add(Sappy.Callback030);
            SappyEvent.Add(Sappy.Callback031);
            SappyEvent.Add(Sappy.Callback032);
            SappyEvent.Add(Sappy.Callback033);
            SappyEvent.Add(Sappy.Callback034);
            SappyEvent.Add(Sappy.Callback035);
            SappyEvent.Add(Sappy.Callback036);
            SappyEvent.Add(Sappy.Callback037);
            SappyEvent.Add(Sappy.Callback038);
            SappyEvent.Add(Sappy.Callback039);
            SappyEvent.Add(Sappy.Callback040);
            SappyEvent.Add(Sappy.Callback041);
            SappyEvent.Add(Sappy.Callback042);
            SappyEvent.Add(Sappy.Callback043);
            SappyEvent.Add(Sappy.Callback044);
            SappyEvent.Add(Sappy.Callback045);
            SappyEvent.Add(Sappy.Callback046);
            SappyEvent.Add(Sappy.Callback047);
            SappyEvent.Add(Sappy.Callback048);
            SappyEvent.Add(Sappy.Callback049);
            SappyEvent.Add(Sappy.Callback050);
            SappyEvent.Add(Sappy.Callback051);
            SappyEvent.Add(Sappy.Callback052);
            SappyEvent.Add(Sappy.Callback053);
            SappyEvent.Add(Sappy.Callback054);
            SappyEvent.Add(Sappy.Callback055);
            SappyEvent.Add(Sappy.Callback056);
            SappyEvent.Add(Sappy.Callback057);
            SappyEvent.Add(Sappy.Callback058);
            SappyEvent.Add(Sappy.Callback059);
            SappyEvent.Add(Sappy.Callback060);
            SappyEvent.Add(Sappy.Callback061);
            SappyEvent.Add(Sappy.Callback062);
            SappyEvent.Add(Sappy.Callback063);
            SappyEvent.Add(Sappy.Callback064);
            SappyEvent.Add(Sappy.Callback065);
            SappyEvent.Add(Sappy.Callback066);
            SappyEvent.Add(Sappy.Callback067);
            SappyEvent.Add(Sappy.Callback068);
            SappyEvent.Add(Sappy.Callback069);
            SappyEvent.Add(Sappy.Callback070);
            SappyEvent.Add(Sappy.Callback071);
            SappyEvent.Add(Sappy.Callback072);
            SappyEvent.Add(Sappy.Callback073);
            SappyEvent.Add(Sappy.Callback074);
            SappyEvent.Add(Sappy.Callback075);
            SappyEvent.Add(Sappy.Callback076);
            SappyEvent.Add(Sappy.Callback077);
            SappyEvent.Add(Sappy.Callback078);
            SappyEvent.Add(Sappy.Callback079);
            SappyEvent.Add(Sappy.Callback080);
            SappyEvent.Add(Sappy.Callback081);
            SappyEvent.Add(Sappy.Callback082);
            SappyEvent.Add(Sappy.Callback083);
            SappyEvent.Add(Sappy.Callback084);
            SappyEvent.Add(Sappy.Callback085);
            SappyEvent.Add(Sappy.Callback086);
            SappyEvent.Add(Sappy.Callback087);
            SappyEvent.Add(Sappy.Callback088);
            SappyEvent.Add(Sappy.Callback089);
            SappyEvent.Add(Sappy.Callback090);
            SappyEvent.Add(Sappy.Callback091);
            SappyEvent.Add(Sappy.Callback092);
            SappyEvent.Add(Sappy.Callback093);
            SappyEvent.Add(Sappy.Callback094);
            SappyEvent.Add(Sappy.Callback095);
            SappyEvent.Add(Sappy.Callback096);
            SappyEvent.Add(Sappy.Callback097);
            SappyEvent.Add(Sappy.Callback098);
            SappyEvent.Add(Sappy.Callback099);
            SappyEvent.Add(Sappy.Callback100);
            SappyEvent.Add(Sappy.Callback101);
            SappyEvent.Add(Sappy.Callback102);
            SappyEvent.Add(Sappy.Callback103);
            SappyEvent.Add(Sappy.Callback104);
            SappyEvent.Add(Sappy.Callback105);
            SappyEvent.Add(Sappy.Callback106);
            SappyEvent.Add(Sappy.Callback107);
            SappyEvent.Add(Sappy.Callback108);
            SappyEvent.Add(Sappy.Callback109);
            SappyEvent.Add(Sappy.Callback110);
            SappyEvent.Add(Sappy.Callback111);
            SappyEvent.Add(Sappy.Callback112);
            SappyEvent.Add(Sappy.Callback113);
            SappyEvent.Add(Sappy.Callback114);
            SappyEvent.Add(Sappy.Callback115);
            SappyEvent.Add(Sappy.Callback116);
            SappyEvent.Add(Sappy.Callback117);
            SappyEvent.Add(Sappy.Callback118);
            SappyEvent.Add(Sappy.Callback119);
            SappyEvent.Add(Sappy.Callback120);
            SappyEvent.Add(Sappy.Callback121);
            SappyEvent.Add(Sappy.Callback122);
            SappyEvent.Add(Sappy.Callback123);
            SappyEvent.Add(Sappy.Callback124);
            SappyEvent.Add(Sappy.Callback125);
            SappyEvent.Add(Sappy.Callback126);
            SappyEvent.Add(Sappy.Callback127);
            SappyEvent.Add(Sappy.Callback128);
            SappyEvent.Add(Sappy.Callback129);
            SappyEvent.Add(Sappy.Callback130);
            SappyEvent.Add(Sappy.Callback131);
            SappyEvent.Add(Sappy.Callback132);
            SappyEvent.Add(Sappy.Callback133);
            SappyEvent.Add(Sappy.Callback134);
            SappyEvent.Add(Sappy.Callback135);
            SappyEvent.Add(Sappy.Callback136);
            SappyEvent.Add(Sappy.Callback137);
            SappyEvent.Add(Sappy.Callback138);
            SappyEvent.Add(Sappy.Callback139);
            SappyEvent.Add(Sappy.Callback140);
            SappyEvent.Add(Sappy.Callback141);
            SappyEvent.Add(Sappy.Callback142);
            SappyEvent.Add(Sappy.Callback143);
            SappyEvent.Add(Sappy.Callback144);
            SappyEvent.Add(Sappy.Callback145);
            SappyEvent.Add(Sappy.Callback146);
            SappyEvent.Add(Sappy.Callback147);
            SappyEvent.Add(Sappy.Callback148);
            SappyEvent.Add(Sappy.Callback149);
            SappyEvent.Add(Sappy.Callback150);
            SappyEvent.Add(Sappy.Callback151);
            SappyEvent.Add(Sappy.Callback152);
            SappyEvent.Add(Sappy.Callback153);
            SappyEvent.Add(Sappy.Callback154);
            SappyEvent.Add(Sappy.Callback155);
            SappyEvent.Add(Sappy.Callback156);
            SappyEvent.Add(Sappy.Callback157);
            SappyEvent.Add(Sappy.Callback158);
            SappyEvent.Add(Sappy.Callback159);
            SappyEvent.Add(Sappy.Callback160);
            SappyEvent.Add(Sappy.Callback161);
            SappyEvent.Add(Sappy.Callback162);
            SappyEvent.Add(Sappy.Callback163);
            SappyEvent.Add(Sappy.Callback164);
            SappyEvent.Add(Sappy.Callback165);
            SappyEvent.Add(Sappy.Callback166);
            SappyEvent.Add(Sappy.Callback167);
            SappyEvent.Add(Sappy.Callback168);
            SappyEvent.Add(Sappy.Callback169);
            SappyEvent.Add(Sappy.Callback170);
            SappyEvent.Add(Sappy.Callback171);
            SappyEvent.Add(Sappy.Callback172);
            SappyEvent.Add(Sappy.Callback173);
            SappyEvent.Add(Sappy.Callback174);
            SappyEvent.Add(Sappy.Callback175);
            SappyEvent.Add(Sappy.Callback176);
            SappyEvent.Add(Sappy.Callback177);
            SappyEvent.Add(Sappy.Callback178);
            SappyEvent.Add(Sappy.Callback179);
            SappyEvent.Add(Sappy.Callback180);
            SappyEvent.Add(Sappy.Callback181);
            SappyEvent.Add(Sappy.Callback182);
            SappyEvent.Add(Sappy.Callback183);
            SappyEvent.Add(Sappy.Callback184);
            SappyEvent.Add(Sappy.Callback185);
            SappyEvent.Add(Sappy.Callback186);
            SappyEvent.Add(Sappy.Callback187);
            SappyEvent.Add(Sappy.Callback188);
            SappyEvent.Add(Sappy.Callback189);
            SappyEvent.Add(Sappy.Callback190);
            SappyEvent.Add(Sappy.Callback191);
            SappyEvent.Add(Sappy.Callback192);
            SappyEvent.Add(Sappy.Callback193);
            SappyEvent.Add(Sappy.Callback194);
            SappyEvent.Add(Sappy.Callback195);
            SappyEvent.Add(Sappy.Callback196);
            SappyEvent.Add(Sappy.Callback197);
            SappyEvent.Add(Sappy.Callback198);
            SappyEvent.Add(Sappy.Callback199);
            SappyEvent.Add(Sappy.Callback200);
            SappyEvent.Add(Sappy.Callback201);
            SappyEvent.Add(Sappy.Callback202);
            SappyEvent.Add(Sappy.Callback203);
            SappyEvent.Add(Sappy.Callback204);
            SappyEvent.Add(Sappy.Callback205);
            SappyEvent.Add(Sappy.Callback206);
            SappyEvent.Add(Sappy.Callback207);
            SappyEvent.Add(Sappy.Callback208);
            SappyEvent.Add(Sappy.Callback209);
            SappyEvent.Add(Sappy.Callback210);
            SappyEvent.Add(Sappy.Callback211);
            SappyEvent.Add(Sappy.Callback212);
            SappyEvent.Add(Sappy.Callback213);
            SappyEvent.Add(Sappy.Callback214);
            SappyEvent.Add(Sappy.Callback215);
            SappyEvent.Add(Sappy.Callback216);
            SappyEvent.Add(Sappy.Callback217);
            SappyEvent.Add(Sappy.Callback218);
            SappyEvent.Add(Sappy.Callback219);
            SappyEvent.Add(Sappy.Callback220);
            SappyEvent.Add(Sappy.Callback221);
            SappyEvent.Add(Sappy.Callback222);
            SappyEvent.Add(Sappy.Callback223);
            SappyEvent.Add(Sappy.Callback224);
            SappyEvent.Add(Sappy.Callback225);
            SappyEvent.Add(Sappy.Callback226);
            SappyEvent.Add(Sappy.Callback227);
            SappyEvent.Add(Sappy.Callback228);
            SappyEvent.Add(Sappy.Callback229);
            SappyEvent.Add(Sappy.Callback230);
            SappyEvent.Add(Sappy.Callback231);
            SappyEvent.Add(Sappy.Callback232);
            SappyEvent.Add(Sappy.Callback233);
            SappyEvent.Add(Sappy.Callback234);
            SappyEvent.Add(Sappy.Callback235);
            SappyEvent.Add(Sappy.Callback236);
            SappyEvent.Add(Sappy.Callback237);
            SappyEvent.Add(Sappy.Callback238);
            SappyEvent.Add(Sappy.Callback239);
            SappyEvent.Add(Sappy.Callback240);
            SappyEvent.Add(Sappy.Callback241);
            SappyEvent.Add(Sappy.Callback242);
            SappyEvent.Add(Sappy.Callback243);
            SappyEvent.Add(Sappy.Callback244);
            SappyEvent.Add(Sappy.Callback245);
            SappyEvent.Add(Sappy.Callback246);
            SappyEvent.Add(Sappy.Callback247);
            SappyEvent.Add(Sappy.Callback248);
            SappyEvent.Add(Sappy.Callback249);
            SappyEvent.Add(Sappy.Callback250);
            SappyEvent.Add(Sappy.Callback251);
            SappyEvent.Add(Sappy.Callback252);
            SappyEvent.Add(Sappy.Callback253);
            SappyEvent.Add(Sappy.Callback254);
            SappyEvent.Add(Sappy.Callback255);
            SappyEvent.Add(Sappy.Callback256);
            SappyEvent.Add(Sappy.Callback257);
            SappyEvent.Add(Sappy.Callback258);
            SappyEvent.Add(Sappy.Callback259);
            SappyEvent.Add(Sappy.Callback260);
            SappyEvent.Add(Sappy.Callback261);
            SappyEvent.Add(Sappy.Callback262);
            SappyEvent.Add(Sappy.Callback263);
            SappyEvent.Add(Sappy.Callback264);
            SappyEvent.Add(Sappy.Callback265);
            SappyEvent.Add(Sappy.Callback266);
            SappyEvent.Add(Sappy.Callback267);
            SappyEvent.Add(Sappy.Callback268);
            SappyEvent.Add(Sappy.Callback269);
            SappyEvent.Add(Sappy.Callback270);
            SappyEvent.Add(Sappy.Callback271);
            SappyEvent.Add(Sappy.Callback272);
            SappyEvent.Add(Sappy.Callback273);
            SappyEvent.Add(Sappy.Callback274);
            SappyEvent.Add(Sappy.Callback275);
            SappyEvent.Add(Sappy.Callback276);
            SappyEvent.Add(Sappy.Callback277);
            SappyEvent.Add(Sappy.Callback278);
            SappyEvent.Add(Sappy.Callback279);
            SappyEvent.Add(Sappy.Callback280);
            SappyEvent.Add(Sappy.Callback281);
            SappyEvent.Add(Sappy.Callback282);
            SappyEvent.Add(Sappy.Callback283);
            SappyEvent.Add(Sappy.Callback284);
            SappyEvent.Add(Sappy.Callback285);
            SappyEvent.Add(Sappy.Callback286);
            SappyEvent.Add(Sappy.Callback287);
            SappyEvent.Add(Sappy.Callback288);
            SappyEvent.Add(Sappy.Callback289);
            SappyEvent.Add(Sappy.Callback290);
            SappyEvent.Add(Sappy.Callback291);
            SappyEvent.Add(Sappy.Callback292);
            SappyEvent.Add(Sappy.Callback293);
            SappyEvent.Add(Sappy.Callback294);
            SappyEvent.Add(Sappy.Callback295);
            SappyEvent.Add(Sappy.Callback296);
            SappyEvent.Add(Sappy.Callback297);
            SappyEvent.Add(Sappy.Callback298);
            SappyEvent.Add(Sappy.Callback299);
            SappyEvent.Add(Sappy.Callback300);
            SappyEvent.Add(Sappy.Callback301);
            SappyEvent.Add(Sappy.Callback302);
            SappyEvent.Add(Sappy.Callback303);
            SappyEvent.Add(Sappy.Callback304);
            SappyEvent.Add(Sappy.Callback305);
            SappyEvent.Add(Sappy.Callback306);
            SappyEvent.Add(Sappy.Callback307);
            SappyEvent.Add(Sappy.Callback308);
            SappyEvent.Add(Sappy.Callback309);
            SappyEvent.Add(Sappy.Callback310);
            SappyEvent.Add(Sappy.Callback311);
            SappyEvent.Add(Sappy.Callback312);
            SappyEvent.Add(Sappy.Callback313);
            SappyEvent.Add(Sappy.Callback314);
            SappyEvent.Add(Sappy.Callback315);
            SappyEvent.Add(Sappy.Callback316);
            SappyEvent.Add(Sappy.Callback317);
            SappyEvent.Add(Sappy.Callback318);
            SappyEvent.Add(Sappy.Callback319);
            SappyEvent.Add(Sappy.Callback320);
            SappyEvent.Add(Sappy.Callback321);
            SappyEvent.Add(Sappy.Callback322);
            SappyEvent.Add(Sappy.Callback323);
            SappyEvent.Add(Sappy.Callback324);
            SappyEvent.Add(Sappy.Callback325);
            SappyEvent.Add(Sappy.Callback326);
            SappyEvent.Add(Sappy.Callback327);
            SappyEvent.Add(Sappy.Callback328);
            SappyEvent.Add(Sappy.Callback329);
            SappyEvent.Add(Sappy.Callback330);
            SappyEvent.Add(Sappy.Callback331);
            SappyEvent.Add(Sappy.Callback332);
            SappyEvent.Add(Sappy.Callback333);
            SappyEvent.Add(Sappy.Callback334);
            SappyEvent.Add(Sappy.Callback335);
            SappyEvent.Add(Sappy.Callback336);
            SappyEvent.Add(Sappy.Callback337);
            SappyEvent.Add(Sappy.Callback338);
            SappyEvent.Add(Sappy.Callback339);
            SappyEvent.Add(Sappy.Callback340);
            SappyEvent.Add(Sappy.Callback341);
            SappyEvent.Add(Sappy.Callback342);
            SappyEvent.Add(Sappy.Callback343);
            SappyEvent.Add(Sappy.Callback344);
            SappyEvent.Add(Sappy.Callback345);
            SappyEvent.Add(Sappy.Callback346);
            SappyEvent.Add(Sappy.Callback347);
            SappyEvent.Add(Sappy.Callback348);
            SappyEvent.Add(Sappy.Callback349);
            SappyEvent.Add(Sappy.Callback350);
            SappyEvent.Add(Sappy.Callback351);
            SappyEvent.Add(Sappy.Callback352);
            SappyEvent.Add(Sappy.Callback353);
            SappyEvent.Add(Sappy.Callback354);
            SappyEvent.Add(Sappy.Callback355);
            SappyEvent.Add(Sappy.Callback356);
            SappyEvent.Add(Sappy.Callback357);
            SappyEvent.Add(Sappy.Callback358);
            SappyEvent.Add(Sappy.Callback359);
            SappyEvent.Add(Sappy.Callback360);
            SappyEvent.Add(Sappy.Callback361);
            SappyEvent.Add(Sappy.Callback362);
            SappyEvent.Add(Sappy.Callback363);
            SappyEvent.Add(Sappy.Callback364);
            SappyEvent.Add(Sappy.Callback365);
            SappyEvent.Add(Sappy.Callback366);
            SappyEvent.Add(Sappy.Callback367);
            SappyEvent.Add(Sappy.Callback368);
            SappyEvent.Add(Sappy.Callback369);
            SappyEvent.Add(Sappy.Callback370);
            SappyEvent.Add(Sappy.Callback371);
            SappyEvent.Add(Sappy.Callback372);
            SappyEvent.Add(Sappy.Callback373);
            SappyEvent.Add(Sappy.Callback374);
            SappyEvent.Add(Sappy.Callback375);
            SappyEvent.Add(Sappy.Callback376);
            SappyEvent.Add(Sappy.Callback377);
            SappyEvent.Add(Sappy.Callback378);
            SappyEvent.Add(Sappy.Callback379);
            SappyEvent.Add(Sappy.Callback380);
            SappyEvent.Add(Sappy.Callback381);
            SappyEvent.Add(Sappy.Callback382);
            SappyEvent.Add(Sappy.Callback383);
            SappyEvent.Add(Sappy.Callback384);
            SappyEvent.Add(Sappy.Callback385);
            SappyEvent.Add(Sappy.Callback386);
            SappyEvent.Add(Sappy.Callback387);
            SappyEvent.Add(Sappy.Callback388);
            SappyEvent.Add(Sappy.Callback389);
            SappyEvent.Add(Sappy.Callback390);
            SappyEvent.Add(Sappy.Callback391);
            SappyEvent.Add(Sappy.Callback392);
            SappyEvent.Add(Sappy.Callback393);
            SappyEvent.Add(Sappy.Callback394);
            SappyEvent.Add(Sappy.Callback395);
            SappyEvent.Add(Sappy.Callback396);
            SappyEvent.Add(Sappy.Callback397);
            SappyEvent.Add(Sappy.Callback398);
            SappyEvent.Add(Sappy.Callback399);
            SappyEvent.Add(Sappy.Callback400);
            SappyEvent.Add(Sappy.Callback401);
            SappyEvent.Add(Sappy.Callback402);
            SappyEvent.Add(Sappy.Callback403);
            SappyEvent.Add(Sappy.Callback404);
            SappyEvent.Add(Sappy.Callback405);
            SappyEvent.Add(Sappy.Callback406);
            SappyEvent.Add(Sappy.Callback407);
            SappyEvent.Add(Sappy.Callback408);
            SappyEvent.Add(Sappy.Callback409);
            SappyEvent.Add(Sappy.Callback410);
            SappyEvent.Add(Sappy.Callback411);
            SappyEvent.Add(Sappy.Callback412);
            SappyEvent.Add(Sappy.Callback413);
            SappyEvent.Add(Sappy.Callback414);
            SappyEvent.Add(Sappy.Callback415);
            SappyEvent.Add(Sappy.Callback416);
            SappyEvent.Add(Sappy.Callback417);
            SappyEvent.Add(Sappy.Callback418);
            SappyEvent.Add(Sappy.Callback419);
            SappyEvent.Add(Sappy.Callback420);
            SappyEvent.Add(Sappy.Callback421);
            SappyEvent.Add(Sappy.Callback422);
            SappyEvent.Add(Sappy.Callback423);
            SappyEvent.Add(Sappy.Callback424);
            SappyEvent.Add(Sappy.Callback425);
            SappyEvent.Add(Sappy.Callback426);
            SappyEvent.Add(Sappy.Callback427);
            SappyEvent.Add(Sappy.Callback428);
            SappyEvent.Add(Sappy.Callback429);
            SappyEvent.Add(Sappy.Callback430);
            SappyEvent.Add(Sappy.Callback431);
            SappyEvent.Add(Sappy.Callback432);
            SappyEvent.Add(Sappy.Callback433);
            SappyEvent.Add(Sappy.Callback434);
            SappyEvent.Add(Sappy.Callback435);
            SappyEvent.Add(Sappy.Callback436);
            SappyEvent.Add(Sappy.Callback437);
            SappyEvent.Add(Sappy.Callback438);
            SappyEvent.Add(Sappy.Callback439);
            SappyEvent.Add(Sappy.Callback440);
            SappyEvent.Add(Sappy.Callback441);
            SappyEvent.Add(Sappy.Callback442);
            SappyEvent.Add(Sappy.Callback443);
            SappyEvent.Add(Sappy.Callback444);
            SappyEvent.Add(Sappy.Callback445);
            SappyEvent.Add(Sappy.Callback446);
            SappyEvent.Add(Sappy.Callback447);
            SappyEvent.Add(Sappy.Callback448);
            SappyEvent.Add(Sappy.Callback449);
            SappyEvent.Add(Sappy.Callback450);
            SappyEvent.Add(Sappy.Callback451);
            SappyEvent.Add(Sappy.Callback452);
            SappyEvent.Add(Sappy.Callback453);
            SappyEvent.Add(Sappy.Callback454);
            SappyEvent.Add(Sappy.Callback455);
            SappyEvent.Add(Sappy.Callback456);
            SappyEvent.Add(Sappy.Callback457);
            SappyEvent.Add(Sappy.Callback458);
            SappyEvent.Add(Sappy.Callback459);
            SappyEvent.Add(Sappy.Callback460);
            SappyEvent.Add(Sappy.Callback461);
            SappyEvent.Add(Sappy.Callback462);
            SappyEvent.Add(Sappy.Callback463);
            SappyEvent.Add(Sappy.Callback464);
            SappyEvent.Add(Sappy.Callback465);
            SappyEvent.Add(Sappy.Callback466);
            SappyEvent.Add(Sappy.Callback467);
            SappyEvent.Add(Sappy.Callback468);
            SappyEvent.Add(Sappy.Callback469);
            SappyEvent.Add(Sappy.Callback470);
            SappyEvent.Add(Sappy.Callback471);
            SappyEvent.Add(Sappy.Callback472);
            SappyEvent.Add(Sappy.Callback473);
            SappyEvent.Add(Sappy.Callback474);
            SappyEvent.Add(Sappy.Callback475);
            SappyEvent.Add(Sappy.Callback476);
            SappyEvent.Add(Sappy.Callback477);
            SappyEvent.Add(Sappy.Callback478);
            SappyEvent.Add(Sappy.Callback479);
            SappyEvent.Add(Sappy.Callback480);
            SappyEvent.Add(Sappy.Callback481);
            SappyEvent.Add(Sappy.Callback482);
            SappyEvent.Add(Sappy.Callback483);
            SappyEvent.Add(Sappy.Callback484);
            SappyEvent.Add(Sappy.Callback485);
            SappyEvent.Add(Sappy.Callback486);
            SappyEvent.Add(Sappy.Callback487);
            SappyEvent.Add(Sappy.Callback488);
            SappyEvent.Add(Sappy.Callback489);
            SappyEvent.Add(Sappy.Callback490);
            SappyEvent.Add(Sappy.Callback491);
            SappyEvent.Add(Sappy.Callback492);
            SappyEvent.Add(Sappy.Callback493);
            SappyEvent.Add(Sappy.Callback494);
            SappyEvent.Add(Sappy.Callback495);
            SappyEvent.Add(Sappy.Callback496);
            SappyEvent.Add(Sappy.Callback497);
            SappyEvent.Add(Sappy.Callback498);
            SappyEvent.Add(Sappy.Callback499);
            SappyEvent.Add(Sappy.Callback500);
            SappyEvent.Add(Sappy.Callback501);
            SappyEvent.Add(Sappy.Callback502);
            SappyEvent.Add(Sappy.Callback503);
            SappyEvent.Add(Sappy.Callback504);
            SappyEvent.Add(Sappy.Callback505);
            SappyEvent.Add(Sappy.Callback506);
            SappyEvent.Add(Sappy.Callback507);
            SappyEvent.Add(Sappy.Callback508);
            SappyEvent.Add(Sappy.Callback509);
            SappyEvent.Add(Sappy.Callback510);
            SappyEvent.Add(Sappy.Callback511);
            SappyEvent.Add(Sappy.Callback512);
            SappyEvent.Add(Sappy.Callback513);
            SappyEvent.Add(Sappy.Callback514);
            SappyEvent.Add(Sappy.Callback515);
            SappyEvent.Add(Sappy.Callback516);
            SappyEvent.Add(Sappy.Callback517);
            SappyEvent.Add(Sappy.Callback518);
            SappyEvent.Add(Sappy.Callback519);
            SappyEvent.Add(Sappy.Callback520);
            SappyEvent.Add(Sappy.Callback521);
            SappyEvent.Add(Sappy.Callback522);
            SappyEvent.Add(Sappy.Callback523);
            SappyEvent.Add(Sappy.Callback524);
            SappyEvent.Add(Sappy.Callback525);
            SappyEvent.Add(Sappy.Callback526);
            SappyEvent.Add(Sappy.Callback527);
            SappyEvent.Add(Sappy.Callback528);
            SappyEvent.Add(Sappy.Callback529);
            SappyEvent.Add(Sappy.Callback530);
            SappyEvent.Add(Sappy.Callback531);
            SappyEvent.Add(Sappy.Callback532);
            SappyEvent.Add(Sappy.Callback533);
            SappyEvent.Add(Sappy.Callback534);
            SappyEvent.Add(Sappy.Callback535);
            SappyEvent.Add(Sappy.Callback536);
            SappyEvent.Add(Sappy.Callback537);
            SappyEvent.Add(Sappy.Callback538);
            SappyEvent.Add(Sappy.Callback539);
            SappyEvent.Add(Sappy.Callback540);
            SappyEvent.Add(Sappy.Callback541);
            SappyEvent.Add(Sappy.Callback542);
            SappyEvent.Add(Sappy.Callback543);
            SappyEvent.Add(Sappy.Callback544);
            SappyEvent.Add(Sappy.Callback545);
            SappyEvent.Add(Sappy.Callback546);
            SappyEvent.Add(Sappy.Callback547);
            SappyEvent.Add(Sappy.Callback548);
            SappyEvent.Add(Sappy.Callback549);
            SappyEvent.Add(Sappy.Callback550);
            SappyEvent.Add(Sappy.Callback551);
            SappyEvent.Add(Sappy.Callback552);
            SappyEvent.Add(Sappy.Callback553);
            SappyEvent.Add(Sappy.Callback554);
            SappyEvent.Add(Sappy.Callback555);
            SappyEvent.Add(Sappy.Callback556);
            SappyEvent.Add(Sappy.Callback557);
            SappyEvent.Add(Sappy.Callback558);
            SappyEvent.Add(Sappy.Callback559);
            SappyEvent.Add(Sappy.Callback560);
            SappyEvent.Add(Sappy.Callback561);
            SappyEvent.Add(Sappy.Callback562);
            SappyEvent.Add(Sappy.Callback563);
            SappyEvent.Add(Sappy.Callback564);
            SappyEvent.Add(Sappy.Callback565);
            SappyEvent.Add(Sappy.Callback566);
            SappyEvent.Add(Sappy.Callback567);
            SappyEvent.Add(Sappy.Callback568);
            SappyEvent.Add(Sappy.Callback569);
            SappyEvent.Add(Sappy.Callback570);
            SappyEvent.Add(Sappy.Callback571);
            SappyEvent.Add(Sappy.Callback572);
            SappyEvent.Add(Sappy.Callback573);
            SappyEvent.Add(Sappy.Callback574);
            SappyEvent.Add(Sappy.Callback575);
            SappyEvent.Add(Sappy.Callback576);
            SappyEvent.Add(Sappy.Callback577);
            SappyEvent.Add(Sappy.Callback578);
            SappyEvent.Add(Sappy.Callback579);
            SappyEvent.Add(Sappy.Callback580);
            SappyEvent.Add(Sappy.Callback581);
            SappyEvent.Add(Sappy.Callback582);
            SappyEvent.Add(Sappy.Callback583);
            SappyEvent.Add(Sappy.Callback584);
            SappyEvent.Add(Sappy.Callback585);
            SappyEvent.Add(Sappy.Callback586);
            SappyEvent.Add(Sappy.Callback587);
            SappyEvent.Add(Sappy.Callback588);
            SappyEvent.Add(Sappy.Callback589);
            SappyEvent.Add(Sappy.Callback590);
            SappyEvent.Add(Sappy.Callback591);
            SappyEvent.Add(Sappy.Callback592);
            SappyEvent.Add(Sappy.Callback593);
            SappyEvent.Add(Sappy.Callback594);
            SappyEvent.Add(Sappy.Callback595);
            SappyEvent.Add(Sappy.Callback596);
            SappyEvent.Add(Sappy.Callback597);
            SappyEvent.Add(Sappy.Callback598);
            SappyEvent.Add(Sappy.Callback599);
            SappyEvent.Add(Sappy.Callback600);
            SappyEvent.Add(Sappy.Callback601);
            SappyEvent.Add(Sappy.Callback602);
            SappyEvent.Add(Sappy.Callback603);
            SappyEvent.Add(Sappy.Callback604);
            SappyEvent.Add(Sappy.Callback605);
            SappyEvent.Add(Sappy.Callback606);
            SappyEvent.Add(Sappy.Callback607);
            SappyEvent.Add(Sappy.Callback608);
            SappyEvent.Add(Sappy.Callback609);
            SappyEvent.Add(Sappy.Callback610);
            SappyEvent.Add(Sappy.Callback611);
            SappyEvent.Add(Sappy.Callback612);
            SappyEvent.Add(Sappy.Callback613);
            SappyEvent.Add(Sappy.Callback614);
            SappyEvent.Add(Sappy.Callback615);
            SappyEvent.Add(Sappy.Callback616);
            SappyEvent.Add(Sappy.Callback617);
            SappyEvent.Add(Sappy.Callback618);
            SappyEvent.Add(Sappy.Callback619);
            SappyEvent.Add(Sappy.Callback620);
            SappyEvent.Add(Sappy.Callback621);
            SappyEvent.Add(Sappy.Callback622);
            SappyEvent.Add(Sappy.Callback623);
            SappyEvent.Add(Sappy.Callback624);
            SappyEvent.Add(Sappy.Callback625);
            SappyEvent.Add(Sappy.Callback626);
            SappyEvent.Add(Sappy.Callback627);
            SappyEvent.Add(Sappy.Callback628);
            SappyEvent.Add(Sappy.Callback629);
            SappyEvent.Add(Sappy.Callback630);
            SappyEvent.Add(Sappy.Callback631);
            SappyEvent.Add(Sappy.Callback632);
            SappyEvent.Add(Sappy.Callback633);
            SappyEvent.Add(Sappy.Callback634);
            SappyEvent.Add(Sappy.Callback635);
            SappyEvent.Add(Sappy.Callback636);
            SappyEvent.Add(Sappy.Callback637);
            SappyEvent.Add(Sappy.Callback638);
            SappyEvent.Add(Sappy.Callback639);
            SappyEvent.Add(Sappy.Callback640);
            SappyEvent.Add(Sappy.Callback641);
            SappyEvent.Add(Sappy.Callback642);
            SappyEvent.Add(Sappy.Callback643);
            SappyEvent.Add(Sappy.Callback644);
            SappyEvent.Add(Sappy.Callback645);
            SappyEvent.Add(Sappy.Callback646);
            SappyEvent.Add(Sappy.Callback647);
            SappyEvent.Add(Sappy.Callback648);
            SappyEvent.Add(Sappy.Callback649);
            SappyEvent.Add(Sappy.Callback650);
            SappyEvent.Add(Sappy.Callback651);
            SappyEvent.Add(Sappy.Callback652);
            SappyEvent.Add(Sappy.Callback653);
            SappyEvent.Add(Sappy.Callback654);
            SappyEvent.Add(Sappy.Callback655);
            SappyEvent.Add(Sappy.Callback656);
            SappyEvent.Add(Sappy.Callback657);
            SappyEvent.Add(Sappy.Callback658);
            SappyEvent.Add(Sappy.Callback659);
            SappyEvent.Add(Sappy.Callback660);
            SappyEvent.Add(Sappy.Callback661);
            SappyEvent.Add(Sappy.Callback662);
            SappyEvent.Add(Sappy.Callback663);
            SappyEvent.Add(Sappy.Callback664);
            SappyEvent.Add(Sappy.Callback665);
            SappyEvent.Add(Sappy.Callback666);
            SappyEvent.Add(Sappy.Callback667);
            SappyEvent.Add(Sappy.Callback668);
            SappyEvent.Add(Sappy.Callback669);
            SappyEvent.Add(Sappy.Callback670);
            SappyEvent.Add(Sappy.Callback671);
            SappyEvent.Add(Sappy.Callback672);
            SappyEvent.Add(Sappy.Callback673);
            SappyEvent.Add(Sappy.Callback674);
            SappyEvent.Add(Sappy.Callback675);
            SappyEvent.Add(Sappy.Callback676);
            SappyEvent.Add(Sappy.Callback677);
            SappyEvent.Add(Sappy.Callback678);
            SappyEvent.Add(Sappy.Callback679);
            SappyEvent.Add(Sappy.Callback680);
            SappyEvent.Add(Sappy.Callback681);
            SappyEvent.Add(Sappy.Callback682);
            SappyEvent.Add(Sappy.Callback683);
            SappyEvent.Add(Sappy.Callback684);
            SappyEvent.Add(Sappy.Callback685);
            SappyEvent.Add(Sappy.Callback686);
            SappyEvent.Add(Sappy.Callback687);
            SappyEvent.Add(Sappy.Callback688);
            SappyEvent.Add(Sappy.Callback689);
            SappyEvent.Add(Sappy.Callback690);
            SappyEvent.Add(Sappy.Callback691);
            SappyEvent.Add(Sappy.Callback692);
            SappyEvent.Add(Sappy.Callback693);
            SappyEvent.Add(Sappy.Callback694);
            SappyEvent.Add(Sappy.Callback695);
            SappyEvent.Add(Sappy.Callback696);
            SappyEvent.Add(Sappy.Callback697);
            SappyEvent.Add(Sappy.Callback698);
            SappyEvent.Add(Sappy.Callback699);
            SappyEvent.Add(Sappy.Callback700);
            SappyEvent.Add(Sappy.Callback701);
            SappyEvent.Add(Sappy.Callback702);
            SappyEvent.Add(Sappy.Callback703);
            SappyEvent.Add(Sappy.Callback704);
            SappyEvent.Add(Sappy.Callback705);
            SappyEvent.Add(Sappy.Callback706);
            SappyEvent.Add(Sappy.Callback707);
            SappyEvent.Add(Sappy.Callback708);
            SappyEvent.Add(Sappy.Callback709);
            SappyEvent.Add(Sappy.Callback710);
            SappyEvent.Add(Sappy.Callback711);
            SappyEvent.Add(Sappy.Callback712);
            SappyEvent.Add(Sappy.Callback713);
            SappyEvent.Add(Sappy.Callback714);
            SappyEvent.Add(Sappy.Callback715);
            SappyEvent.Add(Sappy.Callback716);
            SappyEvent.Add(Sappy.Callback717);
            SappyEvent.Add(Sappy.Callback718);
            SappyEvent.Add(Sappy.Callback719);
            SappyEvent.Add(Sappy.Callback720);
            SappyEvent.Add(Sappy.Callback721);
            SappyEvent.Add(Sappy.Callback722);
            SappyEvent.Add(Sappy.Callback723);
            SappyEvent.Add(Sappy.Callback724);
            SappyEvent.Add(Sappy.Callback725);
            SappyEvent.Add(Sappy.Callback726);
            SappyEvent.Add(Sappy.Callback727);
            SappyEvent.Add(Sappy.Callback728);
            SappyEvent.Add(Sappy.Callback729);
            SappyEvent.Add(Sappy.Callback730);
            SappyEvent.Add(Sappy.Callback731);
            SappyEvent.Add(Sappy.Callback732);
            SappyEvent.Add(Sappy.Callback733);
            SappyEvent.Add(Sappy.Callback734);
            SappyEvent.Add(Sappy.Callback735);
            SappyEvent.Add(Sappy.Callback736);
            SappyEvent.Add(Sappy.Callback737);
            SappyEvent.Add(Sappy.Callback738);
            SappyEvent.Add(Sappy.Callback739);
            SappyEvent.Add(Sappy.Callback740);
            SappyEvent.Add(Sappy.Callback741);
            SappyEvent.Add(Sappy.Callback742);
            SappyEvent.Add(Sappy.Callback743);
            SappyEvent.Add(Sappy.Callback744);
            SappyEvent.Add(Sappy.Callback745);
            SappyEvent.Add(Sappy.Callback746);
            SappyEvent.Add(Sappy.Callback747);
            SappyEvent.Add(Sappy.Callback748);
            SappyEvent.Add(Sappy.Callback749);
            SappyEvent.Add(Sappy.Callback750);
            SappyEvent.Add(Sappy.Callback751);
            SappyEvent.Add(Sappy.Callback752);
            SappyEvent.Add(Sappy.Callback753);
            SappyEvent.Add(Sappy.Callback754);
            SappyEvent.Add(Sappy.Callback755);
            SappyEvent.Add(Sappy.Callback756);
            SappyEvent.Add(Sappy.Callback757);
            SappyEvent.Add(Sappy.Callback758);
            SappyEvent.Add(Sappy.Callback759);
            SappyEvent.Add(Sappy.Callback760);
            SappyEvent.Add(Sappy.Callback761);
            SappyEvent.Add(Sappy.Callback762);
            SappyEvent.Add(Sappy.Callback763);
            SappyEvent.Add(Sappy.Callback764);
            SappyEvent.Add(Sappy.Callback765);
            SappyEvent.Add(Sappy.Callback766);
            SappyEvent.Add(Sappy.Callback767);
            SappyEvent.Add(Sappy.Callback768);
            SappyEvent.Add(Sappy.Callback769);
            SappyEvent.Add(Sappy.Callback770);
            SappyEvent.Add(Sappy.Callback771);
            SappyEvent.Add(Sappy.Callback772);
            SappyEvent.Add(Sappy.Callback773);
            SappyEvent.Add(Sappy.Callback774);
            SappyEvent.Add(Sappy.Callback775);
            SappyEvent.Add(Sappy.Callback776);
            SappyEvent.Add(Sappy.Callback777);
            SappyEvent.Add(Sappy.Callback778);
            SappyEvent.Add(Sappy.Callback779);
            SappyEvent.Add(Sappy.Callback780);
            SappyEvent.Add(Sappy.Callback781);
            SappyEvent.Add(Sappy.Callback782);
            SappyEvent.Add(Sappy.Callback783);
            SappyEvent.Add(Sappy.Callback784);
            SappyEvent.Add(Sappy.Callback785);
            SappyEvent.Add(Sappy.Callback786);
            SappyEvent.Add(Sappy.Callback787);
            SappyEvent.Add(Sappy.Callback788);
            SappyEvent.Add(Sappy.Callback789);
            SappyEvent.Add(Sappy.Callback790);
            SappyEvent.Add(Sappy.Callback791);
            SappyEvent.Add(Sappy.Callback792);
            SappyEvent.Add(Sappy.Callback793);
            SappyEvent.Add(Sappy.Callback794);
            SappyEvent.Add(Sappy.Callback795);
            SappyEvent.Add(Sappy.Callback796);
            SappyEvent.Add(Sappy.Callback797);
            SappyEvent.Add(Sappy.Callback798);
            SappyEvent.Add(Sappy.Callback799);
            SappyEvent.Add(Sappy.Callback800);
            SappyEvent.Add(Sappy.Callback801);
            SappyEvent.Add(Sappy.Callback802);
            SappyEvent.Add(Sappy.Callback803);
            SappyEvent.Add(Sappy.Callback804);
            SappyEvent.Add(Sappy.Callback805);
            SappyEvent.Add(Sappy.Callback806);
            SappyEvent.Add(Sappy.Callback807);
            SappyEvent.Add(Sappy.Callback808);
            SappyEvent.Add(Sappy.Callback809);
            SappyEvent.Add(Sappy.Callback810);
            SappyEvent.Add(Sappy.Callback811);
            SappyEvent.Add(Sappy.Callback812);
            SappyEvent.Add(Sappy.Callback813);
            SappyEvent.Add(Sappy.Callback814);
            SappyEvent.Add(Sappy.Callback815);
            SappyEvent.Add(Sappy.Callback816);
            SappyEvent.Add(Sappy.Callback817);
            SappyEvent.Add(Sappy.Callback818);
            SappyEvent.Add(Sappy.Callback819);
            SappyEvent.Add(Sappy.Callback820);
            SappyEvent.Add(Sappy.Callback821);
            SappyEvent.Add(Sappy.Callback822);
            SappyEvent.Add(Sappy.Callback823);
            SappyEvent.Add(Sappy.Callback824);
            SappyEvent.Add(Sappy.Callback825);
            SappyEvent.Add(Sappy.Callback826);
            SappyEvent.Add(Sappy.Callback827);
            SappyEvent.Add(Sappy.Callback828);
            SappyEvent.Add(Sappy.Callback829);
            SappyEvent.Add(Sappy.Callback830);
            SappyEvent.Add(Sappy.Callback831);
            SappyEvent.Add(Sappy.Callback832);
            SappyEvent.Add(Sappy.Callback833);
            SappyEvent.Add(Sappy.Callback834);
            SappyEvent.Add(Sappy.Callback835);
            SappyEvent.Add(Sappy.Callback836);
            SappyEvent.Add(Sappy.Callback837);
            SappyEvent.Add(Sappy.Callback838);
            SappyEvent.Add(Sappy.Callback839);
            SappyEvent.Add(Sappy.Callback840);
            SappyEvent.Add(Sappy.Callback841);
            SappyEvent.Add(Sappy.Callback842);
            SappyEvent.Add(Sappy.Callback843);
            SappyEvent.Add(Sappy.Callback844);
            SappyEvent.Add(Sappy.Callback845);
            SappyEvent.Add(Sappy.Callback846);
            SappyEvent.Add(Sappy.Callback847);
            SappyEvent.Add(Sappy.Callback848);
            SappyEvent.Add(Sappy.Callback849);
            SappyEvent.Add(Sappy.Callback850);
            SappyEvent.Add(Sappy.Callback851);
            SappyEvent.Add(Sappy.Callback852);
            SappyEvent.Add(Sappy.Callback853);
            SappyEvent.Add(Sappy.Callback854);
            SappyEvent.Add(Sappy.Callback855);
            SappyEvent.Add(Sappy.Callback856);
            SappyEvent.Add(Sappy.Callback857);
            SappyEvent.Add(Sappy.Callback858);
            SappyEvent.Add(Sappy.Callback859);
            SappyEvent.Add(Sappy.Callback860);
            SappyEvent.Add(Sappy.Callback861);
            SappyEvent.Add(Sappy.Callback862);
            SappyEvent.Add(Sappy.Callback863);
            SappyEvent.Add(Sappy.Callback864);
            SappyEvent.Add(Sappy.Callback865);
            SappyEvent.Add(Sappy.Callback866);
            SappyEvent.Add(Sappy.Callback867);
            SappyEvent.Add(Sappy.Callback868);
            SappyEvent.Add(Sappy.Callback869);
            SappyEvent.Add(Sappy.Callback870);
            SappyEvent.Add(Sappy.Callback871);
            SappyEvent.Add(Sappy.Callback872);
            SappyEvent.Add(Sappy.Callback873);
            SappyEvent.Add(Sappy.Callback874);
            SappyEvent.Add(Sappy.Callback875);
            SappyEvent.Add(Sappy.Callback876);
            SappyEvent.Add(Sappy.Callback877);
            SappyEvent.Add(Sappy.Callback878);
            SappyEvent.Add(Sappy.Callback879);
            SappyEvent.Add(Sappy.Callback880);
            SappyEvent.Add(Sappy.Callback881);
            SappyEvent.Add(Sappy.Callback882);
            SappyEvent.Add(Sappy.Callback883);
            SappyEvent.Add(Sappy.Callback884);
            SappyEvent.Add(Sappy.Callback885);
            SappyEvent.Add(Sappy.Callback886);
            SappyEvent.Add(Sappy.Callback887);
            SappyEvent.Add(Sappy.Callback888);
            SappyEvent.Add(Sappy.Callback889);
            SappyEvent.Add(Sappy.Callback890);
            SappyEvent.Add(Sappy.Callback891);
            SappyEvent.Add(Sappy.Callback892);
            SappyEvent.Add(Sappy.Callback893);
            SappyEvent.Add(Sappy.Callback894);
            SappyEvent.Add(Sappy.Callback895);
            SappyEvent.Add(Sappy.Callback896);
            SappyEvent.Add(Sappy.Callback897);
            SappyEvent.Add(Sappy.Callback898);
            SappyEvent.Add(Sappy.Callback899);
            SappyEvent.Add(Sappy.Callback900);
            SappyEvent.Add(Sappy.Callback901);
            SappyEvent.Add(Sappy.Callback902);
            SappyEvent.Add(Sappy.Callback903);
            SappyEvent.Add(Sappy.Callback904);
            SappyEvent.Add(Sappy.Callback905);
            SappyEvent.Add(Sappy.Callback906);
            SappyEvent.Add(Sappy.Callback907);
            SappyEvent.Add(Sappy.Callback908);
            SappyEvent.Add(Sappy.Callback909);
            SappyEvent.Add(Sappy.Callback910);
            SappyEvent.Add(Sappy.Callback911);
            SappyEvent.Add(Sappy.Callback912);
            SappyEvent.Add(Sappy.Callback913);
            SappyEvent.Add(Sappy.Callback914);
            SappyEvent.Add(Sappy.Callback915);
            SappyEvent.Add(Sappy.Callback916);
            SappyEvent.Add(Sappy.Callback917);
            SappyEvent.Add(Sappy.Callback918);
            SappyEvent.Add(Sappy.Callback919);
            SappyEvent.Add(Sappy.Callback920);
            SappyEvent.Add(Sappy.Callback921);
            SappyEvent.Add(Sappy.Callback922);
            SappyEvent.Add(Sappy.Callback923);
            SappyEvent.Add(Sappy.Callback924);
            SappyEvent.Add(Sappy.Callback925);
            SappyEvent.Add(Sappy.Callback926);
            SappyEvent.Add(Sappy.Callback927);
            SappyEvent.Add(Sappy.Callback928);
            SappyEvent.Add(Sappy.Callback929);
            SappyEvent.Add(Sappy.Callback930);
            SappyEvent.Add(Sappy.Callback931);
            SappyEvent.Add(Sappy.Callback932);
            SappyEvent.Add(Sappy.Callback933);
            SappyEvent.Add(Sappy.Callback934);
            SappyEvent.Add(Sappy.Callback935);
            SappyEvent.Add(Sappy.Callback936);
            SappyEvent.Add(Sappy.Callback937);
            SappyEvent.Add(Sappy.Callback938);
            SappyEvent.Add(Sappy.Callback939);
            SappyEvent.Add(Sappy.Callback940);
            SappyEvent.Add(Sappy.Callback941);
            SappyEvent.Add(Sappy.Callback942);
            SappyEvent.Add(Sappy.Callback943);
            SappyEvent.Add(Sappy.Callback944);
            SappyEvent.Add(Sappy.Callback945);
            SappyEvent.Add(Sappy.Callback946);
            SappyEvent.Add(Sappy.Callback947);
            SappyEvent.Add(Sappy.Callback948);
            SappyEvent.Add(Sappy.Callback949);
            SappyEvent.Add(Sappy.Callback950);
            SappyEvent.Add(Sappy.Callback951);
            SappyEvent.Add(Sappy.Callback952);
            SappyEvent.Add(Sappy.Callback953);
            SappyEvent.Add(Sappy.Callback954);
            SappyEvent.Add(Sappy.Callback955);
            SappyEvent.Add(Sappy.Callback956);
            SappyEvent.Add(Sappy.Callback957);
            SappyEvent.Add(Sappy.Callback958);
            SappyEvent.Add(Sappy.Callback959);
            SappyEvent.Add(Sappy.Callback960);
            SappyEvent.Add(Sappy.Callback961);
            SappyEvent.Add(Sappy.Callback962);
            SappyEvent.Add(Sappy.Callback963);
            SappyEvent.Add(Sappy.Callback964);
            SappyEvent.Add(Sappy.Callback965);
            SappyEvent.Add(Sappy.Callback966);
            SappyEvent.Add(Sappy.Callback967);
            SappyEvent.Add(Sappy.Callback968);
            SappyEvent.Add(Sappy.Callback969);
            SappyEvent.Add(Sappy.Callback970);
            SappyEvent.Add(Sappy.Callback971);
            SappyEvent.Add(Sappy.Callback972);
            SappyEvent.Add(Sappy.Callback973);
            SappyEvent.Add(Sappy.Callback974);
            SappyEvent.Add(Sappy.Callback975);
            SappyEvent.Add(Sappy.Callback976);
            SappyEvent.Add(Sappy.Callback977);
            SappyEvent.Add(Sappy.Callback978);
            SappyEvent.Add(Sappy.Callback979);
            SappyEvent.Add(Sappy.Callback980);
            SappyEvent.Add(Sappy.Callback981);
            SappyEvent.Add(Sappy.Callback982);
            SappyEvent.Add(Sappy.Callback983);
            SappyEvent.Add(Sappy.Callback984);
            SappyEvent.Add(Sappy.Callback985);
            SappyEvent.Add(Sappy.Callback986);
            SappyEvent.Add(Sappy.Callback987);
            SappyEvent.Add(Sappy.Callback988);
            SappyEvent.Add(Sappy.Callback989);
            SappyEvent.Add(Sappy.Callback990);
            SappyEvent.Add(Sappy.Callback991);
            SappyEvent.Add(Sappy.Callback992);
            SappyEvent.Add(Sappy.Callback993);
            SappyEvent.Add(Sappy.Callback994);
            SappyEvent.Add(Sappy.Callback995);
            SappyEvent.Add(Sappy.Callback996);
            SappyEvent.Add(Sappy.Callback997);
            SappyEvent.Add(Sappy.Callback998);
            SappyEvent.Add(Sappy.Callback999);
            
            _stopwatch.Stop();
            var n1 = _stopwatch.Elapsed.TotalSeconds;
            // New: Subscriptions End
            
            // New: Invocation Start
            _stopwatch.Restart();
            
            for (var j = 0; j < invocationsCount; j++)
            {
                SappyStem.Send();
            }
            
            _stopwatch.Stop();
            var n2 = _stopwatch.Elapsed.TotalSeconds;
            // New: Invocation End
            
            // New: Unsubscriptions Start
            _stopwatch.Restart();
            
            SappyEvent.Remove(Sappy.Callback000);
            SappyEvent.Remove(Sappy.Callback001);
            SappyEvent.Remove(Sappy.Callback002);
            SappyEvent.Remove(Sappy.Callback003);
            SappyEvent.Remove(Sappy.Callback004);
            SappyEvent.Remove(Sappy.Callback005);
            SappyEvent.Remove(Sappy.Callback006);
            SappyEvent.Remove(Sappy.Callback007);
            SappyEvent.Remove(Sappy.Callback008);
            SappyEvent.Remove(Sappy.Callback009);
            SappyEvent.Remove(Sappy.Callback010);
            SappyEvent.Remove(Sappy.Callback011);
            SappyEvent.Remove(Sappy.Callback012);
            SappyEvent.Remove(Sappy.Callback013);
            SappyEvent.Remove(Sappy.Callback014);
            SappyEvent.Remove(Sappy.Callback015);
            SappyEvent.Remove(Sappy.Callback016);
            SappyEvent.Remove(Sappy.Callback017);
            SappyEvent.Remove(Sappy.Callback018);
            SappyEvent.Remove(Sappy.Callback019);
            SappyEvent.Remove(Sappy.Callback020);
            SappyEvent.Remove(Sappy.Callback021);
            SappyEvent.Remove(Sappy.Callback022);
            SappyEvent.Remove(Sappy.Callback023);
            SappyEvent.Remove(Sappy.Callback024);
            SappyEvent.Remove(Sappy.Callback025);
            SappyEvent.Remove(Sappy.Callback026);
            SappyEvent.Remove(Sappy.Callback027);
            SappyEvent.Remove(Sappy.Callback028);
            SappyEvent.Remove(Sappy.Callback029);
            SappyEvent.Remove(Sappy.Callback030);
            SappyEvent.Remove(Sappy.Callback031);
            SappyEvent.Remove(Sappy.Callback032);
            SappyEvent.Remove(Sappy.Callback033);
            SappyEvent.Remove(Sappy.Callback034);
            SappyEvent.Remove(Sappy.Callback035);
            SappyEvent.Remove(Sappy.Callback036);
            SappyEvent.Remove(Sappy.Callback037);
            SappyEvent.Remove(Sappy.Callback038);
            SappyEvent.Remove(Sappy.Callback039);
            SappyEvent.Remove(Sappy.Callback040);
            SappyEvent.Remove(Sappy.Callback041);
            SappyEvent.Remove(Sappy.Callback042);
            SappyEvent.Remove(Sappy.Callback043);
            SappyEvent.Remove(Sappy.Callback044);
            SappyEvent.Remove(Sappy.Callback045);
            SappyEvent.Remove(Sappy.Callback046);
            SappyEvent.Remove(Sappy.Callback047);
            SappyEvent.Remove(Sappy.Callback048);
            SappyEvent.Remove(Sappy.Callback049);
            SappyEvent.Remove(Sappy.Callback050);
            SappyEvent.Remove(Sappy.Callback051);
            SappyEvent.Remove(Sappy.Callback052);
            SappyEvent.Remove(Sappy.Callback053);
            SappyEvent.Remove(Sappy.Callback054);
            SappyEvent.Remove(Sappy.Callback055);
            SappyEvent.Remove(Sappy.Callback056);
            SappyEvent.Remove(Sappy.Callback057);
            SappyEvent.Remove(Sappy.Callback058);
            SappyEvent.Remove(Sappy.Callback059);
            SappyEvent.Remove(Sappy.Callback060);
            SappyEvent.Remove(Sappy.Callback061);
            SappyEvent.Remove(Sappy.Callback062);
            SappyEvent.Remove(Sappy.Callback063);
            SappyEvent.Remove(Sappy.Callback064);
            SappyEvent.Remove(Sappy.Callback065);
            SappyEvent.Remove(Sappy.Callback066);
            SappyEvent.Remove(Sappy.Callback067);
            SappyEvent.Remove(Sappy.Callback068);
            SappyEvent.Remove(Sappy.Callback069);
            SappyEvent.Remove(Sappy.Callback070);
            SappyEvent.Remove(Sappy.Callback071);
            SappyEvent.Remove(Sappy.Callback072);
            SappyEvent.Remove(Sappy.Callback073);
            SappyEvent.Remove(Sappy.Callback074);
            SappyEvent.Remove(Sappy.Callback075);
            SappyEvent.Remove(Sappy.Callback076);
            SappyEvent.Remove(Sappy.Callback077);
            SappyEvent.Remove(Sappy.Callback078);
            SappyEvent.Remove(Sappy.Callback079);
            SappyEvent.Remove(Sappy.Callback080);
            SappyEvent.Remove(Sappy.Callback081);
            SappyEvent.Remove(Sappy.Callback082);
            SappyEvent.Remove(Sappy.Callback083);
            SappyEvent.Remove(Sappy.Callback084);
            SappyEvent.Remove(Sappy.Callback085);
            SappyEvent.Remove(Sappy.Callback086);
            SappyEvent.Remove(Sappy.Callback087);
            SappyEvent.Remove(Sappy.Callback088);
            SappyEvent.Remove(Sappy.Callback089);
            SappyEvent.Remove(Sappy.Callback090);
            SappyEvent.Remove(Sappy.Callback091);
            SappyEvent.Remove(Sappy.Callback092);
            SappyEvent.Remove(Sappy.Callback093);
            SappyEvent.Remove(Sappy.Callback094);
            SappyEvent.Remove(Sappy.Callback095);
            SappyEvent.Remove(Sappy.Callback096);
            SappyEvent.Remove(Sappy.Callback097);
            SappyEvent.Remove(Sappy.Callback098);
            SappyEvent.Remove(Sappy.Callback099);
            SappyEvent.Remove(Sappy.Callback100);
            SappyEvent.Remove(Sappy.Callback101);
            SappyEvent.Remove(Sappy.Callback102);
            SappyEvent.Remove(Sappy.Callback103);
            SappyEvent.Remove(Sappy.Callback104);
            SappyEvent.Remove(Sappy.Callback105);
            SappyEvent.Remove(Sappy.Callback106);
            SappyEvent.Remove(Sappy.Callback107);
            SappyEvent.Remove(Sappy.Callback108);
            SappyEvent.Remove(Sappy.Callback109);
            SappyEvent.Remove(Sappy.Callback110);
            SappyEvent.Remove(Sappy.Callback111);
            SappyEvent.Remove(Sappy.Callback112);
            SappyEvent.Remove(Sappy.Callback113);
            SappyEvent.Remove(Sappy.Callback114);
            SappyEvent.Remove(Sappy.Callback115);
            SappyEvent.Remove(Sappy.Callback116);
            SappyEvent.Remove(Sappy.Callback117);
            SappyEvent.Remove(Sappy.Callback118);
            SappyEvent.Remove(Sappy.Callback119);
            SappyEvent.Remove(Sappy.Callback120);
            SappyEvent.Remove(Sappy.Callback121);
            SappyEvent.Remove(Sappy.Callback122);
            SappyEvent.Remove(Sappy.Callback123);
            SappyEvent.Remove(Sappy.Callback124);
            SappyEvent.Remove(Sappy.Callback125);
            SappyEvent.Remove(Sappy.Callback126);
            SappyEvent.Remove(Sappy.Callback127);
            SappyEvent.Remove(Sappy.Callback128);
            SappyEvent.Remove(Sappy.Callback129);
            SappyEvent.Remove(Sappy.Callback130);
            SappyEvent.Remove(Sappy.Callback131);
            SappyEvent.Remove(Sappy.Callback132);
            SappyEvent.Remove(Sappy.Callback133);
            SappyEvent.Remove(Sappy.Callback134);
            SappyEvent.Remove(Sappy.Callback135);
            SappyEvent.Remove(Sappy.Callback136);
            SappyEvent.Remove(Sappy.Callback137);
            SappyEvent.Remove(Sappy.Callback138);
            SappyEvent.Remove(Sappy.Callback139);
            SappyEvent.Remove(Sappy.Callback140);
            SappyEvent.Remove(Sappy.Callback141);
            SappyEvent.Remove(Sappy.Callback142);
            SappyEvent.Remove(Sappy.Callback143);
            SappyEvent.Remove(Sappy.Callback144);
            SappyEvent.Remove(Sappy.Callback145);
            SappyEvent.Remove(Sappy.Callback146);
            SappyEvent.Remove(Sappy.Callback147);
            SappyEvent.Remove(Sappy.Callback148);
            SappyEvent.Remove(Sappy.Callback149);
            SappyEvent.Remove(Sappy.Callback150);
            SappyEvent.Remove(Sappy.Callback151);
            SappyEvent.Remove(Sappy.Callback152);
            SappyEvent.Remove(Sappy.Callback153);
            SappyEvent.Remove(Sappy.Callback154);
            SappyEvent.Remove(Sappy.Callback155);
            SappyEvent.Remove(Sappy.Callback156);
            SappyEvent.Remove(Sappy.Callback157);
            SappyEvent.Remove(Sappy.Callback158);
            SappyEvent.Remove(Sappy.Callback159);
            SappyEvent.Remove(Sappy.Callback160);
            SappyEvent.Remove(Sappy.Callback161);
            SappyEvent.Remove(Sappy.Callback162);
            SappyEvent.Remove(Sappy.Callback163);
            SappyEvent.Remove(Sappy.Callback164);
            SappyEvent.Remove(Sappy.Callback165);
            SappyEvent.Remove(Sappy.Callback166);
            SappyEvent.Remove(Sappy.Callback167);
            SappyEvent.Remove(Sappy.Callback168);
            SappyEvent.Remove(Sappy.Callback169);
            SappyEvent.Remove(Sappy.Callback170);
            SappyEvent.Remove(Sappy.Callback171);
            SappyEvent.Remove(Sappy.Callback172);
            SappyEvent.Remove(Sappy.Callback173);
            SappyEvent.Remove(Sappy.Callback174);
            SappyEvent.Remove(Sappy.Callback175);
            SappyEvent.Remove(Sappy.Callback176);
            SappyEvent.Remove(Sappy.Callback177);
            SappyEvent.Remove(Sappy.Callback178);
            SappyEvent.Remove(Sappy.Callback179);
            SappyEvent.Remove(Sappy.Callback180);
            SappyEvent.Remove(Sappy.Callback181);
            SappyEvent.Remove(Sappy.Callback182);
            SappyEvent.Remove(Sappy.Callback183);
            SappyEvent.Remove(Sappy.Callback184);
            SappyEvent.Remove(Sappy.Callback185);
            SappyEvent.Remove(Sappy.Callback186);
            SappyEvent.Remove(Sappy.Callback187);
            SappyEvent.Remove(Sappy.Callback188);
            SappyEvent.Remove(Sappy.Callback189);
            SappyEvent.Remove(Sappy.Callback190);
            SappyEvent.Remove(Sappy.Callback191);
            SappyEvent.Remove(Sappy.Callback192);
            SappyEvent.Remove(Sappy.Callback193);
            SappyEvent.Remove(Sappy.Callback194);
            SappyEvent.Remove(Sappy.Callback195);
            SappyEvent.Remove(Sappy.Callback196);
            SappyEvent.Remove(Sappy.Callback197);
            SappyEvent.Remove(Sappy.Callback198);
            SappyEvent.Remove(Sappy.Callback199);
            SappyEvent.Remove(Sappy.Callback200);
            SappyEvent.Remove(Sappy.Callback201);
            SappyEvent.Remove(Sappy.Callback202);
            SappyEvent.Remove(Sappy.Callback203);
            SappyEvent.Remove(Sappy.Callback204);
            SappyEvent.Remove(Sappy.Callback205);
            SappyEvent.Remove(Sappy.Callback206);
            SappyEvent.Remove(Sappy.Callback207);
            SappyEvent.Remove(Sappy.Callback208);
            SappyEvent.Remove(Sappy.Callback209);
            SappyEvent.Remove(Sappy.Callback210);
            SappyEvent.Remove(Sappy.Callback211);
            SappyEvent.Remove(Sappy.Callback212);
            SappyEvent.Remove(Sappy.Callback213);
            SappyEvent.Remove(Sappy.Callback214);
            SappyEvent.Remove(Sappy.Callback215);
            SappyEvent.Remove(Sappy.Callback216);
            SappyEvent.Remove(Sappy.Callback217);
            SappyEvent.Remove(Sappy.Callback218);
            SappyEvent.Remove(Sappy.Callback219);
            SappyEvent.Remove(Sappy.Callback220);
            SappyEvent.Remove(Sappy.Callback221);
            SappyEvent.Remove(Sappy.Callback222);
            SappyEvent.Remove(Sappy.Callback223);
            SappyEvent.Remove(Sappy.Callback224);
            SappyEvent.Remove(Sappy.Callback225);
            SappyEvent.Remove(Sappy.Callback226);
            SappyEvent.Remove(Sappy.Callback227);
            SappyEvent.Remove(Sappy.Callback228);
            SappyEvent.Remove(Sappy.Callback229);
            SappyEvent.Remove(Sappy.Callback230);
            SappyEvent.Remove(Sappy.Callback231);
            SappyEvent.Remove(Sappy.Callback232);
            SappyEvent.Remove(Sappy.Callback233);
            SappyEvent.Remove(Sappy.Callback234);
            SappyEvent.Remove(Sappy.Callback235);
            SappyEvent.Remove(Sappy.Callback236);
            SappyEvent.Remove(Sappy.Callback237);
            SappyEvent.Remove(Sappy.Callback238);
            SappyEvent.Remove(Sappy.Callback239);
            SappyEvent.Remove(Sappy.Callback240);
            SappyEvent.Remove(Sappy.Callback241);
            SappyEvent.Remove(Sappy.Callback242);
            SappyEvent.Remove(Sappy.Callback243);
            SappyEvent.Remove(Sappy.Callback244);
            SappyEvent.Remove(Sappy.Callback245);
            SappyEvent.Remove(Sappy.Callback246);
            SappyEvent.Remove(Sappy.Callback247);
            SappyEvent.Remove(Sappy.Callback248);
            SappyEvent.Remove(Sappy.Callback249);
            SappyEvent.Remove(Sappy.Callback250);
            SappyEvent.Remove(Sappy.Callback251);
            SappyEvent.Remove(Sappy.Callback252);
            SappyEvent.Remove(Sappy.Callback253);
            SappyEvent.Remove(Sappy.Callback254);
            SappyEvent.Remove(Sappy.Callback255);
            SappyEvent.Remove(Sappy.Callback256);
            SappyEvent.Remove(Sappy.Callback257);
            SappyEvent.Remove(Sappy.Callback258);
            SappyEvent.Remove(Sappy.Callback259);
            SappyEvent.Remove(Sappy.Callback260);
            SappyEvent.Remove(Sappy.Callback261);
            SappyEvent.Remove(Sappy.Callback262);
            SappyEvent.Remove(Sappy.Callback263);
            SappyEvent.Remove(Sappy.Callback264);
            SappyEvent.Remove(Sappy.Callback265);
            SappyEvent.Remove(Sappy.Callback266);
            SappyEvent.Remove(Sappy.Callback267);
            SappyEvent.Remove(Sappy.Callback268);
            SappyEvent.Remove(Sappy.Callback269);
            SappyEvent.Remove(Sappy.Callback270);
            SappyEvent.Remove(Sappy.Callback271);
            SappyEvent.Remove(Sappy.Callback272);
            SappyEvent.Remove(Sappy.Callback273);
            SappyEvent.Remove(Sappy.Callback274);
            SappyEvent.Remove(Sappy.Callback275);
            SappyEvent.Remove(Sappy.Callback276);
            SappyEvent.Remove(Sappy.Callback277);
            SappyEvent.Remove(Sappy.Callback278);
            SappyEvent.Remove(Sappy.Callback279);
            SappyEvent.Remove(Sappy.Callback280);
            SappyEvent.Remove(Sappy.Callback281);
            SappyEvent.Remove(Sappy.Callback282);
            SappyEvent.Remove(Sappy.Callback283);
            SappyEvent.Remove(Sappy.Callback284);
            SappyEvent.Remove(Sappy.Callback285);
            SappyEvent.Remove(Sappy.Callback286);
            SappyEvent.Remove(Sappy.Callback287);
            SappyEvent.Remove(Sappy.Callback288);
            SappyEvent.Remove(Sappy.Callback289);
            SappyEvent.Remove(Sappy.Callback290);
            SappyEvent.Remove(Sappy.Callback291);
            SappyEvent.Remove(Sappy.Callback292);
            SappyEvent.Remove(Sappy.Callback293);
            SappyEvent.Remove(Sappy.Callback294);
            SappyEvent.Remove(Sappy.Callback295);
            SappyEvent.Remove(Sappy.Callback296);
            SappyEvent.Remove(Sappy.Callback297);
            SappyEvent.Remove(Sappy.Callback298);
            SappyEvent.Remove(Sappy.Callback299);
            SappyEvent.Remove(Sappy.Callback300);
            SappyEvent.Remove(Sappy.Callback301);
            SappyEvent.Remove(Sappy.Callback302);
            SappyEvent.Remove(Sappy.Callback303);
            SappyEvent.Remove(Sappy.Callback304);
            SappyEvent.Remove(Sappy.Callback305);
            SappyEvent.Remove(Sappy.Callback306);
            SappyEvent.Remove(Sappy.Callback307);
            SappyEvent.Remove(Sappy.Callback308);
            SappyEvent.Remove(Sappy.Callback309);
            SappyEvent.Remove(Sappy.Callback310);
            SappyEvent.Remove(Sappy.Callback311);
            SappyEvent.Remove(Sappy.Callback312);
            SappyEvent.Remove(Sappy.Callback313);
            SappyEvent.Remove(Sappy.Callback314);
            SappyEvent.Remove(Sappy.Callback315);
            SappyEvent.Remove(Sappy.Callback316);
            SappyEvent.Remove(Sappy.Callback317);
            SappyEvent.Remove(Sappy.Callback318);
            SappyEvent.Remove(Sappy.Callback319);
            SappyEvent.Remove(Sappy.Callback320);
            SappyEvent.Remove(Sappy.Callback321);
            SappyEvent.Remove(Sappy.Callback322);
            SappyEvent.Remove(Sappy.Callback323);
            SappyEvent.Remove(Sappy.Callback324);
            SappyEvent.Remove(Sappy.Callback325);
            SappyEvent.Remove(Sappy.Callback326);
            SappyEvent.Remove(Sappy.Callback327);
            SappyEvent.Remove(Sappy.Callback328);
            SappyEvent.Remove(Sappy.Callback329);
            SappyEvent.Remove(Sappy.Callback330);
            SappyEvent.Remove(Sappy.Callback331);
            SappyEvent.Remove(Sappy.Callback332);
            SappyEvent.Remove(Sappy.Callback333);
            SappyEvent.Remove(Sappy.Callback334);
            SappyEvent.Remove(Sappy.Callback335);
            SappyEvent.Remove(Sappy.Callback336);
            SappyEvent.Remove(Sappy.Callback337);
            SappyEvent.Remove(Sappy.Callback338);
            SappyEvent.Remove(Sappy.Callback339);
            SappyEvent.Remove(Sappy.Callback340);
            SappyEvent.Remove(Sappy.Callback341);
            SappyEvent.Remove(Sappy.Callback342);
            SappyEvent.Remove(Sappy.Callback343);
            SappyEvent.Remove(Sappy.Callback344);
            SappyEvent.Remove(Sappy.Callback345);
            SappyEvent.Remove(Sappy.Callback346);
            SappyEvent.Remove(Sappy.Callback347);
            SappyEvent.Remove(Sappy.Callback348);
            SappyEvent.Remove(Sappy.Callback349);
            SappyEvent.Remove(Sappy.Callback350);
            SappyEvent.Remove(Sappy.Callback351);
            SappyEvent.Remove(Sappy.Callback352);
            SappyEvent.Remove(Sappy.Callback353);
            SappyEvent.Remove(Sappy.Callback354);
            SappyEvent.Remove(Sappy.Callback355);
            SappyEvent.Remove(Sappy.Callback356);
            SappyEvent.Remove(Sappy.Callback357);
            SappyEvent.Remove(Sappy.Callback358);
            SappyEvent.Remove(Sappy.Callback359);
            SappyEvent.Remove(Sappy.Callback360);
            SappyEvent.Remove(Sappy.Callback361);
            SappyEvent.Remove(Sappy.Callback362);
            SappyEvent.Remove(Sappy.Callback363);
            SappyEvent.Remove(Sappy.Callback364);
            SappyEvent.Remove(Sappy.Callback365);
            SappyEvent.Remove(Sappy.Callback366);
            SappyEvent.Remove(Sappy.Callback367);
            SappyEvent.Remove(Sappy.Callback368);
            SappyEvent.Remove(Sappy.Callback369);
            SappyEvent.Remove(Sappy.Callback370);
            SappyEvent.Remove(Sappy.Callback371);
            SappyEvent.Remove(Sappy.Callback372);
            SappyEvent.Remove(Sappy.Callback373);
            SappyEvent.Remove(Sappy.Callback374);
            SappyEvent.Remove(Sappy.Callback375);
            SappyEvent.Remove(Sappy.Callback376);
            SappyEvent.Remove(Sappy.Callback377);
            SappyEvent.Remove(Sappy.Callback378);
            SappyEvent.Remove(Sappy.Callback379);
            SappyEvent.Remove(Sappy.Callback380);
            SappyEvent.Remove(Sappy.Callback381);
            SappyEvent.Remove(Sappy.Callback382);
            SappyEvent.Remove(Sappy.Callback383);
            SappyEvent.Remove(Sappy.Callback384);
            SappyEvent.Remove(Sappy.Callback385);
            SappyEvent.Remove(Sappy.Callback386);
            SappyEvent.Remove(Sappy.Callback387);
            SappyEvent.Remove(Sappy.Callback388);
            SappyEvent.Remove(Sappy.Callback389);
            SappyEvent.Remove(Sappy.Callback390);
            SappyEvent.Remove(Sappy.Callback391);
            SappyEvent.Remove(Sappy.Callback392);
            SappyEvent.Remove(Sappy.Callback393);
            SappyEvent.Remove(Sappy.Callback394);
            SappyEvent.Remove(Sappy.Callback395);
            SappyEvent.Remove(Sappy.Callback396);
            SappyEvent.Remove(Sappy.Callback397);
            SappyEvent.Remove(Sappy.Callback398);
            SappyEvent.Remove(Sappy.Callback399);
            SappyEvent.Remove(Sappy.Callback400);
            SappyEvent.Remove(Sappy.Callback401);
            SappyEvent.Remove(Sappy.Callback402);
            SappyEvent.Remove(Sappy.Callback403);
            SappyEvent.Remove(Sappy.Callback404);
            SappyEvent.Remove(Sappy.Callback405);
            SappyEvent.Remove(Sappy.Callback406);
            SappyEvent.Remove(Sappy.Callback407);
            SappyEvent.Remove(Sappy.Callback408);
            SappyEvent.Remove(Sappy.Callback409);
            SappyEvent.Remove(Sappy.Callback410);
            SappyEvent.Remove(Sappy.Callback411);
            SappyEvent.Remove(Sappy.Callback412);
            SappyEvent.Remove(Sappy.Callback413);
            SappyEvent.Remove(Sappy.Callback414);
            SappyEvent.Remove(Sappy.Callback415);
            SappyEvent.Remove(Sappy.Callback416);
            SappyEvent.Remove(Sappy.Callback417);
            SappyEvent.Remove(Sappy.Callback418);
            SappyEvent.Remove(Sappy.Callback419);
            SappyEvent.Remove(Sappy.Callback420);
            SappyEvent.Remove(Sappy.Callback421);
            SappyEvent.Remove(Sappy.Callback422);
            SappyEvent.Remove(Sappy.Callback423);
            SappyEvent.Remove(Sappy.Callback424);
            SappyEvent.Remove(Sappy.Callback425);
            SappyEvent.Remove(Sappy.Callback426);
            SappyEvent.Remove(Sappy.Callback427);
            SappyEvent.Remove(Sappy.Callback428);
            SappyEvent.Remove(Sappy.Callback429);
            SappyEvent.Remove(Sappy.Callback430);
            SappyEvent.Remove(Sappy.Callback431);
            SappyEvent.Remove(Sappy.Callback432);
            SappyEvent.Remove(Sappy.Callback433);
            SappyEvent.Remove(Sappy.Callback434);
            SappyEvent.Remove(Sappy.Callback435);
            SappyEvent.Remove(Sappy.Callback436);
            SappyEvent.Remove(Sappy.Callback437);
            SappyEvent.Remove(Sappy.Callback438);
            SappyEvent.Remove(Sappy.Callback439);
            SappyEvent.Remove(Sappy.Callback440);
            SappyEvent.Remove(Sappy.Callback441);
            SappyEvent.Remove(Sappy.Callback442);
            SappyEvent.Remove(Sappy.Callback443);
            SappyEvent.Remove(Sappy.Callback444);
            SappyEvent.Remove(Sappy.Callback445);
            SappyEvent.Remove(Sappy.Callback446);
            SappyEvent.Remove(Sappy.Callback447);
            SappyEvent.Remove(Sappy.Callback448);
            SappyEvent.Remove(Sappy.Callback449);
            SappyEvent.Remove(Sappy.Callback450);
            SappyEvent.Remove(Sappy.Callback451);
            SappyEvent.Remove(Sappy.Callback452);
            SappyEvent.Remove(Sappy.Callback453);
            SappyEvent.Remove(Sappy.Callback454);
            SappyEvent.Remove(Sappy.Callback455);
            SappyEvent.Remove(Sappy.Callback456);
            SappyEvent.Remove(Sappy.Callback457);
            SappyEvent.Remove(Sappy.Callback458);
            SappyEvent.Remove(Sappy.Callback459);
            SappyEvent.Remove(Sappy.Callback460);
            SappyEvent.Remove(Sappy.Callback461);
            SappyEvent.Remove(Sappy.Callback462);
            SappyEvent.Remove(Sappy.Callback463);
            SappyEvent.Remove(Sappy.Callback464);
            SappyEvent.Remove(Sappy.Callback465);
            SappyEvent.Remove(Sappy.Callback466);
            SappyEvent.Remove(Sappy.Callback467);
            SappyEvent.Remove(Sappy.Callback468);
            SappyEvent.Remove(Sappy.Callback469);
            SappyEvent.Remove(Sappy.Callback470);
            SappyEvent.Remove(Sappy.Callback471);
            SappyEvent.Remove(Sappy.Callback472);
            SappyEvent.Remove(Sappy.Callback473);
            SappyEvent.Remove(Sappy.Callback474);
            SappyEvent.Remove(Sappy.Callback475);
            SappyEvent.Remove(Sappy.Callback476);
            SappyEvent.Remove(Sappy.Callback477);
            SappyEvent.Remove(Sappy.Callback478);
            SappyEvent.Remove(Sappy.Callback479);
            SappyEvent.Remove(Sappy.Callback480);
            SappyEvent.Remove(Sappy.Callback481);
            SappyEvent.Remove(Sappy.Callback482);
            SappyEvent.Remove(Sappy.Callback483);
            SappyEvent.Remove(Sappy.Callback484);
            SappyEvent.Remove(Sappy.Callback485);
            SappyEvent.Remove(Sappy.Callback486);
            SappyEvent.Remove(Sappy.Callback487);
            SappyEvent.Remove(Sappy.Callback488);
            SappyEvent.Remove(Sappy.Callback489);
            SappyEvent.Remove(Sappy.Callback490);
            SappyEvent.Remove(Sappy.Callback491);
            SappyEvent.Remove(Sappy.Callback492);
            SappyEvent.Remove(Sappy.Callback493);
            SappyEvent.Remove(Sappy.Callback494);
            SappyEvent.Remove(Sappy.Callback495);
            SappyEvent.Remove(Sappy.Callback496);
            SappyEvent.Remove(Sappy.Callback497);
            SappyEvent.Remove(Sappy.Callback498);
            SappyEvent.Remove(Sappy.Callback499);
            SappyEvent.Remove(Sappy.Callback500);
            SappyEvent.Remove(Sappy.Callback501);
            SappyEvent.Remove(Sappy.Callback502);
            SappyEvent.Remove(Sappy.Callback503);
            SappyEvent.Remove(Sappy.Callback504);
            SappyEvent.Remove(Sappy.Callback505);
            SappyEvent.Remove(Sappy.Callback506);
            SappyEvent.Remove(Sappy.Callback507);
            SappyEvent.Remove(Sappy.Callback508);
            SappyEvent.Remove(Sappy.Callback509);
            SappyEvent.Remove(Sappy.Callback510);
            SappyEvent.Remove(Sappy.Callback511);
            SappyEvent.Remove(Sappy.Callback512);
            SappyEvent.Remove(Sappy.Callback513);
            SappyEvent.Remove(Sappy.Callback514);
            SappyEvent.Remove(Sappy.Callback515);
            SappyEvent.Remove(Sappy.Callback516);
            SappyEvent.Remove(Sappy.Callback517);
            SappyEvent.Remove(Sappy.Callback518);
            SappyEvent.Remove(Sappy.Callback519);
            SappyEvent.Remove(Sappy.Callback520);
            SappyEvent.Remove(Sappy.Callback521);
            SappyEvent.Remove(Sappy.Callback522);
            SappyEvent.Remove(Sappy.Callback523);
            SappyEvent.Remove(Sappy.Callback524);
            SappyEvent.Remove(Sappy.Callback525);
            SappyEvent.Remove(Sappy.Callback526);
            SappyEvent.Remove(Sappy.Callback527);
            SappyEvent.Remove(Sappy.Callback528);
            SappyEvent.Remove(Sappy.Callback529);
            SappyEvent.Remove(Sappy.Callback530);
            SappyEvent.Remove(Sappy.Callback531);
            SappyEvent.Remove(Sappy.Callback532);
            SappyEvent.Remove(Sappy.Callback533);
            SappyEvent.Remove(Sappy.Callback534);
            SappyEvent.Remove(Sappy.Callback535);
            SappyEvent.Remove(Sappy.Callback536);
            SappyEvent.Remove(Sappy.Callback537);
            SappyEvent.Remove(Sappy.Callback538);
            SappyEvent.Remove(Sappy.Callback539);
            SappyEvent.Remove(Sappy.Callback540);
            SappyEvent.Remove(Sappy.Callback541);
            SappyEvent.Remove(Sappy.Callback542);
            SappyEvent.Remove(Sappy.Callback543);
            SappyEvent.Remove(Sappy.Callback544);
            SappyEvent.Remove(Sappy.Callback545);
            SappyEvent.Remove(Sappy.Callback546);
            SappyEvent.Remove(Sappy.Callback547);
            SappyEvent.Remove(Sappy.Callback548);
            SappyEvent.Remove(Sappy.Callback549);
            SappyEvent.Remove(Sappy.Callback550);
            SappyEvent.Remove(Sappy.Callback551);
            SappyEvent.Remove(Sappy.Callback552);
            SappyEvent.Remove(Sappy.Callback553);
            SappyEvent.Remove(Sappy.Callback554);
            SappyEvent.Remove(Sappy.Callback555);
            SappyEvent.Remove(Sappy.Callback556);
            SappyEvent.Remove(Sappy.Callback557);
            SappyEvent.Remove(Sappy.Callback558);
            SappyEvent.Remove(Sappy.Callback559);
            SappyEvent.Remove(Sappy.Callback560);
            SappyEvent.Remove(Sappy.Callback561);
            SappyEvent.Remove(Sappy.Callback562);
            SappyEvent.Remove(Sappy.Callback563);
            SappyEvent.Remove(Sappy.Callback564);
            SappyEvent.Remove(Sappy.Callback565);
            SappyEvent.Remove(Sappy.Callback566);
            SappyEvent.Remove(Sappy.Callback567);
            SappyEvent.Remove(Sappy.Callback568);
            SappyEvent.Remove(Sappy.Callback569);
            SappyEvent.Remove(Sappy.Callback570);
            SappyEvent.Remove(Sappy.Callback571);
            SappyEvent.Remove(Sappy.Callback572);
            SappyEvent.Remove(Sappy.Callback573);
            SappyEvent.Remove(Sappy.Callback574);
            SappyEvent.Remove(Sappy.Callback575);
            SappyEvent.Remove(Sappy.Callback576);
            SappyEvent.Remove(Sappy.Callback577);
            SappyEvent.Remove(Sappy.Callback578);
            SappyEvent.Remove(Sappy.Callback579);
            SappyEvent.Remove(Sappy.Callback580);
            SappyEvent.Remove(Sappy.Callback581);
            SappyEvent.Remove(Sappy.Callback582);
            SappyEvent.Remove(Sappy.Callback583);
            SappyEvent.Remove(Sappy.Callback584);
            SappyEvent.Remove(Sappy.Callback585);
            SappyEvent.Remove(Sappy.Callback586);
            SappyEvent.Remove(Sappy.Callback587);
            SappyEvent.Remove(Sappy.Callback588);
            SappyEvent.Remove(Sappy.Callback589);
            SappyEvent.Remove(Sappy.Callback590);
            SappyEvent.Remove(Sappy.Callback591);
            SappyEvent.Remove(Sappy.Callback592);
            SappyEvent.Remove(Sappy.Callback593);
            SappyEvent.Remove(Sappy.Callback594);
            SappyEvent.Remove(Sappy.Callback595);
            SappyEvent.Remove(Sappy.Callback596);
            SappyEvent.Remove(Sappy.Callback597);
            SappyEvent.Remove(Sappy.Callback598);
            SappyEvent.Remove(Sappy.Callback599);
            SappyEvent.Remove(Sappy.Callback600);
            SappyEvent.Remove(Sappy.Callback601);
            SappyEvent.Remove(Sappy.Callback602);
            SappyEvent.Remove(Sappy.Callback603);
            SappyEvent.Remove(Sappy.Callback604);
            SappyEvent.Remove(Sappy.Callback605);
            SappyEvent.Remove(Sappy.Callback606);
            SappyEvent.Remove(Sappy.Callback607);
            SappyEvent.Remove(Sappy.Callback608);
            SappyEvent.Remove(Sappy.Callback609);
            SappyEvent.Remove(Sappy.Callback610);
            SappyEvent.Remove(Sappy.Callback611);
            SappyEvent.Remove(Sappy.Callback612);
            SappyEvent.Remove(Sappy.Callback613);
            SappyEvent.Remove(Sappy.Callback614);
            SappyEvent.Remove(Sappy.Callback615);
            SappyEvent.Remove(Sappy.Callback616);
            SappyEvent.Remove(Sappy.Callback617);
            SappyEvent.Remove(Sappy.Callback618);
            SappyEvent.Remove(Sappy.Callback619);
            SappyEvent.Remove(Sappy.Callback620);
            SappyEvent.Remove(Sappy.Callback621);
            SappyEvent.Remove(Sappy.Callback622);
            SappyEvent.Remove(Sappy.Callback623);
            SappyEvent.Remove(Sappy.Callback624);
            SappyEvent.Remove(Sappy.Callback625);
            SappyEvent.Remove(Sappy.Callback626);
            SappyEvent.Remove(Sappy.Callback627);
            SappyEvent.Remove(Sappy.Callback628);
            SappyEvent.Remove(Sappy.Callback629);
            SappyEvent.Remove(Sappy.Callback630);
            SappyEvent.Remove(Sappy.Callback631);
            SappyEvent.Remove(Sappy.Callback632);
            SappyEvent.Remove(Sappy.Callback633);
            SappyEvent.Remove(Sappy.Callback634);
            SappyEvent.Remove(Sappy.Callback635);
            SappyEvent.Remove(Sappy.Callback636);
            SappyEvent.Remove(Sappy.Callback637);
            SappyEvent.Remove(Sappy.Callback638);
            SappyEvent.Remove(Sappy.Callback639);
            SappyEvent.Remove(Sappy.Callback640);
            SappyEvent.Remove(Sappy.Callback641);
            SappyEvent.Remove(Sappy.Callback642);
            SappyEvent.Remove(Sappy.Callback643);
            SappyEvent.Remove(Sappy.Callback644);
            SappyEvent.Remove(Sappy.Callback645);
            SappyEvent.Remove(Sappy.Callback646);
            SappyEvent.Remove(Sappy.Callback647);
            SappyEvent.Remove(Sappy.Callback648);
            SappyEvent.Remove(Sappy.Callback649);
            SappyEvent.Remove(Sappy.Callback650);
            SappyEvent.Remove(Sappy.Callback651);
            SappyEvent.Remove(Sappy.Callback652);
            SappyEvent.Remove(Sappy.Callback653);
            SappyEvent.Remove(Sappy.Callback654);
            SappyEvent.Remove(Sappy.Callback655);
            SappyEvent.Remove(Sappy.Callback656);
            SappyEvent.Remove(Sappy.Callback657);
            SappyEvent.Remove(Sappy.Callback658);
            SappyEvent.Remove(Sappy.Callback659);
            SappyEvent.Remove(Sappy.Callback660);
            SappyEvent.Remove(Sappy.Callback661);
            SappyEvent.Remove(Sappy.Callback662);
            SappyEvent.Remove(Sappy.Callback663);
            SappyEvent.Remove(Sappy.Callback664);
            SappyEvent.Remove(Sappy.Callback665);
            SappyEvent.Remove(Sappy.Callback666);
            SappyEvent.Remove(Sappy.Callback667);
            SappyEvent.Remove(Sappy.Callback668);
            SappyEvent.Remove(Sappy.Callback669);
            SappyEvent.Remove(Sappy.Callback670);
            SappyEvent.Remove(Sappy.Callback671);
            SappyEvent.Remove(Sappy.Callback672);
            SappyEvent.Remove(Sappy.Callback673);
            SappyEvent.Remove(Sappy.Callback674);
            SappyEvent.Remove(Sappy.Callback675);
            SappyEvent.Remove(Sappy.Callback676);
            SappyEvent.Remove(Sappy.Callback677);
            SappyEvent.Remove(Sappy.Callback678);
            SappyEvent.Remove(Sappy.Callback679);
            SappyEvent.Remove(Sappy.Callback680);
            SappyEvent.Remove(Sappy.Callback681);
            SappyEvent.Remove(Sappy.Callback682);
            SappyEvent.Remove(Sappy.Callback683);
            SappyEvent.Remove(Sappy.Callback684);
            SappyEvent.Remove(Sappy.Callback685);
            SappyEvent.Remove(Sappy.Callback686);
            SappyEvent.Remove(Sappy.Callback687);
            SappyEvent.Remove(Sappy.Callback688);
            SappyEvent.Remove(Sappy.Callback689);
            SappyEvent.Remove(Sappy.Callback690);
            SappyEvent.Remove(Sappy.Callback691);
            SappyEvent.Remove(Sappy.Callback692);
            SappyEvent.Remove(Sappy.Callback693);
            SappyEvent.Remove(Sappy.Callback694);
            SappyEvent.Remove(Sappy.Callback695);
            SappyEvent.Remove(Sappy.Callback696);
            SappyEvent.Remove(Sappy.Callback697);
            SappyEvent.Remove(Sappy.Callback698);
            SappyEvent.Remove(Sappy.Callback699);
            SappyEvent.Remove(Sappy.Callback700);
            SappyEvent.Remove(Sappy.Callback701);
            SappyEvent.Remove(Sappy.Callback702);
            SappyEvent.Remove(Sappy.Callback703);
            SappyEvent.Remove(Sappy.Callback704);
            SappyEvent.Remove(Sappy.Callback705);
            SappyEvent.Remove(Sappy.Callback706);
            SappyEvent.Remove(Sappy.Callback707);
            SappyEvent.Remove(Sappy.Callback708);
            SappyEvent.Remove(Sappy.Callback709);
            SappyEvent.Remove(Sappy.Callback710);
            SappyEvent.Remove(Sappy.Callback711);
            SappyEvent.Remove(Sappy.Callback712);
            SappyEvent.Remove(Sappy.Callback713);
            SappyEvent.Remove(Sappy.Callback714);
            SappyEvent.Remove(Sappy.Callback715);
            SappyEvent.Remove(Sappy.Callback716);
            SappyEvent.Remove(Sappy.Callback717);
            SappyEvent.Remove(Sappy.Callback718);
            SappyEvent.Remove(Sappy.Callback719);
            SappyEvent.Remove(Sappy.Callback720);
            SappyEvent.Remove(Sappy.Callback721);
            SappyEvent.Remove(Sappy.Callback722);
            SappyEvent.Remove(Sappy.Callback723);
            SappyEvent.Remove(Sappy.Callback724);
            SappyEvent.Remove(Sappy.Callback725);
            SappyEvent.Remove(Sappy.Callback726);
            SappyEvent.Remove(Sappy.Callback727);
            SappyEvent.Remove(Sappy.Callback728);
            SappyEvent.Remove(Sappy.Callback729);
            SappyEvent.Remove(Sappy.Callback730);
            SappyEvent.Remove(Sappy.Callback731);
            SappyEvent.Remove(Sappy.Callback732);
            SappyEvent.Remove(Sappy.Callback733);
            SappyEvent.Remove(Sappy.Callback734);
            SappyEvent.Remove(Sappy.Callback735);
            SappyEvent.Remove(Sappy.Callback736);
            SappyEvent.Remove(Sappy.Callback737);
            SappyEvent.Remove(Sappy.Callback738);
            SappyEvent.Remove(Sappy.Callback739);
            SappyEvent.Remove(Sappy.Callback740);
            SappyEvent.Remove(Sappy.Callback741);
            SappyEvent.Remove(Sappy.Callback742);
            SappyEvent.Remove(Sappy.Callback743);
            SappyEvent.Remove(Sappy.Callback744);
            SappyEvent.Remove(Sappy.Callback745);
            SappyEvent.Remove(Sappy.Callback746);
            SappyEvent.Remove(Sappy.Callback747);
            SappyEvent.Remove(Sappy.Callback748);
            SappyEvent.Remove(Sappy.Callback749);
            SappyEvent.Remove(Sappy.Callback750);
            SappyEvent.Remove(Sappy.Callback751);
            SappyEvent.Remove(Sappy.Callback752);
            SappyEvent.Remove(Sappy.Callback753);
            SappyEvent.Remove(Sappy.Callback754);
            SappyEvent.Remove(Sappy.Callback755);
            SappyEvent.Remove(Sappy.Callback756);
            SappyEvent.Remove(Sappy.Callback757);
            SappyEvent.Remove(Sappy.Callback758);
            SappyEvent.Remove(Sappy.Callback759);
            SappyEvent.Remove(Sappy.Callback760);
            SappyEvent.Remove(Sappy.Callback761);
            SappyEvent.Remove(Sappy.Callback762);
            SappyEvent.Remove(Sappy.Callback763);
            SappyEvent.Remove(Sappy.Callback764);
            SappyEvent.Remove(Sappy.Callback765);
            SappyEvent.Remove(Sappy.Callback766);
            SappyEvent.Remove(Sappy.Callback767);
            SappyEvent.Remove(Sappy.Callback768);
            SappyEvent.Remove(Sappy.Callback769);
            SappyEvent.Remove(Sappy.Callback770);
            SappyEvent.Remove(Sappy.Callback771);
            SappyEvent.Remove(Sappy.Callback772);
            SappyEvent.Remove(Sappy.Callback773);
            SappyEvent.Remove(Sappy.Callback774);
            SappyEvent.Remove(Sappy.Callback775);
            SappyEvent.Remove(Sappy.Callback776);
            SappyEvent.Remove(Sappy.Callback777);
            SappyEvent.Remove(Sappy.Callback778);
            SappyEvent.Remove(Sappy.Callback779);
            SappyEvent.Remove(Sappy.Callback780);
            SappyEvent.Remove(Sappy.Callback781);
            SappyEvent.Remove(Sappy.Callback782);
            SappyEvent.Remove(Sappy.Callback783);
            SappyEvent.Remove(Sappy.Callback784);
            SappyEvent.Remove(Sappy.Callback785);
            SappyEvent.Remove(Sappy.Callback786);
            SappyEvent.Remove(Sappy.Callback787);
            SappyEvent.Remove(Sappy.Callback788);
            SappyEvent.Remove(Sappy.Callback789);
            SappyEvent.Remove(Sappy.Callback790);
            SappyEvent.Remove(Sappy.Callback791);
            SappyEvent.Remove(Sappy.Callback792);
            SappyEvent.Remove(Sappy.Callback793);
            SappyEvent.Remove(Sappy.Callback794);
            SappyEvent.Remove(Sappy.Callback795);
            SappyEvent.Remove(Sappy.Callback796);
            SappyEvent.Remove(Sappy.Callback797);
            SappyEvent.Remove(Sappy.Callback798);
            SappyEvent.Remove(Sappy.Callback799);
            SappyEvent.Remove(Sappy.Callback800);
            SappyEvent.Remove(Sappy.Callback801);
            SappyEvent.Remove(Sappy.Callback802);
            SappyEvent.Remove(Sappy.Callback803);
            SappyEvent.Remove(Sappy.Callback804);
            SappyEvent.Remove(Sappy.Callback805);
            SappyEvent.Remove(Sappy.Callback806);
            SappyEvent.Remove(Sappy.Callback807);
            SappyEvent.Remove(Sappy.Callback808);
            SappyEvent.Remove(Sappy.Callback809);
            SappyEvent.Remove(Sappy.Callback810);
            SappyEvent.Remove(Sappy.Callback811);
            SappyEvent.Remove(Sappy.Callback812);
            SappyEvent.Remove(Sappy.Callback813);
            SappyEvent.Remove(Sappy.Callback814);
            SappyEvent.Remove(Sappy.Callback815);
            SappyEvent.Remove(Sappy.Callback816);
            SappyEvent.Remove(Sappy.Callback817);
            SappyEvent.Remove(Sappy.Callback818);
            SappyEvent.Remove(Sappy.Callback819);
            SappyEvent.Remove(Sappy.Callback820);
            SappyEvent.Remove(Sappy.Callback821);
            SappyEvent.Remove(Sappy.Callback822);
            SappyEvent.Remove(Sappy.Callback823);
            SappyEvent.Remove(Sappy.Callback824);
            SappyEvent.Remove(Sappy.Callback825);
            SappyEvent.Remove(Sappy.Callback826);
            SappyEvent.Remove(Sappy.Callback827);
            SappyEvent.Remove(Sappy.Callback828);
            SappyEvent.Remove(Sappy.Callback829);
            SappyEvent.Remove(Sappy.Callback830);
            SappyEvent.Remove(Sappy.Callback831);
            SappyEvent.Remove(Sappy.Callback832);
            SappyEvent.Remove(Sappy.Callback833);
            SappyEvent.Remove(Sappy.Callback834);
            SappyEvent.Remove(Sappy.Callback835);
            SappyEvent.Remove(Sappy.Callback836);
            SappyEvent.Remove(Sappy.Callback837);
            SappyEvent.Remove(Sappy.Callback838);
            SappyEvent.Remove(Sappy.Callback839);
            SappyEvent.Remove(Sappy.Callback840);
            SappyEvent.Remove(Sappy.Callback841);
            SappyEvent.Remove(Sappy.Callback842);
            SappyEvent.Remove(Sappy.Callback843);
            SappyEvent.Remove(Sappy.Callback844);
            SappyEvent.Remove(Sappy.Callback845);
            SappyEvent.Remove(Sappy.Callback846);
            SappyEvent.Remove(Sappy.Callback847);
            SappyEvent.Remove(Sappy.Callback848);
            SappyEvent.Remove(Sappy.Callback849);
            SappyEvent.Remove(Sappy.Callback850);
            SappyEvent.Remove(Sappy.Callback851);
            SappyEvent.Remove(Sappy.Callback852);
            SappyEvent.Remove(Sappy.Callback853);
            SappyEvent.Remove(Sappy.Callback854);
            SappyEvent.Remove(Sappy.Callback855);
            SappyEvent.Remove(Sappy.Callback856);
            SappyEvent.Remove(Sappy.Callback857);
            SappyEvent.Remove(Sappy.Callback858);
            SappyEvent.Remove(Sappy.Callback859);
            SappyEvent.Remove(Sappy.Callback860);
            SappyEvent.Remove(Sappy.Callback861);
            SappyEvent.Remove(Sappy.Callback862);
            SappyEvent.Remove(Sappy.Callback863);
            SappyEvent.Remove(Sappy.Callback864);
            SappyEvent.Remove(Sappy.Callback865);
            SappyEvent.Remove(Sappy.Callback866);
            SappyEvent.Remove(Sappy.Callback867);
            SappyEvent.Remove(Sappy.Callback868);
            SappyEvent.Remove(Sappy.Callback869);
            SappyEvent.Remove(Sappy.Callback870);
            SappyEvent.Remove(Sappy.Callback871);
            SappyEvent.Remove(Sappy.Callback872);
            SappyEvent.Remove(Sappy.Callback873);
            SappyEvent.Remove(Sappy.Callback874);
            SappyEvent.Remove(Sappy.Callback875);
            SappyEvent.Remove(Sappy.Callback876);
            SappyEvent.Remove(Sappy.Callback877);
            SappyEvent.Remove(Sappy.Callback878);
            SappyEvent.Remove(Sappy.Callback879);
            SappyEvent.Remove(Sappy.Callback880);
            SappyEvent.Remove(Sappy.Callback881);
            SappyEvent.Remove(Sappy.Callback882);
            SappyEvent.Remove(Sappy.Callback883);
            SappyEvent.Remove(Sappy.Callback884);
            SappyEvent.Remove(Sappy.Callback885);
            SappyEvent.Remove(Sappy.Callback886);
            SappyEvent.Remove(Sappy.Callback887);
            SappyEvent.Remove(Sappy.Callback888);
            SappyEvent.Remove(Sappy.Callback889);
            SappyEvent.Remove(Sappy.Callback890);
            SappyEvent.Remove(Sappy.Callback891);
            SappyEvent.Remove(Sappy.Callback892);
            SappyEvent.Remove(Sappy.Callback893);
            SappyEvent.Remove(Sappy.Callback894);
            SappyEvent.Remove(Sappy.Callback895);
            SappyEvent.Remove(Sappy.Callback896);
            SappyEvent.Remove(Sappy.Callback897);
            SappyEvent.Remove(Sappy.Callback898);
            SappyEvent.Remove(Sappy.Callback899);
            SappyEvent.Remove(Sappy.Callback900);
            SappyEvent.Remove(Sappy.Callback901);
            SappyEvent.Remove(Sappy.Callback902);
            SappyEvent.Remove(Sappy.Callback903);
            SappyEvent.Remove(Sappy.Callback904);
            SappyEvent.Remove(Sappy.Callback905);
            SappyEvent.Remove(Sappy.Callback906);
            SappyEvent.Remove(Sappy.Callback907);
            SappyEvent.Remove(Sappy.Callback908);
            SappyEvent.Remove(Sappy.Callback909);
            SappyEvent.Remove(Sappy.Callback910);
            SappyEvent.Remove(Sappy.Callback911);
            SappyEvent.Remove(Sappy.Callback912);
            SappyEvent.Remove(Sappy.Callback913);
            SappyEvent.Remove(Sappy.Callback914);
            SappyEvent.Remove(Sappy.Callback915);
            SappyEvent.Remove(Sappy.Callback916);
            SappyEvent.Remove(Sappy.Callback917);
            SappyEvent.Remove(Sappy.Callback918);
            SappyEvent.Remove(Sappy.Callback919);
            SappyEvent.Remove(Sappy.Callback920);
            SappyEvent.Remove(Sappy.Callback921);
            SappyEvent.Remove(Sappy.Callback922);
            SappyEvent.Remove(Sappy.Callback923);
            SappyEvent.Remove(Sappy.Callback924);
            SappyEvent.Remove(Sappy.Callback925);
            SappyEvent.Remove(Sappy.Callback926);
            SappyEvent.Remove(Sappy.Callback927);
            SappyEvent.Remove(Sappy.Callback928);
            SappyEvent.Remove(Sappy.Callback929);
            SappyEvent.Remove(Sappy.Callback930);
            SappyEvent.Remove(Sappy.Callback931);
            SappyEvent.Remove(Sappy.Callback932);
            SappyEvent.Remove(Sappy.Callback933);
            SappyEvent.Remove(Sappy.Callback934);
            SappyEvent.Remove(Sappy.Callback935);
            SappyEvent.Remove(Sappy.Callback936);
            SappyEvent.Remove(Sappy.Callback937);
            SappyEvent.Remove(Sappy.Callback938);
            SappyEvent.Remove(Sappy.Callback939);
            SappyEvent.Remove(Sappy.Callback940);
            SappyEvent.Remove(Sappy.Callback941);
            SappyEvent.Remove(Sappy.Callback942);
            SappyEvent.Remove(Sappy.Callback943);
            SappyEvent.Remove(Sappy.Callback944);
            SappyEvent.Remove(Sappy.Callback945);
            SappyEvent.Remove(Sappy.Callback946);
            SappyEvent.Remove(Sappy.Callback947);
            SappyEvent.Remove(Sappy.Callback948);
            SappyEvent.Remove(Sappy.Callback949);
            SappyEvent.Remove(Sappy.Callback950);
            SappyEvent.Remove(Sappy.Callback951);
            SappyEvent.Remove(Sappy.Callback952);
            SappyEvent.Remove(Sappy.Callback953);
            SappyEvent.Remove(Sappy.Callback954);
            SappyEvent.Remove(Sappy.Callback955);
            SappyEvent.Remove(Sappy.Callback956);
            SappyEvent.Remove(Sappy.Callback957);
            SappyEvent.Remove(Sappy.Callback958);
            SappyEvent.Remove(Sappy.Callback959);
            SappyEvent.Remove(Sappy.Callback960);
            SappyEvent.Remove(Sappy.Callback961);
            SappyEvent.Remove(Sappy.Callback962);
            SappyEvent.Remove(Sappy.Callback963);
            SappyEvent.Remove(Sappy.Callback964);
            SappyEvent.Remove(Sappy.Callback965);
            SappyEvent.Remove(Sappy.Callback966);
            SappyEvent.Remove(Sappy.Callback967);
            SappyEvent.Remove(Sappy.Callback968);
            SappyEvent.Remove(Sappy.Callback969);
            SappyEvent.Remove(Sappy.Callback970);
            SappyEvent.Remove(Sappy.Callback971);
            SappyEvent.Remove(Sappy.Callback972);
            SappyEvent.Remove(Sappy.Callback973);
            SappyEvent.Remove(Sappy.Callback974);
            SappyEvent.Remove(Sappy.Callback975);
            SappyEvent.Remove(Sappy.Callback976);
            SappyEvent.Remove(Sappy.Callback977);
            SappyEvent.Remove(Sappy.Callback978);
            SappyEvent.Remove(Sappy.Callback979);
            SappyEvent.Remove(Sappy.Callback980);
            SappyEvent.Remove(Sappy.Callback981);
            SappyEvent.Remove(Sappy.Callback982);
            SappyEvent.Remove(Sappy.Callback983);
            SappyEvent.Remove(Sappy.Callback984);
            SappyEvent.Remove(Sappy.Callback985);
            SappyEvent.Remove(Sappy.Callback986);
            SappyEvent.Remove(Sappy.Callback987);
            SappyEvent.Remove(Sappy.Callback988);
            SappyEvent.Remove(Sappy.Callback989);
            SappyEvent.Remove(Sappy.Callback990);
            SappyEvent.Remove(Sappy.Callback991);
            SappyEvent.Remove(Sappy.Callback992);
            SappyEvent.Remove(Sappy.Callback993);
            SappyEvent.Remove(Sappy.Callback994);
            SappyEvent.Remove(Sappy.Callback995);
            SappyEvent.Remove(Sappy.Callback996);
            SappyEvent.Remove(Sappy.Callback997);
            SappyEvent.Remove(Sappy.Callback998);
            SappyEvent.Remove(Sappy.Callback999);
        
            _stopwatch.Stop();
            var n3 = _stopwatch.Elapsed.TotalSeconds;
            // New: Unsubscriptions End

            if (i == 0)
            {
                oldSubscription = o1;
                newSubscription = n1;
            }
            else
            {
                oldResubscription += o1;
                newResubscription += n1;
            }
            oldInvocation += o2;
            oldUnsubscription += o3;
            newInvocation += n2;
            newUnsubscription += n3;
        }

        oldResubscription /= (loopsCount - 1);
        newResubscription /= (loopsCount - 1);
        oldInvocation /= loopsCount;
        oldUnsubscription /= loopsCount;
        newInvocation /= loopsCount;
        newUnsubscription /= loopsCount;

        if (invocationsCount > 1)
        {
            oldInvocation /= invocationsCount;
            newInvocation /= invocationsCount;
        }
    }

    [SapTarget]
    private void Callback000() => UnityEngine.Random.Range(0, 000);
    [SapTarget]
    private void Callback001() => UnityEngine.Random.Range(0, 001);
    [SapTarget]
    private void Callback002() => UnityEngine.Random.Range(0, 002);
    [SapTarget]
    private void Callback003() => UnityEngine.Random.Range(0, 003);
    [SapTarget]
    private void Callback004() => UnityEngine.Random.Range(0, 004);
    [SapTarget]
    private void Callback005() => UnityEngine.Random.Range(0, 005);
    [SapTarget]
    private void Callback006() => UnityEngine.Random.Range(0, 006);
    [SapTarget]
    private void Callback007() => UnityEngine.Random.Range(0, 007);
    [SapTarget]
    private void Callback008() => UnityEngine.Random.Range(0, 008);
    [SapTarget]
    private void Callback009() => UnityEngine.Random.Range(0, 009);
    [SapTarget]
    private void Callback010() => UnityEngine.Random.Range(0, 010);
    [SapTarget]
    private void Callback011() => UnityEngine.Random.Range(0, 011);
    [SapTarget]
    private void Callback012() => UnityEngine.Random.Range(0, 012);
    [SapTarget]
    private void Callback013() => UnityEngine.Random.Range(0, 013);
    [SapTarget]
    private void Callback014() => UnityEngine.Random.Range(0, 014);
    [SapTarget]
    private void Callback015() => UnityEngine.Random.Range(0, 015);
    [SapTarget]
    private void Callback016() => UnityEngine.Random.Range(0, 016);
    [SapTarget]
    private void Callback017() => UnityEngine.Random.Range(0, 017);
    [SapTarget]
    private void Callback018() => UnityEngine.Random.Range(0, 018);
    [SapTarget]
    private void Callback019() => UnityEngine.Random.Range(0, 019);
    [SapTarget]
    private void Callback020() => UnityEngine.Random.Range(0, 020);
    [SapTarget]
    private void Callback021() => UnityEngine.Random.Range(0, 021);
    [SapTarget]
    private void Callback022() => UnityEngine.Random.Range(0, 022);
    [SapTarget]
    private void Callback023() => UnityEngine.Random.Range(0, 023);
    [SapTarget]
    private void Callback024() => UnityEngine.Random.Range(0, 024);
    [SapTarget]
    private void Callback025() => UnityEngine.Random.Range(0, 025);
    [SapTarget]
    private void Callback026() => UnityEngine.Random.Range(0, 026);
    [SapTarget]
    private void Callback027() => UnityEngine.Random.Range(0, 027);
    [SapTarget]
    private void Callback028() => UnityEngine.Random.Range(0, 028);
    [SapTarget]
    private void Callback029() => UnityEngine.Random.Range(0, 029);
    [SapTarget]
    private void Callback030() => UnityEngine.Random.Range(0, 030);
    [SapTarget]
    private void Callback031() => UnityEngine.Random.Range(0, 031);
    [SapTarget]
    private void Callback032() => UnityEngine.Random.Range(0, 032);
    [SapTarget]
    private void Callback033() => UnityEngine.Random.Range(0, 033);
    [SapTarget]
    private void Callback034() => UnityEngine.Random.Range(0, 034);
    [SapTarget]
    private void Callback035() => UnityEngine.Random.Range(0, 035);
    [SapTarget]
    private void Callback036() => UnityEngine.Random.Range(0, 036);
    [SapTarget]
    private void Callback037() => UnityEngine.Random.Range(0, 037);
    [SapTarget]
    private void Callback038() => UnityEngine.Random.Range(0, 038);
    [SapTarget]
    private void Callback039() => UnityEngine.Random.Range(0, 039);
    [SapTarget]
    private void Callback040() => UnityEngine.Random.Range(0, 040);
    [SapTarget]
    private void Callback041() => UnityEngine.Random.Range(0, 041);
    [SapTarget]
    private void Callback042() => UnityEngine.Random.Range(0, 042);
    [SapTarget]
    private void Callback043() => UnityEngine.Random.Range(0, 043);
    [SapTarget]
    private void Callback044() => UnityEngine.Random.Range(0, 044);
    [SapTarget]
    private void Callback045() => UnityEngine.Random.Range(0, 045);
    [SapTarget]
    private void Callback046() => UnityEngine.Random.Range(0, 046);
    [SapTarget]
    private void Callback047() => UnityEngine.Random.Range(0, 047);
    [SapTarget]
    private void Callback048() => UnityEngine.Random.Range(0, 048);
    [SapTarget]
    private void Callback049() => UnityEngine.Random.Range(0, 049);
    [SapTarget]
    private void Callback050() => UnityEngine.Random.Range(0, 050);
    [SapTarget]
    private void Callback051() => UnityEngine.Random.Range(0, 051);
    [SapTarget]
    private void Callback052() => UnityEngine.Random.Range(0, 052);
    [SapTarget]
    private void Callback053() => UnityEngine.Random.Range(0, 053);
    [SapTarget]
    private void Callback054() => UnityEngine.Random.Range(0, 054);
    [SapTarget]
    private void Callback055() => UnityEngine.Random.Range(0, 055);
    [SapTarget]
    private void Callback056() => UnityEngine.Random.Range(0, 056);
    [SapTarget]
    private void Callback057() => UnityEngine.Random.Range(0, 057);
    [SapTarget]
    private void Callback058() => UnityEngine.Random.Range(0, 058);
    [SapTarget]
    private void Callback059() => UnityEngine.Random.Range(0, 059);
    [SapTarget]
    private void Callback060() => UnityEngine.Random.Range(0, 060);
    [SapTarget]
    private void Callback061() => UnityEngine.Random.Range(0, 061);
    [SapTarget]
    private void Callback062() => UnityEngine.Random.Range(0, 062);
    [SapTarget]
    private void Callback063() => UnityEngine.Random.Range(0, 063);
    [SapTarget]
    private void Callback064() => UnityEngine.Random.Range(0, 064);
    [SapTarget]
    private void Callback065() => UnityEngine.Random.Range(0, 065);
    [SapTarget]
    private void Callback066() => UnityEngine.Random.Range(0, 066);
    [SapTarget]
    private void Callback067() => UnityEngine.Random.Range(0, 067);
    [SapTarget]
    private void Callback068() => UnityEngine.Random.Range(0, 068);
    [SapTarget]
    private void Callback069() => UnityEngine.Random.Range(0, 069);
    [SapTarget]
    private void Callback070() => UnityEngine.Random.Range(0, 070);
    [SapTarget]
    private void Callback071() => UnityEngine.Random.Range(0, 071);
    [SapTarget]
    private void Callback072() => UnityEngine.Random.Range(0, 072);
    [SapTarget]
    private void Callback073() => UnityEngine.Random.Range(0, 073);
    [SapTarget]
    private void Callback074() => UnityEngine.Random.Range(0, 074);
    [SapTarget]
    private void Callback075() => UnityEngine.Random.Range(0, 075);
    [SapTarget]
    private void Callback076() => UnityEngine.Random.Range(0, 076);
    [SapTarget]
    private void Callback077() => UnityEngine.Random.Range(0, 077);
    [SapTarget]
    private void Callback078() => UnityEngine.Random.Range(0, 078);
    [SapTarget]
    private void Callback079() => UnityEngine.Random.Range(0, 079);
    [SapTarget]
    private void Callback080() => UnityEngine.Random.Range(0, 080);
    [SapTarget]
    private void Callback081() => UnityEngine.Random.Range(0, 081);
    [SapTarget]
    private void Callback082() => UnityEngine.Random.Range(0, 082);
    [SapTarget]
    private void Callback083() => UnityEngine.Random.Range(0, 083);
    [SapTarget]
    private void Callback084() => UnityEngine.Random.Range(0, 084);
    [SapTarget]
    private void Callback085() => UnityEngine.Random.Range(0, 085);
    [SapTarget]
    private void Callback086() => UnityEngine.Random.Range(0, 086);
    [SapTarget]
    private void Callback087() => UnityEngine.Random.Range(0, 087);
    [SapTarget]
    private void Callback088() => UnityEngine.Random.Range(0, 088);
    [SapTarget]
    private void Callback089() => UnityEngine.Random.Range(0, 089);
    [SapTarget]
    private void Callback090() => UnityEngine.Random.Range(0, 090);
    [SapTarget]
    private void Callback091() => UnityEngine.Random.Range(0, 091);
    [SapTarget]
    private void Callback092() => UnityEngine.Random.Range(0, 092);
    [SapTarget]
    private void Callback093() => UnityEngine.Random.Range(0, 093);
    [SapTarget]
    private void Callback094() => UnityEngine.Random.Range(0, 094);
    [SapTarget]
    private void Callback095() => UnityEngine.Random.Range(0, 095);
    [SapTarget]
    private void Callback096() => UnityEngine.Random.Range(0, 096);
    [SapTarget]
    private void Callback097() => UnityEngine.Random.Range(0, 097);
    [SapTarget]
    private void Callback098() => UnityEngine.Random.Range(0, 098);
    [SapTarget]
    private void Callback099() => UnityEngine.Random.Range(0, 099);
    [SapTarget]
    private void Callback100() => UnityEngine.Random.Range(0, 100);
    [SapTarget]
    private void Callback101() => UnityEngine.Random.Range(0, 101);
    [SapTarget]
    private void Callback102() => UnityEngine.Random.Range(0, 102);
    [SapTarget]
    private void Callback103() => UnityEngine.Random.Range(0, 103);
    [SapTarget]
    private void Callback104() => UnityEngine.Random.Range(0, 104);
    [SapTarget]
    private void Callback105() => UnityEngine.Random.Range(0, 105);
    [SapTarget]
    private void Callback106() => UnityEngine.Random.Range(0, 106);
    [SapTarget]
    private void Callback107() => UnityEngine.Random.Range(0, 107);
    [SapTarget]
    private void Callback108() => UnityEngine.Random.Range(0, 108);
    [SapTarget]
    private void Callback109() => UnityEngine.Random.Range(0, 109);
    [SapTarget]
    private void Callback110() => UnityEngine.Random.Range(0, 110);
    [SapTarget]
    private void Callback111() => UnityEngine.Random.Range(0, 111);
    [SapTarget]
    private void Callback112() => UnityEngine.Random.Range(0, 112);
    [SapTarget]
    private void Callback113() => UnityEngine.Random.Range(0, 113);
    [SapTarget]
    private void Callback114() => UnityEngine.Random.Range(0, 114);
    [SapTarget]
    private void Callback115() => UnityEngine.Random.Range(0, 115);
    [SapTarget]
    private void Callback116() => UnityEngine.Random.Range(0, 116);
    [SapTarget]
    private void Callback117() => UnityEngine.Random.Range(0, 117);
    [SapTarget]
    private void Callback118() => UnityEngine.Random.Range(0, 118);
    [SapTarget]
    private void Callback119() => UnityEngine.Random.Range(0, 119);
    [SapTarget]
    private void Callback120() => UnityEngine.Random.Range(0, 120);
    [SapTarget]
    private void Callback121() => UnityEngine.Random.Range(0, 121);
    [SapTarget]
    private void Callback122() => UnityEngine.Random.Range(0, 122);
    [SapTarget]
    private void Callback123() => UnityEngine.Random.Range(0, 123);
    [SapTarget]
    private void Callback124() => UnityEngine.Random.Range(0, 124);
    [SapTarget]
    private void Callback125() => UnityEngine.Random.Range(0, 125);
    [SapTarget]
    private void Callback126() => UnityEngine.Random.Range(0, 126);
    [SapTarget]
    private void Callback127() => UnityEngine.Random.Range(0, 127);
    [SapTarget]
    private void Callback128() => UnityEngine.Random.Range(0, 128);
    [SapTarget]
    private void Callback129() => UnityEngine.Random.Range(0, 129);
    [SapTarget]
    private void Callback130() => UnityEngine.Random.Range(0, 130);
    [SapTarget]
    private void Callback131() => UnityEngine.Random.Range(0, 131);
    [SapTarget]
    private void Callback132() => UnityEngine.Random.Range(0, 132);
    [SapTarget]
    private void Callback133() => UnityEngine.Random.Range(0, 133);
    [SapTarget]
    private void Callback134() => UnityEngine.Random.Range(0, 134);
    [SapTarget]
    private void Callback135() => UnityEngine.Random.Range(0, 135);
    [SapTarget]
    private void Callback136() => UnityEngine.Random.Range(0, 136);
    [SapTarget]
    private void Callback137() => UnityEngine.Random.Range(0, 137);
    [SapTarget]
    private void Callback138() => UnityEngine.Random.Range(0, 138);
    [SapTarget]
    private void Callback139() => UnityEngine.Random.Range(0, 139);
    [SapTarget]
    private void Callback140() => UnityEngine.Random.Range(0, 140);
    [SapTarget]
    private void Callback141() => UnityEngine.Random.Range(0, 141);
    [SapTarget]
    private void Callback142() => UnityEngine.Random.Range(0, 142);
    [SapTarget]
    private void Callback143() => UnityEngine.Random.Range(0, 143);
    [SapTarget]
    private void Callback144() => UnityEngine.Random.Range(0, 144);
    [SapTarget]
    private void Callback145() => UnityEngine.Random.Range(0, 145);
    [SapTarget]
    private void Callback146() => UnityEngine.Random.Range(0, 146);
    [SapTarget]
    private void Callback147() => UnityEngine.Random.Range(0, 147);
    [SapTarget]
    private void Callback148() => UnityEngine.Random.Range(0, 148);
    [SapTarget]
    private void Callback149() => UnityEngine.Random.Range(0, 149);
    [SapTarget]
    private void Callback150() => UnityEngine.Random.Range(0, 150);
    [SapTarget]
    private void Callback151() => UnityEngine.Random.Range(0, 151);
    [SapTarget]
    private void Callback152() => UnityEngine.Random.Range(0, 152);
    [SapTarget]
    private void Callback153() => UnityEngine.Random.Range(0, 153);
    [SapTarget]
    private void Callback154() => UnityEngine.Random.Range(0, 154);
    [SapTarget]
    private void Callback155() => UnityEngine.Random.Range(0, 155);
    [SapTarget]
    private void Callback156() => UnityEngine.Random.Range(0, 156);
    [SapTarget]
    private void Callback157() => UnityEngine.Random.Range(0, 157);
    [SapTarget]
    private void Callback158() => UnityEngine.Random.Range(0, 158);
    [SapTarget]
    private void Callback159() => UnityEngine.Random.Range(0, 159);
    [SapTarget]
    private void Callback160() => UnityEngine.Random.Range(0, 160);
    [SapTarget]
    private void Callback161() => UnityEngine.Random.Range(0, 161);
    [SapTarget]
    private void Callback162() => UnityEngine.Random.Range(0, 162);
    [SapTarget]
    private void Callback163() => UnityEngine.Random.Range(0, 163);
    [SapTarget]
    private void Callback164() => UnityEngine.Random.Range(0, 164);
    [SapTarget]
    private void Callback165() => UnityEngine.Random.Range(0, 165);
    [SapTarget]
    private void Callback166() => UnityEngine.Random.Range(0, 166);
    [SapTarget]
    private void Callback167() => UnityEngine.Random.Range(0, 167);
    [SapTarget]
    private void Callback168() => UnityEngine.Random.Range(0, 168);
    [SapTarget]
    private void Callback169() => UnityEngine.Random.Range(0, 169);
    [SapTarget]
    private void Callback170() => UnityEngine.Random.Range(0, 170);
    [SapTarget]
    private void Callback171() => UnityEngine.Random.Range(0, 171);
    [SapTarget]
    private void Callback172() => UnityEngine.Random.Range(0, 172);
    [SapTarget]
    private void Callback173() => UnityEngine.Random.Range(0, 173);
    [SapTarget]
    private void Callback174() => UnityEngine.Random.Range(0, 174);
    [SapTarget]
    private void Callback175() => UnityEngine.Random.Range(0, 175);
    [SapTarget]
    private void Callback176() => UnityEngine.Random.Range(0, 176);
    [SapTarget]
    private void Callback177() => UnityEngine.Random.Range(0, 177);
    [SapTarget]
    private void Callback178() => UnityEngine.Random.Range(0, 178);
    [SapTarget]
    private void Callback179() => UnityEngine.Random.Range(0, 179);
    [SapTarget]
    private void Callback180() => UnityEngine.Random.Range(0, 180);
    [SapTarget]
    private void Callback181() => UnityEngine.Random.Range(0, 181);
    [SapTarget]
    private void Callback182() => UnityEngine.Random.Range(0, 182);
    [SapTarget]
    private void Callback183() => UnityEngine.Random.Range(0, 183);
    [SapTarget]
    private void Callback184() => UnityEngine.Random.Range(0, 184);
    [SapTarget]
    private void Callback185() => UnityEngine.Random.Range(0, 185);
    [SapTarget]
    private void Callback186() => UnityEngine.Random.Range(0, 186);
    [SapTarget]
    private void Callback187() => UnityEngine.Random.Range(0, 187);
    [SapTarget]
    private void Callback188() => UnityEngine.Random.Range(0, 188);
    [SapTarget]
    private void Callback189() => UnityEngine.Random.Range(0, 189);
    [SapTarget]
    private void Callback190() => UnityEngine.Random.Range(0, 190);
    [SapTarget]
    private void Callback191() => UnityEngine.Random.Range(0, 191);
    [SapTarget]
    private void Callback192() => UnityEngine.Random.Range(0, 192);
    [SapTarget]
    private void Callback193() => UnityEngine.Random.Range(0, 193);
    [SapTarget]
    private void Callback194() => UnityEngine.Random.Range(0, 194);
    [SapTarget]
    private void Callback195() => UnityEngine.Random.Range(0, 195);
    [SapTarget]
    private void Callback196() => UnityEngine.Random.Range(0, 196);
    [SapTarget]
    private void Callback197() => UnityEngine.Random.Range(0, 197);
    [SapTarget]
    private void Callback198() => UnityEngine.Random.Range(0, 198);
    [SapTarget]
    private void Callback199() => UnityEngine.Random.Range(0, 199);
    [SapTarget]
    private void Callback200() => UnityEngine.Random.Range(0, 200);
    [SapTarget]
    private void Callback201() => UnityEngine.Random.Range(0, 201);
    [SapTarget]
    private void Callback202() => UnityEngine.Random.Range(0, 202);
    [SapTarget]
    private void Callback203() => UnityEngine.Random.Range(0, 203);
    [SapTarget]
    private void Callback204() => UnityEngine.Random.Range(0, 204);
    [SapTarget]
    private void Callback205() => UnityEngine.Random.Range(0, 205);
    [SapTarget]
    private void Callback206() => UnityEngine.Random.Range(0, 206);
    [SapTarget]
    private void Callback207() => UnityEngine.Random.Range(0, 207);
    [SapTarget]
    private void Callback208() => UnityEngine.Random.Range(0, 208);
    [SapTarget]
    private void Callback209() => UnityEngine.Random.Range(0, 209);
    [SapTarget]
    private void Callback210() => UnityEngine.Random.Range(0, 210);
    [SapTarget]
    private void Callback211() => UnityEngine.Random.Range(0, 211);
    [SapTarget]
    private void Callback212() => UnityEngine.Random.Range(0, 212);
    [SapTarget]
    private void Callback213() => UnityEngine.Random.Range(0, 213);
    [SapTarget]
    private void Callback214() => UnityEngine.Random.Range(0, 214);
    [SapTarget]
    private void Callback215() => UnityEngine.Random.Range(0, 215);
    [SapTarget]
    private void Callback216() => UnityEngine.Random.Range(0, 216);
    [SapTarget]
    private void Callback217() => UnityEngine.Random.Range(0, 217);
    [SapTarget]
    private void Callback218() => UnityEngine.Random.Range(0, 218);
    [SapTarget]
    private void Callback219() => UnityEngine.Random.Range(0, 219);
    [SapTarget]
    private void Callback220() => UnityEngine.Random.Range(0, 220);
    [SapTarget]
    private void Callback221() => UnityEngine.Random.Range(0, 221);
    [SapTarget]
    private void Callback222() => UnityEngine.Random.Range(0, 222);
    [SapTarget]
    private void Callback223() => UnityEngine.Random.Range(0, 223);
    [SapTarget]
    private void Callback224() => UnityEngine.Random.Range(0, 224);
    [SapTarget]
    private void Callback225() => UnityEngine.Random.Range(0, 225);
    [SapTarget]
    private void Callback226() => UnityEngine.Random.Range(0, 226);
    [SapTarget]
    private void Callback227() => UnityEngine.Random.Range(0, 227);
    [SapTarget]
    private void Callback228() => UnityEngine.Random.Range(0, 228);
    [SapTarget]
    private void Callback229() => UnityEngine.Random.Range(0, 229);
    [SapTarget]
    private void Callback230() => UnityEngine.Random.Range(0, 230);
    [SapTarget]
    private void Callback231() => UnityEngine.Random.Range(0, 231);
    [SapTarget]
    private void Callback232() => UnityEngine.Random.Range(0, 232);
    [SapTarget]
    private void Callback233() => UnityEngine.Random.Range(0, 233);
    [SapTarget]
    private void Callback234() => UnityEngine.Random.Range(0, 234);
    [SapTarget]
    private void Callback235() => UnityEngine.Random.Range(0, 235);
    [SapTarget]
    private void Callback236() => UnityEngine.Random.Range(0, 236);
    [SapTarget]
    private void Callback237() => UnityEngine.Random.Range(0, 237);
    [SapTarget]
    private void Callback238() => UnityEngine.Random.Range(0, 238);
    [SapTarget]
    private void Callback239() => UnityEngine.Random.Range(0, 239);
    [SapTarget]
    private void Callback240() => UnityEngine.Random.Range(0, 240);
    [SapTarget]
    private void Callback241() => UnityEngine.Random.Range(0, 241);
    [SapTarget]
    private void Callback242() => UnityEngine.Random.Range(0, 242);
    [SapTarget]
    private void Callback243() => UnityEngine.Random.Range(0, 243);
    [SapTarget]
    private void Callback244() => UnityEngine.Random.Range(0, 244);
    [SapTarget]
    private void Callback245() => UnityEngine.Random.Range(0, 245);
    [SapTarget]
    private void Callback246() => UnityEngine.Random.Range(0, 246);
    [SapTarget]
    private void Callback247() => UnityEngine.Random.Range(0, 247);
    [SapTarget]
    private void Callback248() => UnityEngine.Random.Range(0, 248);
    [SapTarget]
    private void Callback249() => UnityEngine.Random.Range(0, 249);
    [SapTarget]
    private void Callback250() => UnityEngine.Random.Range(0, 250);
    [SapTarget]
    private void Callback251() => UnityEngine.Random.Range(0, 251);
    [SapTarget]
    private void Callback252() => UnityEngine.Random.Range(0, 252);
    [SapTarget]
    private void Callback253() => UnityEngine.Random.Range(0, 253);
    [SapTarget]
    private void Callback254() => UnityEngine.Random.Range(0, 254);
    [SapTarget]
    private void Callback255() => UnityEngine.Random.Range(0, 255);
    [SapTarget]
    private void Callback256() => UnityEngine.Random.Range(0, 256);
    [SapTarget]
    private void Callback257() => UnityEngine.Random.Range(0, 257);
    [SapTarget]
    private void Callback258() => UnityEngine.Random.Range(0, 258);
    [SapTarget]
    private void Callback259() => UnityEngine.Random.Range(0, 259);
    [SapTarget]
    private void Callback260() => UnityEngine.Random.Range(0, 260);
    [SapTarget]
    private void Callback261() => UnityEngine.Random.Range(0, 261);
    [SapTarget]
    private void Callback262() => UnityEngine.Random.Range(0, 262);
    [SapTarget]
    private void Callback263() => UnityEngine.Random.Range(0, 263);
    [SapTarget]
    private void Callback264() => UnityEngine.Random.Range(0, 264);
    [SapTarget]
    private void Callback265() => UnityEngine.Random.Range(0, 265);
    [SapTarget]
    private void Callback266() => UnityEngine.Random.Range(0, 266);
    [SapTarget]
    private void Callback267() => UnityEngine.Random.Range(0, 267);
    [SapTarget]
    private void Callback268() => UnityEngine.Random.Range(0, 268);
    [SapTarget]
    private void Callback269() => UnityEngine.Random.Range(0, 269);
    [SapTarget]
    private void Callback270() => UnityEngine.Random.Range(0, 270);
    [SapTarget]
    private void Callback271() => UnityEngine.Random.Range(0, 271);
    [SapTarget]
    private void Callback272() => UnityEngine.Random.Range(0, 272);
    [SapTarget]
    private void Callback273() => UnityEngine.Random.Range(0, 273);
    [SapTarget]
    private void Callback274() => UnityEngine.Random.Range(0, 274);
    [SapTarget]
    private void Callback275() => UnityEngine.Random.Range(0, 275);
    [SapTarget]
    private void Callback276() => UnityEngine.Random.Range(0, 276);
    [SapTarget]
    private void Callback277() => UnityEngine.Random.Range(0, 277);
    [SapTarget]
    private void Callback278() => UnityEngine.Random.Range(0, 278);
    [SapTarget]
    private void Callback279() => UnityEngine.Random.Range(0, 279);
    [SapTarget]
    private void Callback280() => UnityEngine.Random.Range(0, 280);
    [SapTarget]
    private void Callback281() => UnityEngine.Random.Range(0, 281);
    [SapTarget]
    private void Callback282() => UnityEngine.Random.Range(0, 282);
    [SapTarget]
    private void Callback283() => UnityEngine.Random.Range(0, 283);
    [SapTarget]
    private void Callback284() => UnityEngine.Random.Range(0, 284);
    [SapTarget]
    private void Callback285() => UnityEngine.Random.Range(0, 285);
    [SapTarget]
    private void Callback286() => UnityEngine.Random.Range(0, 286);
    [SapTarget]
    private void Callback287() => UnityEngine.Random.Range(0, 287);
    [SapTarget]
    private void Callback288() => UnityEngine.Random.Range(0, 288);
    [SapTarget]
    private void Callback289() => UnityEngine.Random.Range(0, 289);
    [SapTarget]
    private void Callback290() => UnityEngine.Random.Range(0, 290);
    [SapTarget]
    private void Callback291() => UnityEngine.Random.Range(0, 291);
    [SapTarget]
    private void Callback292() => UnityEngine.Random.Range(0, 292);
    [SapTarget]
    private void Callback293() => UnityEngine.Random.Range(0, 293);
    [SapTarget]
    private void Callback294() => UnityEngine.Random.Range(0, 294);
    [SapTarget]
    private void Callback295() => UnityEngine.Random.Range(0, 295);
    [SapTarget]
    private void Callback296() => UnityEngine.Random.Range(0, 296);
    [SapTarget]
    private void Callback297() => UnityEngine.Random.Range(0, 297);
    [SapTarget]
    private void Callback298() => UnityEngine.Random.Range(0, 298);
    [SapTarget]
    private void Callback299() => UnityEngine.Random.Range(0, 299);
    [SapTarget]
    private void Callback300() => UnityEngine.Random.Range(0, 300);
    [SapTarget]
    private void Callback301() => UnityEngine.Random.Range(0, 301);
    [SapTarget]
    private void Callback302() => UnityEngine.Random.Range(0, 302);
    [SapTarget]
    private void Callback303() => UnityEngine.Random.Range(0, 303);
    [SapTarget]
    private void Callback304() => UnityEngine.Random.Range(0, 304);
    [SapTarget]
    private void Callback305() => UnityEngine.Random.Range(0, 305);
    [SapTarget]
    private void Callback306() => UnityEngine.Random.Range(0, 306);
    [SapTarget]
    private void Callback307() => UnityEngine.Random.Range(0, 307);
    [SapTarget]
    private void Callback308() => UnityEngine.Random.Range(0, 308);
    [SapTarget]
    private void Callback309() => UnityEngine.Random.Range(0, 309);
    [SapTarget]
    private void Callback310() => UnityEngine.Random.Range(0, 310);
    [SapTarget]
    private void Callback311() => UnityEngine.Random.Range(0, 311);
    [SapTarget]
    private void Callback312() => UnityEngine.Random.Range(0, 312);
    [SapTarget]
    private void Callback313() => UnityEngine.Random.Range(0, 313);
    [SapTarget]
    private void Callback314() => UnityEngine.Random.Range(0, 314);
    [SapTarget]
    private void Callback315() => UnityEngine.Random.Range(0, 315);
    [SapTarget]
    private void Callback316() => UnityEngine.Random.Range(0, 316);
    [SapTarget]
    private void Callback317() => UnityEngine.Random.Range(0, 317);
    [SapTarget]
    private void Callback318() => UnityEngine.Random.Range(0, 318);
    [SapTarget]
    private void Callback319() => UnityEngine.Random.Range(0, 319);
    [SapTarget]
    private void Callback320() => UnityEngine.Random.Range(0, 320);
    [SapTarget]
    private void Callback321() => UnityEngine.Random.Range(0, 321);
    [SapTarget]
    private void Callback322() => UnityEngine.Random.Range(0, 322);
    [SapTarget]
    private void Callback323() => UnityEngine.Random.Range(0, 323);
    [SapTarget]
    private void Callback324() => UnityEngine.Random.Range(0, 324);
    [SapTarget]
    private void Callback325() => UnityEngine.Random.Range(0, 325);
    [SapTarget]
    private void Callback326() => UnityEngine.Random.Range(0, 326);
    [SapTarget]
    private void Callback327() => UnityEngine.Random.Range(0, 327);
    [SapTarget]
    private void Callback328() => UnityEngine.Random.Range(0, 328);
    [SapTarget]
    private void Callback329() => UnityEngine.Random.Range(0, 329);
    [SapTarget]
    private void Callback330() => UnityEngine.Random.Range(0, 330);
    [SapTarget]
    private void Callback331() => UnityEngine.Random.Range(0, 331);
    [SapTarget]
    private void Callback332() => UnityEngine.Random.Range(0, 332);
    [SapTarget]
    private void Callback333() => UnityEngine.Random.Range(0, 333);
    [SapTarget]
    private void Callback334() => UnityEngine.Random.Range(0, 334);
    [SapTarget]
    private void Callback335() => UnityEngine.Random.Range(0, 335);
    [SapTarget]
    private void Callback336() => UnityEngine.Random.Range(0, 336);
    [SapTarget]
    private void Callback337() => UnityEngine.Random.Range(0, 337);
    [SapTarget]
    private void Callback338() => UnityEngine.Random.Range(0, 338);
    [SapTarget]
    private void Callback339() => UnityEngine.Random.Range(0, 339);
    [SapTarget]
    private void Callback340() => UnityEngine.Random.Range(0, 340);
    [SapTarget]
    private void Callback341() => UnityEngine.Random.Range(0, 341);
    [SapTarget]
    private void Callback342() => UnityEngine.Random.Range(0, 342);
    [SapTarget]
    private void Callback343() => UnityEngine.Random.Range(0, 343);
    [SapTarget]
    private void Callback344() => UnityEngine.Random.Range(0, 344);
    [SapTarget]
    private void Callback345() => UnityEngine.Random.Range(0, 345);
    [SapTarget]
    private void Callback346() => UnityEngine.Random.Range(0, 346);
    [SapTarget]
    private void Callback347() => UnityEngine.Random.Range(0, 347);
    [SapTarget]
    private void Callback348() => UnityEngine.Random.Range(0, 348);
    [SapTarget]
    private void Callback349() => UnityEngine.Random.Range(0, 349);
    [SapTarget]
    private void Callback350() => UnityEngine.Random.Range(0, 350);
    [SapTarget]
    private void Callback351() => UnityEngine.Random.Range(0, 351);
    [SapTarget]
    private void Callback352() => UnityEngine.Random.Range(0, 352);
    [SapTarget]
    private void Callback353() => UnityEngine.Random.Range(0, 353);
    [SapTarget]
    private void Callback354() => UnityEngine.Random.Range(0, 354);
    [SapTarget]
    private void Callback355() => UnityEngine.Random.Range(0, 355);
    [SapTarget]
    private void Callback356() => UnityEngine.Random.Range(0, 356);
    [SapTarget]
    private void Callback357() => UnityEngine.Random.Range(0, 357);
    [SapTarget]
    private void Callback358() => UnityEngine.Random.Range(0, 358);
    [SapTarget]
    private void Callback359() => UnityEngine.Random.Range(0, 359);
    [SapTarget]
    private void Callback360() => UnityEngine.Random.Range(0, 360);
    [SapTarget]
    private void Callback361() => UnityEngine.Random.Range(0, 361);
    [SapTarget]
    private void Callback362() => UnityEngine.Random.Range(0, 362);
    [SapTarget]
    private void Callback363() => UnityEngine.Random.Range(0, 363);
    [SapTarget]
    private void Callback364() => UnityEngine.Random.Range(0, 364);
    [SapTarget]
    private void Callback365() => UnityEngine.Random.Range(0, 365);
    [SapTarget]
    private void Callback366() => UnityEngine.Random.Range(0, 366);
    [SapTarget]
    private void Callback367() => UnityEngine.Random.Range(0, 367);
    [SapTarget]
    private void Callback368() => UnityEngine.Random.Range(0, 368);
    [SapTarget]
    private void Callback369() => UnityEngine.Random.Range(0, 369);
    [SapTarget]
    private void Callback370() => UnityEngine.Random.Range(0, 370);
    [SapTarget]
    private void Callback371() => UnityEngine.Random.Range(0, 371);
    [SapTarget]
    private void Callback372() => UnityEngine.Random.Range(0, 372);
    [SapTarget]
    private void Callback373() => UnityEngine.Random.Range(0, 373);
    [SapTarget]
    private void Callback374() => UnityEngine.Random.Range(0, 374);
    [SapTarget]
    private void Callback375() => UnityEngine.Random.Range(0, 375);
    [SapTarget]
    private void Callback376() => UnityEngine.Random.Range(0, 376);
    [SapTarget]
    private void Callback377() => UnityEngine.Random.Range(0, 377);
    [SapTarget]
    private void Callback378() => UnityEngine.Random.Range(0, 378);
    [SapTarget]
    private void Callback379() => UnityEngine.Random.Range(0, 379);
    [SapTarget]
    private void Callback380() => UnityEngine.Random.Range(0, 380);
    [SapTarget]
    private void Callback381() => UnityEngine.Random.Range(0, 381);
    [SapTarget]
    private void Callback382() => UnityEngine.Random.Range(0, 382);
    [SapTarget]
    private void Callback383() => UnityEngine.Random.Range(0, 383);
    [SapTarget]
    private void Callback384() => UnityEngine.Random.Range(0, 384);
    [SapTarget]
    private void Callback385() => UnityEngine.Random.Range(0, 385);
    [SapTarget]
    private void Callback386() => UnityEngine.Random.Range(0, 386);
    [SapTarget]
    private void Callback387() => UnityEngine.Random.Range(0, 387);
    [SapTarget]
    private void Callback388() => UnityEngine.Random.Range(0, 388);
    [SapTarget]
    private void Callback389() => UnityEngine.Random.Range(0, 389);
    [SapTarget]
    private void Callback390() => UnityEngine.Random.Range(0, 390);
    [SapTarget]
    private void Callback391() => UnityEngine.Random.Range(0, 391);
    [SapTarget]
    private void Callback392() => UnityEngine.Random.Range(0, 392);
    [SapTarget]
    private void Callback393() => UnityEngine.Random.Range(0, 393);
    [SapTarget]
    private void Callback394() => UnityEngine.Random.Range(0, 394);
    [SapTarget]
    private void Callback395() => UnityEngine.Random.Range(0, 395);
    [SapTarget]
    private void Callback396() => UnityEngine.Random.Range(0, 396);
    [SapTarget]
    private void Callback397() => UnityEngine.Random.Range(0, 397);
    [SapTarget]
    private void Callback398() => UnityEngine.Random.Range(0, 398);
    [SapTarget]
    private void Callback399() => UnityEngine.Random.Range(0, 399);
    [SapTarget]
    private void Callback400() => UnityEngine.Random.Range(0, 400);
    [SapTarget]
    private void Callback401() => UnityEngine.Random.Range(0, 401);
    [SapTarget]
    private void Callback402() => UnityEngine.Random.Range(0, 402);
    [SapTarget]
    private void Callback403() => UnityEngine.Random.Range(0, 403);
    [SapTarget]
    private void Callback404() => UnityEngine.Random.Range(0, 404);
    [SapTarget]
    private void Callback405() => UnityEngine.Random.Range(0, 405);
    [SapTarget]
    private void Callback406() => UnityEngine.Random.Range(0, 406);
    [SapTarget]
    private void Callback407() => UnityEngine.Random.Range(0, 407);
    [SapTarget]
    private void Callback408() => UnityEngine.Random.Range(0, 408);
    [SapTarget]
    private void Callback409() => UnityEngine.Random.Range(0, 409);
    [SapTarget]
    private void Callback410() => UnityEngine.Random.Range(0, 410);
    [SapTarget]
    private void Callback411() => UnityEngine.Random.Range(0, 411);
    [SapTarget]
    private void Callback412() => UnityEngine.Random.Range(0, 412);
    [SapTarget]
    private void Callback413() => UnityEngine.Random.Range(0, 413);
    [SapTarget]
    private void Callback414() => UnityEngine.Random.Range(0, 414);
    [SapTarget]
    private void Callback415() => UnityEngine.Random.Range(0, 415);
    [SapTarget]
    private void Callback416() => UnityEngine.Random.Range(0, 416);
    [SapTarget]
    private void Callback417() => UnityEngine.Random.Range(0, 417);
    [SapTarget]
    private void Callback418() => UnityEngine.Random.Range(0, 418);
    [SapTarget]
    private void Callback419() => UnityEngine.Random.Range(0, 419);
    [SapTarget]
    private void Callback420() => UnityEngine.Random.Range(0, 420);
    [SapTarget]
    private void Callback421() => UnityEngine.Random.Range(0, 421);
    [SapTarget]
    private void Callback422() => UnityEngine.Random.Range(0, 422);
    [SapTarget]
    private void Callback423() => UnityEngine.Random.Range(0, 423);
    [SapTarget]
    private void Callback424() => UnityEngine.Random.Range(0, 424);
    [SapTarget]
    private void Callback425() => UnityEngine.Random.Range(0, 425);
    [SapTarget]
    private void Callback426() => UnityEngine.Random.Range(0, 426);
    [SapTarget]
    private void Callback427() => UnityEngine.Random.Range(0, 427);
    [SapTarget]
    private void Callback428() => UnityEngine.Random.Range(0, 428);
    [SapTarget]
    private void Callback429() => UnityEngine.Random.Range(0, 429);
    [SapTarget]
    private void Callback430() => UnityEngine.Random.Range(0, 430);
    [SapTarget]
    private void Callback431() => UnityEngine.Random.Range(0, 431);
    [SapTarget]
    private void Callback432() => UnityEngine.Random.Range(0, 432);
    [SapTarget]
    private void Callback433() => UnityEngine.Random.Range(0, 433);
    [SapTarget]
    private void Callback434() => UnityEngine.Random.Range(0, 434);
    [SapTarget]
    private void Callback435() => UnityEngine.Random.Range(0, 435);
    [SapTarget]
    private void Callback436() => UnityEngine.Random.Range(0, 436);
    [SapTarget]
    private void Callback437() => UnityEngine.Random.Range(0, 437);
    [SapTarget]
    private void Callback438() => UnityEngine.Random.Range(0, 438);
    [SapTarget]
    private void Callback439() => UnityEngine.Random.Range(0, 439);
    [SapTarget]
    private void Callback440() => UnityEngine.Random.Range(0, 440);
    [SapTarget]
    private void Callback441() => UnityEngine.Random.Range(0, 441);
    [SapTarget]
    private void Callback442() => UnityEngine.Random.Range(0, 442);
    [SapTarget]
    private void Callback443() => UnityEngine.Random.Range(0, 443);
    [SapTarget]
    private void Callback444() => UnityEngine.Random.Range(0, 444);
    [SapTarget]
    private void Callback445() => UnityEngine.Random.Range(0, 445);
    [SapTarget]
    private void Callback446() => UnityEngine.Random.Range(0, 446);
    [SapTarget]
    private void Callback447() => UnityEngine.Random.Range(0, 447);
    [SapTarget]
    private void Callback448() => UnityEngine.Random.Range(0, 448);
    [SapTarget]
    private void Callback449() => UnityEngine.Random.Range(0, 449);
    [SapTarget]
    private void Callback450() => UnityEngine.Random.Range(0, 450);
    [SapTarget]
    private void Callback451() => UnityEngine.Random.Range(0, 451);
    [SapTarget]
    private void Callback452() => UnityEngine.Random.Range(0, 452);
    [SapTarget]
    private void Callback453() => UnityEngine.Random.Range(0, 453);
    [SapTarget]
    private void Callback454() => UnityEngine.Random.Range(0, 454);
    [SapTarget]
    private void Callback455() => UnityEngine.Random.Range(0, 455);
    [SapTarget]
    private void Callback456() => UnityEngine.Random.Range(0, 456);
    [SapTarget]
    private void Callback457() => UnityEngine.Random.Range(0, 457);
    [SapTarget]
    private void Callback458() => UnityEngine.Random.Range(0, 458);
    [SapTarget]
    private void Callback459() => UnityEngine.Random.Range(0, 459);
    [SapTarget]
    private void Callback460() => UnityEngine.Random.Range(0, 460);
    [SapTarget]
    private void Callback461() => UnityEngine.Random.Range(0, 461);
    [SapTarget]
    private void Callback462() => UnityEngine.Random.Range(0, 462);
    [SapTarget]
    private void Callback463() => UnityEngine.Random.Range(0, 463);
    [SapTarget]
    private void Callback464() => UnityEngine.Random.Range(0, 464);
    [SapTarget]
    private void Callback465() => UnityEngine.Random.Range(0, 465);
    [SapTarget]
    private void Callback466() => UnityEngine.Random.Range(0, 466);
    [SapTarget]
    private void Callback467() => UnityEngine.Random.Range(0, 467);
    [SapTarget]
    private void Callback468() => UnityEngine.Random.Range(0, 468);
    [SapTarget]
    private void Callback469() => UnityEngine.Random.Range(0, 469);
    [SapTarget]
    private void Callback470() => UnityEngine.Random.Range(0, 470);
    [SapTarget]
    private void Callback471() => UnityEngine.Random.Range(0, 471);
    [SapTarget]
    private void Callback472() => UnityEngine.Random.Range(0, 472);
    [SapTarget]
    private void Callback473() => UnityEngine.Random.Range(0, 473);
    [SapTarget]
    private void Callback474() => UnityEngine.Random.Range(0, 474);
    [SapTarget]
    private void Callback475() => UnityEngine.Random.Range(0, 475);
    [SapTarget]
    private void Callback476() => UnityEngine.Random.Range(0, 476);
    [SapTarget]
    private void Callback477() => UnityEngine.Random.Range(0, 477);
    [SapTarget]
    private void Callback478() => UnityEngine.Random.Range(0, 478);
    [SapTarget]
    private void Callback479() => UnityEngine.Random.Range(0, 479);
    [SapTarget]
    private void Callback480() => UnityEngine.Random.Range(0, 480);
    [SapTarget]
    private void Callback481() => UnityEngine.Random.Range(0, 481);
    [SapTarget]
    private void Callback482() => UnityEngine.Random.Range(0, 482);
    [SapTarget]
    private void Callback483() => UnityEngine.Random.Range(0, 483);
    [SapTarget]
    private void Callback484() => UnityEngine.Random.Range(0, 484);
    [SapTarget]
    private void Callback485() => UnityEngine.Random.Range(0, 485);
    [SapTarget]
    private void Callback486() => UnityEngine.Random.Range(0, 486);
    [SapTarget]
    private void Callback487() => UnityEngine.Random.Range(0, 487);
    [SapTarget]
    private void Callback488() => UnityEngine.Random.Range(0, 488);
    [SapTarget]
    private void Callback489() => UnityEngine.Random.Range(0, 489);
    [SapTarget]
    private void Callback490() => UnityEngine.Random.Range(0, 490);
    [SapTarget]
    private void Callback491() => UnityEngine.Random.Range(0, 491);
    [SapTarget]
    private void Callback492() => UnityEngine.Random.Range(0, 492);
    [SapTarget]
    private void Callback493() => UnityEngine.Random.Range(0, 493);
    [SapTarget]
    private void Callback494() => UnityEngine.Random.Range(0, 494);
    [SapTarget]
    private void Callback495() => UnityEngine.Random.Range(0, 495);
    [SapTarget]
    private void Callback496() => UnityEngine.Random.Range(0, 496);
    [SapTarget]
    private void Callback497() => UnityEngine.Random.Range(0, 497);
    [SapTarget]
    private void Callback498() => UnityEngine.Random.Range(0, 498);
    [SapTarget]
    private void Callback499() => UnityEngine.Random.Range(0, 499);
    [SapTarget]
    private void Callback500() => UnityEngine.Random.Range(0, 500);
    [SapTarget]
    private void Callback501() => UnityEngine.Random.Range(0, 501);
    [SapTarget]
    private void Callback502() => UnityEngine.Random.Range(0, 502);
    [SapTarget]
    private void Callback503() => UnityEngine.Random.Range(0, 503);
    [SapTarget]
    private void Callback504() => UnityEngine.Random.Range(0, 504);
    [SapTarget]
    private void Callback505() => UnityEngine.Random.Range(0, 505);
    [SapTarget]
    private void Callback506() => UnityEngine.Random.Range(0, 506);
    [SapTarget]
    private void Callback507() => UnityEngine.Random.Range(0, 507);
    [SapTarget]
    private void Callback508() => UnityEngine.Random.Range(0, 508);
    [SapTarget]
    private void Callback509() => UnityEngine.Random.Range(0, 509);
    [SapTarget]
    private void Callback510() => UnityEngine.Random.Range(0, 510);
    [SapTarget]
    private void Callback511() => UnityEngine.Random.Range(0, 511);
    [SapTarget]
    private void Callback512() => UnityEngine.Random.Range(0, 512);
    [SapTarget]
    private void Callback513() => UnityEngine.Random.Range(0, 513);
    [SapTarget]
    private void Callback514() => UnityEngine.Random.Range(0, 514);
    [SapTarget]
    private void Callback515() => UnityEngine.Random.Range(0, 515);
    [SapTarget]
    private void Callback516() => UnityEngine.Random.Range(0, 516);
    [SapTarget]
    private void Callback517() => UnityEngine.Random.Range(0, 517);
    [SapTarget]
    private void Callback518() => UnityEngine.Random.Range(0, 518);
    [SapTarget]
    private void Callback519() => UnityEngine.Random.Range(0, 519);
    [SapTarget]
    private void Callback520() => UnityEngine.Random.Range(0, 520);
    [SapTarget]
    private void Callback521() => UnityEngine.Random.Range(0, 521);
    [SapTarget]
    private void Callback522() => UnityEngine.Random.Range(0, 522);
    [SapTarget]
    private void Callback523() => UnityEngine.Random.Range(0, 523);
    [SapTarget]
    private void Callback524() => UnityEngine.Random.Range(0, 524);
    [SapTarget]
    private void Callback525() => UnityEngine.Random.Range(0, 525);
    [SapTarget]
    private void Callback526() => UnityEngine.Random.Range(0, 526);
    [SapTarget]
    private void Callback527() => UnityEngine.Random.Range(0, 527);
    [SapTarget]
    private void Callback528() => UnityEngine.Random.Range(0, 528);
    [SapTarget]
    private void Callback529() => UnityEngine.Random.Range(0, 529);
    [SapTarget]
    private void Callback530() => UnityEngine.Random.Range(0, 530);
    [SapTarget]
    private void Callback531() => UnityEngine.Random.Range(0, 531);
    [SapTarget]
    private void Callback532() => UnityEngine.Random.Range(0, 532);
    [SapTarget]
    private void Callback533() => UnityEngine.Random.Range(0, 533);
    [SapTarget]
    private void Callback534() => UnityEngine.Random.Range(0, 534);
    [SapTarget]
    private void Callback535() => UnityEngine.Random.Range(0, 535);
    [SapTarget]
    private void Callback536() => UnityEngine.Random.Range(0, 536);
    [SapTarget]
    private void Callback537() => UnityEngine.Random.Range(0, 537);
    [SapTarget]
    private void Callback538() => UnityEngine.Random.Range(0, 538);
    [SapTarget]
    private void Callback539() => UnityEngine.Random.Range(0, 539);
    [SapTarget]
    private void Callback540() => UnityEngine.Random.Range(0, 540);
    [SapTarget]
    private void Callback541() => UnityEngine.Random.Range(0, 541);
    [SapTarget]
    private void Callback542() => UnityEngine.Random.Range(0, 542);
    [SapTarget]
    private void Callback543() => UnityEngine.Random.Range(0, 543);
    [SapTarget]
    private void Callback544() => UnityEngine.Random.Range(0, 544);
    [SapTarget]
    private void Callback545() => UnityEngine.Random.Range(0, 545);
    [SapTarget]
    private void Callback546() => UnityEngine.Random.Range(0, 546);
    [SapTarget]
    private void Callback547() => UnityEngine.Random.Range(0, 547);
    [SapTarget]
    private void Callback548() => UnityEngine.Random.Range(0, 548);
    [SapTarget]
    private void Callback549() => UnityEngine.Random.Range(0, 549);
    [SapTarget]
    private void Callback550() => UnityEngine.Random.Range(0, 550);
    [SapTarget]
    private void Callback551() => UnityEngine.Random.Range(0, 551);
    [SapTarget]
    private void Callback552() => UnityEngine.Random.Range(0, 552);
    [SapTarget]
    private void Callback553() => UnityEngine.Random.Range(0, 553);
    [SapTarget]
    private void Callback554() => UnityEngine.Random.Range(0, 554);
    [SapTarget]
    private void Callback555() => UnityEngine.Random.Range(0, 555);
    [SapTarget]
    private void Callback556() => UnityEngine.Random.Range(0, 556);
    [SapTarget]
    private void Callback557() => UnityEngine.Random.Range(0, 557);
    [SapTarget]
    private void Callback558() => UnityEngine.Random.Range(0, 558);
    [SapTarget]
    private void Callback559() => UnityEngine.Random.Range(0, 559);
    [SapTarget]
    private void Callback560() => UnityEngine.Random.Range(0, 560);
    [SapTarget]
    private void Callback561() => UnityEngine.Random.Range(0, 561);
    [SapTarget]
    private void Callback562() => UnityEngine.Random.Range(0, 562);
    [SapTarget]
    private void Callback563() => UnityEngine.Random.Range(0, 563);
    [SapTarget]
    private void Callback564() => UnityEngine.Random.Range(0, 564);
    [SapTarget]
    private void Callback565() => UnityEngine.Random.Range(0, 565);
    [SapTarget]
    private void Callback566() => UnityEngine.Random.Range(0, 566);
    [SapTarget]
    private void Callback567() => UnityEngine.Random.Range(0, 567);
    [SapTarget]
    private void Callback568() => UnityEngine.Random.Range(0, 568);
    [SapTarget]
    private void Callback569() => UnityEngine.Random.Range(0, 569);
    [SapTarget]
    private void Callback570() => UnityEngine.Random.Range(0, 570);
    [SapTarget]
    private void Callback571() => UnityEngine.Random.Range(0, 571);
    [SapTarget]
    private void Callback572() => UnityEngine.Random.Range(0, 572);
    [SapTarget]
    private void Callback573() => UnityEngine.Random.Range(0, 573);
    [SapTarget]
    private void Callback574() => UnityEngine.Random.Range(0, 574);
    [SapTarget]
    private void Callback575() => UnityEngine.Random.Range(0, 575);
    [SapTarget]
    private void Callback576() => UnityEngine.Random.Range(0, 576);
    [SapTarget]
    private void Callback577() => UnityEngine.Random.Range(0, 577);
    [SapTarget]
    private void Callback578() => UnityEngine.Random.Range(0, 578);
    [SapTarget]
    private void Callback579() => UnityEngine.Random.Range(0, 579);
    [SapTarget]
    private void Callback580() => UnityEngine.Random.Range(0, 580);
    [SapTarget]
    private void Callback581() => UnityEngine.Random.Range(0, 581);
    [SapTarget]
    private void Callback582() => UnityEngine.Random.Range(0, 582);
    [SapTarget]
    private void Callback583() => UnityEngine.Random.Range(0, 583);
    [SapTarget]
    private void Callback584() => UnityEngine.Random.Range(0, 584);
    [SapTarget]
    private void Callback585() => UnityEngine.Random.Range(0, 585);
    [SapTarget]
    private void Callback586() => UnityEngine.Random.Range(0, 586);
    [SapTarget]
    private void Callback587() => UnityEngine.Random.Range(0, 587);
    [SapTarget]
    private void Callback588() => UnityEngine.Random.Range(0, 588);
    [SapTarget]
    private void Callback589() => UnityEngine.Random.Range(0, 589);
    [SapTarget]
    private void Callback590() => UnityEngine.Random.Range(0, 590);
    [SapTarget]
    private void Callback591() => UnityEngine.Random.Range(0, 591);
    [SapTarget]
    private void Callback592() => UnityEngine.Random.Range(0, 592);
    [SapTarget]
    private void Callback593() => UnityEngine.Random.Range(0, 593);
    [SapTarget]
    private void Callback594() => UnityEngine.Random.Range(0, 594);
    [SapTarget]
    private void Callback595() => UnityEngine.Random.Range(0, 595);
    [SapTarget]
    private void Callback596() => UnityEngine.Random.Range(0, 596);
    [SapTarget]
    private void Callback597() => UnityEngine.Random.Range(0, 597);
    [SapTarget]
    private void Callback598() => UnityEngine.Random.Range(0, 598);
    [SapTarget]
    private void Callback599() => UnityEngine.Random.Range(0, 599);
    [SapTarget]
    private void Callback600() => UnityEngine.Random.Range(0, 600);
    [SapTarget]
    private void Callback601() => UnityEngine.Random.Range(0, 601);
    [SapTarget]
    private void Callback602() => UnityEngine.Random.Range(0, 602);
    [SapTarget]
    private void Callback603() => UnityEngine.Random.Range(0, 603);
    [SapTarget]
    private void Callback604() => UnityEngine.Random.Range(0, 604);
    [SapTarget]
    private void Callback605() => UnityEngine.Random.Range(0, 605);
    [SapTarget]
    private void Callback606() => UnityEngine.Random.Range(0, 606);
    [SapTarget]
    private void Callback607() => UnityEngine.Random.Range(0, 607);
    [SapTarget]
    private void Callback608() => UnityEngine.Random.Range(0, 608);
    [SapTarget]
    private void Callback609() => UnityEngine.Random.Range(0, 609);
    [SapTarget]
    private void Callback610() => UnityEngine.Random.Range(0, 610);
    [SapTarget]
    private void Callback611() => UnityEngine.Random.Range(0, 611);
    [SapTarget]
    private void Callback612() => UnityEngine.Random.Range(0, 612);
    [SapTarget]
    private void Callback613() => UnityEngine.Random.Range(0, 613);
    [SapTarget]
    private void Callback614() => UnityEngine.Random.Range(0, 614);
    [SapTarget]
    private void Callback615() => UnityEngine.Random.Range(0, 615);
    [SapTarget]
    private void Callback616() => UnityEngine.Random.Range(0, 616);
    [SapTarget]
    private void Callback617() => UnityEngine.Random.Range(0, 617);
    [SapTarget]
    private void Callback618() => UnityEngine.Random.Range(0, 618);
    [SapTarget]
    private void Callback619() => UnityEngine.Random.Range(0, 619);
    [SapTarget]
    private void Callback620() => UnityEngine.Random.Range(0, 620);
    [SapTarget]
    private void Callback621() => UnityEngine.Random.Range(0, 621);
    [SapTarget]
    private void Callback622() => UnityEngine.Random.Range(0, 622);
    [SapTarget]
    private void Callback623() => UnityEngine.Random.Range(0, 623);
    [SapTarget]
    private void Callback624() => UnityEngine.Random.Range(0, 624);
    [SapTarget]
    private void Callback625() => UnityEngine.Random.Range(0, 625);
    [SapTarget]
    private void Callback626() => UnityEngine.Random.Range(0, 626);
    [SapTarget]
    private void Callback627() => UnityEngine.Random.Range(0, 627);
    [SapTarget]
    private void Callback628() => UnityEngine.Random.Range(0, 628);
    [SapTarget]
    private void Callback629() => UnityEngine.Random.Range(0, 629);
    [SapTarget]
    private void Callback630() => UnityEngine.Random.Range(0, 630);
    [SapTarget]
    private void Callback631() => UnityEngine.Random.Range(0, 631);
    [SapTarget]
    private void Callback632() => UnityEngine.Random.Range(0, 632);
    [SapTarget]
    private void Callback633() => UnityEngine.Random.Range(0, 633);
    [SapTarget]
    private void Callback634() => UnityEngine.Random.Range(0, 634);
    [SapTarget]
    private void Callback635() => UnityEngine.Random.Range(0, 635);
    [SapTarget]
    private void Callback636() => UnityEngine.Random.Range(0, 636);
    [SapTarget]
    private void Callback637() => UnityEngine.Random.Range(0, 637);
    [SapTarget]
    private void Callback638() => UnityEngine.Random.Range(0, 638);
    [SapTarget]
    private void Callback639() => UnityEngine.Random.Range(0, 639);
    [SapTarget]
    private void Callback640() => UnityEngine.Random.Range(0, 640);
    [SapTarget]
    private void Callback641() => UnityEngine.Random.Range(0, 641);
    [SapTarget]
    private void Callback642() => UnityEngine.Random.Range(0, 642);
    [SapTarget]
    private void Callback643() => UnityEngine.Random.Range(0, 643);
    [SapTarget]
    private void Callback644() => UnityEngine.Random.Range(0, 644);
    [SapTarget]
    private void Callback645() => UnityEngine.Random.Range(0, 645);
    [SapTarget]
    private void Callback646() => UnityEngine.Random.Range(0, 646);
    [SapTarget]
    private void Callback647() => UnityEngine.Random.Range(0, 647);
    [SapTarget]
    private void Callback648() => UnityEngine.Random.Range(0, 648);
    [SapTarget]
    private void Callback649() => UnityEngine.Random.Range(0, 649);
    [SapTarget]
    private void Callback650() => UnityEngine.Random.Range(0, 650);
    [SapTarget]
    private void Callback651() => UnityEngine.Random.Range(0, 651);
    [SapTarget]
    private void Callback652() => UnityEngine.Random.Range(0, 652);
    [SapTarget]
    private void Callback653() => UnityEngine.Random.Range(0, 653);
    [SapTarget]
    private void Callback654() => UnityEngine.Random.Range(0, 654);
    [SapTarget]
    private void Callback655() => UnityEngine.Random.Range(0, 655);
    [SapTarget]
    private void Callback656() => UnityEngine.Random.Range(0, 656);
    [SapTarget]
    private void Callback657() => UnityEngine.Random.Range(0, 657);
    [SapTarget]
    private void Callback658() => UnityEngine.Random.Range(0, 658);
    [SapTarget]
    private void Callback659() => UnityEngine.Random.Range(0, 659);
    [SapTarget]
    private void Callback660() => UnityEngine.Random.Range(0, 660);
    [SapTarget]
    private void Callback661() => UnityEngine.Random.Range(0, 661);
    [SapTarget]
    private void Callback662() => UnityEngine.Random.Range(0, 662);
    [SapTarget]
    private void Callback663() => UnityEngine.Random.Range(0, 663);
    [SapTarget]
    private void Callback664() => UnityEngine.Random.Range(0, 664);
    [SapTarget]
    private void Callback665() => UnityEngine.Random.Range(0, 665);
    [SapTarget]
    private void Callback666() => UnityEngine.Random.Range(0, 666);
    [SapTarget]
    private void Callback667() => UnityEngine.Random.Range(0, 667);
    [SapTarget]
    private void Callback668() => UnityEngine.Random.Range(0, 668);
    [SapTarget]
    private void Callback669() => UnityEngine.Random.Range(0, 669);
    [SapTarget]
    private void Callback670() => UnityEngine.Random.Range(0, 670);
    [SapTarget]
    private void Callback671() => UnityEngine.Random.Range(0, 671);
    [SapTarget]
    private void Callback672() => UnityEngine.Random.Range(0, 672);
    [SapTarget]
    private void Callback673() => UnityEngine.Random.Range(0, 673);
    [SapTarget]
    private void Callback674() => UnityEngine.Random.Range(0, 674);
    [SapTarget]
    private void Callback675() => UnityEngine.Random.Range(0, 675);
    [SapTarget]
    private void Callback676() => UnityEngine.Random.Range(0, 676);
    [SapTarget]
    private void Callback677() => UnityEngine.Random.Range(0, 677);
    [SapTarget]
    private void Callback678() => UnityEngine.Random.Range(0, 678);
    [SapTarget]
    private void Callback679() => UnityEngine.Random.Range(0, 679);
    [SapTarget]
    private void Callback680() => UnityEngine.Random.Range(0, 680);
    [SapTarget]
    private void Callback681() => UnityEngine.Random.Range(0, 681);
    [SapTarget]
    private void Callback682() => UnityEngine.Random.Range(0, 682);
    [SapTarget]
    private void Callback683() => UnityEngine.Random.Range(0, 683);
    [SapTarget]
    private void Callback684() => UnityEngine.Random.Range(0, 684);
    [SapTarget]
    private void Callback685() => UnityEngine.Random.Range(0, 685);
    [SapTarget]
    private void Callback686() => UnityEngine.Random.Range(0, 686);
    [SapTarget]
    private void Callback687() => UnityEngine.Random.Range(0, 687);
    [SapTarget]
    private void Callback688() => UnityEngine.Random.Range(0, 688);
    [SapTarget]
    private void Callback689() => UnityEngine.Random.Range(0, 689);
    [SapTarget]
    private void Callback690() => UnityEngine.Random.Range(0, 690);
    [SapTarget]
    private void Callback691() => UnityEngine.Random.Range(0, 691);
    [SapTarget]
    private void Callback692() => UnityEngine.Random.Range(0, 692);
    [SapTarget]
    private void Callback693() => UnityEngine.Random.Range(0, 693);
    [SapTarget]
    private void Callback694() => UnityEngine.Random.Range(0, 694);
    [SapTarget]
    private void Callback695() => UnityEngine.Random.Range(0, 695);
    [SapTarget]
    private void Callback696() => UnityEngine.Random.Range(0, 696);
    [SapTarget]
    private void Callback697() => UnityEngine.Random.Range(0, 697);
    [SapTarget]
    private void Callback698() => UnityEngine.Random.Range(0, 698);
    [SapTarget]
    private void Callback699() => UnityEngine.Random.Range(0, 699);
    [SapTarget]
    private void Callback700() => UnityEngine.Random.Range(0, 700);
    [SapTarget]
    private void Callback701() => UnityEngine.Random.Range(0, 701);
    [SapTarget]
    private void Callback702() => UnityEngine.Random.Range(0, 702);
    [SapTarget]
    private void Callback703() => UnityEngine.Random.Range(0, 703);
    [SapTarget]
    private void Callback704() => UnityEngine.Random.Range(0, 704);
    [SapTarget]
    private void Callback705() => UnityEngine.Random.Range(0, 705);
    [SapTarget]
    private void Callback706() => UnityEngine.Random.Range(0, 706);
    [SapTarget]
    private void Callback707() => UnityEngine.Random.Range(0, 707);
    [SapTarget]
    private void Callback708() => UnityEngine.Random.Range(0, 708);
    [SapTarget]
    private void Callback709() => UnityEngine.Random.Range(0, 709);
    [SapTarget]
    private void Callback710() => UnityEngine.Random.Range(0, 710);
    [SapTarget]
    private void Callback711() => UnityEngine.Random.Range(0, 711);
    [SapTarget]
    private void Callback712() => UnityEngine.Random.Range(0, 712);
    [SapTarget]
    private void Callback713() => UnityEngine.Random.Range(0, 713);
    [SapTarget]
    private void Callback714() => UnityEngine.Random.Range(0, 714);
    [SapTarget]
    private void Callback715() => UnityEngine.Random.Range(0, 715);
    [SapTarget]
    private void Callback716() => UnityEngine.Random.Range(0, 716);
    [SapTarget]
    private void Callback717() => UnityEngine.Random.Range(0, 717);
    [SapTarget]
    private void Callback718() => UnityEngine.Random.Range(0, 718);
    [SapTarget]
    private void Callback719() => UnityEngine.Random.Range(0, 719);
    [SapTarget]
    private void Callback720() => UnityEngine.Random.Range(0, 720);
    [SapTarget]
    private void Callback721() => UnityEngine.Random.Range(0, 721);
    [SapTarget]
    private void Callback722() => UnityEngine.Random.Range(0, 722);
    [SapTarget]
    private void Callback723() => UnityEngine.Random.Range(0, 723);
    [SapTarget]
    private void Callback724() => UnityEngine.Random.Range(0, 724);
    [SapTarget]
    private void Callback725() => UnityEngine.Random.Range(0, 725);
    [SapTarget]
    private void Callback726() => UnityEngine.Random.Range(0, 726);
    [SapTarget]
    private void Callback727() => UnityEngine.Random.Range(0, 727);
    [SapTarget]
    private void Callback728() => UnityEngine.Random.Range(0, 728);
    [SapTarget]
    private void Callback729() => UnityEngine.Random.Range(0, 729);
    [SapTarget]
    private void Callback730() => UnityEngine.Random.Range(0, 730);
    [SapTarget]
    private void Callback731() => UnityEngine.Random.Range(0, 731);
    [SapTarget]
    private void Callback732() => UnityEngine.Random.Range(0, 732);
    [SapTarget]
    private void Callback733() => UnityEngine.Random.Range(0, 733);
    [SapTarget]
    private void Callback734() => UnityEngine.Random.Range(0, 734);
    [SapTarget]
    private void Callback735() => UnityEngine.Random.Range(0, 735);
    [SapTarget]
    private void Callback736() => UnityEngine.Random.Range(0, 736);
    [SapTarget]
    private void Callback737() => UnityEngine.Random.Range(0, 737);
    [SapTarget]
    private void Callback738() => UnityEngine.Random.Range(0, 738);
    [SapTarget]
    private void Callback739() => UnityEngine.Random.Range(0, 739);
    [SapTarget]
    private void Callback740() => UnityEngine.Random.Range(0, 740);
    [SapTarget]
    private void Callback741() => UnityEngine.Random.Range(0, 741);
    [SapTarget]
    private void Callback742() => UnityEngine.Random.Range(0, 742);
    [SapTarget]
    private void Callback743() => UnityEngine.Random.Range(0, 743);
    [SapTarget]
    private void Callback744() => UnityEngine.Random.Range(0, 744);
    [SapTarget]
    private void Callback745() => UnityEngine.Random.Range(0, 745);
    [SapTarget]
    private void Callback746() => UnityEngine.Random.Range(0, 746);
    [SapTarget]
    private void Callback747() => UnityEngine.Random.Range(0, 747);
    [SapTarget]
    private void Callback748() => UnityEngine.Random.Range(0, 748);
    [SapTarget]
    private void Callback749() => UnityEngine.Random.Range(0, 749);
    [SapTarget]
    private void Callback750() => UnityEngine.Random.Range(0, 750);
    [SapTarget]
    private void Callback751() => UnityEngine.Random.Range(0, 751);
    [SapTarget]
    private void Callback752() => UnityEngine.Random.Range(0, 752);
    [SapTarget]
    private void Callback753() => UnityEngine.Random.Range(0, 753);
    [SapTarget]
    private void Callback754() => UnityEngine.Random.Range(0, 754);
    [SapTarget]
    private void Callback755() => UnityEngine.Random.Range(0, 755);
    [SapTarget]
    private void Callback756() => UnityEngine.Random.Range(0, 756);
    [SapTarget]
    private void Callback757() => UnityEngine.Random.Range(0, 757);
    [SapTarget]
    private void Callback758() => UnityEngine.Random.Range(0, 758);
    [SapTarget]
    private void Callback759() => UnityEngine.Random.Range(0, 759);
    [SapTarget]
    private void Callback760() => UnityEngine.Random.Range(0, 760);
    [SapTarget]
    private void Callback761() => UnityEngine.Random.Range(0, 761);
    [SapTarget]
    private void Callback762() => UnityEngine.Random.Range(0, 762);
    [SapTarget]
    private void Callback763() => UnityEngine.Random.Range(0, 763);
    [SapTarget]
    private void Callback764() => UnityEngine.Random.Range(0, 764);
    [SapTarget]
    private void Callback765() => UnityEngine.Random.Range(0, 765);
    [SapTarget]
    private void Callback766() => UnityEngine.Random.Range(0, 766);
    [SapTarget]
    private void Callback767() => UnityEngine.Random.Range(0, 767);
    [SapTarget]
    private void Callback768() => UnityEngine.Random.Range(0, 768);
    [SapTarget]
    private void Callback769() => UnityEngine.Random.Range(0, 769);
    [SapTarget]
    private void Callback770() => UnityEngine.Random.Range(0, 770);
    [SapTarget]
    private void Callback771() => UnityEngine.Random.Range(0, 771);
    [SapTarget]
    private void Callback772() => UnityEngine.Random.Range(0, 772);
    [SapTarget]
    private void Callback773() => UnityEngine.Random.Range(0, 773);
    [SapTarget]
    private void Callback774() => UnityEngine.Random.Range(0, 774);
    [SapTarget]
    private void Callback775() => UnityEngine.Random.Range(0, 775);
    [SapTarget]
    private void Callback776() => UnityEngine.Random.Range(0, 776);
    [SapTarget]
    private void Callback777() => UnityEngine.Random.Range(0, 777);
    [SapTarget]
    private void Callback778() => UnityEngine.Random.Range(0, 778);
    [SapTarget]
    private void Callback779() => UnityEngine.Random.Range(0, 779);
    [SapTarget]
    private void Callback780() => UnityEngine.Random.Range(0, 780);
    [SapTarget]
    private void Callback781() => UnityEngine.Random.Range(0, 781);
    [SapTarget]
    private void Callback782() => UnityEngine.Random.Range(0, 782);
    [SapTarget]
    private void Callback783() => UnityEngine.Random.Range(0, 783);
    [SapTarget]
    private void Callback784() => UnityEngine.Random.Range(0, 784);
    [SapTarget]
    private void Callback785() => UnityEngine.Random.Range(0, 785);
    [SapTarget]
    private void Callback786() => UnityEngine.Random.Range(0, 786);
    [SapTarget]
    private void Callback787() => UnityEngine.Random.Range(0, 787);
    [SapTarget]
    private void Callback788() => UnityEngine.Random.Range(0, 788);
    [SapTarget]
    private void Callback789() => UnityEngine.Random.Range(0, 789);
    [SapTarget]
    private void Callback790() => UnityEngine.Random.Range(0, 790);
    [SapTarget]
    private void Callback791() => UnityEngine.Random.Range(0, 791);
    [SapTarget]
    private void Callback792() => UnityEngine.Random.Range(0, 792);
    [SapTarget]
    private void Callback793() => UnityEngine.Random.Range(0, 793);
    [SapTarget]
    private void Callback794() => UnityEngine.Random.Range(0, 794);
    [SapTarget]
    private void Callback795() => UnityEngine.Random.Range(0, 795);
    [SapTarget]
    private void Callback796() => UnityEngine.Random.Range(0, 796);
    [SapTarget]
    private void Callback797() => UnityEngine.Random.Range(0, 797);
    [SapTarget]
    private void Callback798() => UnityEngine.Random.Range(0, 798);
    [SapTarget]
    private void Callback799() => UnityEngine.Random.Range(0, 799);
    [SapTarget]
    private void Callback800() => UnityEngine.Random.Range(0, 800);
    [SapTarget]
    private void Callback801() => UnityEngine.Random.Range(0, 801);
    [SapTarget]
    private void Callback802() => UnityEngine.Random.Range(0, 802);
    [SapTarget]
    private void Callback803() => UnityEngine.Random.Range(0, 803);
    [SapTarget]
    private void Callback804() => UnityEngine.Random.Range(0, 804);
    [SapTarget]
    private void Callback805() => UnityEngine.Random.Range(0, 805);
    [SapTarget]
    private void Callback806() => UnityEngine.Random.Range(0, 806);
    [SapTarget]
    private void Callback807() => UnityEngine.Random.Range(0, 807);
    [SapTarget]
    private void Callback808() => UnityEngine.Random.Range(0, 808);
    [SapTarget]
    private void Callback809() => UnityEngine.Random.Range(0, 809);
    [SapTarget]
    private void Callback810() => UnityEngine.Random.Range(0, 810);
    [SapTarget]
    private void Callback811() => UnityEngine.Random.Range(0, 811);
    [SapTarget]
    private void Callback812() => UnityEngine.Random.Range(0, 812);
    [SapTarget]
    private void Callback813() => UnityEngine.Random.Range(0, 813);
    [SapTarget]
    private void Callback814() => UnityEngine.Random.Range(0, 814);
    [SapTarget]
    private void Callback815() => UnityEngine.Random.Range(0, 815);
    [SapTarget]
    private void Callback816() => UnityEngine.Random.Range(0, 816);
    [SapTarget]
    private void Callback817() => UnityEngine.Random.Range(0, 817);
    [SapTarget]
    private void Callback818() => UnityEngine.Random.Range(0, 818);
    [SapTarget]
    private void Callback819() => UnityEngine.Random.Range(0, 819);
    [SapTarget]
    private void Callback820() => UnityEngine.Random.Range(0, 820);
    [SapTarget]
    private void Callback821() => UnityEngine.Random.Range(0, 821);
    [SapTarget]
    private void Callback822() => UnityEngine.Random.Range(0, 822);
    [SapTarget]
    private void Callback823() => UnityEngine.Random.Range(0, 823);
    [SapTarget]
    private void Callback824() => UnityEngine.Random.Range(0, 824);
    [SapTarget]
    private void Callback825() => UnityEngine.Random.Range(0, 825);
    [SapTarget]
    private void Callback826() => UnityEngine.Random.Range(0, 826);
    [SapTarget]
    private void Callback827() => UnityEngine.Random.Range(0, 827);
    [SapTarget]
    private void Callback828() => UnityEngine.Random.Range(0, 828);
    [SapTarget]
    private void Callback829() => UnityEngine.Random.Range(0, 829);
    [SapTarget]
    private void Callback830() => UnityEngine.Random.Range(0, 830);
    [SapTarget]
    private void Callback831() => UnityEngine.Random.Range(0, 831);
    [SapTarget]
    private void Callback832() => UnityEngine.Random.Range(0, 832);
    [SapTarget]
    private void Callback833() => UnityEngine.Random.Range(0, 833);
    [SapTarget]
    private void Callback834() => UnityEngine.Random.Range(0, 834);
    [SapTarget]
    private void Callback835() => UnityEngine.Random.Range(0, 835);
    [SapTarget]
    private void Callback836() => UnityEngine.Random.Range(0, 836);
    [SapTarget]
    private void Callback837() => UnityEngine.Random.Range(0, 837);
    [SapTarget]
    private void Callback838() => UnityEngine.Random.Range(0, 838);
    [SapTarget]
    private void Callback839() => UnityEngine.Random.Range(0, 839);
    [SapTarget]
    private void Callback840() => UnityEngine.Random.Range(0, 840);
    [SapTarget]
    private void Callback841() => UnityEngine.Random.Range(0, 841);
    [SapTarget]
    private void Callback842() => UnityEngine.Random.Range(0, 842);
    [SapTarget]
    private void Callback843() => UnityEngine.Random.Range(0, 843);
    [SapTarget]
    private void Callback844() => UnityEngine.Random.Range(0, 844);
    [SapTarget]
    private void Callback845() => UnityEngine.Random.Range(0, 845);
    [SapTarget]
    private void Callback846() => UnityEngine.Random.Range(0, 846);
    [SapTarget]
    private void Callback847() => UnityEngine.Random.Range(0, 847);
    [SapTarget]
    private void Callback848() => UnityEngine.Random.Range(0, 848);
    [SapTarget]
    private void Callback849() => UnityEngine.Random.Range(0, 849);
    [SapTarget]
    private void Callback850() => UnityEngine.Random.Range(0, 850);
    [SapTarget]
    private void Callback851() => UnityEngine.Random.Range(0, 851);
    [SapTarget]
    private void Callback852() => UnityEngine.Random.Range(0, 852);
    [SapTarget]
    private void Callback853() => UnityEngine.Random.Range(0, 853);
    [SapTarget]
    private void Callback854() => UnityEngine.Random.Range(0, 854);
    [SapTarget]
    private void Callback855() => UnityEngine.Random.Range(0, 855);
    [SapTarget]
    private void Callback856() => UnityEngine.Random.Range(0, 856);
    [SapTarget]
    private void Callback857() => UnityEngine.Random.Range(0, 857);
    [SapTarget]
    private void Callback858() => UnityEngine.Random.Range(0, 858);
    [SapTarget]
    private void Callback859() => UnityEngine.Random.Range(0, 859);
    [SapTarget]
    private void Callback860() => UnityEngine.Random.Range(0, 860);
    [SapTarget]
    private void Callback861() => UnityEngine.Random.Range(0, 861);
    [SapTarget]
    private void Callback862() => UnityEngine.Random.Range(0, 862);
    [SapTarget]
    private void Callback863() => UnityEngine.Random.Range(0, 863);
    [SapTarget]
    private void Callback864() => UnityEngine.Random.Range(0, 864);
    [SapTarget]
    private void Callback865() => UnityEngine.Random.Range(0, 865);
    [SapTarget]
    private void Callback866() => UnityEngine.Random.Range(0, 866);
    [SapTarget]
    private void Callback867() => UnityEngine.Random.Range(0, 867);
    [SapTarget]
    private void Callback868() => UnityEngine.Random.Range(0, 868);
    [SapTarget]
    private void Callback869() => UnityEngine.Random.Range(0, 869);
    [SapTarget]
    private void Callback870() => UnityEngine.Random.Range(0, 870);
    [SapTarget]
    private void Callback871() => UnityEngine.Random.Range(0, 871);
    [SapTarget]
    private void Callback872() => UnityEngine.Random.Range(0, 872);
    [SapTarget]
    private void Callback873() => UnityEngine.Random.Range(0, 873);
    [SapTarget]
    private void Callback874() => UnityEngine.Random.Range(0, 874);
    [SapTarget]
    private void Callback875() => UnityEngine.Random.Range(0, 875);
    [SapTarget]
    private void Callback876() => UnityEngine.Random.Range(0, 876);
    [SapTarget]
    private void Callback877() => UnityEngine.Random.Range(0, 877);
    [SapTarget]
    private void Callback878() => UnityEngine.Random.Range(0, 878);
    [SapTarget]
    private void Callback879() => UnityEngine.Random.Range(0, 879);
    [SapTarget]
    private void Callback880() => UnityEngine.Random.Range(0, 880);
    [SapTarget]
    private void Callback881() => UnityEngine.Random.Range(0, 881);
    [SapTarget]
    private void Callback882() => UnityEngine.Random.Range(0, 882);
    [SapTarget]
    private void Callback883() => UnityEngine.Random.Range(0, 883);
    [SapTarget]
    private void Callback884() => UnityEngine.Random.Range(0, 884);
    [SapTarget]
    private void Callback885() => UnityEngine.Random.Range(0, 885);
    [SapTarget]
    private void Callback886() => UnityEngine.Random.Range(0, 886);
    [SapTarget]
    private void Callback887() => UnityEngine.Random.Range(0, 887);
    [SapTarget]
    private void Callback888() => UnityEngine.Random.Range(0, 888);
    [SapTarget]
    private void Callback889() => UnityEngine.Random.Range(0, 889);
    [SapTarget]
    private void Callback890() => UnityEngine.Random.Range(0, 890);
    [SapTarget]
    private void Callback891() => UnityEngine.Random.Range(0, 891);
    [SapTarget]
    private void Callback892() => UnityEngine.Random.Range(0, 892);
    [SapTarget]
    private void Callback893() => UnityEngine.Random.Range(0, 893);
    [SapTarget]
    private void Callback894() => UnityEngine.Random.Range(0, 894);
    [SapTarget]
    private void Callback895() => UnityEngine.Random.Range(0, 895);
    [SapTarget]
    private void Callback896() => UnityEngine.Random.Range(0, 896);
    [SapTarget]
    private void Callback897() => UnityEngine.Random.Range(0, 897);
    [SapTarget]
    private void Callback898() => UnityEngine.Random.Range(0, 898);
    [SapTarget]
    private void Callback899() => UnityEngine.Random.Range(0, 899);
    [SapTarget]
    private void Callback900() => UnityEngine.Random.Range(0, 900);
    [SapTarget]
    private void Callback901() => UnityEngine.Random.Range(0, 901);
    [SapTarget]
    private void Callback902() => UnityEngine.Random.Range(0, 902);
    [SapTarget]
    private void Callback903() => UnityEngine.Random.Range(0, 903);
    [SapTarget]
    private void Callback904() => UnityEngine.Random.Range(0, 904);
    [SapTarget]
    private void Callback905() => UnityEngine.Random.Range(0, 905);
    [SapTarget]
    private void Callback906() => UnityEngine.Random.Range(0, 906);
    [SapTarget]
    private void Callback907() => UnityEngine.Random.Range(0, 907);
    [SapTarget]
    private void Callback908() => UnityEngine.Random.Range(0, 908);
    [SapTarget]
    private void Callback909() => UnityEngine.Random.Range(0, 909);
    [SapTarget]
    private void Callback910() => UnityEngine.Random.Range(0, 910);
    [SapTarget]
    private void Callback911() => UnityEngine.Random.Range(0, 911);
    [SapTarget]
    private void Callback912() => UnityEngine.Random.Range(0, 912);
    [SapTarget]
    private void Callback913() => UnityEngine.Random.Range(0, 913);
    [SapTarget]
    private void Callback914() => UnityEngine.Random.Range(0, 914);
    [SapTarget]
    private void Callback915() => UnityEngine.Random.Range(0, 915);
    [SapTarget]
    private void Callback916() => UnityEngine.Random.Range(0, 916);
    [SapTarget]
    private void Callback917() => UnityEngine.Random.Range(0, 917);
    [SapTarget]
    private void Callback918() => UnityEngine.Random.Range(0, 918);
    [SapTarget]
    private void Callback919() => UnityEngine.Random.Range(0, 919);
    [SapTarget]
    private void Callback920() => UnityEngine.Random.Range(0, 920);
    [SapTarget]
    private void Callback921() => UnityEngine.Random.Range(0, 921);
    [SapTarget]
    private void Callback922() => UnityEngine.Random.Range(0, 922);
    [SapTarget]
    private void Callback923() => UnityEngine.Random.Range(0, 923);
    [SapTarget]
    private void Callback924() => UnityEngine.Random.Range(0, 924);
    [SapTarget]
    private void Callback925() => UnityEngine.Random.Range(0, 925);
    [SapTarget]
    private void Callback926() => UnityEngine.Random.Range(0, 926);
    [SapTarget]
    private void Callback927() => UnityEngine.Random.Range(0, 927);
    [SapTarget]
    private void Callback928() => UnityEngine.Random.Range(0, 928);
    [SapTarget]
    private void Callback929() => UnityEngine.Random.Range(0, 929);
    [SapTarget]
    private void Callback930() => UnityEngine.Random.Range(0, 930);
    [SapTarget]
    private void Callback931() => UnityEngine.Random.Range(0, 931);
    [SapTarget]
    private void Callback932() => UnityEngine.Random.Range(0, 932);
    [SapTarget]
    private void Callback933() => UnityEngine.Random.Range(0, 933);
    [SapTarget]
    private void Callback934() => UnityEngine.Random.Range(0, 934);
    [SapTarget]
    private void Callback935() => UnityEngine.Random.Range(0, 935);
    [SapTarget]
    private void Callback936() => UnityEngine.Random.Range(0, 936);
    [SapTarget]
    private void Callback937() => UnityEngine.Random.Range(0, 937);
    [SapTarget]
    private void Callback938() => UnityEngine.Random.Range(0, 938);
    [SapTarget]
    private void Callback939() => UnityEngine.Random.Range(0, 939);
    [SapTarget]
    private void Callback940() => UnityEngine.Random.Range(0, 940);
    [SapTarget]
    private void Callback941() => UnityEngine.Random.Range(0, 941);
    [SapTarget]
    private void Callback942() => UnityEngine.Random.Range(0, 942);
    [SapTarget]
    private void Callback943() => UnityEngine.Random.Range(0, 943);
    [SapTarget]
    private void Callback944() => UnityEngine.Random.Range(0, 944);
    [SapTarget]
    private void Callback945() => UnityEngine.Random.Range(0, 945);
    [SapTarget]
    private void Callback946() => UnityEngine.Random.Range(0, 946);
    [SapTarget]
    private void Callback947() => UnityEngine.Random.Range(0, 947);
    [SapTarget]
    private void Callback948() => UnityEngine.Random.Range(0, 948);
    [SapTarget]
    private void Callback949() => UnityEngine.Random.Range(0, 949);
    [SapTarget]
    private void Callback950() => UnityEngine.Random.Range(0, 950);
    [SapTarget]
    private void Callback951() => UnityEngine.Random.Range(0, 951);
    [SapTarget]
    private void Callback952() => UnityEngine.Random.Range(0, 952);
    [SapTarget]
    private void Callback953() => UnityEngine.Random.Range(0, 953);
    [SapTarget]
    private void Callback954() => UnityEngine.Random.Range(0, 954);
    [SapTarget]
    private void Callback955() => UnityEngine.Random.Range(0, 955);
    [SapTarget]
    private void Callback956() => UnityEngine.Random.Range(0, 956);
    [SapTarget]
    private void Callback957() => UnityEngine.Random.Range(0, 957);
    [SapTarget]
    private void Callback958() => UnityEngine.Random.Range(0, 958);
    [SapTarget]
    private void Callback959() => UnityEngine.Random.Range(0, 959);
    [SapTarget]
    private void Callback960() => UnityEngine.Random.Range(0, 960);
    [SapTarget]
    private void Callback961() => UnityEngine.Random.Range(0, 961);
    [SapTarget]
    private void Callback962() => UnityEngine.Random.Range(0, 962);
    [SapTarget]
    private void Callback963() => UnityEngine.Random.Range(0, 963);
    [SapTarget]
    private void Callback964() => UnityEngine.Random.Range(0, 964);
    [SapTarget]
    private void Callback965() => UnityEngine.Random.Range(0, 965);
    [SapTarget]
    private void Callback966() => UnityEngine.Random.Range(0, 966);
    [SapTarget]
    private void Callback967() => UnityEngine.Random.Range(0, 967);
    [SapTarget]
    private void Callback968() => UnityEngine.Random.Range(0, 968);
    [SapTarget]
    private void Callback969() => UnityEngine.Random.Range(0, 969);
    [SapTarget]
    private void Callback970() => UnityEngine.Random.Range(0, 970);
    [SapTarget]
    private void Callback971() => UnityEngine.Random.Range(0, 971);
    [SapTarget]
    private void Callback972() => UnityEngine.Random.Range(0, 972);
    [SapTarget]
    private void Callback973() => UnityEngine.Random.Range(0, 973);
    [SapTarget]
    private void Callback974() => UnityEngine.Random.Range(0, 974);
    [SapTarget]
    private void Callback975() => UnityEngine.Random.Range(0, 975);
    [SapTarget]
    private void Callback976() => UnityEngine.Random.Range(0, 976);
    [SapTarget]
    private void Callback977() => UnityEngine.Random.Range(0, 977);
    [SapTarget]
    private void Callback978() => UnityEngine.Random.Range(0, 978);
    [SapTarget]
    private void Callback979() => UnityEngine.Random.Range(0, 979);
    [SapTarget]
    private void Callback980() => UnityEngine.Random.Range(0, 980);
    [SapTarget]
    private void Callback981() => UnityEngine.Random.Range(0, 981);
    [SapTarget]
    private void Callback982() => UnityEngine.Random.Range(0, 982);
    [SapTarget]
    private void Callback983() => UnityEngine.Random.Range(0, 983);
    [SapTarget]
    private void Callback984() => UnityEngine.Random.Range(0, 984);
    [SapTarget]
    private void Callback985() => UnityEngine.Random.Range(0, 985);
    [SapTarget]
    private void Callback986() => UnityEngine.Random.Range(0, 986);
    [SapTarget]
    private void Callback987() => UnityEngine.Random.Range(0, 987);
    [SapTarget]
    private void Callback988() => UnityEngine.Random.Range(0, 988);
    [SapTarget]
    private void Callback989() => UnityEngine.Random.Range(0, 989);
    [SapTarget]
    private void Callback990() => UnityEngine.Random.Range(0, 990);
    [SapTarget]
    private void Callback991() => UnityEngine.Random.Range(0, 991);
    [SapTarget]
    private void Callback992() => UnityEngine.Random.Range(0, 992);
    [SapTarget]
    private void Callback993() => UnityEngine.Random.Range(0, 993);
    [SapTarget]
    private void Callback994() => UnityEngine.Random.Range(0, 994);
    [SapTarget]
    private void Callback995() => UnityEngine.Random.Range(0, 995);
    [SapTarget]
    private void Callback996() => UnityEngine.Random.Range(0, 996);
    [SapTarget]
    private void Callback997() => UnityEngine.Random.Range(0, 997);
    [SapTarget]
    private void Callback998() => UnityEngine.Random.Range(0, 998);
    [SapTarget]
    private void Callback999() => UnityEngine.Random.Range(0, 999);
}
