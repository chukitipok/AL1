# Decorator

Imaginons le code suivant :

```C#
public class MailNotifier
{
	public void Send(User user, string message) { /* Code envoi mail */ }
}
```

Nous l'utilisons partout dans le code de la manière suivante :

```C#
var mailNotifier = new MailNotifier();

if (user.Email != null)
    mailNotifier.Send(user, "hello");
```

Après quelques temps, on nous demande d'ajouter la possibilité de notifier les utilisateurs par SMS. Nous ajoutons donc le code suivant :

```C#
public class MailNotifier
{
	public void Send(User user, string message) { /* Code envoi mail */ }
}

public class SmsNotifier
{
	public void Send(User user, string message) { /* Code envoi sms */ }
}
```

```C#
var mailNotifier = new MailNotifier();
var smsNotifier = new SmsNotifier();

if (user.Email != null)
    mailNotifier.Send(user, "hello");

if (user.PhoneNumber != null)
    smsNotifier.Send(user, "hello");
```

Puis encore après quelques temps, on nous demande d'ajouter nouveau un moyen de notifier. Nous modifions en conséquence notre code de la manière suivante : 

```C#
public class MailNotifier
{
	public void Send(User user, string message) { /* Code envoi mail */ }
}

public class SmsNotifier
{
	public void Send(User user, string message) { /* Code envoi sms */ }
}

public class SlackNotifier
{
	public void Send(User user, string message) { /* Code envoi slack */ }
}
```

```C#
var mailNotifier = new MailNotifier();
var smsNotifier = new SmsNotifier();
var slackNotifier = new SlackNotifier();

if (user.Email != null)
    mailNotifier.Send(user, "hello");

if (user.PhoneNumber != null)
    smsNotifier.Send(user, "hello");

if (user.PhoneNumber != null)
    slackNotifier.Send(user, "hello");
```

Il est facile de constater que plus nous allons ajouter des nouveaux comportement, plus nous allons devoir modifier le code orchestration et le faire grossir. Tentons d'améliorer les choses :

```C#
public interface INotifier 
{
   Send(User user, string message); 
}

public class MailNotifier
{
	public void Send(User user, string message) 
    { 
        if (user.Email != null)
            /* Code envoi mail */ 
    }
}

public class SmsNotifier
{
    private INotifier notifier;

    public SmsNotifier(INotifier notifier)
    {
        this.notifier = notifier;
    }

	public void Send(User user, string message) 
    { 
        if (user.PhoneNumber != null)
            /* Code envoi sms */ 
    }
}

public class SlackNotifier
{
    private INotifier notifier;
    
    public SlackNotifier(INotifier notifier)
    {
        this.notifier = notifier;
    }

	public void Send(User user, string message) 
    { 
        if (user.PhoneNumber != null)
            /* Code envoi slack */ 
    }
}
```

```C#
var mailNotifier = new MailNotifier();
var smsNotifier = new SmsNotifier();

if (user.Email != null)
    mailNotifier.Send(user, "hello");

if (user.PhoneNumber != null)
    smsNotifier.Send(user, "hello");
```

Utilisons le :

```C#
var notifier = new new SlackNotifier(new SmsNotifier(new EmailNotifier()))
notifier.Send(user, "hello");
```

Le design pattern decorator est un design pattern structurel d'ajouter un comportement à un objet sans le modifier.

