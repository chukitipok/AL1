# Factory

Imaginons le code suivant :

```C#
public class SQLServerBdd
{
	public void OpenConnection(string cnx) { /* Code spécifique SQLServer */ }
	public void CloseConnection() { /* Code spécifique SQLServer */ }
	public string Execute(string sql) { /* Code spécifique SQLServer */ return ""; }
}
```

Nous l'utilisons partout dans le code de la manière suivante :

```C#
var sqlServerBdd = new SQLServerBdd();

sqlServerBdd.OpenConnection("ma chaine de connexion");
var result = sqlServerBdd.Execute("ma requete sql");
sqlServerBdd.CloseConnection();
```

Après quelques temps, il nous est demandé de changer de type de base de donnée pour passer à PostgreSQL et nous créeons donc le code suivant :

```C#
public class PostgreSQLBdd
{
	public void OpenConnection(string cnx) { /* Code spécifique PostgreSQL */ }
	public void CloseConnection() { /* Code spécifique PostgreSQL */ }
	public string Execute(string sql) { /* Code spécifique PostgreSQL */ return ""; }
}
```

Puis nous modifions les utilisations partout dans le code :

```C#
var postgresSQLBdd = new PostgreSQLBdd();

postgresSQLBdd.OpenConnection("ma chaine de connexion");
var result = postgresSQLBdd.Execute("ma requete sql");
postgresSQLBdd.CloseConnection();
```

Finalement, encore après quelques temps, il nous est demandé de pouvoir laisser le choix du type de base de donnée à la personne installant le logiciel... En réfléchissant, nous nous rendons compte que les bases de donnée SQLServer et PostgreSQL offrent globalement le meme service; la chose qui change c'est la manière de réaliser ces services.

Tentons d'unifier les services communs :

```C#
public abstract class Bdd
{
	public abstract void OpenConnection(string cnx);
	public abstract void CloseConnection();
	public abstract string Execute(string sql);
}

public class SQLServerBdd : Bdd
{
	public override void OpenConnection(string cnx) { /* Code spécifique SQLServer */ }
	public override void CloseConnection() { /* Code spécifique SQLServer */ }
	public override string Execute(string sql) { /* Code spécifique SQLServer */ return ""; }
}

public class PostgreSQLBdd : Bdd
{
	public override void OpenConnection(string cnx) { /* Code spécifique PostgreSQL */ }
	public override void CloseConnection() { /* Code spécifique PostgreSQL */ }
	public override string Execute(string sql) { /* Code spécifique PostgreSQL */ return ""; }
}
```

Maintenant il nous suffit de créer la base de donnée en fonction de nos besoins partout dans le code

```C#
Bdd bdd = null;

if (CONFIG == "POSTGRESSQL")
	bdd = new PostgreSQLBdd();
else if (CONFIG == "SQLSERVER")
	bdd = new SQLServerBdd();
else
	throw new Exception("...");

bdd.OpenConnection("ma chaine de connexion");
var result = bdd.Execute("ma requete sql");
bdd.CloseConnection();
```

Nous avons réussi à nous abstraire au niveau de la logique du type de base de donnée mais... la duplication du code de création pose le problème l'évolutivité le jour où nous allons devoir intégrer une nouvelle base de donnée

Tentons de résoudre le problème avec un design pattern appelé Factory :

```C#
public abstract class Bdd
{
	public abstract void OpenConnection(string cnx);
	public abstract void CloseConnection();
	public abstract string Execute(string sql);

	public static Bdd Create(string config)
	{
		if (CONFIG == "POSTGRESSQL")
			return new PostgreSQLBdd();
		else if (CONFIG == "SQLSERVER")
			return new SQLServerBdd();
		else
			throw new Exception("...");		
	}
}
```

Utilisons le :

```C#
Bdd bdd = Bdd.Create(CONFIG);

bdd.OpenConnection("ma chaine de connexion");
var result = bdd.Execute("ma requete sql");
bdd.CloseConnection();
```

Le design pattern factory est un design pattern de création qui permet de factoriser et de cacher les détails de création d'un objet.