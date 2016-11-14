﻿namespace Com.CodeGame.CodeWizards2016.DevKit.CSharpCgdk.Model
{
    /// <summary>
    /// Возможные действия волшебника.
    /// </summary>
    /// <remarks>
    /// Волшебник не может совершать новые действия, если он ещё не восстановился после своего предыдущего действия
    /// (значение wizard.remainingActionCooldownTicks больше 0).
    /// Волшебник не может использовать действие, если оно ещё не восстановилось после его предыдущего применения
    /// (значение remainingCooldownTicksByAction[actionType.ordinal()] больше 0).
    /// </remarks>
    public enum ActionType
    {
        /// <summary>
        /// Ничего не делать.
        /// </summary>
        None,

        /// <summary>
        /// Ударить посохом.
        /// </summary>
        /// <remarks>
        /// Атака поражает все живые объекты в секторе от -game.staffSector / 2.0 до
        /// game.staffSector / 2.0. Расстояние от центра волшебника до центра цели не должно
        /// превышать значение game.staffRange + livingUnit.radius.
        /// </remarks>
        Staff,

        /// <summary>
        /// Создать магическую ракету.
        /// </summary>
        /// <remarks>
        /// Магическая ракета является базовым заклинанием любого волшебника. Наносит урон при
        /// прямом попадании.
        /// При создании магической ракеты её центр совпадает с центром волшебника, направление
        /// определяется как wizard.angle + move.castAngle, а абсолютное значение скорости равно
        /// game.magicMissileSpeed. Столкновения магического снаряда и создавшего его волшебника
        /// игнорируются.
        /// Требует game.magicMissileManacost единиц магической энергии. 
        /// </remarks>
        MagicMissile,

        /// <summary>
        /// Создать ледяную стрелу.
        /// </summary>
        /// <remarks>
        /// Ледяная стрела наносит урон при прямом попадании, а также замораживает цель.
        /// При создании ледяной стрелы её центр совпадает с центром волшебника, направление
        /// определяется как wizard.angle + move.castAngle, а абсолютное значение скорости равно
        /// game.frostBoltSpeed. Столкновения магического снаряда и создавшего его волшебника
        /// игнорируются.
        /// Требует game.frostBoltManacost единиц магической энергии и изучения умения FROST_BOLT.
        /// </remarks>
        FrostBolt,

        /// <summary>
        /// Создать огненный шар.
        /// </summary>
        /// <remarks>
        /// Огненный шар взрывается при достижении максимальной дальности полёта или при
        /// столкновении с живым объектом. Наносит урон всем близлежащим живым объектам, а также
        /// поджигает их.
        /// При создании огненного шара его центр совпадает с центром волшебника, направление
        /// определяется как wizard.angle + move.castAngle, а абсолютное значение скорости равно
        /// game.fireballSpeed. Столкновения магического снаряда и создавшего его волшебника игнорируются.
        /// Требует game.fireballManacost единиц магической энергии и изучения умения FIREBALL.
        /// </remarks>
        Fireball,

        /// <summary>
        /// Временно ускорить волшебника с идентификатором move.statusTargetId или самого себя, если
        /// такой волшебник не найден.
        /// </summary>
        /// <remarks>
        /// Требует game.hasteManacost единиц магической энергии и изучения умения HASTE.
        /// </remarks>
        Haste,

        /// <summary>
        /// На время создать магический щит вокруг волшебника с идентификатором move.statusTargetId
        /// или самого себя, если такой волшебник не найден.
        /// </summary>
        /// <remarks>
        /// Требует game.shieldManacost единиц магической энергии и изучения умения SHIELD.
        /// </remarks>
        Shield
    }
}