namespace Frank.Libraries.ML.CharacterRecognition;

internal class Garbage
{
    //
    //
    //
    // static object NeuralNetRenderer(Trainer trainer)
    // {
    //     const int MaxItemsToDisplay = 100;
    //
    //     var net = trainer.Net;
    //     var firingNet = new FiringNet(net);
    //     var canvas = new Canvas { Margin = new System.Windows.Thickness(10) };
    //
    //     var children = (
    //         from layer in net.Neurons
    //         from neuron in layer.Take(MaxItemsToDisplay)
    //         select new
    //         {
    //             neuron,
    //             layer,
    //             circle = new Border
    //             {
    //                 Background = new SolidColorBrush(Color.FromRgb(200, 200, 200)),
    //                 CornerRadius = new CornerRadius(50),
    //                 Child = neuron.IsOutputNeuron
    //                     ? new TextBlock
    //                     {
    //                         Text = neuron.Index.ToString(),
    //                         HorizontalAlignment = HorizontalAlignment.Center,
    //                         VerticalAlignment = VerticalAlignment.Center,
    //                         FontSize = 15,
    //                         FontWeight = FontWeights.Bold,
    //                         Foreground = Brushes.White
    //                     }
    //                     : null
    //             },
    //             lines = neuron.InputWeights.Take(neuron.Layer == 0
    //                                                  ? 0
    //                                                  : MaxItemsToDisplay)
    //                           .Select((weight, i) => new
    //                           {
    //                               Index = i,
    //                               Line = new Line
    //                               {
    //                                   Stroke = new SolidColorBrush(Color.FromArgb(64, 80, 80, 80)),
    //                                   StrokeThickness = 3,
    //                                   StrokeStartLineCap = PenLineCap.Round,
    //                                   StrokeEndLineCap = PenLineCap.Round
    //                               }
    //                           })
    //                           .ToArray()
    //         }).ToArray();
    //
    //     double GetDiameter(Array layer) => canvas.ActualHeight / (Math.Min(MaxItemsToDisplay, layer.Length) + 3);
    //
    //     canvas.SizeChanged += delegate
    //     {
    //         var layer = children.First()
    //                             .layer;
    //         int layerIndex = 0;
    //         foreach (var n in children)
    //         {
    //             if (layer != n.layer) layerIndex++;
    //             layer = n.layer;
    //             n.circle.Width = n.circle.Height = GetDiameter(layer);
    //             double xPerItem = (canvas.ActualWidth - GetDiameter(layer)) / (net.Neurons.Length - 1);
    //             double left = xPerItem * layerIndex;
    //             double top = canvas.ActualHeight / Math.Min(MaxItemsToDisplay, layer.Length) * n.neuron.Index + n.circle.Height / 2;
    //             n.circle.SetValue(Canvas.LeftProperty, left);
    //             n.circle.SetValue(Canvas.TopProperty, top);
    //             int i = 0;
    //             foreach (var l in n.lines)
    //             {
    //                 var prevLayer = net.Neurons[n.neuron.Layer - 1];
    //                 l.Line.X1 = left - xPerItem + GetDiameter(prevLayer) / 2;
    //                 l.Line.X2 = left + GetDiameter(layer) / 2;
    //                 l.Line.Y1 = canvas.ActualHeight / Math.Min(MaxItemsToDisplay, prevLayer.Length) * i + GetDiameter(prevLayer);
    //                 l.Line.Y2 = top + GetDiameter(layer) / 2;
    //                 i++;
    //             }
    //         }
    //     };
    //
    //     var infoPanel = new DockPanel { Margin = new System.Windows.Thickness(10) };
    //     infoPanel.SetValue(Grid.ColumnProperty, 1);
    //
    //     var lblTrainingInfo = new Label { FontSize = 18, Margin = new Thickness(0, 0, 0, 10) };
    //     lblTrainingInfo.SetValue(DockPanel.DockProperty, Dock.Top);
    //     infoPanel.Children.Add(lblTrainingInfo);
    //
    //     var lblLiveTraining = new Label { FontSize = 18, Foreground = Brushes.Green };
    //     lblLiveTraining.SetValue(DockPanel.DockProperty, Dock.Top);
    //     infoPanel.Children.Add(lblLiveTraining);
    //
    //     var btnClear = new Button { Content = "Clear >>", Padding = new Thickness(10) };
    //     btnClear.SetValue(DockPanel.DockProperty, Dock.Bottom);
    //     infoPanel.Children.Add(btnClear);
    //
    //     var lblPrediction = new Label { FontSize = 100, Margin = new Thickness(0), FontWeight = FontWeights.Bold, Foreground = Brushes.Blue, HorizontalContentAlignment = HorizontalAlignment.Center };
    //     infoPanel.Children.Add(lblPrediction);
    //
    //     int lastIterations = 0;
    //     var timer = new DispatcherTimer { IsEnabled = true, Interval = TimeSpan.FromMilliseconds(150) };
    //     timer.Tick += delegate
    //     {
    //         lblTrainingInfo.Content = trainer.TrainingInfo;
    //
    //         if (trainer.CurrentEpoch > 0)
    //             lblLiveTraining.Content = "Current epoch = "
    //                                       + trainer.CurrentEpoch
    //                                       + (trainer.CurrentAccuracy == 0
    //                                           ? ""
    //                                           : "\r\nLast training score = " + (trainer.CurrentAccuracy).ToString("N1") + "%");
    //
    //         if (trainer.Iterations == lastIterations) return;
    //         lastIterations = trainer.Iterations;
    //
    //         var minMax = children.GroupBy(c => c.neuron.Layer)
    //                              .ToDictionary(
    //                                  g => g.Key,
    //                                  g => new
    //                                  {
    //                                      MinBias = Math.Min(-1, g.Min(x => x.neuron.Bias)),
    //                                      MaxBias = Math.Max(1, g.Max(x => x.neuron.Bias)),
    //                                      MinWeight = Math.Min(-1, g.SelectMany(x => x.neuron.InputWeights)
    //                                                                .Min(l => l)),
    //                                      MaxWeight = Math.Max(1, g.SelectMany(x => x.neuron.InputWeights)
    //                                                               .Max(l => l)),
    //                                  });
    //
    //         foreach (var n in children)
    //         {
    //             var minMaxEntry = minMax[n.neuron.Layer];
    //             n.circle.Background = new SolidColorBrush(GetColor(
    //                                                           n.neuron.Bias,
    //                                                           minMaxEntry.MinBias,
    //                                                           minMaxEntry.MaxBias,
    //                                                           255));
    //             n.circle.ToolTip = "Bias=" + n.neuron.Bias;
    //
    //             foreach (var l in n.lines)
    //             {
    //                 l.Line.Stroke = new SolidColorBrush(GetColor(
    //                                                         n.neuron.InputWeights[l.Index],
    //                                                         minMaxEntry.MinWeight,
    //                                                         minMaxEntry.MaxWeight,
    //                                                         100));
    //                 l.Line.ToolTip = "Weight=" + n.neuron.InputWeights[l.Index];
    //             }
    //         }
    //     };
    //
    //     foreach (var n in children)
    //     foreach (var l in n.lines)
    //         canvas.Children.Add(l.Line);
    //
    //     foreach (var n in children)
    //         canvas.Children.Add(n.circle);
    //
    //     var drawingBox = GetDrawingBox(net, ImageWidthHeight);
    //     var drawingBoxHost = new WindowsFormsHost { Child = drawingBox };
    //
    //     drawingBoxHost.Margin = new Thickness(10);
    //     drawingBoxHost.HorizontalAlignment = HorizontalAlignment.Right;
    //     drawingBoxHost.SetValue(Grid.ColumnProperty, 2);
    //
    //     drawingBox.MouseUp += (sender, args) =>
    //     {
    //         using (var scaledImage = new System.Drawing.Bitmap(ImageWidthHeight, ImageWidthHeight))
    //         using (var g = System.Drawing.Graphics.FromImage(scaledImage))
    //         {
    //             g.DrawImage(drawingBox.Image, 0, 0, ImageWidthHeight * drawingBox.Width / drawingBox.Height, ImageWidthHeight);
    //             var data = BitmapToByteArray(scaledImage);
    //             var greyData = data.SelectMany((b, n) => n % 4 == 1
    //                                                ? new[] { (byte)(Math.Min(255, b * 3 / 2)) }
    //                                                : new byte [0])
    //                                .ToArray();
    //             greyData = CentreImage(greyData, ImageWidthHeight);
    //             var input = greyData.Select(d => (double)d / 255)
    //                                 .ToArray();
    //             firingNet.FeedForward(input);
    //             lblPrediction.Content = IndexOfMax(firingNet.OutputValues.ToArray());
    //         }
    //     };
    //
    //     btnClear.Click += (sender, args) =>
    //     {
    //         using (var g = System.Drawing.Graphics.FromImage(drawingBox.Image))
    //             g.Clear(System.Drawing.Color.Black);
    //
    //         drawingBox.Invalidate();
    //
    //         lblPrediction.Content = "";
    //     };
    //
    //     var grid = new Grid();
    //
    //     grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(5, GridUnitType.Star) });
    //     grid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Auto, MinWidth = 250 });
    //     grid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Auto });
    //
    //     grid.LayoutUpdated += (sender, args) =>
    //         drawingBoxHost.Width = drawingBoxHost.Height = Math.Max(50, Math.Min(grid.ActualWidth / 3, grid.ActualHeight - 20));
    //
    //     grid.Children.Add(canvas);
    //     grid.Children.Add(infoPanel);
    //     grid.Children.Add(drawingBoxHost);
    //
    //     var panel = new DockPanel { Background = Brushes.White };
    //     panel.Children.Add(grid);
    //     return panel;
    // }


    // static Canvas GetDrawingCanvas(NeuralNet net, int widthAndHeight)
    // {
    //     var canvas = new Canvas { Background = Brushes.Black };
    //     Point? lastPos = null;
    //     canvas.MouseMove += (sender, args) =>
    //     {
    //         if (args.LeftButton == System.Windows.Input.MouseButtonState.Pressed)
    //         {
    //             var newPos = args.GetPosition(canvas);
    //             if (lastPos != null)
    //                 canvas.Children.Add(new Line
    //                 {
    //                     X1 = lastPos.Value.X,
    //                     X2 = newPos.X,
    //                     Y1 = lastPos.Value.Y,
    //                     Y2 = newPos.Y,
    //                     StrokeThickness = 20,
    //                     Stroke = Brushes.White,
    //                     StrokeStartLineCap = PenLineCap.Round,
    //                     StrokeEndLineCap = PenLineCap.Round
    //                 });
    //             lastPos = newPos;
    //         }
    //         else
    //             lastPos = null;
    //     };
    //     return canvas;
    // }
    //
    // static System.Windows.Forms.PictureBox GetDrawingBox(NeuralNet net, int widthAndHeight)
    // {
    //     var box = new System.Windows.Forms.PictureBox();
    //     var pen = new System.Drawing.Pen(System.Drawing.Color.White, System.Windows.Forms.Control.DefaultFont.Height * 2.2f);
    //     pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
    //     System.Drawing.Graphics graphics = null;
    //     box.SizeChanged += delegate
    //     {
    //         if (box.Width == 0 || box.Height == 0) return;
    //         var oldImage = box.Image;
    //         box.Image = new System.Drawing.Bitmap(box.Width, box.Height);
    //         if (oldImage != null) oldImage.Dispose();
    //         graphics = System.Drawing.Graphics.FromImage(box.Image);
    //         graphics.FillRectangle(System.Drawing.Brushes.Black, 0, 0, box.Height, box.Height);
    //     };
    //
    //     var lastPos = System.Drawing.Point.Empty;
    //     box.MouseMove += (sender, args) =>
    //     {
    //         if (args.Button == System.Windows.Forms.MouseButtons.Left)
    //         {
    //             graphics.DrawLine(pen, lastPos, args.Location);
    //             box.Invalidate();
    //         }
    //
    //         lastPos = args.Location;
    //     };
    //
    //     return box;
    // }
}