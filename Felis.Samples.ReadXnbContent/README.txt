Felis.Samples.ReadXnb.Program クラスは、XNA Shadow Mapping サンプルに含まれる
"dude" アセットを読み込むように実装してあります。
しかし、"dude" アセットは総ファイル サイズが大きいため、GitHub のリポジトリ
管理から除外しています。このため、手動で XNA Shadow Mapping サンプルより
"dude" アセットをコピーして配備する必要があります。

あるいは、"dude" アセットを必要としないならば、該当するアセットのロード処理を
コメントアウトするなり、自分が必要とするアセットをコンテンツ プロジェクトへ
登録して呼び出すように変更するなどしても良いでしょう。

XNA Shadow Mapping サンプルから "dude" アセットをコピーする場合には、以下の
ファイルを配備して下さい。

    dude.fbx
    head.tga
    headN.tga
    headS.tga
    jacket.tga
    jacketN.tga
    jacketS.tga
    pants.tga
    pantsN.tga
    pantsS.tga
    upBodyC.tga
    upBodyC2.tga
    upbodyN.tga
    upbodyS.tga

また、上記ファイルを配置した後、以下のファイルをコンテンツ プロジェクトへ
手動で追加してください。

    dude.fbx

各ファイルに対するパイプライン設定は、XNA ShadowMapping サンプルの値を
参考に設定して下さい。
