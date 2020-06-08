# Uni Clipboard

* 文字列をクリップボードにコピーできるパッケージ

## 使用例

```cs
using Kogane;
using UnityEngine;

public class Example : MonoBehaviour
{
    private void Start()
    {
        Clipboard.SetText( "ピカチュウ" );

        Debug.Log( Clipboard.GetText() );
    }
}

```