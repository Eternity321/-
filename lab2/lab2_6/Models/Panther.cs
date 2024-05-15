using System;
using System.Collections.Generic;

public class Panther : Animal
{
	protected double _maxSpeed = 88.0;
	protected double _speed = 0;
	protected bool _onTree = false;

	public override string Stay()
	{
		if (_speed == 0) return "Животное уже стоит";

		_speed -= _maxSpeed / 3;
		if(_speed < 0) _speed = 0;
		return $"Скорость пантеры = {_speed.ToString()}";
    }

	public override string Go()
	{
		if (_speed == _maxSpeed) return "Скорость уже максимальная";

		_speed += _maxSpeed / 3;
		if (_speed > _maxSpeed) _speed = _maxSpeed;
		return $"Скорость пантеры = {_speed.ToString()}";
    }

	public override double GetSpeed()
	{
		return _speed;
	}

    public override double GetMaxSpeed()
    {
        return _maxSpeed;
    }

    public override string jump()
	{
		return "Пантера прыгнула";
	}
}