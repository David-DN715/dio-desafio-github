#Inicio para criar uma chave ssh no git:
*  ~
- $ ssh-keygen -t ed25519 -C *******@e-mail.com
Generating public/private ed25519 key pair.
Enter file in which to save the key  (/c/Users//.ssh/): ******

Enter passphrase (empty for no passphrase):
Enter same passphrase again:
Your identification has been saved in *****
Your public key has been saved in *******.pub
The key fingerprint is:

The key's randomart image is:



## repeti o primeiro passo por errar:
* 
Generating public/private  key pair.
Enter file in which to save the key (/c/Users//):
Enter passphrase (empty for no passphrase):
Enter same passphrase again:
Your identification has been saved in /c/Users/
Your public key has been saved in /c/Users/gabri/.ssh/id_*****.pub
The key fingerprint is:
The key's randomart image is:

chave publica:

- proximo passo:
$ eval $(ssh-agent -s)
Agent pid

- proximo passo
$ ssh-add 
Enter passphrase for :
Identity added: 

## algumas configurações 

* /c/workspace/livro-receitas (master)
$ git config --global user.email "qualquerum@e-mail.com"

* /c/workspace/livro-receitas (master)
$ git config --global user.name "name.user"



## primeiro passo com git ini e git add e git commit

* /c/workspace/livro-receitas (master)
$ git add *

* /c/workspace/livro-receitas (master)
$ git commit -m "commit inicial"
[master (root-commit) e3f5623] commit inicial
 1 file changed, 23 insertions(+)
 create mode 100644 strogonoff.markdown





---------------------------------------------------------------------------------------
### How to push for github?

* /c/workspace/livro-receitas (master)
$ git remote add origin "repository and you acess"

- this comand show a origin repositori:
* /c/workspace/livro-receitas (master)
$ git remote -v
origin  Show repositori (fechet)
origin  show repositori (push)

* /c/workspace/livro-receitas (master)
$ git status
On branch master
nothing to commit, working tree clean

* /c/workspace/livro-receitas (master)
$ git push origin master
Enter passphrase for key '/c/Users/:
Enumerating objects: 8, done.
Counting objects: 100% (8/8), done.
Delta compression using up to 8 threads
Compressing objects: 100% (6/6), done.
Writing objects: 100% (8/8), 1.08 KiB | 138.00 KiB/s, done.
Total 8 (delta 0), reused 0 (delta 0), pack-reused 0
To github.com:David-DN715/livro-receitas.git
 * [new branch]      master -> master
