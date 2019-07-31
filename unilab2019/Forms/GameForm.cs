using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace unilab2019.Forms
{
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NumOfLines_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// フレームごとに実行する処理(ロジック部分)を書く。
        /// </summary>
         #region 毎フレーム処理
        private void globalTimer_Tick(object sender, EventArgs e)
        {
            _update();
            _draw();

            goalPictureBox.Visible = false;

            // ゴールに着いたらタイマーを止める
            if (_field.Player.Intersect(_field.Goal))
            {
                globalTimer.Stop();
                _pressedKeys.Clear();
                exeCodeStack.Clear();
                endlessFlag = false;
                isGoaledDictionary[_field.StageName] = true;
                MPTextBox.Text = $"行数: {codeListBox.Items.Count}　　目標: {desiredMP}";
                PedometerTextBox.Text = $"時間: {_field.Player.Pedometer}　　目標: {_field.Player.DesiredPedometer}";
                goalPictureBox.Visible = true;

                if (!isAllGoaledFlag)
                {
                    isAllGoaledFlag = true;
                    foreach (bool goaled in isGoaledDictionary.Values)
                    {
                        if (!goaled) isAllGoaledFlag = false;
                    }
                    if (isAllGoaledFlag)
                    {
                        allGoaledPictureBox.Visible = true;
                        ChangeCode();
                        _initialize(_field.StageName);
                        allGoaledPictureBox.Focus();
                    }
                } 
            }
        }

        /// <summary>
        /// フレームごとに実行する処理(描画部分)を書く。
        /// まだ2018の流用したままなのでそのまま
        /// </summary>
        private void _draw()
        {
            _graphicsFore.Clear(Color.Transparent);
            foreach (var obj in _field.GameObjectList())
            {
                if (obj != null && obj.CanMove) obj.Draw(_graphicsFore, CellWidth, CellHeight);
            }
            Refresh();
            HPTextBox.Text = $"HP: {_field.Player.HP}/{_field.Player.MaxHP}";
            if (isGoaledDictionary[_field.StageName])
            {
                MPTextBox.Text = $"行数: {codeListBox.Items.Count}　　目標: {desiredMP}";
                PedometerTextBox.Text = $"時間: {_field.Player.Pedometer}　　目標: {_field.Player.DesiredPedometer}";
            }
            else
            {
                MPTextBox.Text = $"行数: {codeListBox.Items.Count}　　目標: ?";
                PedometerTextBox.Text = $"時間: {_field.Player.Pedometer}　　目標: ?";
            }
        }

        /// <summary>
        /// コード実行時の毎フレーム処理
        /// </summary>
        private void codeTimer_Tick(object sender, EventArgs e)
        {
            //テレポーターがプレーヤーの座標と同じになるかどうかの判定？　よくわからない
            if (IsTeleporter(_field.Player.X, _field.Player.Y) )
            {
                TeleporterPairId = _field.Teleporters.Find(t => t.X == _field.Player.X && t.Y == _field.Player.Y).PairId;
                TeleportDestination = _field.Teleporters.Find(t => t.PairId == TeleporterPairId && (t.X != _field.Player.X || t.Y != _field.Player.Y));
                _field.Player.X = TeleportDestination.X;
                _field.Player.Y = TeleportDestination.Y;
                _field.Player.Direction = TeleportDestination.Direction;
                _field.Player.Pedometer++;
            }
            else if (!_field.Player.Intersect(_field.Goal))
            {
                canMoveNextCode = true;
                while (exeCodeStack.Count > 0 && canMoveNextCode) exeCodeStack.Peek().MoveNext();
            }

            //プレーヤーの残機判定があるかないかの判定、残機0になったらコード消去してプレーヤーをリセット？？　
            //これも2018の流用
            if (IsSwamp(_field.Player.X, _field.Player.Y)) _field.Player.HP--;
            if (_field.Player.HP <= 0)
            {
                exeCodeStack.Clear();
                endlessFlag = false;
                _initializePlayer();
            }
        }
        #endregion
    }
}
