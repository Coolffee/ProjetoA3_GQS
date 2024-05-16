<h1>ProjetoA3_GQS
Projeto A3 - Gestão e Qualidade de Software - UnP 2024</h1>

<h2>O procedimento de alocar os arquivos por meio do git bash:</h2>

<div>git init<\div>
<div>git pull https://github.com/Coolffee/ProjetoA3_GQS.git</div>
<div>git commit -m "Sua descrição, pode ser data, horario"<\div>
<div>git add .</div>

Se mostrar o erro, exemplo:<div> error: open(".vs/AED/v16/Server/sqlite3/db.lock"): Permission denied error: unable to index file '.vs/AED/v16/Server/sqlite3/db.lock' fatal: adding files failed<\div>
<div>coloque touch .gitignore no git bash</div> 
<div>E coloque dentro do arquivo que .vs/ </div>
<div>E digite novamente git add .</div>
<div>git branch -M main</div> Ou pode ser uma outra banch para caso de querer testar outras versões e modificações utilizadas no código, mas main é a principal para colocar as coisas que estão funcionando 
<div>git remote add origin https://github.com/Coolffee/ProjetoA3_GQS.git
</div>
<div>git push origin main</div>
//se surgir algum erro no git fale no grupo do whats
--------------------
<h2>Mudar de branch para versão mais atualizada (pedroevatest)</h2>

git branch -M pedroevatest
<div>Um adendo que se for para mudar todo o código, crie uma nova branch especifico para você, evitar possíveis problemas futuros de perder o que já está funcionando</div>

![comoCriarumaBRanchNovaPessoalNoProjeto](https://github.com/Coolffee/ProjetoA3_GQS/assets/69175898/e9a9f92a-370f-44bc-a317-9abce79aee60)

## A parte do Source é referente a qual pasta quer se basea para pode puxar os arquivos referente.

