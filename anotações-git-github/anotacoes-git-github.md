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
______________________________________________________________________________________________________________________

# Started a little project!


* PCuser_bash/c/dio-github-desafio
$ git clone chave_do_repositorio_a_clonar
Cloning into 'dio-desafio-github'...
Enter passphrase for key '/c/Users/:
remote: Enumerating objects: 6, done.
remote: Counting objects: 100% (6/6), done.
remote: Compressing objects: 100% (4/4), done.
remote: Total 6 (delta 1), reused 0 (delta 0), pack-reused 0
Receiving objects: 100% (6/6), done.
Resolving deltas: 100% (1/1), done.

* PCuser_bash /c/dio-github-desafio
$ cd dio-desafio-github/

* PCuser_bash /c/dio-github-desafio/dio-desafio-github (main)
$ ls
README.md

* PCuser_bash /c/dio-github-desafio/dio-desafio-github (main)
$ ls
README.md  anotações-git-github/

* PCuser_bash /c/dio-github-desafio/dio-desafio-github (main)
$ cd anotações-git-github/

* PCuser_bash/c/dio-github-desafio/dio-desafio-github/anotações-git-github (main)
$ echo > anotacoes-git-github.md

* PCuser_bash /c/dio-github-desafio/dio-desafio-github/anotações-git-github (main)
$ ls
anotacoes-git-github.md

* PCuser_bash/c/dio-github-desafio/dio-desafio-github/anotações-git-github (main)
$ cd ..

* PCuser_bash /c/dio-github-desafio/dio-desafio-github (main)
$ git status
On branch main
Your branch is up to date with 'origin/main'.

Untracked files:
  (use "git add <file>..." to include in what will be committed)
        "anota\303\247\303\265es-git-github/"

nothing added to commit but untracked files present (use "git add" to track)

* PCuser_bash /c/dio-github-desafio/dio-desafio-github (main)
$ git add *

* PCuser_bash /c/dio-github-desafio/dio-desafio-github (main)
$ git status
On branch main
Your branch is up to date with 'origin/main'.

Changes to be committed:
  (use "git restore --staged <file>..." to unstage)
        new file:   "anota\303\247\303\265es-git-github/anotacoes-git-github.md"
        
* PCuser_bash /c/dio-github-desafio/dio-desafio-github (main)
$ git commit -m "anotações do curso de git e github"
[main 31de300] anotações do curso de git e github
 1 file changed, 91 insertions(+)
 create mode 100644 "anota\303\247\303\265es-git-github/anotacoes-git-github.md"

* PCuser_bash /c/dio-github-desafio/dio-desafio-github (main)
$ git status
On branch main
Your branch is ahead of 'origin/main' by 1 commit.
  (use "git push" to publish your local commits)

nothing to commit, working tree clean

* PCuser_bash /c/dio-github-desafio/dio-desafio-github (main)
$ git origin -v
git: 'origin' is not a git command. See 'git --help'.

* PCuser_bash /c/dio-github-desafio/dio-desafio-github (main)
$ git push origin main
Enter passphrase for key '/c/Users/:
Enumerating objects: 5, done.
Counting objects: 100% (5/5), done.
Delta compression using up to 8 threads
Compressing objects: 100% (4/4), done.
Writing objects: 100% (4/4), 1.25 KiB | 638.00 KiB/s, done.
Total 4 (delta 0), reused 0 (delta 0), pack-reused 0
To github.com:David-DN715/dio-desafio-github.git
   d09fabc..31de300  main -> main
