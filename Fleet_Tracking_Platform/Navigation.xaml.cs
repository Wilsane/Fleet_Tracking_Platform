
<UserControl x:Class="Fleet_Tracking_Platform.Navigation"
             xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
             xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
             xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006" 
             xmlns:d="http://schemas.microsoft.com/expression/blend/2008" 
             xmlns:materialDesign="http://materialdesigninxaml.net/winfx/xaml/themes"
             xmlns:local="clr-namespace:Fleet_Tracking_Platform"
             xmlns:fa="http://schemas.fontawesome.io/icons/"
             mc:Ignorable="d" 
             d:DesignHeight="720" d:DesignWidth="1020">
    <Grid>
        <StackPanel Width="250" Margin="0,0,770,10" Background="#29ab87">
            <Image Source="pack://application:,,,/Assets/Icons/Logo1_PNG.png" Height="104"/>

            <Menu>
                <!--Overview Menu-->
                <MenuItem Header="Overview" Background="#29ab87" Width="250" Foreground="White" FontSize="18">
                    <MenuItem.Icon>
                        <fa:FontAwesome Icon="PencilSquareOutline"/>
                    </MenuItem.Icon>
                    <MenuItem Header="View" Foreground="Black">
                        <MenuItem.Icon>
                            <fa:FontAwesome Icon="Eye"/>
                        </MenuItem.Icon>
                    </MenuItem>
                    <MenuItem Header="Add new User" Foreground="Black">
                        <MenuItem.Icon>
                            <fa:FontAwesome Icon="Plus"/>
                        </MenuItem.Icon>
                    </MenuItem>
                </MenuItem>

                <!--Vehicle Menu-->
                <MenuItem Header="Vehicles" Foreground="White" Background="#29ab87" Width="250" FontSize="18">
                    <MenuItem.Icon>
                        <fa:FontAwesome Icon="Truck" />
                    </MenuItem.Icon>
                    <MenuItem Header="New vehicle" Foreground="Black" >
                        <MenuItem.Icon>
                            <fa:FontAwesome Icon="PlusCircle"/>
                        </MenuItem.Icon>
                    </MenuItem>
                    <MenuItem Header="View vehicle" Foreground="Black">
                        <MenuItem.Icon>
                            <fa:FontAwesome Icon="Stethoscope"/>
                        </MenuItem.Icon>
                    </MenuItem>
                </MenuItem>

                <!--Drivers-->
                <MenuItem Header="Drivers" Background="#29ab87" Width="250" Foreground="White">
                    <MenuItem.Icon>
                        <fa:FontAwesome Icon="User"/>
                    </MenuItem.Icon>
                    <!--THeres nothing here WHY !!!!!!!!!!!!!!-->
                </MenuItem>

                <!--Trip management-->
                <MenuItem Header="Trip manager" Foreground="White" Background="#29ab87" Width="262">
                    <MenuItem.Icon>
                        <fa:FontAwesome Icon="Tripadvisor"/>
                    </MenuItem.Icon>
                </MenuItem>

                <!--Service management-->
                <MenuItem Header="Service manager" Width="312" Foreground="White" Background="#29ab87">
                    <MenuItem.Icon>
                        <fa:FontAwesome Icon="Gears"/>
                    </MenuItem.Icon>
                    <MenuItem Header="View Vehicles"></MenuItem>
                </MenuItem>

                <!--Timesheet-->
                <MenuItem Header="Timesheet" Foreground="White" Background="#29ab87" Width="250">
                    <MenuItem.Icon>
                        <fa:FontAwesome Icon="Table"/>
                    </MenuItem.Icon>
                    <Rectangle HorizontalAlignment="Left" Height="100" Stroke="Black" VerticalAlignment="Top" Width="100"/>
                </MenuItem>

            </Menu>
            <Border Margin="0, 55, 0, 0" BorderBrush="White" BorderThickness="1" CornerRadius="30" Width="150" Height="55">
                <Label x:Name="lblLogin" Content="Exit" Foreground="White" FontSize="16" HorizontalContentAlignment="Center" VerticalContentAlignment="Center"/>
            </Border>

        </StackPanel>

    </Grid>
</UserControl>
