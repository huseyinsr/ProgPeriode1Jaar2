classDiagram

    class Enemy {
        -Health health
        +TakeDamage()
    }

    class Health {
        -int currentHealth
        +TakeDamage()
    }

    class Teeth {
        -Health health
    }

    class ToothpasteShooter {
        -DetectionZone detectionZone
        +OnDetectionEnter()
        +OnDetectionExit()
    }

    class DetectionZone {
        +OnTriggerEnter()
    }

    class ToothpasteProjectile {
        -int damage
        +OnCollisionEnter()
    }

    class WaveSpawner {
        +SpawnEnemy()
    }

    class GameManager {
        -int suns
        +BuyShooter()
    }

    class ShooterSlot {
        -GameManager gameManager
    }

    class Tile {
        -bool hasShooter
    }

    class Sun {
        -int value
    }

    class SunSpawner {
        +SpawnSun()
    }

    class TutorialDialogue {
        -string[] messages
        +ShowNextMessage()
    }

    class Menu {
        +Show()
        +Hide()
    }

    class StartMenu {
        +StartGame()
        +QuitGame()
    }

    Enemy --* Health
    Teeth --* Health
    ToothpasteShooter --> DetectionZone
    DetectionZone --> Enemy
    ToothpasteShooter --> ToothpasteProjectile
    ToothpasteProjectile --> Enemy
    WaveSpawner --> Enemy
    ShooterSlot --> GameManager
    GameManager --> Tile
    GameManager --> Sun
    SunSpawner --> Sun
