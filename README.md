# Unity ゲームジャム　　題名「おくる」

#### 作成

- 2023 年 12 月 23 日：作成開始
- 2023 年 12 月 26 日：初期版公開 ver:0.80
- 2023 年 12 月 26 日：画面サイズの修正・ゲーム性の修正 ver1.00 公開

### お題：「おくる」

## 概要

今回初めての Unity ゲームジャムで，短い期間でゲームを作ってみる体験をしようと考えてとりあえずゲームを作る．

## 作成するゲームについて

### 題名：「お」くる

### [「お」くる 詳細ページへ](okuru_detail.md)

Unity ゲームジャムゲームページ：「[https://unityroom.com/games/o-kuru](https://unityroom.com/games/o-kuru)」

### 簡単なゲーム説明

「お」があなたに向かってきます笑．クリックまたは，タップをしてやってくる「お」だけを倒してください．「お」が規定より近づいたらあなたの負けです．
「お」を倒す簡単シューティングゲーム？？

### 推奨環境

- ゲーム環境：Web で PC または，スマホの横画面
- 画面サイズ：1920X1080

## 使用した技術

- Unity (2022.3.6f1)
- C#
- Figma

## Unity ゲームジャムとは

Unity を使って 1 週間でゲームを作るイベント．Unity がインストールされた PC とインターネット環境があれば誰でも参加できる．
月曜 0 時にお題が発表されて，日曜 20 時までにゲームを作って投稿する．
お題についても多少こじつけても大丈夫．ゲーム作りを楽しくことを心がける．
ブラウザで遊べる WebGL 形式でビルドし，unityroom に投稿する．

## WebGL とは？

WebGL とは（Web Graphics Library）で，互換性があるウェブブラウザでプラグインを使用せずにインタラクティブな 3D グラフィックスや 2D グラフィックスをレンダリングするための，JavaScriptAPI．

### Unity で WebGL ビルド方法

<参考サイト>

- [unity WebGL ビルド方法](https://blog.naichilab.com/entry/2017/04/29/125527)
- [【unity】WebGL ビルド方法 ② CloudBuild の利用](https://blog.naichilab.com/entry/cloud-build-webgl)
- [【unity】unityroom に投稿する方法](https://blog.naichilab.com/entry/how-to-upload-unityroom)

1. ゲームを作る
2. プラットフォームを切り替え<br>
   File→BuildSetting を開く．SwitchPlatform を押す．
3. ビルド対象シーンを追加<br>
   BuildSetting の画面でビルド対象となるシーンを選んでおく必要がある．
4. ビルド実行<br>
   BuildSetting の画面で，Build もしくは，Build And Run（実行まで確認する場合）を押す．保存フォルダ名を決める．
5. 出力されたファイルの確認<br>
   Build 時に選択したフォルダに下記ファイルが出力される．

### unityroom 　に投稿する

1. WebGL にゲームをビルドする
2. unityroom にログインする
3. 新規ゲームを作成する<br>
   ヘッダー → ゲームを登録する．タイトルとゲーム ID，簡単な説明を入力して，登録．
   タイトル：ゲームのタイトル．ゲーム ID：URL の一部として使われる文字列．自由．
4. アイコンの登録<br>
   サイドバーの基本情報メニュー．アイコンを選択して更新する．
5. スクリーンショットを登録（任意）<br>
   サイドバーのスクリーンショットメニュー
6. WebGL の設定<br>
   サイドバーの WebGL 設定
   Unity のバージョンや表示サイズ，メモリは任意で入力
7. WebGL アップロード<br>
   拡張子を見て設定して下さい．
8. カテゴリー（任意）
9. タグ設定（任意）
10. イベント参加（任意）<br>
    サイドバーのイベント参加メニュー．Unity1 週間ゲームジャムにだすならここで設定
11. 使用アセット，関連記事（任意）
12. Android/iOS ストアリンク設定（任意）
13. その他（任意）
14. 公開設定<br>
    一般公開

### gz ファイルでビルドする方法

1. project settings を開く
2. publish settings の項目に移動する
3. Brip となっているものを，Gzip に変更する．

### 参考

1. [UnityGameJam](https://unityroom.com/unity1weeks) - 2023 年 12 月
2. [WebGL とは](https://try-m.co.jp/blog/web-create/7350/) - 2023 年 12 月
