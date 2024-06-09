/* src/components/CountyForm.js */

// Package Block
import { useState, useEffect } from 'react';
import { Spin } from 'antd';
import Button from '../components/Button';
import { getCounties } from '../services/counties';
import { CustomCounties } from '../utils/constant';

const CountyForm = ({ handleInputChange, handleSubmit, formData }) => {
  const [counties, setCounties] = useState(CustomCounties);
  const [loader, setLoader] = useState(false);
  // Getting Data of Counties & States
  const getCustomCounties = async () => {
    setLoader(true);
    try {
      const response = await getCounties();
      setCounties(response?.data?.data);
      setLoader(false);
    } catch (error) {
      console.log('🚀 ~ getCustomCounties ~ error:', error);
      setLoader(false);
    }
  };

  useEffect(() => {
    getCustomCounties();
  }, []);
  return (
    <Spin spinning={loader}>
      <form onSubmit={handleSubmit}>
        <label className="form-subtitle">
          Select your organization's County.
        </label>
        <select
          value={formData.countiesId}
          onChange={handleInputChange}
          required
          className="select-field"
          placeholder="Select..."
          name="countiesId"
        >
          <option value="" disabled>
            Select...
          </option>
          {counties?.map((county, index) => (
            <option key={index} value={county?.id}>
              {county?.name}
            </option>
          ))}
        </select>
        <Button className="button" type="submit">
          Continue
        </Button>
      </form>
    </Spin>
  );
};

export default CountyForm;
