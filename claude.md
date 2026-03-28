# Space Survivor – Claude.md

## Project Overview
A Survivor.io-style top-down 2D space shooter built in Unity 2D.
The player survives endless waves of enemies, collecting XP and choosing upgrades.

## Tech Stack
- Unity 2D (URP or built-in render pipeline)
- C#
- Unity Physics 2D

## Core Systems

### Player
- Top-down movement with WASD / arrow keys
- Has Health, Speed, and XP stats
- On levelup: pause game, show 3 random upgrade choices

### Enemies
- Spawn in waves from screen edges
- Move toward the player
- Drop XP orbs on death

### Weapons / Companions
- Weapons are components attached to the player
- Each weapon has: Damage, Cooldown, Level (1–3)

### Upgrade System
- UpgradeManager picks a random upgrades on levelup
- Each upgrade either adds a new weapon or levels up an existing one
- Max level per weapon: 3