using System;
using System.Windows.Forms;

namespace SalesUI
{
    public partial class maps : UserControl
    {
        public maps()
        {
            InitializeComponent();
        }

        private void map_Load(object sender, EventArgs e)
        {
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache; //выбор подгрузки карты – онлайн или из ресурсов
            map.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance; //какой провайдер карт используется (в нашем случае гугл) 
            map.MinZoom = 2; //минимальный зум
            map.MaxZoom = 16; //максимальный зум
            map.Zoom = 4; // какой используется зум при открытии
            map.Position = new GMap.NET.PointLatLng(66.4169575018027, 94.25025752215694);// точка в центре карты при открытии (центр России)
            map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter; // как приближает (просто в центр карты или по положению мыши)
            map.CanDragMap = true; // перетаскивание карты мышью
            map.DragButton = MouseButtons.Left; // какой кнопкой осуществляется перетаскивание
            map.ShowCenter = false; //показывать или скрывать красный крестик в центре
            map.ShowTileGridLines = false; //показывать или скрывать тайлы
        }
    }
}
