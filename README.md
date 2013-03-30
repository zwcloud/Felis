Felis
==========

概要
-----
.xnb デシリアライゼーション ライブラリ。

基本的には、XBOX LIVE indie games で公開されている Compiled Content Format
サンプル (C++) を C# 化したものであるが、サンプルでは実際に必要とするコンテントのインスタンス化を含まないため、これを汎用的に行う仕組みを追加している。

> Compiled Content Format サンプルについては下記 XBOX LIVE indie games のページを参照。
>
> + [Compiled Content Format (english)](http://xbox.create.msdn.com/en-us/sample/xnb_format)
> + [Compiled Content Format (日本語)](http://xbox.create.msdn.com/ja-JP/sample/xnb_format)

アセンブリ
-----
### Felis
.xnb デシリアライゼーション ライブラリ。Felis は XNA アセンブリから独立。

Felis では、XNA ContentTypeReader に相当する TypeReader クラスが .xnb をフォーマット仕様に基いて解析し、得られた値を順に TypeBuilder へ設定し、TypeBuilder がアセットのインスタンス化を担う。各環境によりインスタンス化に用いるクラスは異なるため、TypeBuilder は具体的なインスタンス化をサブクラスに委ねる抽象クラスである。このため、各環境で利用するコンテント クラスに対して TypeBuilder のサブクラスを定義し、Felis へ登録して利用する手順となる。

> Felis はインスタンス化の抽象化を目的にしているため、より効率的な .xnb 読み込みを必要とする場合には、TypeReader のサブクラスで .xnb を解析すると同時にインスタンス化すべきである。

なお、制限として、Felis では Model、Texture2D、SpriteFont の読み込みのみをサポートする。また、Model は参照するエフェクトが BasicEffect であることを前提としている。

> Felise を利用する他プロジェクトは DirectX 11 対応、かつ、Effect フレームワークを用いないため、Effect に含まれるバイトコードを利用しない。また、Model、Texture2D、SpriteFont 以外を利用する予定も無い。利用プロジェクトが無ければ十分なテストを行えないため、当面は他のアセット形式について対応しない。

### Felis.Samples.ReadXnb
Felis を利用したサンプル アプリケーション。

XNA コンテンツ プロジェクトである Felis.Samples.ReadXnbContent をビルド時に参照するため、ビルドは XNA インストール済みを前提とする。

### Felis.Samples.ReadXnbContent
Felis.Samples.ReadXnb から参照する XNA コンテンツ プロジェクト。

サンプルでは XNA Shadow Mapping サンプルのコンテンツを利用しているが、実際のファイルはリポジトリ管理外としている。このため、XNA Shadow Mapping サンプルから、必要なファイルを手動で配備する必要がある。詳細は Felis.Samples.ReadXnbContent の README を参照のこと。