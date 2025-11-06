# ProgPeriode1Jaar2

Les 1 Opdracht 1

![a8ecxd](https://github.com/user-attachments/assets/3b535b6d-5a6b-4ad8-b6d7-ec0679b1aaea)

CreateBall.cs

https://github.com/huseyinsr/ProgPeriode1Jaar2/blob/main/Assets/Script/CreateBall.cs

De script maakt random kleuren voor ballen. De ballen spawnen met verschillende kleuren(100 ballen in het begin). Ze verdwijnen na 3 seconden.

Ik heb met deze opdracht functions, classes en arrays herhaald.

----------------------------------------------------------

Les 1 Opdracht 2

![a8ed5y](https://github.com/user-attachments/assets/6bfe2d7a-ee0d-47b7-8d38-36569e400222)

Tower.cs

https://github.com/huseyinsr/ProgPeriode1Jaar2/blob/main/Assets/Script/Tower.cs

TowerSpawner.cs

https://github.com/huseyinsr/ProgPeriode1Jaar2/blob/main/Assets/Script/TowerSpawner.cs

Je maakt niuwe toren elke keer als je in het scherm klikt.

Ik heb met deze opdracht functions, classes en arrays herhaald.

----------------------------------------------------------

les 1 Opdracht 3

![a8eder](https://github.com/user-attachments/assets/35a132cf-e4c9-4551-a736-897de35996f0)

EnemySpawner.cs

https://github.com/huseyinsr/ProgPeriode1Jaar2/blob/main/Assets/Script/EnemySpawner.cs

Enemy.cs

https://github.com/huseyinsr/ProgPeriode1Jaar2/blob/main/Assets/Script/Enemy.cs

Er spawnen 3 enemy elke seconden. Als je op W toets drukt spawnen er 100 enemy en als je op Q toets drukt verwijder je de alle enemies.

Ik heb met deze opdracht functions, classes en arrays herhaald.

----------------------------------------------------------

Les 2

![a8edi1](https://github.com/user-attachments/assets/6c3ef505-7e56-4f5e-b3e0-89b09fa3506f)

Pickup.cs

https://github.com/huseyinsr/ProgPeriode1Jaar2/blob/main/Assets/Script/Pickup.cs

Scoreboard.cs

https://github.com/huseyinsr/ProgPeriode1Jaar2/blob/main/Assets/Script/Scoreboard.cs

MovementScript.cs

https://github.com/huseyinsr/ProgPeriode1Jaar2/blob/main/Assets/Script/MovementScript.cs

Er is een player die je kan controleren. Als je aan een coin raakt dan jouw score wordt hooger.

Ik heb met deze opdracht action events geleerd.

----------------------------------------------------------

Les 3

Wat veroorzaakt de bugs?

1. De enemy herkent de speler niet door verkeerde target tags.

2. De kogels hebben geen collision detection.

----------------------------------------------------------
   
Mythe bugsMythe bugsMythe bugs

Wall Jump werkt niet goed

wat er eigenlijk zou moeten gebeuren.

Speler moet van de muur kunnen springen maar soms springt speler niet.

wat er verkeerd gaat.

<img width="833" height="290" alt="Screenshot 2025-11-06 221901" src="https://github.com/user-attachments/assets/688a29db-f990-4f93-8a8c-e1c79e4d460d" />
<img width="433" height="146" alt="Screenshot 2025-11-06 221922" src="https://github.com/user-attachments/assets/4ba5b909-5b24-4287-a49f-1e98ff0ad99e" />

Als cooldown niet reset op tijd kan je niet van muuren springen. Dus werkt het niet altijd.

wat je denkt dat de oorzaak kan zijn.

Cooldown reset te laat waardoor wall jump niet altijd werkt.

evt hoe je denkt dat dit opgelost kan worden

Cooldown en timer systeem aanpassen zodat het goed blijft werken of een niewe script schhrijven voor hele wallJump systeem.

welke vervolg acties nodig zijn.

Script verbeteren en debug toevoegen en testen tijdens wall slide en wall jump.

----------------------------------------------------------

Camera volgt niet bij bat transformatie(het was een oude bug dus heb geen screenshots)

wat er eigenlijk zou moeten gebeuren.

Cameravolg  moet altijd bat en player vvolgen.

wat er verkeerd gaat.

Camera stopt met volgen als je transformeert naar bat.

wat je denkt dat de oorzaak kan zijn.

Camera target verwijst aleen naar player object en dus niet naar bat.

evt hoe je denkt dat dit opgelost kan worden

Camera target altijd updaten tijdens transformeren.

welke vervolg acties nodig zijn.

Script veerbeteren en testen tijdens transformeren.

----------------------------------------------------------

Dash werkt niet na transformatie(het was een oude bug dus heb geen screenshots)

wat er eigenlijk zou moeten gebeuren.

Dash moet altijd goed werken ook na transformeren naar bat.

wat er verkeerd gaat.

Als je transformeert terwijl de dash cooldown nog actief is, kan je daarna niet dashen.

wat je denkt dat de oorzaak kan zijn.

Cooldown staat alleen in het player object en verdwijnt bij bat. Bat krijgt de cooldown niet mee waardoor dash permanent geblokkeerd wordt.

evt hoe je denkt dat dit opgelost kan worden

Cooldown verplaatsen naar parent of manager zodat het werkt ook bij bat. Daardoor kan je nog steeds dashen na het bat vorm.

welke vervolg acties nodig zijn.

Scribt verbeteren. Dash testen voor en na transform

----------------------------------------------------------

Tower Defense bugs

1. Als een toren wordt verwijdert door vijanden kan je daar niet een adere toren bouwen.

<img width="249" height="237" alt="Screenshot 2025-11-05 151122" src="https://github.com/user-attachments/assets/6ef399f0-94a5-4a59-826a-29fdbdcc8709" />

<img width="274" height="232" alt="Screenshot 2025-11-05 151210" src="https://github.com/user-attachments/assets/bae4c502-ef93-499e-b091-dd8b69b0b368" />

In het begin er is een shooter. Die shooter wordt verwijdert door een vijand en kan ik niet meer daar een shooter bouwen(je kan die halfe transparante visual effect zien maar niet iets bouwen). 

<img width="396" height="66" alt="Screenshot 2025-11-05 153103" src="https://github.com/user-attachments/assets/858e159c-0c24-482a-8151-fa999f29e402" />

Wat kan de oorazaak zijn: Elke tile kan detecten als er een shooter is of niet. Als er een shooter is dan kan je daar niet een andere shooter zetten(dat is goed) maar blijft het altijd zo(ook als er is geen shooter meer). 

<img width="361" height="196" alt="Screenshot 2025-11-05 154555" src="https://github.com/user-attachments/assets/92d2c988-18bc-48a1-bd0f-66262b63e5f0" />

Ik moet een betere script schrijven voor detecteren. Het moet altijd blijven deteceteren er is een toren of niet.

----------------------------------------------------------

les 4

![a925l4](https://github.com/user-attachments/assets/a479e1d3-9be6-4b8a-b636-7a3ee7d43c47)

ItemSystem.cs

https://github.com/huseyinsr/ProgPeriode1Jaar2/blob/main/Assets/Script/ItemSystem.cs

Movement.cs

https://github.com/huseyinsr/ProgPeriode1Jaar2/blob/main/Assets/Script/Movement.cs

Shooting.cs

https://github.com/huseyinsr/ProgPeriode1Jaar2/blob/main/Assets/Script/Shooting.cs

UIManager.cs

https://github.com/huseyinsr/ProgPeriode1Jaar2/blob/main/Assets/Script/UIManager.cs

Ik heb de Script van Space48 duidelijker gemaakkt met SRP en DRY methode. 

----------------------------------------------------------

les 5

![a95uom](https://github.com/user-attachments/assets/a37aca89-9dcb-47ff-bb39-97ae561aefda)

EnemyLes5.cs

https://github.com/huseyinsr/ProgPeriode1Jaar2/blob/main/Assets/Script/EnemyLes5.cs

HealthLes5.cs

https://github.com/huseyinsr/ProgPeriode1Jaar2/blob/main/Assets/Script/HealthLes5.cs

ShootFromCamera.cs

https://github.com/huseyinsr/ProgPeriode1Jaar2/blob/main/Assets/Script/ShootFromCamera.cs

Brute.cs

https://github.com/huseyinsr/ProgPeriode1Jaar2/blob/main/Assets/Script/Brute.cs

Elf.cs

https://github.com/huseyinsr/ProgPeriode1Jaar2/blob/main/Assets/Script/Elf.cs

Ik heb een Enemy script gemaakt. Onder de Enemy script ik heb 2 andere script(Elf en Brute) gemaakt als child.

----------------------------------------------------------

les 6

class Tile:

bool hasShooter - read and write 


class Enemy:

System.Action OnEnemyDeath - write only 

void TakeDamage(int amount) - write only


class Health:

int maxHealth - read only 

int currentHealth - read only 

UnityEvent onDamaged - write only 

UnityEvent onDeath - write only 

void TakeDamage(int amount) - write only 


class ToothpasteShooter:

void OnDetectionEnter(Enemy enemy) - write only 

void OnDetectionExit(Enemy enemy) - write only 


class GameManager:

int suns - read and write

GameObject currentShooter - read and write 

static GameManager Instance - read only 

void BuyShooter(GameObject shooterPrefab, Sprite sprite) - write only 


Ik heb 15 class in totaal maar ze zijn helemaal private.





