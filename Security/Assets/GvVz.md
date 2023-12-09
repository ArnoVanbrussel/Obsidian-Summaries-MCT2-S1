Het Grootvader-vader-zoon (GvVz) systeem is een methode voor het organiseren van backups om verschillende versies van gegevens op te slaan. Het is een vorm van incrementele backups die een historische reeks van gegevens behouden, waardoor je teruggaat in de tijd naar verschillende punten van opslag.

- **Grootvader (Grandfather):** Dit vertegenwoordigt de oudste backuplaag in het systeem. Normaal gesproken wordt deze minder frequent bijgewerkt en bewaard voor langere periodes, zoals wekelijkse of maandelijkse backups. Deze oudste backups dienen als referentiepunten voor de lange termijn en worden minder vaak gewijzigd.

- **Vader (Father):** Dit is een tussenlaag tussen de oudste en de meest recente backups. Vaderbackups worden vaak dagelijks gemaakt en behouden gegevens van de afgelopen weken of maanden. Ze fungeren als een tussenliggende historische versie tussen de grootvader- en zoonbackups.

- **Zoon (Son):** Dit vertegenwoordigt de meest recente laag in het backupproces. Zoonbackups worden meestal dagelijks of zelfs meerdere keren per dag gemaakt. Ze bevatten de meest actuele gegevens en zijn het snelst toegankelijk voor het geval dataverlies optreedt.

Deze aanpak maakt het mogelijk om gegevensherstel uit te voeren op basis van verschillende tijdsperioden. Als er bijvoorbeeld gegevens beschadigd raken of per ongeluk worden verwijderd, kun je teruggaan naar een specifiek punt in de tijd en de benodigde versie herstellen, afhankelijk van hoe lang je teruggaat in de GvVz-hiërarchie.

Dit systeem zorgt voor een evenwicht tussen het behoud van recente wijzigingen en het opslaan van oudere, stabiele versies van gegevens, waardoor organisaties zich kunnen beschermen tegen verschillende vormen van dataverlies.