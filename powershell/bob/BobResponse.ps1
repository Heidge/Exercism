Function Get-BobResponse() {
    <#
    .SYNOPSIS
    Bob is a lackadaisical teenager. In conversation, his responses are very limited.
    
    .DESCRIPTION
    Bob is a lackadaisical teenager. In conversation, his responses are very limited.

    Bob answers 'Sure.' if you ask him a question.

    He answers 'Whoa, chill out!' if you yell at him.

    He answers 'Calm down, I know what I'm doing!' if you yell a question at him.

    He says 'Fine. Be that way!' if you address him without actually saying
    anything.

    He answers 'Whatever.' to anything else.
    
    .PARAMETER HeyBob
    The sentence you say to Bob.
    
    .EXAMPLE
    Get-BobResponse -HeyBob "Hi Bob"
    #>
    [CmdletBinding()]
    Param(
        [string]$HeyBob
    )
    [string]$HeyBobUpper = $HeyBob.ToUpper()
    [string]$HeyBobTrim = $HeyBob.Replace(' ','')
    [string]$HeyBobTrimUpper = $HeyBobTrim.ToUpper()

    if (([string]::IsNullOrWhiteSpace($HeyBob) -eq $HeyBob) -or ([string]::Empty -eq $HeyBob))
    {
        Write-Output "Fine. Be that way!"
    }
    else
    {
        if ($HeyBob -ceq $HeyBobUpper -and $HeyBob -match '[A-Za-z]')
        {
            if ($HeyBobTrim[-1] -eq '?')
            {
                Write-Output "Calm down, I know what I'm doing!"
            }
            else
            {
                Write-Output "Whoa, chill out!"
            }
        }
        else
        {
            if ($HeyBobTrim[-1] -eq '?')
            {
                Write-Output 'Sure.'
            }
            else
            {
                Write-Output 'Whatever.'
            }
        }  
    }
}
