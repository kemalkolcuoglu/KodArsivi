#!/usr/bin/env python3
# -*- coding: utf-8 -*-

from bs4 import BeautifulSoup
import requests
import json
import logging


detailed_format = '%(asctime)s - %(levelname)s - %(funcName)s - %(lineno)d - %(message)s'

logging.basicConfig(
    filename='./example.log',
    filemode='a',
    format=detailed_format,
    level=logging.DEBUG
)
logger = logging.getLogger('simple_example')
ch = logging.StreamHandler()
ch.setLevel(logging.DEBUG)
formatter = logging.Formatter(detailed_format)
ch.setFormatter(formatter)
logger.addHandler(ch)

def get_data():
    list_of_endpoints = [
        'su-boregi-katmer-saci-saci-su-boregi-ocagi',
        'pleyt-izgara-kunefe-ocagi',
        'lokanta-ocagi',
        'yufka-saci',
        'kavurma-saci',
        'kunefe-ocagi',
        'ayakli-lokanta-ocagi',
        #'hamur-yogurma-makinasi',
        #'tost-makinesi'
        'gaz-aletleri-imalati-brulor-toptancisi',
        'dogalgaz-bruloru-lpg-bruloru-lng-bruloru',
        #'kuzine',
        'komurlu-mangal-emaye-mangal-tuplu-mangal',
        'pide-etliekmek-firini',
        'doner-ocagi',
        'pleyt-izgara',
        'kiyma-makinasi',
        'kahveci-ocagi'
    ]
    list_of_pardes_datas = dict()
    for endpoint in list_of_endpoints:
        response = requests.get("http://www.gulsanisi.com/" + endpoint + ".htm", timeout=10)
        logger.debug('URL -> {}'.format(endpoint))
        logger.debug('Response -> {}'.format(response))
        logger.debug('Encoding -> {}'.format(response.encoding))
        logger.debug('Headers -> {}'.format(response.headers))
        texts, images = parse_data(response.text)
        list_of_pardes_datas[endpoint] = {'texts': texts, 'images': images}
    return list_of_pardes_datas

def parse_data(data):
    try:
        logger.debug('Enter the Parse Data')
        #json_data = dict()
        productions = list()
        imgs = list()
        soup = BeautifulSoup(data, 'html.parser')
        text_datas = soup.find('table').find_all('font')
        img_datas = soup.find('table').find_all('img', {'style': 'border:1px solid #000000'})
        logger.debug('Enter the First For')
        for item in text_datas:
            production = str(item.text).strip().replace('\n', '')
            logger.debug('production ->  {}'.format(production))
            productions.append(production)
        logger.debug('Enter the Second For')
        for item in img_datas:
            image = item['src']
            logger.debug('image ->  {}'.format(image))
            imgs.append(image)
        """
        logger.debug('Enter the Dict For')
        for index, item in enumerate(productions):
            try:
                json_data[str(index)] = {'image': imgs[index], 'text': item}
            except Exception as exp:
                logging.error(str(exp))
        """
        logger.debug(productions)
        logger.debug(imgs)
        return productions, imgs
    except Exception as ex:
        logging.critical(ex)
        return [], []


if __name__ == '__main__':
    datas = get_data()
    logger.debug(json.dumps(datas))
    with open('web_scrapping_output.json', 'w+', encoding='utf-8') as fs:
        json.dump(datas, fs)



# <img src="gulsan/urunler/son/kiyma-makinasi1.jpg" alt="" style="border:1px solid #000000;" width="400" height="300" border="0">