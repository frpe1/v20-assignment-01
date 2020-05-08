# Inlämningsuppgift 1

Plattformspel Demo. Inspirerat av antartiskt klimat.
Arbetsnamnet heter "ice ball".

Rulla bollen åt vänster, undvik att ramla ned i havet.
Samla coins för poäng. Du klarar uppdraget
när du träffar den sista "lila" bollen längs åt vänster.

# Controls

Du styr med piltagenterna och hoppar med space tagenten.

# Details

All contents har skapats av mig via Blender.

CamerTriggerZones 

Detta objekt innehåller en rad olika triggers som
hanterar kamerans beteende. Så fort du berör en av punkterna så zoomar kameran in lite eller ut igen.

Kameran i sig är byggd med smooth follow principen,
och skapar en mjuk eftersläpning av kameran,
så upplevelsen känns mer flytande när man rör sig.

Coin

Dessa objekt är de man samlar in och får poäng för.

Portals

Dessa objekt finns under Level/PlatformA och Level/PlatformB. Dessa objekt är skapade med s.k shaders.
och är skriptade så att när man träffar en sådan så förflyttar bollen sig från den nuvarande position till en annan. Därav namnet portals. Så dessa objekt förflyttar objekten från en position till en annan. 

BackgroundObjects

Här finner vi fler objekt i bakgrund, som är isberg,
också egengjorda via Blender.

GameSystem

Detta är ett tomt gameobjekt som är indraget i scenen
vars enda syfte är att köra skript som startas när 
spelet startas initialt. varvid vi då har
en reset funktion som nollställer alla scriptableObjects samt DetaTrigger som ser till att
lyssna på om vi hamnar i havet och sjunker, varvid vi då kastas tillbaks från start igen. 

# Important details about the project

Scenen har också s.k UDP universal renderer pipeline
och postprocessing. Detta för att skapa lite effekter
och förbättra lite resultatet.

