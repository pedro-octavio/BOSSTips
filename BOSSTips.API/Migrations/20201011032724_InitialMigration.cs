﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace BOSSTips.API.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 10, nullable: false),
                    Name = table.Column<string>(maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bosses",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 10, nullable: false),
                    Name = table.Column<string>(maxLength: 40, nullable: false),
                    Tips = table.Column<string>(maxLength: 7200, nullable: true),
                    GameId = table.Column<string>(maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bosses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bosses_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "3254b199ca", "Dark Souls 1" },
                    { "ef0b57436f", "Dark Souls 2" },
                    { "12c28a1a46", "Dark Souls 3" },
                    { "fa4a31c3c8", "Metal Gear Solid 5: The Panthom Pain" },
                    { "342c67d085", "Final Fantasy 7" },
                    { "1ce92db6f2", "The Legend of Zelda: Breath of the Wild" }
                });

            migrationBuilder.InsertData(
                table: "Bosses",
                columns: new[] { "Id", "GameId", "Name", "Tips" },
                values: new object[,]
                {
                    { "f6ea493f9b", "3254b199ca", "Manus, Father of The Abyss", "If you saved Sif in the area before the boss room*, it's possible to summon him to assist you during the battle. There will be a White Summon Sign near the middle of the room (behind and to the left of where you start) that will summon Sif to aid you in his puppy form, although the summon sign can be a little difficult to reach due to the boss's quick attack rates. The summon sign can also be tricky to spot at first, given that your attention will be on avoiding Manus' attacks from the moment you enter the arena. Sif attacks rather slowly for approximately 100 damage on NG but it is extremely difficult for Manus to kill him, and he is thus a suitable distraction for solo players, or for those who cannot find summon signs for Manus in their level range. As opposed to other summons signs, all you need to do is interact with this one to summon Sif, there is no confirmation dialog." },
                    { "1b084623d6", "3254b199ca", "Ornstein e Smough", @"Do not lock on to either Ornstein or Smough, be sure to know the general placement of each of these two for the duration of the fight in order to block their attacks. You can kill them one at a time, which we recommend doing- Then the boss fight enters a second phase - a powered up version of the last remaining boss. For this guide, we're going to recommend that you kill Ornstein first.
                So, dealing with Ornstein is a bit of a pain, he has a few rushdown attacks that will definitely catch you off guard more than a few times. The first of which is a charging stab which locks onto your location, in addition to another Lunge which is a shorter range version of this.
                He also can cast lightning bolts at you which home in on your location.He is all about catching you off - guard, which is why we're going to want to kill him first." },
                    { "b017778d9d", "ef0b57436f", "Smelter Demon", @"He is weak to Piercing damage, and very weak to Lightning damage. If you have any Strength-based weapons with Pierce attacks or any Gold Resin, you might consider using it.
                Other than that, the fight is simply learning his attacks and how to dodge them or, if you have a shield with both high Physical and Fire block, guard them.If you screw up and get hit, healing is tough since he's so aggressive.
                Use his Power Up phases for healing, since he takes greatly reduced damage during the animations.First power up phase makes him do Fire damage around himself, second makes his weapon do 100 % Fire damage.
                The only time you can heal safely outside of those power - up animations, that I found, is after he misses a leaping plunge attack.Roll away twice to make sure you escape the AOE explosion he sometimes throw in and chug Estus." },
                    { "08187f5226", "ef0b57436f", "Vendrick", @"Make sure that at least two (have five for the best results) ""Soul of a Giant"" are in your inventory; this will weaken Vendrick's defense so that killing him isn't an impossibility. Pre-Patch 1.10 You can in fact farm giant souls from the two giants in black gulch, just use a Bonfire Ascetic on the first bonfire.
                Stay close to his left leg and roll out of the way when he swings his sword in any direction.Attack only when he finishes attacking, then rinse and repeat.Casters and Archers can use this same method to beat him.In fact, casters can stand just behind his left leg and circle strafe him while casting; his leg will nudge you to safety.Another thing to remember is if Vendrick leaps back do not pursue him rather let him come to you and be prepared to dodge backwards, wait until the last second if straight slam or simply dodge left or right." },
                    { "1746878fab", "ef0b57436f", "Ruin Sentinels", @"As soon as you exit the mist, you drop onto an elevated platform where Yahim immediately attacks. If you have a proper shield, you can block the first attack with no damage inflicted. Otherwise, you need to dodge when you land on the platform to insure you avoid Yahim's initial attack.
                Stay on the platform while you battle against Yahim.If you fall down to the floor below, Alessia and Ricce will join the battle and it will be much tougher. If you stay close to Yahim, it only uses one of two attacks. It will either use a linear attack with a moderately lengthy animation(easy to see coming) followed by a circular attack that covers the front of Yahim, or it will use two consecutive circular attacks.
                All of the attacks can be blocked with a decent shield.The linear attack is relatively easy to avoid with a well - timed dodge, but it’s a good idea to block the circular attacks with a shield unless you can get behind Yahim. Even if you're behind Yahim, the circular attack covers almost a 240-degree radius, so back up a bit to ensure you avoid the attack." },
                    { "3a4e8478e1", "12c28a1a46", "Pontiff Sulyvahn", @"Sulyvahn has very long combos and leaves few openings, so be sure to better your stamina with the Cloranthy Ring, Ring of Favor, Grass Crest Shield or Green Blossoms to be on the safe side. When you enter, he will likely leap at you with his fire sword. Roll to the right or the left when his sword is about the reach the ground and attack him one or two times. Then, get as far as you can. He will likely do the same attack over and over.
                Be careful, because if you get too close, he will chain his attacks rapidly, and you won't be able to avoid them all. If you want to get close to him, roll through his attacks and strike immediately when he stops attacking. The preferable angle of attack is his back, but he turns quite rapidly.
                When his phantom clone appears, don't bother attacking him and make sure to roll through its attack and wait as far as you can, luring Pontiff into leaping towards you. Be careful, because he could also use a ranged magic attack, which is quite deadly, but is easy to avoid; just roll to your left or right. " },
                    { "573ceeb39c", "fa4a31c3c8", "Quiet", @"If you want to win the battle by depleting Quiet's endurance bar, your best weapon is the sniper rifle. In the situation, in which Quiet learns your position, stay behind your cover and lean out only to take the shot. Then, walk away quickly, or else her attack ends in a success. If, on the other hand, she does not know your position, you can risk a more precise shot at the head, of course.
                There are many other ways to deplete Quiet's health bar. For example, you can use the rocket launcher or the grenade launcher. If you managed to get close to her current cover, you can surprise her with a grenade and hope that it does not go off before she escapes. Using standard weapons, e.g. a machine gun, is not recommended, because you don't deal too much damage to her, this way, because she escapes into another spot." },
                    { "fc963a283c", "fa4a31c3c8", "Yevgeny Borisovitch Volgin", @"The Man on Fire is immune to conventional firearms and explosive weapons. He is also immune to melee and will kill you instantly if he grabs you. If he gets close, dive away. Watch out if he winds up...a fireball will follow.
                Try not to waste ammo on him and focus on incapacitating him.Be aware that summoning the chopper without disabling the Fire Man usually results in him shooting it out of the sky.You can stun the Man on Fire with water from the water towers and the Water Tanks in the warehouse. Detonating C4 at the base of a water tower will bring it down, flooding the base area around the tower with water.
                Alternately, stand near the the base of the water tower and let him shoot a fireball at the base.This will destroy the tower and the water will end up dousing him and incapacitating him temporarily." },
                    { "7fead2c11f", "342c67d085", "Crab Warden", @"The Crab Warden has a lot of different targets on its body, and to put it on forever, you need to cripple each leg at a time. It is weak for Lightning magic, so make sure you have some Lightning Materia equipped in advance - the more the better, but definitely give Barret an orb, as he can walk away from the battle and support the melee fighters with spells.
                As soon as the fight begins, the Crab Warden electrifies the train tracks, to ensure that your team is not standing on them.This happens from time to time, so keep an eye on the Crab Warden who is preparing the attack and be clear.Once the electricity dissipates, have Cloud and Tifa focus melee attacks on the Crab Guardian's legs, while commanding whoever you have assigned Lightning Materia to reinforce your attacks with Lightning spells. Attacking the crab legs from the side and the back from behind can be very useful, as most weapons are in the front, but be careful with attacking the EMP blast area, which can cause great damage if you are standing too far Close. Repeat this cycle of attacks and defense until you destroy a leg to stagger the crab; use this opportunity to do great damage to your ATB skills.
                The Crab Warden will add additional attacks as it takes more and more damage, eventually opening two large missile launchers aside.They are difficult to dodge, so get ready to protect yourself to mitigate the damage and keep pouring the lightning in the meantime.Missiles are a significant threat, so focus on launchers to destroy them, while also forcing Crab Warden to expose its pilot generator. At that point, you should be free to enter the exposed weakness with everything you need to get rid of the boss in no time." },
                    { "562310ef43", "342c67d085", "Sephiroth", @"Sephiroth is the most aggressive and heavily-damaging boss in the main story, which is fitting, as he is the final boss. You’ll need to spend most of your ATB healing, buffing your party, using damage-mitigating abilities, and even resurrecting.
                While it may, at first, seem like you aren’t dealing much damage to him, don’t lose hope; this health bar is the only one he gets.Although this fight is certainly long and intense, once his HP reaches 0, it’s over.
                Sephiroth moves slowly until he decides to attack with his sword. Watch him closely and activate Punisher Mode as soon as he starts to attack with his sword, or if you see the Telluric Fury move nameplate appear, as it can be countered." },
                    { "3c104a28f1", "1ce92db6f2", "Molduga", @"There are lots of fun ways you can mess around with Moldugas. One of these being if you grab a sand seal and surf around as a Molduga chases you. You can be a daredevil and attempt to Revali’s Gale straight up in the air as he leaps at you, and then fire arrows straight down at the airborne monster.
                They also give you some really great loot that can be useful even late game.The Molduga parts can be used for cooking elixirs or selling for Rupees, and the chests that spawn after beating them contain some pretty strong armor and weapons.
                Like other overworld bosses, these respawn during blood moons, so you basically have a constant supply of items from these guys.After finishing the Gerudo area there aren’t many reasons to return to the desert, but Moldugas are definitely fun bosses worth traveling there to fight." },
                    { "a715fe8fa2", "1ce92db6f2", "Calamity Ganon", @"Being one of the final bosses in the game, I’m glad he was difficult to fight. The disappointing Dark Beast Ganon immediately follows him, so at least there was one final boss fight that was enjoyable.
                If you didn’t complete any of the Divine Beasts before facing Calamity Ganon, he has the potential to be one of the hardest fights that can take the longest amount of time.Before the Calamity Ganon fight, you’ll be forced to fight every elemental Ganon you didn’t beat before.Potentially, you’ll have to fight all four elemental Ganons, Calamity Ganon, and Dark Beast Ganon in a single sitting.
                He proves to be a difficult boss even with Daruk’s Protection and the other Champion abilities enabled.Make sure you bring plenty of fairies and a lot of food because you’ll probably get hurt quite a bit." }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bosses_GameId",
                table: "Bosses",
                column: "GameId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bosses");

            migrationBuilder.DropTable(
                name: "Games");
        }
    }
}
