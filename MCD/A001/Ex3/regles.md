# Exercice 3

## Classification des règles

### Gestion :

- Un produit peut être en stock dans plusieurs magasins.
- Une commande de réapprovisionnement concerne un fournisseur.
- On tient à jour un stock théorique d’après les mouvements du stock.
- Les mouvements de stock sont :
  - Hors période d’inventaire.
    - Livraison Fournisseur : Stock = Stock + Qté livrée
    - Bon de livraison Client : Stock = Stock — Qté livrée
    - Retour marchandises Client : Stock = Stock + Qté retournée
  - Pendant ou hors période d’inventaire :
    - Ajustement (suite à inventaire ou à écart occasionnel constaté)
    - Stock = Stock +/— écart entre stocks réel et théorique. Les retours marchandises fournisseurs n’entrent pas en jeu car les marchandises sont retournées avant d’avoir été prises en compte dans le stock théorique.

### Organisation :

- Le service achats et les magasins sont équipés de micro-ordinateurs pouvant s’échanger des données sur support magnétique ou via l’infrastructure réseau en place. Le service commercial dispose d’un matériel analogue et d’un accès au même réseau.
- La M.A.J. du stock s’effectue :
  - le matin à 9 heures pour les sorties de stock
  - en temps réel à tout autre moment de la journée pour les autres mouvements de stock
- Le courrier est expédié à 12 heures.
- Dans un magasin, tout produit doit pouvoir être rangé dans un seul casier et tout casier ne doit contenir qu’un seul produit.
- A chaque livraison fournisseur, le magasinier contrôle la marchandise livrée en comparant celle-ci à la marchandise commandée figurant sur le bon de commande fournisseur.
- Les livraisons des fournisseurs sont contrôlées par comparaison avec les commandes. Toute livraison non conforme est refusée et retournée au fournisseur.
