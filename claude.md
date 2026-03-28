# Space Survivor – Claude.md

## Project Overview
A Survivor.io-style top-down 2D space shooter built in Unity 2D.
The player survives endless waves of enemies, collecting XP and choosing upgrades.

## Tech Stack
- Unity 2D (URP or built-in render pipeline)
- C#
- Unity Physics 2D

## Project Structure
Assets/
├── Scripts/
│   ├── Player/
│   ├── Enemies/
│   ├── Weapons/
│   ├── Upgrades/
│   └── Managers/
├── Prefabs/
├── Scenes/
└── Art/

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
- Star Companion: hovers above player, fires piercing beam periodically
  - Level 3 evolution: Pulsar Star (rotates, fires beams in all directions)

### Upgrade System
- UpgradeManager picks 3 random upgrades on levelup
- Each upgrade either adds a new weapon or levels up an existing one
- Max level per weapon: 3

### Managers
- GameManager: wave timer, score, game state
- EnemySpawner: spawns enemies on an interval, increases difficulty over time
- UpgradeManager: handles levelup UI and applying upgrades

## Coding Conventions
- MonoBehaviours for game objects
- ScriptableObjects for weapon/upgrade definitions
- Use object pooling for bullets and XP orbs
- Avoid FindObjectOfType in Update() — cache references in Awake/Start

## Known Issues / TODOs
- [ ] Add more enemy types
- [ ] Polish upgrade UI
- [ ] Add screen shake on hit
- [ ] Final boss at wave 10?