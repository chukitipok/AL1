# SPECS

- Tous les éléments ont une valeur `sellIn` qui désigne le nombre de jours restant pour vendre l'article.
- Tous les articles ont une valeur `quality` qui dénote combien l'article est précieux.
- A la fin de chaque journée, notre système diminue ces deux valeurs pour chaque produit.
- Une fois que la date de péremption est passée, la qualité se dégrade deux fois plus rapidement.
- La qualité (`quality`) d'un produit ne peut jamais être négative.

- "Aged Brie" augmente sa qualité (`quality`) plus le temps passe.
- La qualité d'un produit n'est jamais de plus de 50.

- "Sulfuras", étant un objet légendaire, n'a pas de date de péremption et ne perd jamais en qualité (`quality`)
- "Backstage passes", 
comme le "Aged Brie", augmente sa qualité (`quality`) plus le temps passe (`sellIn`) ; 
La qualité augmente de 2 quand il reste 10 jours ou moins et de 3 quand il reste 5 jours ou moins, mais la qualité tombe à 0 après le concert.

