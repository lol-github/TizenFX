/*
 * Copyright (c) 2016 Samsung Electronics Co., Ltd All Rights Reserved
 *
 * Licensed under the Apache License, Version 2.0 (the License);
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an AS IS BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */


namespace ElmSharp.Test.Wearable
{
    class LabelTest1 : WearableTestCase
    {
        public override string TestName => "LabelTest1";
        public override string TestDescription => "To test basic operation of Label";

        public override void Run(Window window)
        {
            Background bg = new Background(window);
            bg.Color = Color.White;
            bg.Move(0, 0);
            bg.Resize(window.ScreenSize.Width, window.ScreenSize.Height);
            bg.Show();

            Label label1 = new Label(window);
            label1.Color = Color.Black;
            label1.Text = "Label Test!!!";

            label1.Show();
            int width = 200;
            int height = 30;
            label1.Resize(width, height);
            label1.Move(window.ScreenSize.Width/2 - width/2, window.ScreenSize.Height/2 - height/2);
        }

    }
}
