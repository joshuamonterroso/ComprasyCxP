-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 11-11-2021 a las 18:54:23
-- Versión del servidor: 8.0.26
-- Versión de PHP: 7.4.22

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `hotelsancarlos`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `aplicacion`
--

CREATE TABLE `aplicacion` (
  `pkId` varchar(15) NOT NULL,
  `fkIdModulo` varchar(15) NOT NULL,
  `nombre` varchar(45) DEFAULT NULL,
  `estado` int NOT NULL,
  `rutaChm` varchar(180) NOT NULL,
  `rutaHtml` varchar(180) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `aplicacion`
--

INSERT INTO `aplicacion` (`pkId`, `fkIdModulo`, `nombre`, `estado`, `rutaChm`, `rutaHtml`) VALUES
('0001', '1', 'Login Seguridad HSC', 1, '1', '0'),
('0002', '1', 'Registrar Usuario', 1, '2', '0'),
('0003', '1', 'Mantenimiento Aplicación', 1, '3', '0'),
('0004', '1', 'Mantenimiento Perfil', 1, '4', '0'),
('0005', '1', 'Asignación de Aplicación a Perfiles', 1, '5', '0'),
('0006', '1', 'Asignación de Aplicación a Usuarios', 1, '6', '0'),
('0007', '1', 'Asignación de Perfiles a Usuarios', 1, '7', '0'),
('0008', '1', 'Asignación Permisos', 1, '8', '0'),
('0009', '1', 'Recuperar Contraseña', 1, '9', '0'),
('0010', '1', 'Cambiar Contraseña', 1, '10', '0'),
('0011', '1', 'Consulta Bitácora', 1, '11', '0'),
('0012', '1', 'Mantenimiento Módulo', 1, '12', '0'),
('2020', '2', 'MantenimientoProveedores2020', 1, 'ayudasmantenimientos/ayudademantenimientos.chm', '/ayudaMantenimientos.html/'),
('2025', '2', 'MantenimientoProducto2025', 1, 'ayudasmantenimientos/ayudademantenimientos.chm', '/ayudaMantenimientos.html/'),
('2030', '2', 'MantenimientoBodega2030', 1, 'ayudasmantenimientos/ayudademantenimientos.chm', '/ayudaMantenimientos.html/'),
('2035', '2', 'MantenimientoInventario2035', 1, 'ayudasmantenimientos/ayudademantenimientos.chm', '/ayudaMantenimientos.html/'),
('2040', '2', 'MantenimientoTipoInventario2040', 1, 'ayudasmantenimientos/ayudademantenimientos.chm', '/ayudaMantenimientos.html/'),
('2045', '2', 'MantenimientoMarca2045', 1, 'ayudasmantenimientos/ayudademantenimientos.chm', '/ayudaMantenimientos.html/'),
('2050', '2', 'MantenimientoLinea2050', 1, 'ayudasmantenimientos/ayudademantenimientos.chm', '/ayudaMantenimientos.html/'),
('2055', '2', 'MantenimientoMovimientos2055', 1, 'ayudaMovimientos/ayudaMovimientos.chm', '/AyudaMovimientos.html/');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `aplicacionperfil`
--

CREATE TABLE `aplicacionperfil` (
  `fkIdPerfil` varchar(15) NOT NULL,
  `fkIdAplicacion` varchar(15) NOT NULL,
  `permisoEscritura` int DEFAULT NULL,
  `permisoLectura` int DEFAULT NULL,
  `permisoModificar` int DEFAULT NULL,
  `permisoEliminar` int DEFAULT NULL,
  `permisoImprimir` int DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `bitacorausuario`
--

CREATE TABLE `bitacorausuario` (
  `pkId` int NOT NULL,
  `fkIdUsuario` varchar(15) NOT NULL,
  `host` varchar(45) DEFAULT NULL,
  `ip` varchar(100) DEFAULT NULL,
  `fkIdModulo` varchar(15) NOT NULL,
  `fkIdAplicacion` varchar(15) NOT NULL,
  `accion` varchar(200) NOT NULL,
  `conexionFecha` date DEFAULT NULL,
  `conexionHora` time DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `bitacorausuario`
--

INSERT INTO `bitacorausuario` (`pkId`, `fkIdUsuario`, `host`, `ip`, `fkIdModulo`, `fkIdAplicacion`, `accion`, `conexionFecha`, `conexionHora`) VALUES
(1, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0001', 'Inicio de sesión exitoso', '2021-11-08', '19:40:23'),
(2, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0001', 'Inicio de sesión exitoso', '2021-11-08', '19:42:14'),
(3, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0001', 'Inicio de sesión exitoso', '2021-11-08', '19:44:22'),
(4, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0001', 'Inicio de sesión exitoso', '2021-11-08', '19:46:25'),
(5, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0001', 'Inicio de sesión exitoso', '2021-11-08', '19:46:39'),
(6, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0001', 'Inicio de sesión exitoso', '2021-11-08', '19:47:45'),
(7, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0001', 'Inicio de sesión exitoso', '2021-11-08', '19:47:54'),
(8, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0001', 'Inicio de sesión exitoso', '2021-11-08', '20:15:08'),
(9, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0001', 'Inicio de sesión exitoso', '2021-11-08', '20:21:00'),
(10, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0001', 'Inicio de sesión exitoso', '2021-11-08', '20:21:44'),
(11, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0001', 'Inicio de sesión exitoso', '2021-11-08', '20:22:49'),
(12, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0001', 'Inicio de sesión exitoso', '2021-11-08', '20:27:57'),
(13, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0001', 'Inicio de sesión exitoso', '2021-11-08', '20:30:49'),
(14, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0001', 'Inicio de sesión exitoso', '2021-11-08', '20:31:13'),
(15, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0011', 'Entrada a la Vista', '2021-11-08', '20:31:26'),
(16, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0012', 'Entrada a la Vista', '2021-11-08', '20:32:28'),
(17, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0012', 'Inserción realizada', '2021-11-08', '20:32:55'),
(18, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0012', 'Inserción realizada', '2021-11-08', '20:33:00'),
(19, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0001', 'Inicio de sesión exitoso', '2021-11-08', '22:36:05'),
(20, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0001', 'Inicio de sesión exitoso', '2021-11-08', '22:36:33'),
(21, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0001', 'Inicio de sesión exitoso', '2021-11-08', '22:36:44'),
(22, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0001', 'Inicio de sesión exitoso', '2021-11-08', '22:39:11'),
(23, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0001', 'Inicio de sesión exitoso', '2021-11-08', '23:10:51'),
(24, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0001', 'Inicio de sesión exitoso', '2021-11-09', '11:26:17'),
(25, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0001', 'Inicio de sesión exitoso', '2021-11-09', '11:26:42'),
(26, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0003', 'Entrada a la Vista', '2021-11-09', '11:26:50'),
(27, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0012', 'Entrada a la Vista', '2021-11-09', '11:26:57'),
(28, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0007', 'Entrada a la Vista', '2021-11-09', '11:27:56'),
(29, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0006', 'Entrada a la Vista', '2021-11-09', '11:28:20'),
(30, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0006', 'Consulta', '2021-11-09', '11:28:26'),
(31, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0006', 'Asignar', '2021-11-09', '11:28:35'),
(32, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0006', 'Asignar', '2021-11-09', '11:28:42'),
(33, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0006', 'Quitar', '2021-11-09', '11:28:44'),
(34, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0006', 'Asignar', '2021-11-09', '11:28:48'),
(35, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0006', 'Asignar', '2021-11-09', '11:28:51'),
(36, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0008', 'Entrada a la Vista', '2021-11-09', '11:29:46'),
(37, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0008', 'Guardar', '2021-11-09', '11:30:33'),
(38, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0010', 'Entrada a la Vista', '2021-11-09', '11:31:18'),
(39, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0011', 'Entrada a la Vista', '2021-11-09', '11:31:26'),
(40, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0001', 'Inicio de sesión exitoso', '2021-11-09', '11:32:42'),
(41, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0003', 'Entrada a la Vista', '2021-11-09', '11:32:47'),
(42, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0001', 'Inicio de sesión exitoso', '2021-11-09', '14:59:02'),
(43, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0001', 'Inicio de sesión exitoso', '2021-11-09', '15:00:15'),
(44, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0001', 'Inicio de sesión exitoso', '2021-11-09', '15:00:24'),
(45, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0012', 'Entrada a la Vista', '2021-11-09', '15:00:30'),
(46, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0003', 'Entrada a la Vista', '2021-11-09', '15:00:43'),
(47, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0003', 'Inserción realizada', '2021-11-09', '15:01:35'),
(48, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0003', 'Inserción realizada', '2021-11-09', '15:02:14'),
(49, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0003', 'Inserción realizada', '2021-11-09', '15:02:38'),
(50, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0003', 'Error al realizar Inserción', '2021-11-09', '15:02:38'),
(51, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0003', 'Inserción realizada', '2021-11-09', '15:02:43'),
(52, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0003', 'Inserción realizada', '2021-11-09', '15:03:19'),
(53, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0003', 'Inserción realizada', '2021-11-09', '15:04:10'),
(54, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0003', 'Inserción realizada', '2021-11-09', '15:04:52'),
(55, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0003', 'Inserción realizada', '2021-11-09', '15:05:21'),
(56, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0006', 'Entrada a la Vista', '2021-11-09', '15:06:11'),
(57, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0006', 'Consulta', '2021-11-09', '15:06:16'),
(58, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0006', 'Asignar', '2021-11-09', '15:06:26'),
(59, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0006', 'Asignar', '2021-11-09', '15:06:35'),
(60, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0006', 'Asignar', '2021-11-09', '15:06:37'),
(61, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0006', 'Asignar', '2021-11-09', '15:06:40'),
(62, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0006', 'Asignar', '2021-11-09', '15:06:42'),
(63, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0006', 'Asignar', '2021-11-09', '15:06:44'),
(64, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0006', 'Asignar', '2021-11-09', '15:06:46'),
(65, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0008', 'Entrada a la Vista', '2021-11-09', '15:07:12'),
(66, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0008', 'Guardar', '2021-11-09', '15:08:10'),
(67, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0008', 'Guardar', '2021-11-09', '15:08:57'),
(68, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0008', 'Guardar', '2021-11-09', '15:09:09'),
(69, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0008', 'Guardar', '2021-11-09', '15:09:21'),
(70, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0008', 'Guardar', '2021-11-09', '15:09:31'),
(71, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0008', 'Guardar', '2021-11-09', '15:09:40'),
(72, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0008', 'Guardar', '2021-11-09', '15:09:48'),
(73, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0001', 'Inicio de sesión exitoso', '2021-11-09', '16:32:46'),
(74, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0001', 'Inicio de sesión exitoso', '2021-11-09', '16:33:18'),
(75, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0001', 'Inicio de sesión exitoso', '2021-11-09', '16:54:47'),
(76, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0001', 'Inicio de sesión exitoso', '2021-11-09', '18:03:19'),
(77, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0001', 'Inicio de sesión exitoso', '2021-11-09', '18:04:57'),
(78, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0001', 'Inicio de sesión exitoso', '2021-11-09', '18:09:26'),
(79, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '2', '2020', 'insertar', '2021-11-09', '18:09:42'),
(80, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0001', 'Inicio de sesión exitoso', '2021-11-09', '19:00:15'),
(81, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '2', '2020', 'insertar', '2021-11-09', '19:00:31'),
(82, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '2', '2020', 'guardar', '2021-11-09', '19:01:01'),
(83, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '2', '2020', 'Boton Siguiente', '2021-11-09', '19:01:11'),
(84, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '2', '2020', 'Boton Anterior', '2021-11-09', '19:01:12'),
(85, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '2', '2020', 'Boton Siguiente', '2021-11-09', '19:01:12'),
(86, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '2', '2020', 'Boton Anterior', '2021-11-09', '19:01:13'),
(87, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '2', '2020', 'Boton Siguiente', '2021-11-09', '19:01:14'),
(88, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '2', '2020', 'Boton Anterior', '2021-11-09', '19:01:14'),
(89, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '2', '2020', 'Boton Siguiente', '2021-11-09', '19:01:15'),
(90, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '2', '2020', 'inicio', '2021-11-09', '19:01:26'),
(91, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '2', '2020', 'Final', '2021-11-09', '19:01:27'),
(92, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '2', '2020', 'eliminar', '2021-11-09', '19:01:34'),
(93, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '2', '2020', 'Salir', '2021-11-09', '19:01:46'),
(94, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '2', '2025', 'insertar', '2021-11-09', '19:02:06'),
(95, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '2', '2025', 'Salir', '2021-11-09', '19:02:40'),
(96, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0001', 'Inicio de sesión exitoso', '2021-11-09', '19:06:11'),
(97, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0001', 'Inicio de sesión exitoso', '2021-11-09', '19:13:34'),
(98, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0001', 'Inicio de sesión exitoso', '2021-11-09', '19:16:38'),
(99, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0001', 'Inicio de sesión exitoso', '2021-11-09', '19:17:51'),
(100, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0003', 'Entrada a la Vista', '2021-11-09', '19:17:56'),
(101, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0001', 'Inicio de sesión exitoso', '2021-11-09', '20:16:13'),
(102, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0001', 'Inicio de sesión exitoso', '2021-11-09', '20:19:37'),
(103, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0001', 'Inicio de sesión exitoso', '2021-11-09', '20:21:37'),
(104, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '2', '2025', 'insertar', '2021-11-09', '20:21:52'),
(105, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '2', '2025', 'Salir', '2021-11-09', '20:22:00'),
(106, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0001', 'Inicio de sesión exitoso', '2021-11-09', '20:31:07'),
(107, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '2', '2025', 'insertar', '2021-11-09', '20:31:21'),
(108, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '2', '2025', 'Salir', '2021-11-09', '20:31:40'),
(109, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0001', 'Inicio de sesión exitoso', '2021-11-09', '20:33:27'),
(110, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '2', '2025', 'insertar', '2021-11-09', '20:33:41'),
(111, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '2', '2025', 'Salir', '2021-11-09', '20:34:01'),
(112, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0001', 'Inicio de sesión exitoso', '2021-11-09', '20:37:32'),
(113, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '2', '2025', 'insertar', '2021-11-09', '20:37:43'),
(114, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '2', '2025', 'guardar', '2021-11-09', '20:38:40'),
(115, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '2', '2025', 'Boton Siguiente', '2021-11-09', '20:38:44'),
(116, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '2', '2025', 'Boton Anterior', '2021-11-09', '20:38:45'),
(117, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '2', '2025', 'Salir', '2021-11-09', '20:39:02'),
(118, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0001', 'Inicio de sesión exitoso', '2021-11-09', '20:59:58'),
(119, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0001', 'Inicio de sesión exitoso', '2021-11-09', '21:01:48'),
(120, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '2', '2030', 'insertar', '2021-11-09', '21:02:23'),
(121, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '2', '2030', 'guardar', '2021-11-09', '21:02:52'),
(122, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '2', '2030', 'Salir', '2021-11-09', '21:03:11'),
(123, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0001', 'Inicio de sesión exitoso', '2021-11-09', '21:31:12'),
(124, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0001', 'Inicio de sesión exitoso', '2021-11-09', '21:32:41'),
(125, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '2', '2035', 'insertar', '2021-11-09', '21:35:03'),
(126, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '2', '2035', 'guardar', '2021-11-09', '21:35:23'),
(127, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '2', '2035', 'Boton Siguiente', '2021-11-09', '21:35:24'),
(128, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '2', '2035', 'Salir', '2021-11-09', '21:35:28'),
(129, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0001', 'Inicio de sesión exitoso', '2021-11-09', '21:55:56'),
(130, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0001', 'Inicio de sesión exitoso', '2021-11-09', '22:06:18'),
(131, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '2', '2040', 'Salir', '2021-11-09', '22:06:29'),
(132, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0001', 'Inicio de sesión exitoso', '2021-11-09', '22:15:47'),
(133, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0001', 'Inicio de sesión exitoso', '2021-11-09', '22:18:11'),
(134, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '2', '2020', 'Salir', '2021-11-09', '22:18:23'),
(135, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '2', '2040', 'Salir', '2021-11-09', '22:18:29'),
(136, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0001', 'Inicio de sesión exitoso', '2021-11-09', '22:19:49'),
(137, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '2', '2045', 'insertar', '2021-11-09', '22:20:00'),
(138, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '2', '2045', 'Salir', '2021-11-09', '22:20:02'),
(139, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0001', 'Inicio de sesión exitoso', '2021-11-09', '22:39:35'),
(140, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0001', 'Inicio de sesión exitoso', '2021-11-09', '22:41:22'),
(141, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0001', 'Inicio de sesión exitoso', '2021-11-09', '22:53:59'),
(142, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0001', 'Inicio de sesión exitoso', '2021-11-09', '22:56:29'),
(143, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0001', 'Inicio de sesión exitoso', '2021-11-09', '22:57:08'),
(144, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '2', '2030', 'Boton Siguiente', '2021-11-09', '22:57:22'),
(145, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '2', '2020', 'reporteador', '2021-11-09', '22:57:31'),
(146, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0001', 'Inicio de sesión exitoso', '2021-11-09', '22:59:04'),
(147, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0001', 'Inicio de sesión exitoso', '2021-11-09', '22:59:36'),
(148, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0001', 'Inicio de sesión exitoso', '2021-11-09', '23:00:26'),
(149, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0001', 'Inicio de sesión exitoso', '2021-11-09', '23:16:58'),
(150, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '2', '2025', 'Ayuda', '2021-11-09', '23:17:12'),
(151, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '2', '2025', 'Ayuda', '2021-11-09', '23:17:17'),
(152, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '2', '2025', 'Ayuda', '2021-11-09', '23:17:18'),
(153, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '2', '2025', 'Ayuda', '2021-11-09', '23:18:10'),
(154, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '2', '2025', 'Salir', '2021-11-09', '23:18:22'),
(155, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0001', 'Inicio de sesión exitoso', '2021-11-09', '23:18:31'),
(156, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0003', 'Entrada a la Vista', '2021-11-09', '23:18:36'),
(157, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0001', 'Inicio de sesión exitoso', '2021-11-09', '23:20:31'),
(158, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '2', '2020', 'Ayuda', '2021-11-09', '23:20:41'),
(159, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '2', '2020', 'Ayuda', '2021-11-09', '23:20:46'),
(160, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '2', '2020', 'Salir', '2021-11-09', '23:20:59'),
(161, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0001', 'Inicio de sesión exitoso', '2021-11-09', '23:22:55'),
(162, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '2', '2020', 'Ayuda', '2021-11-09', '23:23:06'),
(163, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '2', '2020', 'Salir', '2021-11-09', '23:23:20'),
(164, '1', 'DESKTOP-7BQFKM6', '192.168.39.183', '1', '0001', 'Inicio de sesión exitoso', '2021-11-09', '23:30:48'),
(165, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '1', '0001', 'Inicio de sesión exitoso', '2021-11-10', '17:26:40'),
(166, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '1', '0001', 'Inicio de sesión exitoso', '2021-11-10', '17:30:23'),
(167, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '1', '0001', 'Inicio de sesión exitoso', '2021-11-10', '17:34:19'),
(168, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '1', '0001', 'Inicio de sesión exitoso', '2021-11-10', '17:43:24'),
(169, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '1', '0001', 'Inicio de sesión exitoso', '2021-11-10', '17:56:16'),
(170, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '1', '0001', 'Inicio de sesión exitoso', '2021-11-10', '18:14:15'),
(171, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '1', '0001', 'Inicio de sesión exitoso', '2021-11-10', '18:25:52'),
(172, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2030', 'Boton Siguiente', '2021-11-10', '18:26:11'),
(173, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2030', 'Boton Anterior', '2021-11-10', '18:26:11'),
(174, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2030', 'Boton Siguiente', '2021-11-10', '18:26:12'),
(175, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2030', 'Boton Anterior', '2021-11-10', '18:26:12'),
(176, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '1', '0001', 'Inicio de sesión exitoso', '2021-11-10', '18:27:41'),
(177, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2030', 'reporteador', '2021-11-10', '18:27:52'),
(178, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2030', 'Salir', '2021-11-10', '18:28:30'),
(179, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '1', '0001', 'Inicio de sesión exitoso', '2021-11-10', '18:40:39'),
(180, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '1', '0001', 'Inicio de sesión exitoso', '2021-11-10', '18:41:55'),
(181, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2050', 'insertar', '2021-11-10', '18:42:51'),
(182, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2050', 'Salir', '2021-11-10', '18:42:59'),
(183, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '1', '0001', 'Inicio de sesión exitoso', '2021-11-10', '18:45:06'),
(184, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2050', 'insertar', '2021-11-10', '18:45:18'),
(185, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2050', 'Salir', '2021-11-10', '18:45:25'),
(186, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '1', '0001', 'Inicio de sesión exitoso', '2021-11-10', '19:16:08'),
(187, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2030', 'insertar', '2021-11-10', '19:16:18'),
(188, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2030', 'Salir', '2021-11-10', '19:16:42'),
(189, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '1', '0001', 'Inicio de sesión exitoso', '2021-11-10', '19:20:58'),
(190, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2030', 'insertar', '2021-11-10', '19:21:12'),
(191, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2030', 'Salir', '2021-11-10', '19:21:18'),
(192, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '1', '0001', 'Inicio de sesión exitoso', '2021-11-10', '19:21:29'),
(193, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2030', 'insertar', '2021-11-10', '19:21:37'),
(194, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2030', 'Boton Siguiente', '2021-11-10', '19:21:44'),
(195, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2030', 'Boton Anterior', '2021-11-10', '19:21:46'),
(196, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2030', 'Boton Siguiente', '2021-11-10', '19:21:47'),
(197, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2030', 'Boton Anterior', '2021-11-10', '19:21:48'),
(198, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2030', 'Boton Siguiente', '2021-11-10', '19:21:49'),
(199, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2030', 'Boton Anterior', '2021-11-10', '19:21:50'),
(200, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2030', 'Boton Siguiente', '2021-11-10', '19:21:50'),
(201, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '1', '0001', 'Inicio de sesión exitoso', '2021-11-10', '19:21:59'),
(202, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2030', 'Boton Siguiente', '2021-11-10', '19:22:08'),
(203, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2030', 'Boton Anterior', '2021-11-10', '19:22:09'),
(204, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2030', 'eliminar', '2021-11-10', '19:22:12'),
(205, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2030', 'Boton Anterior', '2021-11-10', '19:22:15'),
(206, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2030', 'Boton Siguiente', '2021-11-10', '19:22:16'),
(207, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2030', 'Boton Anterior', '2021-11-10', '19:22:17'),
(208, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2030', 'Boton Siguiente', '2021-11-10', '19:22:18'),
(209, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2030', 'Boton Siguiente', '2021-11-10', '19:22:19'),
(210, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2030', 'Boton Siguiente', '2021-11-10', '19:22:19'),
(211, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2030', 'Boton Siguiente', '2021-11-10', '19:22:20'),
(212, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2030', 'Boton Siguiente', '2021-11-10', '19:22:21'),
(213, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2030', 'Boton Siguiente', '2021-11-10', '19:22:23'),
(214, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2030', 'Boton Siguiente', '2021-11-10', '19:22:24'),
(215, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2030', 'Boton Siguiente', '2021-11-10', '19:22:24'),
(216, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2030', 'Boton Siguiente', '2021-11-10', '19:22:25'),
(217, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2030', 'Boton Siguiente', '2021-11-10', '19:22:25'),
(218, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2030', 'Boton Siguiente', '2021-11-10', '19:22:26'),
(219, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2030', 'Boton Siguiente', '2021-11-10', '19:22:26'),
(220, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2030', 'Boton Siguiente', '2021-11-10', '19:22:26'),
(221, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2030', 'modificar', '2021-11-10', '19:22:29'),
(222, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2030', 'guardar', '2021-11-10', '19:22:33'),
(223, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2030', 'Boton Siguiente', '2021-11-10', '19:22:39'),
(224, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2030', 'Boton Siguiente', '2021-11-10', '19:22:40'),
(225, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2030', 'Boton Siguiente', '2021-11-10', '19:22:40'),
(226, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2030', 'Boton Siguiente', '2021-11-10', '19:22:41'),
(227, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2030', 'Boton Siguiente', '2021-11-10', '19:22:41'),
(228, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2030', 'Boton Siguiente', '2021-11-10', '19:22:42'),
(229, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2030', 'Salir', '2021-11-10', '19:22:42'),
(230, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '1', '0001', 'Inicio de sesión exitoso', '2021-11-10', '19:24:56'),
(231, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '1', '0001', 'Inicio de sesión exitoso', '2021-11-10', '19:25:08'),
(232, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2030', 'insertar', '2021-11-10', '19:25:17'),
(233, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2030', 'guardar', '2021-11-10', '19:25:50'),
(234, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2030', 'Boton Siguiente', '2021-11-10', '19:25:55'),
(235, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2030', 'Boton Siguiente', '2021-11-10', '19:25:56'),
(236, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2030', 'Boton Anterior', '2021-11-10', '19:25:58'),
(237, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2030', 'Boton Anterior', '2021-11-10', '19:25:59'),
(238, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2030', 'Boton Siguiente', '2021-11-10', '19:26:01'),
(239, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2030', 'Boton Siguiente', '2021-11-10', '19:26:02'),
(240, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2030', 'Boton Anterior', '2021-11-10', '19:26:03'),
(241, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2030', 'Boton Anterior', '2021-11-10', '19:26:03'),
(242, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2030', 'Boton Siguiente', '2021-11-10', '19:26:04'),
(243, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2030', 'Boton Siguiente', '2021-11-10', '19:26:05'),
(244, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2030', 'Boton Anterior', '2021-11-10', '19:26:06'),
(245, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2030', 'Boton Anterior', '2021-11-10', '19:26:06'),
(246, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2030', 'Salir', '2021-11-10', '19:26:08'),
(247, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '1', '0001', 'Inicio de sesión exitoso', '2021-11-10', '19:27:26'),
(248, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2030', 'Boton Siguiente', '2021-11-10', '19:27:36'),
(249, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2030', 'Boton Siguiente', '2021-11-10', '19:27:36'),
(250, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2030', 'Boton Anterior', '2021-11-10', '19:27:37'),
(251, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2030', 'Boton Anterior', '2021-11-10', '19:27:37'),
(252, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2030', 'Boton Siguiente', '2021-11-10', '19:27:38'),
(253, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2030', 'Boton Siguiente', '2021-11-10', '19:27:39'),
(254, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2030', 'Boton Anterior', '2021-11-10', '19:27:40'),
(255, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2030', 'Boton Anterior', '2021-11-10', '19:27:40'),
(256, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2030', 'Boton Siguiente', '2021-11-10', '19:27:42'),
(257, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2030', 'Boton Siguiente', '2021-11-10', '19:27:43'),
(258, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2030', 'Boton Anterior', '2021-11-10', '19:27:45'),
(259, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2030', 'Boton Anterior', '2021-11-10', '19:27:45'),
(260, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2030', 'Boton Siguiente', '2021-11-10', '19:27:46'),
(261, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2030', 'Boton Siguiente', '2021-11-10', '19:27:47'),
(262, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2030', 'Boton Anterior', '2021-11-10', '19:27:47'),
(263, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2030', 'Boton Anterior', '2021-11-10', '19:27:47'),
(264, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2030', 'insertar', '2021-11-10', '19:27:49'),
(265, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2030', 'Salir', '2021-11-10', '19:27:59'),
(266, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '1', '0001', 'Inicio de sesión exitoso', '2021-11-10', '19:41:44'),
(267, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2030', 'eliminar', '2021-11-10', '19:42:08'),
(268, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2030', 'Salir', '2021-11-10', '19:42:12'),
(269, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '1', '0001', 'Inicio de sesión exitoso', '2021-11-10', '20:02:07'),
(270, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2020', 'Boton Siguiente', '2021-11-10', '20:02:19'),
(271, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2020', 'Boton Anterior', '2021-11-10', '20:02:21'),
(272, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2020', 'Boton Siguiente', '2021-11-10', '20:02:22'),
(273, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2020', 'Boton Anterior', '2021-11-10', '20:02:24'),
(274, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2020', 'Boton Siguiente', '2021-11-10', '20:02:30'),
(275, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2020', 'Boton Anterior', '2021-11-10', '20:02:31'),
(276, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2020', 'Boton Siguiente', '2021-11-10', '20:02:32'),
(277, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2020', 'Boton Anterior', '2021-11-10', '20:02:33'),
(278, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2020', 'insertar', '2021-11-10', '20:02:35'),
(279, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2020', 'Salir', '2021-11-10', '20:02:39'),
(280, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '1', '0001', 'Inicio de sesión exitoso', '2021-11-10', '20:24:09'),
(281, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2025', 'insertar', '2021-11-10', '20:24:20'),
(282, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2025', 'Salir', '2021-11-10', '20:24:36'),
(283, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '1', '0001', 'Inicio de sesión exitoso', '2021-11-10', '20:38:28'),
(284, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2025', 'Boton Siguiente', '2021-11-10', '20:38:38'),
(285, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2025', 'Boton Anterior', '2021-11-10', '20:38:40'),
(286, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2025', 'Boton Siguiente', '2021-11-10', '20:38:42'),
(287, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2025', 'Boton Anterior', '2021-11-10', '20:38:43'),
(288, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2025', 'Boton Siguiente', '2021-11-10', '20:38:45'),
(289, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2025', 'Boton Anterior', '2021-11-10', '20:38:46'),
(290, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2025', 'Boton Anterior', '2021-11-10', '20:38:47'),
(291, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2025', 'insertar', '2021-11-10', '20:38:48'),
(292, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2025', 'Boton Siguiente', '2021-11-10', '20:38:59'),
(293, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2025', 'Boton Siguiente', '2021-11-10', '20:38:59'),
(294, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2025', 'Boton Siguiente', '2021-11-10', '20:39:00'),
(295, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2025', 'Boton Siguiente', '2021-11-10', '20:39:00'),
(296, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2025', 'Salir', '2021-11-10', '20:39:02'),
(297, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2035', 'Boton Siguiente', '2021-11-10', '20:40:43'),
(298, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2035', 'Boton Anterior', '2021-11-10', '20:40:44'),
(299, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2035', 'Boton Siguiente', '2021-11-10', '20:40:45'),
(300, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2035', 'Boton Anterior', '2021-11-10', '20:40:45'),
(301, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2035', 'Boton Siguiente', '2021-11-10', '20:40:46'),
(302, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2035', 'Boton Anterior', '2021-11-10', '20:40:47'),
(303, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2035', 'Boton Siguiente', '2021-11-10', '20:40:48'),
(304, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2035', 'Boton Anterior', '2021-11-10', '20:40:48'),
(305, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2035', 'Boton Siguiente', '2021-11-10', '20:40:49'),
(306, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2035', 'Boton Anterior', '2021-11-10', '20:40:50'),
(307, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2035', 'Boton Siguiente', '2021-11-10', '20:40:50'),
(308, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2035', 'Boton Anterior', '2021-11-10', '20:40:51'),
(309, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2035', 'eliminar', '2021-11-10', '20:40:52'),
(310, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2035', 'eliminar', '2021-11-10', '20:40:57'),
(311, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2035', 'eliminar', '2021-11-10', '20:40:58'),
(312, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2035', 'eliminar', '2021-11-10', '20:40:59'),
(313, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2035', 'eliminar', '2021-11-10', '20:40:59'),
(314, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2035', 'insertar', '2021-11-10', '20:41:02'),
(315, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2035', 'guardar', '2021-11-10', '20:41:12'),
(316, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2035', 'Boton Siguiente', '2021-11-10', '20:41:14'),
(317, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2035', 'Boton Siguiente', '2021-11-10', '20:41:17'),
(318, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2035', 'Boton Anterior', '2021-11-10', '20:41:20'),
(319, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2035', 'Boton Siguiente', '2021-11-10', '20:41:21'),
(320, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2035', 'Boton Anterior', '2021-11-10', '20:41:23'),
(321, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2035', 'Boton Siguiente', '2021-11-10', '20:41:24'),
(322, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2035', 'eliminar', '2021-11-10', '20:41:27'),
(323, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2035', 'Boton Siguiente', '2021-11-10', '20:41:30'),
(324, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2035', 'Boton Siguiente', '2021-11-10', '20:41:30'),
(325, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2035', 'Boton Anterior', '2021-11-10', '20:41:41'),
(326, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2035', 'Boton Siguiente', '2021-11-10', '20:41:42'),
(327, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2035', 'Boton Anterior', '2021-11-10', '20:41:42'),
(328, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2035', 'Boton Siguiente', '2021-11-10', '20:41:43'),
(329, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2035', 'Boton Anterior', '2021-11-10', '20:41:44'),
(330, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2035', 'Boton Anterior', '2021-11-10', '20:41:44'),
(331, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2035', 'Boton Siguiente', '2021-11-10', '20:41:45'),
(332, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2035', 'Boton Siguiente', '2021-11-10', '20:41:45'),
(333, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2035', 'Boton Anterior', '2021-11-10', '20:41:51'),
(334, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2035', 'Boton Anterior', '2021-11-10', '20:41:52'),
(335, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2035', 'Boton Siguiente', '2021-11-10', '20:41:52'),
(336, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2035', 'Boton Siguiente', '2021-11-10', '20:41:53'),
(337, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '1', '0001', 'Inicio de sesión exitoso', '2021-11-10', '20:43:28'),
(338, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2035', 'Boton Siguiente', '2021-11-10', '20:43:40'),
(339, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2035', 'Boton Siguiente', '2021-11-10', '20:43:40'),
(340, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2035', 'Boton Anterior', '2021-11-10', '20:43:44'),
(341, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2035', 'Boton Anterior', '2021-11-10', '20:43:45'),
(342, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2035', 'Boton Siguiente', '2021-11-10', '20:43:46'),
(343, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2035', 'Boton Siguiente', '2021-11-10', '20:43:47'),
(344, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2035', 'Boton Anterior', '2021-11-10', '20:43:48'),
(345, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2035', 'Boton Anterior', '2021-11-10', '20:43:48'),
(346, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2035', 'Boton Siguiente', '2021-11-10', '20:43:48'),
(347, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2035', 'Boton Siguiente', '2021-11-10', '20:43:49'),
(348, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2035', 'Boton Anterior', '2021-11-10', '20:43:50'),
(349, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2035', 'Boton Anterior', '2021-11-10', '20:43:51'),
(350, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2035', 'Boton Siguiente', '2021-11-10', '20:43:51'),
(351, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2035', 'Boton Siguiente', '2021-11-10', '20:43:52'),
(352, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2035', 'Boton Anterior', '2021-11-10', '20:43:54'),
(353, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2035', 'Boton Anterior', '2021-11-10', '20:43:54'),
(354, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2035', 'eliminar', '2021-11-10', '20:43:58'),
(355, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2035', 'Boton Siguiente', '2021-11-10', '20:44:00'),
(356, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2035', 'Boton Anterior', '2021-11-10', '20:44:00'),
(357, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2035', 'Boton Siguiente', '2021-11-10', '20:44:02'),
(358, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2035', 'Boton Siguiente', '2021-11-10', '20:44:02'),
(359, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2035', 'insertar', '2021-11-10', '20:44:04'),
(360, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2035', 'guardar', '2021-11-10', '20:44:18'),
(361, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2035', 'Boton Siguiente', '2021-11-10', '20:44:20'),
(362, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2035', 'Boton Siguiente', '2021-11-10', '20:44:21'),
(363, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2035', 'Boton Siguiente', '2021-11-10', '20:44:22'),
(364, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2035', 'Boton Anterior', '2021-11-10', '20:44:23'),
(365, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2035', 'Boton Siguiente', '2021-11-10', '20:44:23'),
(366, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2035', 'insertar', '2021-11-10', '20:44:25'),
(367, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2035', 'guardar', '2021-11-10', '20:44:35'),
(368, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2035', 'Boton Siguiente', '2021-11-10', '20:44:37'),
(369, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2035', 'Boton Siguiente', '2021-11-10', '20:44:37'),
(370, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2035', 'Boton Siguiente', '2021-11-10', '20:44:38'),
(371, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2035', 'Boton Siguiente', '2021-11-10', '20:44:38'),
(372, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2035', 'Salir', '2021-11-10', '20:44:40'),
(373, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '1', '0001', 'Inicio de sesión exitoso', '2021-11-10', '20:52:36'),
(374, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2040', 'Boton Siguiente', '2021-11-10', '20:52:45'),
(375, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2040', 'insertar', '2021-11-10', '20:52:50'),
(376, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2040', 'guardar', '2021-11-10', '20:53:02'),
(377, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2040', 'Boton Siguiente', '2021-11-10', '20:53:03'),
(378, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2040', 'Boton Anterior', '2021-11-10', '20:53:04'),
(379, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2040', 'eliminar', '2021-11-10', '20:53:06'),
(380, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2040', 'Salir', '2021-11-10', '20:53:08'),
(381, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '1', '0001', 'Inicio de sesión exitoso', '2021-11-10', '21:00:58'),
(382, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2045', 'Boton Siguiente', '2021-11-10', '21:01:07'),
(383, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2045', 'Boton Anterior', '2021-11-10', '21:01:07'),
(384, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2045', 'Boton Siguiente', '2021-11-10', '21:01:10'),
(385, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2045', 'Boton Anterior', '2021-11-10', '21:01:12'),
(386, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2045', 'modificar', '2021-11-10', '21:01:14'),
(387, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2045', 'guardar', '2021-11-10', '21:01:19'),
(388, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2045', 'Boton Siguiente', '2021-11-10', '21:01:24'),
(389, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2045', 'insertar', '2021-11-10', '21:01:26'),
(390, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2045', 'guardar', '2021-11-10', '21:01:38'),
(391, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2045', 'Salir', '2021-11-10', '21:01:39'),
(392, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '1', '0001', 'Inicio de sesión exitoso', '2021-11-10', '22:06:08'),
(393, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2045', 'Salir', '2021-11-10', '22:06:20'),
(394, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '1', '0001', 'Inicio de sesión exitoso', '2021-11-10', '22:14:50'),
(395, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2050', 'Boton Siguiente', '2021-11-10', '22:14:59'),
(396, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2050', 'insertar', '2021-11-10', '22:15:02'),
(397, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2050', 'guardar', '2021-11-10', '22:15:23'),
(398, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2050', 'Salir', '2021-11-10', '22:15:25'),
(399, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '1', '0001', 'Inicio de sesión exitoso', '2021-11-10', '22:49:30'),
(400, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '1', '0001', 'Inicio de sesión exitoso', '2021-11-10', '22:50:45'),
(401, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '1', '0001', 'Inicio de sesión exitoso', '2021-11-10', '22:50:53'),
(402, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '1', '0003', 'Entrada a la Vista', '2021-11-10', '22:50:59'),
(403, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '1', '0003', 'Inserción realizada', '2021-11-10', '22:51:34'),
(404, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '1', '0006', 'Entrada a la Vista', '2021-11-10', '22:52:10'),
(405, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '1', '0006', 'Consulta', '2021-11-10', '22:52:16'),
(406, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '1', '0006', 'Asignar', '2021-11-10', '22:52:23'),
(407, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '1', '0008', 'Entrada a la Vista', '2021-11-10', '22:52:31'),
(408, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '1', '0008', 'Guardar', '2021-11-10', '22:52:45'),
(409, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2055', 'Salir', '2021-11-10', '22:53:06'),
(410, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '1', '0001', 'Inicio de sesión exitoso', '2021-11-10', '22:56:24'),
(411, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '1', '0001', 'Inicio de sesión exitoso', '2021-11-10', '23:03:55'),
(412, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '1', '0001', 'Inicio de sesión exitoso', '2021-11-10', '23:07:47'),
(413, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '1', '0001', 'Inicio de sesión exitoso', '2021-11-10', '23:09:34'),
(414, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '1', '0001', 'Inicio de sesión exitoso', '2021-11-10', '23:15:14'),
(415, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2020', 'Salir', '2021-11-10', '23:18:09'),
(416, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2025', 'Salir', '2021-11-10', '23:19:06'),
(417, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2030', 'Salir', '2021-11-10', '23:20:03'),
(418, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2035', 'Salir', '2021-11-10', '23:20:35'),
(419, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2040', 'Salir', '2021-11-10', '23:21:37'),
(420, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2045', 'Salir', '2021-11-10', '23:22:31'),
(421, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '1', '0001', 'Inicio de sesión exitoso', '2021-11-10', '23:35:00'),
(422, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2020', 'Ayuda', '2021-11-10', '23:35:11'),
(423, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2020', 'Salir', '2021-11-10', '23:35:17'),
(424, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '1', '0001', 'Inicio de sesión exitoso', '2021-11-10', '23:57:53'),
(425, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '1', '0001', 'Inicio de sesión exitoso', '2021-11-10', '23:58:33'),
(426, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2030', 'reporteador', '2021-11-10', '23:58:40'),
(427, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2030', 'Salir', '2021-11-10', '23:58:43'),
(428, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '1', '0001', 'Inicio de sesión exitoso', '2021-11-11', '00:05:01'),
(429, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2025', 'reporteador', '2021-11-11', '00:05:11'),
(430, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2025', 'Salir', '2021-11-11', '00:05:13'),
(431, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '1', '0001', 'Inicio de sesión exitoso', '2021-11-11', '00:13:52'),
(432, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '1', '0001', 'Inicio de sesión exitoso', '2021-11-11', '07:04:52'),
(433, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '1', '0001', 'Inicio de sesión exitoso', '2021-11-11', '07:18:29'),
(434, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2020', 'Boton Siguiente', '2021-11-11', '07:20:29'),
(435, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2020', 'Boton Siguiente', '2021-11-11', '07:20:29'),
(436, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2020', 'Boton Siguiente', '2021-11-11', '07:20:30'),
(437, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2020', 'Boton Anterior', '2021-11-11', '07:20:30'),
(438, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2020', 'Boton Anterior', '2021-11-11', '07:20:31'),
(439, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2020', 'Boton Anterior', '2021-11-11', '07:20:31'),
(440, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2020', 'Boton Siguiente', '2021-11-11', '07:21:08'),
(441, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2020', 'Boton Anterior', '2021-11-11', '07:21:10'),
(442, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2020', 'insertar', '2021-11-11', '07:21:11'),
(443, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2020', 'guardar', '2021-11-11', '07:21:43'),
(444, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2020', 'Boton Siguiente', '2021-11-11', '07:21:44'),
(445, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2020', 'Boton Siguiente', '2021-11-11', '07:21:44'),
(446, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2020', 'Boton Siguiente', '2021-11-11', '07:21:44'),
(447, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2020', 'Boton Siguiente', '2021-11-11', '07:21:45'),
(448, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2020', 'eliminar', '2021-11-11', '07:21:50'),
(449, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2020', 'Boton Siguiente', '2021-11-11', '07:21:52'),
(450, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2020', 'Boton Siguiente', '2021-11-11', '07:21:52'),
(451, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2020', 'Boton Siguiente', '2021-11-11', '07:21:52'),
(452, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2020', 'Boton Siguiente', '2021-11-11', '07:21:53'),
(453, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2020', 'modificar', '2021-11-11', '07:21:54'),
(454, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2020', 'guardar', '2021-11-11', '07:21:59'),
(455, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2020', 'Ayuda', '2021-11-11', '07:22:02'),
(456, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2020', 'reporteador', '2021-11-11', '07:22:41'),
(457, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2030', 'Boton Siguiente', '2021-11-11', '07:24:48'),
(458, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2030', 'Boton Siguiente', '2021-11-11', '07:24:49'),
(459, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2030', 'Boton Siguiente', '2021-11-11', '07:24:49'),
(460, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2030', 'insertar', '2021-11-11', '07:24:53'),
(461, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2030', 'guardar', '2021-11-11', '07:25:22'),
(462, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2030', 'reporteador', '2021-11-11', '07:25:23'),
(463, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2030', 'Ayuda', '2021-11-11', '07:25:34'),
(464, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2030', 'Ayuda', '2021-11-11', '07:26:16'),
(465, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2025', 'Salir', '2021-11-11', '07:26:36'),
(466, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '1', '0001', 'Inicio de sesión exitoso', '2021-11-11', '07:29:19'),
(467, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '1', '0001', 'Inicio de sesión exitoso', '2021-11-11', '07:33:57'),
(468, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '1', '0001', 'Inicio de sesión exitoso', '2021-11-11', '07:38:02'),
(469, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '1', '0001', 'Inicio de sesión exitoso', '2021-11-11', '07:51:44'),
(470, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2055', 'insertar', '2021-11-11', '07:53:24'),
(471, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2055', 'guardar', '2021-11-11', '07:54:02'),
(472, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2055', 'modificar', '2021-11-11', '07:54:26'),
(473, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2055', 'Final', '2021-11-11', '07:54:29'),
(474, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2055', 'Boton Siguiente', '2021-11-11', '07:54:29'),
(475, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2055', 'Boton Anterior', '2021-11-11', '07:54:30'),
(476, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2055', 'guardar', '2021-11-11', '07:56:41'),
(477, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2055', 'insertar', '2021-11-11', '07:56:54');
INSERT INTO `bitacorausuario` (`pkId`, `fkIdUsuario`, `host`, `ip`, `fkIdModulo`, `fkIdAplicacion`, `accion`, `conexionFecha`, `conexionHora`) VALUES
(478, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2055', 'guardar', '2021-11-11', '07:57:09'),
(479, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2055', 'Boton Siguiente', '2021-11-11', '07:57:12'),
(480, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2055', 'Boton Anterior', '2021-11-11', '07:57:13'),
(481, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2055', 'Boton Siguiente', '2021-11-11', '07:57:15'),
(482, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2055', 'Salir', '2021-11-11', '07:58:29'),
(483, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '1', '0001', 'Inicio de sesión exitoso', '2021-11-11', '07:58:42'),
(484, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2055', 'Ayuda', '2021-11-11', '07:58:54'),
(485, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2055', 'reporteador', '2021-11-11', '07:58:57'),
(486, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2055', 'Salir', '2021-11-11', '07:59:00'),
(487, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2055', 'reporteador', '2021-11-11', '07:59:08'),
(488, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2055', 'Salir', '2021-11-11', '07:59:09'),
(489, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '1', '0001', 'Inicio de sesión exitoso', '2021-11-11', '07:59:17'),
(490, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '1', '0006', 'Entrada a la Vista', '2021-11-11', '07:59:22'),
(491, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '1', '0006', 'Consulta', '2021-11-11', '07:59:28'),
(492, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '1', '0001', 'Inicio de sesión exitoso', '2021-11-11', '08:08:36'),
(493, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2055', 'reporteador', '2021-11-11', '08:08:44'),
(494, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2055', 'Salir', '2021-11-11', '08:08:47'),
(495, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '1', '0001', 'Inicio de sesión exitoso', '2021-11-11', '08:10:14'),
(496, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '1', '0001', 'Inicio de sesión exitoso', '2021-11-11', '08:26:54'),
(497, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2055', 'reporteador', '2021-11-11', '08:27:01'),
(498, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2055', 'Ayuda', '2021-11-11', '08:27:03'),
(499, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2055', 'Salir', '2021-11-11', '08:27:10'),
(500, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '1', '0001', 'Inicio de sesión exitoso', '2021-11-11', '08:29:40'),
(501, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '1', '0001', 'Inicio de sesión exitoso', '2021-11-11', '08:32:06'),
(502, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2055', 'reporteador', '2021-11-11', '08:32:15'),
(503, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2055', 'Salir', '2021-11-11', '08:32:20'),
(504, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2030', 'reporteador', '2021-11-11', '08:32:26'),
(505, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2030', 'Salir', '2021-11-11', '08:32:28'),
(506, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '1', '0001', 'Inicio de sesión exitoso', '2021-11-11', '08:35:12'),
(507, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2035', 'reporteador', '2021-11-11', '08:35:21'),
(508, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2035', 'Salir', '2021-11-11', '08:35:22'),
(509, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2055', 'reporteador', '2021-11-11', '08:35:27'),
(510, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2055', 'Salir', '2021-11-11', '08:35:29'),
(511, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2055', 'Ayuda', '2021-11-11', '08:36:32'),
(512, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2055', 'Ayuda', '2021-11-11', '08:36:58'),
(513, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2055', 'Ayuda', '2021-11-11', '08:37:15'),
(514, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2055', 'reporteador', '2021-11-11', '08:37:21'),
(515, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2055', 'Salir', '2021-11-11', '08:37:40'),
(516, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '1', '0001', 'Inicio de sesión exitoso', '2021-11-11', '09:21:17'),
(517, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '1', '0001', 'Inicio de sesión exitoso', '2021-11-11', '11:06:07'),
(518, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '1', '0001', 'Inicio de sesión exitoso', '2021-11-11', '11:29:35'),
(519, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2050', 'Ayuda', '2021-11-11', '11:29:49'),
(520, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2050', 'reporteador', '2021-11-11', '11:29:56'),
(521, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2050', 'Salir', '2021-11-11', '11:30:14'),
(522, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '1', '0001', 'Inicio de sesión exitoso', '2021-11-11', '11:43:23'),
(523, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '1', '0001', 'Inicio de sesión exitoso', '2021-11-11', '11:46:49'),
(524, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '1', '0001', 'Inicio de sesión exitoso', '2021-11-11', '11:49:45'),
(525, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '1', '0001', 'Inicio de sesión exitoso', '2021-11-11', '11:50:23'),
(526, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2055', 'Ayuda', '2021-11-11', '11:50:31'),
(527, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2055', 'Boton Siguiente', '2021-11-11', '11:50:37'),
(528, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2055', 'Boton Anterior', '2021-11-11', '11:50:38'),
(529, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2055', 'Boton Siguiente', '2021-11-11', '11:50:39'),
(530, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2055', 'Boton Anterior', '2021-11-11', '11:50:39'),
(531, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2055', 'Boton Siguiente', '2021-11-11', '11:50:40'),
(532, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2055', 'insertar', '2021-11-11', '11:50:41'),
(533, '1', 'DESKTOP-7BQFKM6', '192.168.39.184', '2', '2055', 'Salir', '2021-11-11', '11:50:45');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `bodega`
--

CREATE TABLE `bodega` (
  `pkid` varchar(15) NOT NULL,
  `fkidTipobodega` varchar(15) NOT NULL,
  `nombre` varchar(30) NOT NULL,
  `direccion` varchar(65) NOT NULL,
  `estado` varchar(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `bodega`
--

INSERT INTO `bodega` (`pkid`, `fkidTipobodega`, `nombre`, `direccion`, `estado`) VALUES
('1', '1', 'Bodega Fria', 'Interior hotel', 'I'),
('2', '2', 'Bodega de Carnes', 'Sotano 1', 'A'),
('3', '1', 'Prueba', 'Interior hotel', 'A'),
('4', '3', 'Bodega #4', 'Sotano 2', 'A');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cliente`
--

CREATE TABLE `cliente` (
  `Pkid` varchar(15) NOT NULL,
  `nombre` varchar(30) NOT NULL,
  `idTipo` varchar(15) NOT NULL,
  `apellido` varchar(30) NOT NULL,
  `nit` varchar(15) NOT NULL,
  `telefono` varchar(15) NOT NULL,
  `direccion` varchar(50) NOT NULL,
  `correo` varchar(50) NOT NULL,
  `estatus` varchar(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cuenta`
--

CREATE TABLE `cuenta` (
  `idCuenta` varchar(15) NOT NULL,
  `nombre` varchar(65) DEFAULT NULL,
  `idTipoCuenta` varchar(15) DEFAULT NULL,
  `cargo` float DEFAULT '0',
  `abono` float DEFAULT '0',
  `saldoAcumulado` float DEFAULT '0',
  `estado` varchar(1) DEFAULT NULL,
  `idCuentaPadre` varchar(15) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `cuenta`
--

INSERT INTO `cuenta` (`idCuenta`, `nombre`, `idTipoCuenta`, `cargo`, `abono`, `saldoAcumulado`, `estado`, `idCuentaPadre`) VALUES
('1', 'impuesto', '1', 0, 0, 0, 'A', '1'),
('2', 'impuesto2', '1', 0, 0, 0, 'A', '1'),
('3', 'impuesto3', '1', 0, 0, 0, 'A', '1');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `empleado`
--

CREATE TABLE `empleado` (
  `pkIdEmpleado` varchar(15) NOT NULL,
  `nombre` varchar(45) NOT NULL,
  `apellido` varchar(45) NOT NULL,
  `fechaDeNacimiento` varchar(45) NOT NULL,
  `sueldo` float NOT NULL,
  `correo` varchar(45) NOT NULL,
  `direccion` varchar(45) NOT NULL,
  `contratado` varchar(45) NOT NULL,
  `añosDeExperiencia` int NOT NULL,
  `telefono` varchar(10) NOT NULL,
  `fechaContratacion` date NOT NULL,
  `finDeContrato` date NOT NULL,
  `fkIdPuesto` varchar(15) NOT NULL,
  `fkIdEmpresa` varchar(15) NOT NULL,
  `estado` varchar(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `empleado`
--

INSERT INTO `empleado` (`pkIdEmpleado`, `nombre`, `apellido`, `fechaDeNacimiento`, `sueldo`, `correo`, `direccion`, `contratado`, `añosDeExperiencia`, `telefono`, `fechaContratacion`, `finDeContrato`, `fkIdPuesto`, `fkIdEmpresa`, `estado`) VALUES
('1', 'María', 'Hernandez', '1999-09-25', 4000, 'cmaria@gmail.com', 'zona 11', '4', 5, '789654123', '2016-10-25', '2021-12-25', '1', '1', '0');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `empresa`
--

CREATE TABLE `empresa` (
  `idEmpresa` varchar(15) NOT NULL,
  `nit` varchar(13) NOT NULL,
  `nombre` varchar(35) NOT NULL,
  `direccion` text NOT NULL,
  `telefono` int NOT NULL,
  `estatus` char(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `empresa`
--

INSERT INTO `empresa` (`idEmpresa`, `nit`, `nombre`, `direccion`, `telefono`, `estatus`) VALUES
('1', '65464-k', 'hotel san carlos', 'zona 6 de mixco', 65467654, '1');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `facturadetalle`
--

CREATE TABLE `facturadetalle` (
  `idFacturaDetalle` varchar(15) NOT NULL,
  `idFacturaEncabezado` varchar(15) DEFAULT NULL,
  `idProducto` varchar(15) DEFAULT NULL,
  `monto` float DEFAULT NULL,
  `concepto` varchar(65) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `facturadetalle`
--

INSERT INTO `facturadetalle` (`idFacturaDetalle`, `idFacturaEncabezado`, `idProducto`, `monto`, `concepto`) VALUES
('1', '1', '6', 1500, 'Compras Pruebas'),
('2', '2', '6', 500, 'Compras de calzado'),
('3', '3', '7', 7500, 'Compra de dispositivos de red');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `facturaencabezado`
--

CREATE TABLE `facturaencabezado` (
  `idFacturaEncabezado` varchar(15) NOT NULL,
  `idProveedor` varchar(15) NOT NULL,
  `fecha` date DEFAULT NULL,
  `descripcion` varchar(200) DEFAULT NULL,
  `total` float NOT NULL,
  `idOrdenCompra` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `facturaencabezado`
--

INSERT INTO `facturaencabezado` (`idFacturaEncabezado`, `idProveedor`, `fecha`, `descripcion`, `total`, `idOrdenCompra`) VALUES
('1', '2', '2021-11-10', 'Compra de Ordenadores', 10000, '2'),
('2', '2', '2021-11-10', 'Compra de Sillas de oficina', 5000, '3'),
('3', '1', '2021-11-08', 'compra de Dispositivos de red', 7500, '4'),
('5', '2', '2021-11-03', 'Compra de routers', 500, '5');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `formapago`
--

CREATE TABLE `formapago` (
  `Pkid` varchar(15) NOT NULL,
  `nombre` varchar(30) NOT NULL,
  `estatus` varchar(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `impuesto`
--

CREATE TABLE `impuesto` (
  `idImpuesto` varchar(15) NOT NULL,
  `nombre` varchar(65) DEFAULT NULL,
  `porcentaje` float DEFAULT NULL,
  `estado` varchar(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `inventario`
--

CREATE TABLE `inventario` (
  `Pkid` varchar(15) NOT NULL,
  `fkidsucursal` varchar(15) NOT NULL,
  `Fktipoinventario` varchar(15) NOT NULL,
  `fkidbodega` varchar(15) NOT NULL,
  `estatus` varchar(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `inventario`
--

INSERT INTO `inventario` (`Pkid`, `fkidsucursal`, `Fktipoinventario`, `fkidbodega`, `estatus`) VALUES
('1', '1', '1', '1', 'I'),
('2', '1', '1', '1', 'A'),
('3', '1', '1', '2', 'A'),
('4', '1', '1', '2', 'A'),
('5', '1', '1', '3', 'A');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `linea`
--

CREATE TABLE `linea` (
  `idLinea` varchar(15) NOT NULL,
  `nombre` varchar(100) NOT NULL,
  `descripcion` varchar(500) NOT NULL,
  `idMarca` varchar(15) NOT NULL,
  `estatus` varchar(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `linea`
--

INSERT INTO `linea` (`idLinea`, `nombre`, `descripcion`, `idMarca`, `estatus`) VALUES
('1', 'Clasica', 'Cerveza clasica', '1', 'A'),
('2', 'Extra', 'Cerveza clara', '2', 'A'),
('4', 'Zapatos Deportivos', 'zapatos par acualquier ocasion en especial para hacer deporte', '1', NULL);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `marca`
--

CREATE TABLE `marca` (
  `idMarca` varchar(15) NOT NULL,
  `nombre` varchar(100) NOT NULL,
  `descripcion` varchar(500) NOT NULL,
  `estado` varchar(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `marca`
--

INSERT INTO `marca` (`idMarca`, `nombre`, `descripcion`, `estado`) VALUES
('1', 'Gallo', 'Cerveza', 'A'),
('2', 'Heineken', 'Cerveza', 'A'),
('3', 'Corona', 'Cerveza', 'A'),
('4', 'nike', 'distribuidor de calzado ', NULL);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `modulo`
--

CREATE TABLE `modulo` (
  `pkId` varchar(15) NOT NULL,
  `nombre` varchar(30) NOT NULL,
  `descripcion` varchar(200) NOT NULL,
  `estado` varchar(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `modulo`
--

INSERT INTO `modulo` (`pkId`, `nombre`, `descripcion`, `estado`) VALUES
('1', 'Seguridad', 'Módulo de Seguridad', '1'),
('2', 'Compras y cuentas por pagar', 'Modulo de compras y CxP', '1');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `movimiento`
--

CREATE TABLE `movimiento` (
  `idMovimiento` varchar(15) NOT NULL,
  `idOrdenCompra` varchar(15) NOT NULL,
  `total` float DEFAULT NULL,
  `abonado` float DEFAULT NULL,
  `stsMov` varchar(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `movimiento`
--

INSERT INTO `movimiento` (`idMovimiento`, `idOrdenCompra`, `total`, `abonado`, `stsMov`) VALUES
('1', '4', 200, 100, 'I'),
('2', '5', 300, 0, 'A');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ordencompra`
--

CREATE TABLE `ordencompra` (
  `idOrdenCompra` varchar(15) NOT NULL,
  `idProveedor` varchar(15) NOT NULL,
  `total` float NOT NULL,
  `fecha` date DEFAULT NULL,
  `descripcion` varchar(100) DEFAULT NULL,
  `estado` varchar(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `ordencompra`
--

INSERT INTO `ordencompra` (`idOrdenCompra`, `idProveedor`, `total`, `fecha`, `descripcion`, `estado`) VALUES
('10000', '1', 100, '2021-11-05', 'Prueba', NULL),
('101', '5', 1500, '2021-11-11', 'Prueba en clase', NULL),
('2', '2', 10000, '2021-11-10', 'ose compraron ordenadores para el uso de la empresa', 'A'),
('3', '2', 5000, '2021-11-11', 'Compra de Sillas para uso en el Hotel', 'A'),
('4', '1', 7500, '2021-11-08', 'Compra de Dispositivos de red', 'A'),
('5', '2', 500, '2021-11-03', 'Compra de routers', 'A'),
('6', '1', 2500, '2021-11-10', 'orden de compra sobre linea de telefono', 'A');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `perfil`
--

CREATE TABLE `perfil` (
  `pkId` varchar(15) NOT NULL,
  `nombre` varchar(45) DEFAULT NULL,
  `estado` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `perfil`
--

INSERT INTO `perfil` (`pkId`, `nombre`, `estado`) VALUES
('1', 'Administrador', '1'),
('2', 'Vendedor', '1');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `polizadetalle`
--

CREATE TABLE `polizadetalle` (
  `idPolizaEncabezado` varchar(15) NOT NULL,
  `fechaPoliza` date NOT NULL,
  `idCuenta` varchar(15) NOT NULL,
  `saldo` float DEFAULT NULL,
  `idTipoOperacion` varchar(15) DEFAULT NULL,
  `concepto` varchar(65) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `polizadetalle`
--

INSERT INTO `polizadetalle` (`idPolizaEncabezado`, `fechaPoliza`, `idCuenta`, `saldo`, `idTipoOperacion`, `concepto`) VALUES
('1', '2021-10-01', '1', 100, '1', 'compras'),
('1', '2021-10-01', '2', 100, '2', 'compras'),
('10', '2021-11-11', '1', 23000, '1', 'Compras del dia'),
('10', '2021-11-11', '2', 23000, '2', 'Compras del dia'),
('5', '2021-10-01', '1', 100, '1', 'impuesto'),
('5', '2021-10-01', '2', 100, '2', 'impuesto'),
('5', '2021-10-03', '3', 200, '2', 'impuesto'),
('6', '2021-10-02', '1', 100, '1', 'impuesto'),
('6', '2021-10-02', '2', 100, '2', 'impuesto'),
('7', '2021-10-03', '1', 100, '1', 'impuesto'),
('7', '2021-10-03', '2', 100, '2', 'impuesto'),
('8', '2021-10-31', '1', 0, '1', ''),
('8', '2021-10-31', '2', 0, '2', '');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `polizaencabezado`
--

CREATE TABLE `polizaencabezado` (
  `idPolizaEncabezado` varchar(15) NOT NULL,
  `fechaPoliza` date NOT NULL,
  `idTipoPoliza` varchar(15) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `polizaencabezado`
--

INSERT INTO `polizaencabezado` (`idPolizaEncabezado`, `fechaPoliza`, `idTipoPoliza`) VALUES
('1', '2021-10-01', '1'),
('10', '2021-11-11', '1'),
('5', '2021-10-01', '1'),
('6', '2021-10-02', '1'),
('7', '2021-10-03', '1'),
('8', '2021-10-31', '1'),
('9', '2021-11-11', '1');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `producto`
--

CREATE TABLE `producto` (
  `pkid` varchar(15) NOT NULL,
  `fkinventario` varchar(15) NOT NULL,
  `Nombre` varchar(30) NOT NULL,
  `Fkidlinea` varchar(15) NOT NULL,
  `Stock` int NOT NULL,
  `StockMaximo` int NOT NULL,
  `StockMinimo` int NOT NULL,
  `Costo` float NOT NULL,
  `Precio` float NOT NULL,
  `Estatus` varchar(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `producto`
--

INSERT INTO `producto` (`pkid`, `fkinventario`, `Nombre`, `Fkidlinea`, `Stock`, `StockMaximo`, `StockMinimo`, `Costo`, `Precio`, `Estatus`) VALUES
('1', '1', 'Gallo Clara', '1', 3000, 10000, 1000, 4, 15, 'A'),
('6', '1', 'Zapatos Aerodinamicos ', '1', 100, 500, 100, 150, 500, 'A'),
('7', '1', 'Calzado Moderno', '1', 10, 50, 5, 500, 1000, 'A');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `proveedor`
--

CREATE TABLE `proveedor` (
  `idProveedor` varchar(15) NOT NULL,
  `nombre` varchar(100) NOT NULL,
  `direccion` varchar(500) NOT NULL,
  `telefono` int NOT NULL,
  `email` varchar(200) NOT NULL,
  `idEmpresa` varchar(15) DEFAULT NULL,
  `stsproveedor` varchar(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `proveedor`
--

INSERT INTO `proveedor` (`idProveedor`, `nombre`, `direccion`, `telefono`, `email`, `idEmpresa`, `stsproveedor`) VALUES
('1', 'asda', 'asda', 11111, 'asdadsa', '1', 'I'),
('2', 'Fernando', 'Zona 18', 34564734, 'biggs@gmail.com', '1', 'I'),
('5', 'Claro', 'Zona 4 ciudad de Guatemala', 32165445, 'clarogt@gmail.com', '1', 'A'),
('6', 'Intelaf', 'zona 9, ciudad de Guatemala', 54236185, 'intelafgt@gmail.com', '1', 'A'),
('7', 'Demostracion', 'Z1', 12345677, 'Demostracion', '1', 'A');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `puesto`
--

CREATE TABLE `puesto` (
  `pkIdPuesto` varchar(11) NOT NULL,
  `nombre` varchar(45) DEFAULT NULL,
  `añosDeExperiencia` int DEFAULT NULL,
  `fkIdPuestoSuperior` varchar(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `puesto`
--

INSERT INTO `puesto` (`pkIdPuesto`, `nombre`, `añosDeExperiencia`, `fkIdPuestoSuperior`) VALUES
('1', 'Gerente', 10, '1'),
('2', 'Gerente', 10, '1');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `registro_consultas`
--

CREATE TABLE `registro_consultas` (
  `id_registro` int NOT NULL,
  `nombre` varchar(200) DEFAULT NULL,
  `consulta` varchar(500) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `reporte`
--

CREATE TABLE `reporte` (
  `idReporte` varchar(15) NOT NULL,
  `nombre` varchar(80) NOT NULL,
  `ruta` varchar(180) NOT NULL,
  `idAplicacion` varchar(15) NOT NULL,
  `estado` varchar(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `reporte`
--

INSERT INTO `reporte` (`idReporte`, `nombre`, `ruta`, `idAplicacion`, `estado`) VALUES
('1', 'Reporte bodega', 'reportesAdolfoMonterroso/reporteparabodegas.rpt', '2030', 'A'),
('2', 'Reporte Proveedores', 'reportesAdolfoMonterroso/reportedeproveedores.rpt', '2020', 'A'),
('3', 'Reporte productos', 'reportesAdolfoMonterroso/reportedeproducto.rpt', '2025', 'A'),
('4', 'Reporte Inventarios', 'reportesAdolfoMonterroso/reportedeinventario.rpt', '2035', 'A'),
('5', 'Reporte Tipo Inventarios', 'reportesAdolfoMonterroso/reportetipoinventario.rpt', '2040', 'A'),
('6', 'Reporte Marca', 'reportesAdolfoMonterroso/reportedemarca.rpt', '2045', 'A'),
('7', 'Reporte Linea', 'reportesAdolfoMonterroso/reportelineadeadolfo.rpt', '2050', 'A'),
('8', 'Reporte Movimiento', 'reportesAdolfoMonterroso/ReporteParaMovimientos.rpt', '2055', 'A');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `sucursal`
--

CREATE TABLE `sucursal` (
  `idSucursal` varchar(15) NOT NULL,
  `idEmpresa` varchar(15) NOT NULL,
  `nombre` varchar(35) NOT NULL,
  `direccion` text NOT NULL,
  `telefono` int NOT NULL,
  `codigoPostal` int NOT NULL,
  `estatus` char(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `sucursal`
--

INSERT INTO `sucursal` (`idSucursal`, `idEmpresa`, `nombre`, `direccion`, `telefono`, `codigoPostal`, `estatus`) VALUES
('1', '1', 'Sede Central', 'Zona 2', 22128798, 1001, 'A'),
('3', '1', 'Central', 'zona 11', 32165445, 1018, 'A');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipobodega`
--

CREATE TABLE `tipobodega` (
  `pkid` varchar(15) NOT NULL,
  `nombre` varchar(30) NOT NULL,
  `estado` varchar(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tipobodega`
--

INSERT INTO `tipobodega` (`pkid`, `nombre`, `estado`) VALUES
('1', 'Bodega 1', 'A'),
('2', 'Bodega 2', 'A'),
('3', 'BODEGA prodcutos frios', 'A');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipocliente`
--

CREATE TABLE `tipocliente` (
  `idTipo` varchar(15) NOT NULL,
  `nombre` varchar(35) NOT NULL,
  `estatus` char(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipocuenta`
--

CREATE TABLE `tipocuenta` (
  `idTipoCuenta` varchar(15) NOT NULL,
  `nombre` varchar(65) DEFAULT NULL,
  `estado` varchar(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tipocuenta`
--

INSERT INTO `tipocuenta` (`idTipoCuenta`, `nombre`, `estado`) VALUES
('1', 'Activo', 'A'),
('2', 'Activo Corriente', 'A'),
('3', 'Pasivo ', 'A'),
('4', 'Pasivo Corriente', 'A');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipoinventario`
--

CREATE TABLE `tipoinventario` (
  `Pkid` varchar(15) NOT NULL,
  `nombre` varchar(30) NOT NULL,
  `estatus` varchar(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tipoinventario`
--

INSERT INTO `tipoinventario` (`Pkid`, `nombre`, `estatus`) VALUES
('1', 'Prueba', 'I'),
('2', 'Alimentos', 'A');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipooperacion`
--

CREATE TABLE `tipooperacion` (
  `idTipoOperacion` varchar(15) NOT NULL,
  `nombre` varchar(65) DEFAULT NULL,
  `estado` varchar(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tipooperacion`
--

INSERT INTO `tipooperacion` (`idTipoOperacion`, `nombre`, `estado`) VALUES
('1', 'Debe', 'A'),
('2', 'Haber', 'A');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipopoliza`
--

CREATE TABLE `tipopoliza` (
  `idTipoPoliza` varchar(15) NOT NULL,
  `descripcion` varchar(65) DEFAULT NULL,
  `estado` varchar(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tipopoliza`
--

INSERT INTO `tipopoliza` (`idTipoPoliza`, `descripcion`, `estado`) VALUES
('1', 'Poliza Ingresos', 'A'),
('2', 'Poliza Egresos', 'A'),
('3', 'Poliza Total', 'A');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `trasladoproducto`
--

CREATE TABLE `trasladoproducto` (
  `pkId` varchar(15) NOT NULL,
  `fkidbodegaO` varchar(15) NOT NULL,
  `fkidbodegaD` varchar(15) NOT NULL,
  `fecha_salid` date DEFAULT NULL,
  `fecha_ingreso` date DEFAULT NULL,
  `fkidproducto` varchar(15) NOT NULL,
  `cantidad` int DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `trasladoproducto`
--

INSERT INTO `trasladoproducto` (`pkId`, `fkidbodegaO`, `fkidbodegaD`, `fecha_salid`, `fecha_ingreso`, `fkidproducto`, `cantidad`) VALUES
('1', '1', '2', '2021-11-02', '2021-11-06', '1', 4),
('2', '2', '2', '2021-10-30', '2021-11-05', '1', 2),
('3', '4', '2', '2021-11-09', '2021-11-11', '1', 100);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuario`
--

CREATE TABLE `usuario` (
  `pkId` varchar(15) NOT NULL,
  `fkIdEmpleado` varchar(15) NOT NULL,
  `nombre` varchar(30) NOT NULL,
  `contraseña` varchar(100) NOT NULL,
  `estado` varchar(1) NOT NULL,
  `intento` int DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `usuario`
--

INSERT INTO `usuario` (`pkId`, `fkIdEmpleado`, `nombre`, `contraseña`, `estado`, `intento`) VALUES
('1', '1', 'admin', 'LKAekHU9EtweB49HAaTRfg==', '1', 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarioaplicacion`
--

CREATE TABLE `usuarioaplicacion` (
  `fkIdUsuario` varchar(15) NOT NULL,
  `fkIdAplicacion` varchar(15) NOT NULL,
  `permisoEscritura` int DEFAULT NULL,
  `permisoLectura` int DEFAULT NULL,
  `permisoModificar` int DEFAULT NULL,
  `permisoEliminar` int DEFAULT NULL,
  `permisoImprimir` int DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `usuarioaplicacion`
--

INSERT INTO `usuarioaplicacion` (`fkIdUsuario`, `fkIdAplicacion`, `permisoEscritura`, `permisoLectura`, `permisoModificar`, `permisoEliminar`, `permisoImprimir`) VALUES
('1', '0005', NULL, NULL, NULL, NULL, NULL),
('1', '0008', NULL, NULL, NULL, NULL, NULL),
('1', '0009', NULL, NULL, NULL, NULL, NULL),
('1', '2050', 1, 1, 1, 1, 1),
('1', '2020', 1, 1, 1, 1, 1),
('1', '2025', 1, 1, 1, 1, 1),
('1', '2030', 1, 1, 1, 1, 1),
('1', '2035', 1, 1, 1, 1, 1),
('1', '2040', 1, 1, 1, 1, 1),
('1', '2045', 1, 1, 1, 1, 1),
('1', '2055', 1, 1, 1, 1, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarioaplicacionasignados`
--

CREATE TABLE `usuarioaplicacionasignados` (
  `fkIdUsuario` varchar(15) NOT NULL,
  `fkIdAplicacion` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarioperfil`
--

CREATE TABLE `usuarioperfil` (
  `fkIdUsuario` varchar(15) NOT NULL,
  `fkIdPerfil` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `vwpermisosperfil`
-- (Véase abajo para la vista actual)
--
CREATE TABLE `vwpermisosperfil` (
`permisoEscritura` int
,`permisoLectura` int
,`permisoModificar` int
,`permisoEliminar` int
,`permisoImprimir` int
,`pkIdPerfil` varchar(15)
,`Perfil` varchar(45)
,`pkIdAplicacion` varchar(15)
,`Aplicacion` varchar(45)
);

-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `vwpermisosusuario`
-- (Véase abajo para la vista actual)
--
CREATE TABLE `vwpermisosusuario` (
`permisoEscritura` int
,`permisoLectura` int
,`permisoModificar` int
,`permisoEliminar` int
,`permisoImprimir` int
,`pkIdUsuario` varchar(15)
,`Usuario` varchar(30)
,`pkIdAplicacion` varchar(15)
,`Aplicacion` varchar(45)
);

-- --------------------------------------------------------

--
-- Estructura para la vista `vwpermisosperfil`
--
DROP TABLE IF EXISTS `vwpermisosperfil`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vwpermisosperfil`  AS SELECT `a`.`permisoEscritura` AS `permisoEscritura`, `a`.`permisoLectura` AS `permisoLectura`, `a`.`permisoModificar` AS `permisoModificar`, `a`.`permisoEliminar` AS `permisoEliminar`, `a`.`permisoImprimir` AS `permisoImprimir`, `b`.`pkId` AS `pkIdPerfil`, `b`.`nombre` AS `Perfil`, `c`.`pkId` AS `pkIdAplicacion`, `c`.`nombre` AS `Aplicacion` FROM ((`aplicacionperfil` `a` join `perfil` `b` on((`b`.`pkId` = `a`.`fkIdPerfil`))) join `aplicacion` `c` on((`c`.`pkId` = `a`.`fkIdAplicacion`))) ORDER BY `a`.`fkIdPerfil` ASC ;

-- --------------------------------------------------------

--
-- Estructura para la vista `vwpermisosusuario`
--
DROP TABLE IF EXISTS `vwpermisosusuario`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vwpermisosusuario`  AS SELECT `a`.`permisoEscritura` AS `permisoEscritura`, `a`.`permisoLectura` AS `permisoLectura`, `a`.`permisoModificar` AS `permisoModificar`, `a`.`permisoEliminar` AS `permisoEliminar`, `a`.`permisoImprimir` AS `permisoImprimir`, `b`.`pkId` AS `pkIdUsuario`, `b`.`nombre` AS `Usuario`, `c`.`pkId` AS `pkIdAplicacion`, `c`.`nombre` AS `Aplicacion` FROM ((`usuarioaplicacion` `a` join `usuario` `b` on((`b`.`pkId` = `a`.`fkIdUsuario`))) join `aplicacion` `c` on((`c`.`pkId` = `a`.`fkIdAplicacion`))) ORDER BY `a`.`fkIdUsuario` ASC ;

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `aplicacion`
--
ALTER TABLE `aplicacion`
  ADD PRIMARY KEY (`pkId`),
  ADD KEY `fkIdModulo` (`fkIdModulo`);

--
-- Indices de la tabla `aplicacionperfil`
--
ALTER TABLE `aplicacionperfil`
  ADD KEY `fkIdAplicacion` (`fkIdAplicacion`),
  ADD KEY `fkIdPerfil` (`fkIdPerfil`);

--
-- Indices de la tabla `bitacorausuario`
--
ALTER TABLE `bitacorausuario`
  ADD PRIMARY KEY (`pkId`),
  ADD KEY `fkIdUsuario` (`fkIdUsuario`),
  ADD KEY `fkIdModulo` (`fkIdModulo`),
  ADD KEY `fkIdAplicacion` (`fkIdAplicacion`);

--
-- Indices de la tabla `bodega`
--
ALTER TABLE `bodega`
  ADD PRIMARY KEY (`pkid`),
  ADD KEY `fkidTipobodega` (`fkidTipobodega`);

--
-- Indices de la tabla `cliente`
--
ALTER TABLE `cliente`
  ADD PRIMARY KEY (`Pkid`),
  ADD KEY `idTipo` (`idTipo`);

--
-- Indices de la tabla `cuenta`
--
ALTER TABLE `cuenta`
  ADD PRIMARY KEY (`idCuenta`),
  ADD KEY `idTipoCuenta` (`idTipoCuenta`),
  ADD KEY `idCuentaPadre` (`idCuentaPadre`);

--
-- Indices de la tabla `empleado`
--
ALTER TABLE `empleado`
  ADD PRIMARY KEY (`pkIdEmpleado`),
  ADD KEY `fkIdPuesto` (`fkIdPuesto`),
  ADD KEY `fkIdEmpresa` (`fkIdEmpresa`);

--
-- Indices de la tabla `empresa`
--
ALTER TABLE `empresa`
  ADD PRIMARY KEY (`idEmpresa`);

--
-- Indices de la tabla `facturadetalle`
--
ALTER TABLE `facturadetalle`
  ADD PRIMARY KEY (`idFacturaDetalle`),
  ADD KEY `idFacturaEncabezado` (`idFacturaEncabezado`),
  ADD KEY `idProducto` (`idProducto`);

--
-- Indices de la tabla `facturaencabezado`
--
ALTER TABLE `facturaencabezado`
  ADD PRIMARY KEY (`idFacturaEncabezado`),
  ADD KEY `idProveedor` (`idProveedor`),
  ADD KEY `idOrdenCompra` (`idOrdenCompra`);

--
-- Indices de la tabla `formapago`
--
ALTER TABLE `formapago`
  ADD PRIMARY KEY (`Pkid`);

--
-- Indices de la tabla `impuesto`
--
ALTER TABLE `impuesto`
  ADD PRIMARY KEY (`idImpuesto`);

--
-- Indices de la tabla `inventario`
--
ALTER TABLE `inventario`
  ADD PRIMARY KEY (`Pkid`),
  ADD KEY `Fktipoinventario` (`Fktipoinventario`),
  ADD KEY `fkidsucursal` (`fkidsucursal`),
  ADD KEY `fkidbodega` (`fkidbodega`);

--
-- Indices de la tabla `linea`
--
ALTER TABLE `linea`
  ADD PRIMARY KEY (`idLinea`),
  ADD KEY `idMarca` (`idMarca`);

--
-- Indices de la tabla `marca`
--
ALTER TABLE `marca`
  ADD PRIMARY KEY (`idMarca`);

--
-- Indices de la tabla `modulo`
--
ALTER TABLE `modulo`
  ADD PRIMARY KEY (`pkId`);

--
-- Indices de la tabla `movimiento`
--
ALTER TABLE `movimiento`
  ADD PRIMARY KEY (`idMovimiento`),
  ADD KEY `idOrdenCompra` (`idOrdenCompra`);

--
-- Indices de la tabla `ordencompra`
--
ALTER TABLE `ordencompra`
  ADD PRIMARY KEY (`idOrdenCompra`),
  ADD KEY `idProveedor` (`idProveedor`);

--
-- Indices de la tabla `perfil`
--
ALTER TABLE `perfil`
  ADD PRIMARY KEY (`pkId`);

--
-- Indices de la tabla `polizadetalle`
--
ALTER TABLE `polizadetalle`
  ADD PRIMARY KEY (`idPolizaEncabezado`,`fechaPoliza`,`idCuenta`),
  ADD KEY `idCuenta` (`idCuenta`),
  ADD KEY `idTipoOperacion` (`idTipoOperacion`);

--
-- Indices de la tabla `polizaencabezado`
--
ALTER TABLE `polizaencabezado`
  ADD PRIMARY KEY (`idPolizaEncabezado`,`fechaPoliza`),
  ADD KEY `idTipoPoliza` (`idTipoPoliza`);

--
-- Indices de la tabla `producto`
--
ALTER TABLE `producto`
  ADD PRIMARY KEY (`pkid`),
  ADD KEY `Fkidlinea` (`Fkidlinea`),
  ADD KEY `fkinventario` (`fkinventario`);

--
-- Indices de la tabla `proveedor`
--
ALTER TABLE `proveedor`
  ADD PRIMARY KEY (`idProveedor`),
  ADD KEY `idEmpresa` (`idEmpresa`);

--
-- Indices de la tabla `puesto`
--
ALTER TABLE `puesto`
  ADD PRIMARY KEY (`pkIdPuesto`);

--
-- Indices de la tabla `registro_consultas`
--
ALTER TABLE `registro_consultas`
  ADD PRIMARY KEY (`id_registro`);

--
-- Indices de la tabla `reporte`
--
ALTER TABLE `reporte`
  ADD PRIMARY KEY (`idReporte`),
  ADD KEY `idAplicacion` (`idAplicacion`);

--
-- Indices de la tabla `sucursal`
--
ALTER TABLE `sucursal`
  ADD PRIMARY KEY (`idSucursal`),
  ADD KEY `idEmpresa` (`idEmpresa`);

--
-- Indices de la tabla `tipobodega`
--
ALTER TABLE `tipobodega`
  ADD PRIMARY KEY (`pkid`);

--
-- Indices de la tabla `tipocliente`
--
ALTER TABLE `tipocliente`
  ADD PRIMARY KEY (`idTipo`);

--
-- Indices de la tabla `tipocuenta`
--
ALTER TABLE `tipocuenta`
  ADD PRIMARY KEY (`idTipoCuenta`);

--
-- Indices de la tabla `tipoinventario`
--
ALTER TABLE `tipoinventario`
  ADD PRIMARY KEY (`Pkid`);

--
-- Indices de la tabla `tipooperacion`
--
ALTER TABLE `tipooperacion`
  ADD PRIMARY KEY (`idTipoOperacion`);

--
-- Indices de la tabla `tipopoliza`
--
ALTER TABLE `tipopoliza`
  ADD PRIMARY KEY (`idTipoPoliza`);

--
-- Indices de la tabla `trasladoproducto`
--
ALTER TABLE `trasladoproducto`
  ADD PRIMARY KEY (`pkId`),
  ADD KEY `fkidbodegaO` (`fkidbodegaO`),
  ADD KEY `fkidbodegaD` (`fkidbodegaD`),
  ADD KEY `fkidproducto` (`fkidproducto`);

--
-- Indices de la tabla `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`pkId`),
  ADD KEY `fkIdEmpleado` (`fkIdEmpleado`);

--
-- Indices de la tabla `usuarioaplicacion`
--
ALTER TABLE `usuarioaplicacion`
  ADD KEY `fkIdAplicacion` (`fkIdAplicacion`),
  ADD KEY `fkIdUsuario` (`fkIdUsuario`);

--
-- Indices de la tabla `usuarioaplicacionasignados`
--
ALTER TABLE `usuarioaplicacionasignados`
  ADD KEY `fkIdAplicacion` (`fkIdAplicacion`),
  ADD KEY `fkIdUsuario` (`fkIdUsuario`);

--
-- Indices de la tabla `usuarioperfil`
--
ALTER TABLE `usuarioperfil`
  ADD KEY `fkIdPerfil` (`fkIdPerfil`),
  ADD KEY `fkIdUsuario` (`fkIdUsuario`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `bitacorausuario`
--
ALTER TABLE `bitacorausuario`
  MODIFY `pkId` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=534;

--
-- AUTO_INCREMENT de la tabla `registro_consultas`
--
ALTER TABLE `registro_consultas`
  MODIFY `id_registro` int NOT NULL AUTO_INCREMENT;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `aplicacion`
--
ALTER TABLE `aplicacion`
  ADD CONSTRAINT `aplicacion_ibfk_1` FOREIGN KEY (`fkIdModulo`) REFERENCES `modulo` (`pkId`);

--
-- Filtros para la tabla `aplicacionperfil`
--
ALTER TABLE `aplicacionperfil`
  ADD CONSTRAINT `aplicacionperfil_ibfk_1` FOREIGN KEY (`fkIdAplicacion`) REFERENCES `aplicacion` (`pkId`),
  ADD CONSTRAINT `aplicacionperfil_ibfk_2` FOREIGN KEY (`fkIdPerfil`) REFERENCES `perfil` (`pkId`);

--
-- Filtros para la tabla `bitacorausuario`
--
ALTER TABLE `bitacorausuario`
  ADD CONSTRAINT `bitacorausuario_ibfk_1` FOREIGN KEY (`fkIdUsuario`) REFERENCES `usuario` (`pkId`),
  ADD CONSTRAINT `bitacorausuario_ibfk_2` FOREIGN KEY (`fkIdModulo`) REFERENCES `modulo` (`pkId`),
  ADD CONSTRAINT `bitacorausuario_ibfk_3` FOREIGN KEY (`fkIdAplicacion`) REFERENCES `aplicacion` (`pkId`);

--
-- Filtros para la tabla `bodega`
--
ALTER TABLE `bodega`
  ADD CONSTRAINT `bodega_ibfk_1` FOREIGN KEY (`fkidTipobodega`) REFERENCES `tipobodega` (`pkid`);

--
-- Filtros para la tabla `cliente`
--
ALTER TABLE `cliente`
  ADD CONSTRAINT `cliente_ibfk_1` FOREIGN KEY (`idTipo`) REFERENCES `tipocliente` (`idTipo`);

--
-- Filtros para la tabla `cuenta`
--
ALTER TABLE `cuenta`
  ADD CONSTRAINT `cuenta_ibfk_1` FOREIGN KEY (`idTipoCuenta`) REFERENCES `tipocuenta` (`idTipoCuenta`),
  ADD CONSTRAINT `cuenta_ibfk_2` FOREIGN KEY (`idCuentaPadre`) REFERENCES `cuenta` (`idCuenta`);

--
-- Filtros para la tabla `empleado`
--
ALTER TABLE `empleado`
  ADD CONSTRAINT `empleado_ibfk_1` FOREIGN KEY (`fkIdPuesto`) REFERENCES `puesto` (`pkIdPuesto`),
  ADD CONSTRAINT `empleado_ibfk_2` FOREIGN KEY (`fkIdEmpresa`) REFERENCES `empresa` (`idEmpresa`);

--
-- Filtros para la tabla `facturadetalle`
--
ALTER TABLE `facturadetalle`
  ADD CONSTRAINT `facturadetalle_ibfk_1` FOREIGN KEY (`idFacturaEncabezado`) REFERENCES `facturaencabezado` (`idFacturaEncabezado`),
  ADD CONSTRAINT `facturadetalle_ibfk_2` FOREIGN KEY (`idProducto`) REFERENCES `producto` (`pkid`);

--
-- Filtros para la tabla `facturaencabezado`
--
ALTER TABLE `facturaencabezado`
  ADD CONSTRAINT `facturaencabezado_ibfk_1` FOREIGN KEY (`idProveedor`) REFERENCES `proveedor` (`idProveedor`),
  ADD CONSTRAINT `facturaencabezado_ibfk_2` FOREIGN KEY (`idOrdenCompra`) REFERENCES `ordencompra` (`idOrdenCompra`);

--
-- Filtros para la tabla `inventario`
--
ALTER TABLE `inventario`
  ADD CONSTRAINT `inventario_ibfk_1` FOREIGN KEY (`Fktipoinventario`) REFERENCES `tipoinventario` (`Pkid`),
  ADD CONSTRAINT `inventario_ibfk_2` FOREIGN KEY (`fkidsucursal`) REFERENCES `sucursal` (`idSucursal`),
  ADD CONSTRAINT `inventario_ibfk_3` FOREIGN KEY (`fkidbodega`) REFERENCES `bodega` (`pkid`);

--
-- Filtros para la tabla `linea`
--
ALTER TABLE `linea`
  ADD CONSTRAINT `linea_ibfk_1` FOREIGN KEY (`idMarca`) REFERENCES `marca` (`idMarca`);

--
-- Filtros para la tabla `movimiento`
--
ALTER TABLE `movimiento`
  ADD CONSTRAINT `movimiento_ibfk_1` FOREIGN KEY (`idOrdenCompra`) REFERENCES `ordencompra` (`idOrdenCompra`);

--
-- Filtros para la tabla `ordencompra`
--
ALTER TABLE `ordencompra`
  ADD CONSTRAINT `ordencompra_ibfk_1` FOREIGN KEY (`idProveedor`) REFERENCES `proveedor` (`idProveedor`);

--
-- Filtros para la tabla `polizadetalle`
--
ALTER TABLE `polizadetalle`
  ADD CONSTRAINT `polizadetalle_ibfk_1` FOREIGN KEY (`idPolizaEncabezado`) REFERENCES `polizaencabezado` (`idPolizaEncabezado`),
  ADD CONSTRAINT `polizadetalle_ibfk_2` FOREIGN KEY (`idCuenta`) REFERENCES `cuenta` (`idCuenta`),
  ADD CONSTRAINT `polizadetalle_ibfk_3` FOREIGN KEY (`idTipoOperacion`) REFERENCES `tipooperacion` (`idTipoOperacion`);

--
-- Filtros para la tabla `polizaencabezado`
--
ALTER TABLE `polizaencabezado`
  ADD CONSTRAINT `polizaencabezado_ibfk_1` FOREIGN KEY (`idTipoPoliza`) REFERENCES `tipopoliza` (`idTipoPoliza`);

--
-- Filtros para la tabla `producto`
--
ALTER TABLE `producto`
  ADD CONSTRAINT `producto_ibfk_1` FOREIGN KEY (`Fkidlinea`) REFERENCES `linea` (`idLinea`),
  ADD CONSTRAINT `producto_ibfk_2` FOREIGN KEY (`fkinventario`) REFERENCES `inventario` (`Pkid`);

--
-- Filtros para la tabla `proveedor`
--
ALTER TABLE `proveedor`
  ADD CONSTRAINT `proveedor_ibfk_1` FOREIGN KEY (`idEmpresa`) REFERENCES `empresa` (`idEmpresa`);

--
-- Filtros para la tabla `reporte`
--
ALTER TABLE `reporte`
  ADD CONSTRAINT `reporte_ibfk_1` FOREIGN KEY (`idAplicacion`) REFERENCES `aplicacion` (`pkId`);

--
-- Filtros para la tabla `sucursal`
--
ALTER TABLE `sucursal`
  ADD CONSTRAINT `sucursal_ibfk_1` FOREIGN KEY (`idEmpresa`) REFERENCES `empresa` (`idEmpresa`);

--
-- Filtros para la tabla `trasladoproducto`
--
ALTER TABLE `trasladoproducto`
  ADD CONSTRAINT `trasladoproducto_ibfk_1` FOREIGN KEY (`fkidbodegaO`) REFERENCES `bodega` (`pkid`),
  ADD CONSTRAINT `trasladoproducto_ibfk_2` FOREIGN KEY (`fkidbodegaD`) REFERENCES `bodega` (`pkid`),
  ADD CONSTRAINT `trasladoproducto_ibfk_3` FOREIGN KEY (`fkidproducto`) REFERENCES `producto` (`pkid`);

--
-- Filtros para la tabla `usuario`
--
ALTER TABLE `usuario`
  ADD CONSTRAINT `usuario_ibfk_1` FOREIGN KEY (`fkIdEmpleado`) REFERENCES `empleado` (`pkIdEmpleado`);

--
-- Filtros para la tabla `usuarioaplicacion`
--
ALTER TABLE `usuarioaplicacion`
  ADD CONSTRAINT `usuarioaplicacion_ibfk_1` FOREIGN KEY (`fkIdAplicacion`) REFERENCES `aplicacion` (`pkId`),
  ADD CONSTRAINT `usuarioaplicacion_ibfk_2` FOREIGN KEY (`fkIdUsuario`) REFERENCES `usuario` (`pkId`);

--
-- Filtros para la tabla `usuarioaplicacionasignados`
--
ALTER TABLE `usuarioaplicacionasignados`
  ADD CONSTRAINT `usuarioaplicacionasignados_ibfk_1` FOREIGN KEY (`fkIdAplicacion`) REFERENCES `aplicacion` (`pkId`),
  ADD CONSTRAINT `usuarioaplicacionasignados_ibfk_2` FOREIGN KEY (`fkIdUsuario`) REFERENCES `usuario` (`pkId`);

--
-- Filtros para la tabla `usuarioperfil`
--
ALTER TABLE `usuarioperfil`
  ADD CONSTRAINT `usuarioperfil_ibfk_1` FOREIGN KEY (`fkIdPerfil`) REFERENCES `perfil` (`pkId`),
  ADD CONSTRAINT `usuarioperfil_ibfk_2` FOREIGN KEY (`fkIdUsuario`) REFERENCES `usuario` (`pkId`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
