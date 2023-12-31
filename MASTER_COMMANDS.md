```ts
these are keyboard shortcuts compiled from my learning experiences
```

```C#
ctrl + f to search for cli term you are looking for
```
# VSCODE
`open file "side by side" (in new panel)`
```ts
ctrl + \
```

`open file in second panel`
```ts
ctrl + enter
```

`focus file explorer panel`
```ts
ctrl + 0 // <<-- 1, 2, 3 etc.. == panels
```

`focus terminal`
```ts
ctrl + `
```

`focus source control view`
```ts
ctrl + shift + g
```
##### `inside terminal to do "reverse lookup history" (commands entered)`
```ts
ctrl + r
```

`goto/go to definition`
```ts
fn + f12
```

`goto/go to references`
```ts
shift + fn + f12
```

`select current line`
```ts
ctrl + l
```

`open markdown preview`
```ts
ctrl + shift + v
```

`Side by side Markdown edit and preview`
```ts
ctrl + k, v # ctrl + k, then release, press v
```

`change coding language` (inside text editor)
```ts
ctrl + k, m # release ctrl + k, then press m
```

`navigate history (tabs?)`
```ts
ctrl + tab
alt + left # navigate back
alt + right # navigate forward
```

`navigate to specific line`
```ts
ctrl + g
```

`add additional cursors to all occurrences`
```ts
ctrl + shift + l
```

### SSL CERTS:
"caddy" (server caddy) let's encrypt for free (replace nginx & certbot) 
kubernetes --> ingress controller --> for free let's encrypt (replace nginx & certbot)

**vscode**
`ctrl + K + M` --> "change language mode" --> JSON to format JSON stringified object grabbed from browser

# Bash
`following are bash specific`

**EXPLORER WINDOWS FILE SYSTEM**
`open windows file explorer GUI for WSL`
```ts
explorer.exe .
```
##### How to `echo` or `cat` write to a file with Bash:
```ts
cat >> /path/to/existingFile.text<< EOF
some text line 1
some text line 2
some text line 3
EOF
```
switch `cat >>` to `cat >` to create a file instead of append
```ts
cat > /path/to/newFile.text<< EOF
some text line 1
some text line 2
some text line 3
EOF
```

`(( expression ))` <-- this will execute/perform an expression

`print BASH env`
```ts
printenv
```

`echo variables` (example how to access vars in BASH)
```ts
echo $LANG # <-- LANG env var (bash)
```

`$RANDOM in BASH will create a random number`
```ts
echo $RANDOM # <-- 22024 : between 0 and 32767
```

```ts
I=0 # <-- passing this in the terminal will persist a var
(( I++ )) # <-- I will now become 1 and persist
# we don't need to prepend $ for vars in (( expression ))
```

`this will print expressions for (( expression )) operations`
```ts
help let
```
##### `View file "long" with permissions list`
```ts
ls -l
```

`-rw-r--r--` in front of the file indicates the permissions: **`r` = read, `w` = write, `x` = execute**
**output:** `-rwxr-xr-x` <-- see **`x`** by 3 different "users" (all users can execute now)
##### `Give executable permissions to a file`
```ts
chmod +x filename.whatever
```

`man` command is "manual" (like `help`)
```ts
man bash # <-- prints manual for bash
man sleep # <-- prints manual for sleep (binary)
```

**`-e` flag needed for special characters**
```ts
echo -e "\n~~ Countdown Timer ~~\n"
```

`lists root of the file system`
```ts
ls /
```
_ls /bin will list all binaries on the file system. Bash lives here: #!/bin/bash which will use bash commands. we can access other binaries or libraries here_


`lists bash commands`
```ts
help
```

`things we can pass to the bash TEST command (for testing true/false (for ifs or [[ EXPRESSIONS ]]))
```ts
help test
```

```ts
( expression ) # <-- evaluates expression/returns value
```

```ts
help [[ expression ]] # <-- output below
```

      ( EXPRESSION )    Returns the value of EXPRESSION
      ! EXPRESSION              True if EXPRESSION is false; else false
      EXPR1 && EXPR2    True if both EXPR1 and EXPR2 are true; else false
      EXPR1 || EXPR2    True if either EXPR1 or EXPR2 is true; else false

    When the `==' and `!=' operators are used, the string to the right of
    the operator is used as a pattern and pattern matching is performed.
    When the `=~' operator is used, the string to the right of the operator
    is matched as a regular expression.  

    The && and || operators do not evaluate EXPR2 if EXPR1 is sufficient to
    determine the expression's value.

    Exit Status:
    Returns success if EXPR evaluates to true; fails if EXPR evaluates to
    false or an invalid argument is given.

**`we can evaluate any expression in the BASH terminal or .sh script:`**
```ts
[[ 4 -le 5 ]] # <-- `-le` === less-than-or-equal
```

`echo $?`
```ts
echo $? # <-- prints last bash command's EXIT STATUS
0 # <-- 0 === true (0 === no errors)

[[ 4 -ge 5 ]]
echo $?
1 # <-- 1 === false (> 0 === contains errors | "false")
```

```ts
[[ 4 -ge 5 ]]; echo $? # <-- run multiple comands on single line with `;`
1 # <-- output
```

**_we can think of `0` return as TRUE but it actually means `command had 0 errors`_** (***EXIT STATUS***)

`check if a file exists (and output EXIT STATUS)` **`-a | -e`**
_THIS WILL CHECK THE FOLDER FROM WHERE THE COMMAND WAS ENTERED_
```ts
[[ -a countdown.sh  ]]; echo $?
0 # <-- output 0 if file exists
```

`to list all variables in BASH`
```ts
declare -p
```


`all variables: @ | *`
```ts
ARR=("a" "b" "c")
echo ${ARR[@]}

declare -p ARR 
# --> declare -a ARR=([0]="a" [1]="b" [2]="c")
# --> -a === array
```


### Node

`find all running node processes`
```ts
ps -ef | grep node
```

`find node process by port`
```ts
lsof -i :3000
```

`kill process`
```ts
kill -9 PROCESS_ID 
```
### Read (capture user INPUT)

`capture user input`
```ts
read
```

### Debugging in Bash

`set -x` _at the top of a script enables debugging (printing executed commands to the terminal)_
```ts
#!/bin/bash

set -x

# Your script goes here
```

### CRON
**For Ubuntu/Debian, you can find `cron`logs at:**
```ts
/var/log/syslog
```

# Postman

`variables created/stored in "Environments" in postman can be passed into fields using double curlys`
```ts
Client ID: {{google_client_id}}
Client Secret: {{google_client_secret}}
```


# Misc.

```ts
grep nri // <-- 
```

##### `To get a list of all listening TCP ports using lsof`
```ts
sudo lsof -nP -iTCP -sTCP:LISTEN
```

##### `using ss tool (formerly netstat) to list all open ports`
```ts
ss -tulpn
```

# Tree

`tree [OPTIONS] [directory]` ("`.`" might not be necessary)
`List folder structure only directories from current directory`
```ts
tree -d .
```

`List folder structure only directors at depth 1`
```ts
tree -d -L 1 .
```

`List folder structure and all hidden files`
```ts
tree -a .
```

# Ubuntu
`check Ubuntu version`
```ts
lsb_release -a
```

`search for software to install` `<application>`
```ts
sudo apt search <audacity>
```

`install from cli`
```ts
sudo apt install audacity
```

`killall <-- terminates process`
```ts
killall <snap-store>
```

# Oh My ZSH!

`runs zsh powerlvl10k setup (prompt styling)`
```ts
p10k configure
```

# Windows

`inside file explorer:`
```C#
ctrl + l // focus address bar
cmd      // enter cmd to open cmd in this location
```

# Command Prompt

`display directory contents`
```C#
dir // <<-- windows/cmd version of `ls`
```
# Powershell

`find windows IPs`
```powershell
ipconfig
```

`find WSL IPs`
```powershell
wsl hostname -i
wsl hostname -I
```

`open Visual Studio IDE latest version`
```powershell
start devenv
```

`open Visual Studio IDE specific solution (folder or file)`
```powershell
start devenv solution1.sln # file extension? solution?
# because I have multiple VS installed on my machine, i need to include the entier absolute path to the executable in order to run from CLI
```

`open current folder in windows explorer`
```powershell
ii . # <<-- alias Invoke-item
```

`create a new file`
```powershell
New-Item example.txt
```

`delete recursive rm -rf`
```C#
Remove-Item -Recurse -Force <path>
```
# .NET

`restore nuget packages`
```C#
dotnet restore
```

`run C# program.cs (entry point)`
```powershell
dotnet run
```

`create new console app .NET`
```powershell
dotnet new console -o ./CsharpProjects/TestProject
# pass `--use-program-main` for Program Class template
```

(VSCODE)
`generate assets for build and debug`
```C#
ctrl + shift + p // cmd pallette
// enter ".net: g"
// select ".NET: Generate Assets for Build and Debug"
```
should see this:
![[Pasted image 20231121161946.png]]
# Visual Studio

`run application`
```ts
ctrl + fn + f5 # <<-- default run
fn + f5 # <<-- debug run (slower)
```

`open terminal (View.Terminal) shortcut added`
```ts
ctrl + shift + t
```

`quick launch`
```ts
ctrl + q # search commands keywords e.g: "new"
```

`multiline comment`
```ts
shift + alt + a # multi line /* */

ctrl + k, ctrl + / # single line (can be multi) //

ctrl + k, ctrl + c # alternate single line comment
ctrl + k, ctrl + u # uncomment
```

`see all references`
```C#
alt + 2 // <<-- shows where used
```

`<summary></summary> C#Docs`
```C#
/// <-- will auto populate this...
/// <summary>
/// Comment goes here
/// </summary>

// e.g.
/// <summary>
/// Comment goes here
/// </summary>
/// 
```
### Create
`create a new file in project`
```ts
shift + fn + f2 # with Add New File extension
---
ctrl + shift + a
ctrl + n # alternate option
ctrl + shift + n # new project
```

`create new Class in project` (custom) (j === insert)
```c#
ctrl + shift + j, c // release then press c
```

`create new Interface in project` (custom) (j === insert)
```c#
ctrl + shift + j, i // release then press i
```

`format`
```ts
ctrl + k, ctrl + d # formats entire DOCUMENT (d = doc)
ctrl + k, ctrl + f # formats selection (f = format)
```
### Navigate

`focus text editor`
```ts
esc # literally, just hit escape once...
```

`navigate tabs | close tabs`
```ts
ctrl + tab # next tab
ctrl + shift + tab # prev tab
ctrl + fn + f4 # close active tab
alt + w + l # close all tabs
```

`navigate to solution explorer`
```ts
ctrl + alt + l # ctrl + tab navigate tabs here too
ctrl + ; # to solution explorer w/ search bar
```

`go to line start`
```ts
fn + k # k === "home"
ctrl + / + leftArrow # Edit.LineStart
```

`go to line end`
```ts
fn + , # , === "end"
ctrl + / + rightArrow # Edit.LineEnd
```

`go to Class(?)`
```C#
ctrl + click // highlighted class
```

`Go To`
```ts
ctrl + g # go to line
fn + f12 # go to definition
ctrl + fn + f12 # go to declaration
ctrl + d # go to next (highlighted selection)
```

`Go To All` (NICE)
```ts
ctrl + t # backspace to clear out "symbol"
```

`find closing brace`
```ts
ctrl + ]
```

`add cursor above/below`
```ts
ctrl + alt + upArrow
ctrl + alt + downArrow
```

`collapse/expand code blocks`
```ts
ctrl + m, ctrl + m
```

`replace`
```ts
ctrl + h
```

`delete to...`
```ts
ctrl + delete # delete to start of word
ctrl + backspace # delete to end of word
```

`save all`
```ts
ctrl + shift + s
```

`view in browser`
```ts
ctrl + shift + w
```

`bookmark` (_a keyboard chord is multiple shortcuts in a row_)
```ts
ctrl + k, ctrl + k
```
- `View >> Bookmark Window` to view all Bookmarks

`next split pane`
```ts
fn + f6
```

`collapse markup element (html)`
```C#
ctrl + m, ctrl + m
```
### Debugger:
`add breakpoint (highlight line first)`
```ts
fn + f9 # <<-- press again to remove
```
`continue to next breakpoint (inside debugger)`
```ts
fn + fn5
```
`step over (inside debugger)`
```ts
fn + f10
```
`step into method (inside debugger)`
```ts
fn + f11
```
`step out of method (if accidentally stepped in)`
```ts
shift + fn + fn11
```
`exit debugger`
```ts
ctrl + shift + fn + f5
```
---

`replace (find and replace)`
```ts
ctrl + h
```

`rename all properties`
```ts
ctrl + r, ctrl + r
```

`solution explorer (folder explorer)`
```ts
ctrl + alt + l
```

`copyLinesDown (without VSCode extra mappings`
```ts
ctrl + d
```

`alternate copyLinesDown option`
```ts
# without any selection 
ctrl + e
ctrl + v
alt + up/down # <<-- to move
```

`extensions with .user will not get checked-in`
```ts
httpenv.json.user
```

`auto fix suggestions`
```ts
alt + enter 
```

`compile/build application` show error/warning outputs
```ts
ctrl + shift + b
```

#### Refactor
`extract method`
```C#
ctrl + r, ctrl + m
```

#### Object Browser
```ts
ctrl + alt + j
```
- `ctrl + click` on `var` or `type identifier` to open object definition, which will show all attributes and methods on datatype "constructor" parent object ("`struct`" in C#) (available methods)

#### CODE SNIPPETS (inside VS)
- enter these aliases inside your IDE text editor
`Console.WriteLine()`
```ts
cw # press tab twice
```
`public CodeSnippetExamples() { }` "Constructor"
```ts
ctor # press tab twice
```
`public string LastName { get; set; }` "Property"
```ts
prop # press tab twice
propfull # <-- creates FULL prop w/ getter & setter
```
`try { } catch (Exception) { throw; }` try/catch block
```ts
try # press tab twice
tryf # try/finally block
```
- instantiate the Exception inside `catch (... ex)`
`for loop`
```ts
for # press tab twice
forr # for loop decrement
```
`foreach loop` including collection
```ts
var names = new List<string>();
foreach # press tab twice
```
- will output: `foreach (var name in names) { }`
`while loop`
```ts
while # press tab twice
```
`do { } while (true);`
```ts
do # press tab twice
```

`populate snippets from context menu`
```ts
ctrl + k, ctrl + x
# for example, surround With or e.g. Wrap {} w/ braces
```

---

